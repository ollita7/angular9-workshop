﻿using Android.App;
using Android.Content;
using Android.Util;
using Firebase.Messaging;

namespace Seed.Droid
{
    [Service]
    [IntentFilter(new[] { "com.google.firebase.MESSAGING_EVENT" })]
    public class MyFirebaseMessagingService : FirebaseMessagingService
    {
        const string TAG = "MyFirebaseMsgService";
        public override void OnMessageReceived(RemoteMessage message)
        {
            base.OnMessageReceived(message);
            new NotificationHelper().CreateNotification("LLego un coso nuevo", "Este es el body del coso nuevo");

            //Log.Debug(TAG, "From: " + message.From);
            //Log.Debug(TAG, "Message Object: " + message);
            ////Log.Debug(TAG, "Notification Message Body: " + message.GetNotification().Body);
        }
    }
}