// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class MassPushRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("PushTask")]
        [Validation(Required=false)]
        public List<MassPushRequestPushTask> PushTask { get; set; }
        public class MassPushRequestPushTask : TeaModel {
            [NameInMap("AndroidActivity")]
            [Validation(Required=false)]
            public string AndroidActivity { get; set; }

            [NameInMap("AndroidBigBody")]
            [Validation(Required=false)]
            public string AndroidBigBody { get; set; }

            [NameInMap("AndroidBigPictureUrl")]
            [Validation(Required=false)]
            public string AndroidBigPictureUrl { get; set; }

            [NameInMap("AndroidBigTitle")]
            [Validation(Required=false)]
            public string AndroidBigTitle { get; set; }

            [NameInMap("AndroidExtParameters")]
            [Validation(Required=false)]
            public string AndroidExtParameters { get; set; }

            [NameInMap("AndroidHonorTargetUserType")]
            [Validation(Required=false)]
            public int? AndroidHonorTargetUserType { get; set; }

            [NameInMap("AndroidHuaweiReceiptId")]
            [Validation(Required=false)]
            public string AndroidHuaweiReceiptId { get; set; }

            [NameInMap("AndroidHuaweiTargetUserType")]
            [Validation(Required=false)]
            public int? AndroidHuaweiTargetUserType { get; set; }

            [NameInMap("AndroidImageUrl")]
            [Validation(Required=false)]
            public string AndroidImageUrl { get; set; }

            [NameInMap("AndroidInboxBody")]
            [Validation(Required=false)]
            public string AndroidInboxBody { get; set; }

            [NameInMap("AndroidMessageHuaweiCategory")]
            [Validation(Required=false)]
            public string AndroidMessageHuaweiCategory { get; set; }

            [NameInMap("AndroidMessageHuaweiUrgency")]
            [Validation(Required=false)]
            public string AndroidMessageHuaweiUrgency { get; set; }

            [NameInMap("AndroidMessageVivoCategory")]
            [Validation(Required=false)]
            public string AndroidMessageVivoCategory { get; set; }

            [NameInMap("AndroidMusic")]
            [Validation(Required=false)]
            public string AndroidMusic { get; set; }

            [NameInMap("AndroidNotificationBarPriority")]
            [Validation(Required=false)]
            public int? AndroidNotificationBarPriority { get; set; }

            [NameInMap("AndroidNotificationBarType")]
            [Validation(Required=false)]
            public int? AndroidNotificationBarType { get; set; }

            [NameInMap("AndroidNotificationChannel")]
            [Validation(Required=false)]
            public string AndroidNotificationChannel { get; set; }

            [NameInMap("AndroidNotificationGroup")]
            [Validation(Required=false)]
            public string AndroidNotificationGroup { get; set; }

            [NameInMap("AndroidNotificationHonorChannel")]
            [Validation(Required=false)]
            public string AndroidNotificationHonorChannel { get; set; }

            [NameInMap("AndroidNotificationHuaweiChannel")]
            [Validation(Required=false)]
            public string AndroidNotificationHuaweiChannel { get; set; }

            [NameInMap("AndroidNotificationNotifyId")]
            [Validation(Required=false)]
            public int? AndroidNotificationNotifyId { get; set; }

            [NameInMap("AndroidNotificationVivoChannel")]
            [Validation(Required=false)]
            public string AndroidNotificationVivoChannel { get; set; }

            [NameInMap("AndroidNotificationXiaomiChannel")]
            [Validation(Required=false)]
            public string AndroidNotificationXiaomiChannel { get; set; }

            [NameInMap("AndroidNotifyType")]
            [Validation(Required=false)]
            public string AndroidNotifyType { get; set; }

            [NameInMap("AndroidOpenType")]
            [Validation(Required=false)]
            public string AndroidOpenType { get; set; }

            [NameInMap("AndroidOpenUrl")]
            [Validation(Required=false)]
            public string AndroidOpenUrl { get; set; }

            [NameInMap("AndroidPopupActivity")]
            [Validation(Required=false)]
            public string AndroidPopupActivity { get; set; }

            [NameInMap("AndroidPopupBody")]
            [Validation(Required=false)]
            public string AndroidPopupBody { get; set; }

            [NameInMap("AndroidPopupTitle")]
            [Validation(Required=false)]
            public string AndroidPopupTitle { get; set; }

            [NameInMap("AndroidRemind")]
            [Validation(Required=false)]
            public bool? AndroidRemind { get; set; }

            [NameInMap("AndroidRenderStyle")]
            [Validation(Required=false)]
            public string AndroidRenderStyle { get; set; }

            [NameInMap("AndroidTargetUserType")]
            [Validation(Required=false)]
            public int? AndroidTargetUserType { get; set; }

            [NameInMap("AndroidVivoPushMode")]
            [Validation(Required=false)]
            public int? AndroidVivoPushMode { get; set; }

            [NameInMap("AndroidVivoReceiptId")]
            [Validation(Required=false)]
            public string AndroidVivoReceiptId { get; set; }

            [NameInMap("AndroidXiaoMiActivity")]
            [Validation(Required=false)]
            [Obsolete]
            public string AndroidXiaoMiActivity { get; set; }

            [NameInMap("AndroidXiaoMiNotifyBody")]
            [Validation(Required=false)]
            [Obsolete]
            public string AndroidXiaoMiNotifyBody { get; set; }

            [NameInMap("AndroidXiaoMiNotifyTitle")]
            [Validation(Required=false)]
            [Obsolete]
            public string AndroidXiaoMiNotifyTitle { get; set; }

            [NameInMap("AndroidXiaomiBigPictureUrl")]
            [Validation(Required=false)]
            public string AndroidXiaomiBigPictureUrl { get; set; }

            [NameInMap("AndroidXiaomiImageUrl")]
            [Validation(Required=false)]
            public string AndroidXiaomiImageUrl { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Body")]
            [Validation(Required=false)]
            public string Body { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("HarmonyAction")]
            [Validation(Required=false)]
            public string HarmonyAction { get; set; }

            [NameInMap("HarmonyActionType")]
            [Validation(Required=false)]
            public string HarmonyActionType { get; set; }

            [NameInMap("HarmonyCategory")]
            [Validation(Required=false)]
            public string HarmonyCategory { get; set; }

            [NameInMap("HarmonyExtParameters")]
            [Validation(Required=false)]
            public string HarmonyExtParameters { get; set; }

            [NameInMap("HarmonyImageUrl")]
            [Validation(Required=false)]
            public string HarmonyImageUrl { get; set; }

            [NameInMap("HarmonyInboxContent")]
            [Validation(Required=false)]
            public string HarmonyInboxContent { get; set; }

            [NameInMap("HarmonyNotificationSlotType")]
            [Validation(Required=false)]
            public string HarmonyNotificationSlotType { get; set; }

            [NameInMap("HarmonyNotifyId")]
            [Validation(Required=false)]
            public int? HarmonyNotifyId { get; set; }

            [NameInMap("HarmonyReceiptId")]
            [Validation(Required=false)]
            public string HarmonyReceiptId { get; set; }

            [NameInMap("HarmonyRemind")]
            [Validation(Required=false)]
            public bool? HarmonyRemind { get; set; }

            [NameInMap("HarmonyRemindBody")]
            [Validation(Required=false)]
            public string HarmonyRemindBody { get; set; }

            [NameInMap("HarmonyRemindTitle")]
            [Validation(Required=false)]
            public string HarmonyRemindTitle { get; set; }

            [NameInMap("HarmonyRenderStyle")]
            [Validation(Required=false)]
            public string HarmonyRenderStyle { get; set; }

            [NameInMap("HarmonyTestMessage")]
            [Validation(Required=false)]
            public bool? HarmonyTestMessage { get; set; }

            [NameInMap("HarmonyUri")]
            [Validation(Required=false)]
            public string HarmonyUri { get; set; }

            [NameInMap("JobKey")]
            [Validation(Required=false)]
            public string JobKey { get; set; }

            [NameInMap("PushTime")]
            [Validation(Required=false)]
            public string PushTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("PushType")]
            [Validation(Required=false)]
            public string PushType { get; set; }

            [NameInMap("SendChannels")]
            [Validation(Required=false)]
            public string SendChannels { get; set; }

            [NameInMap("SendSpeed")]
            [Validation(Required=false)]
            [Obsolete]
            public int? SendSpeed { get; set; }

            [NameInMap("StoreOffline")]
            [Validation(Required=false)]
            public bool? StoreOffline { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("TargetValue")]
            [Validation(Required=false)]
            public string TargetValue { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("Trim")]
            [Validation(Required=false)]
            public bool? Trim { get; set; }

            [NameInMap("iOSApnsEnv")]
            [Validation(Required=false)]
            public string IOSApnsEnv { get; set; }

            [NameInMap("iOSBadge")]
            [Validation(Required=false)]
            public int? IOSBadge { get; set; }

            [NameInMap("iOSBadgeAutoIncrement")]
            [Validation(Required=false)]
            public bool? IOSBadgeAutoIncrement { get; set; }

            [NameInMap("iOSExtParameters")]
            [Validation(Required=false)]
            public string IOSExtParameters { get; set; }

            [NameInMap("iOSInterruptionLevel")]
            [Validation(Required=false)]
            public string IOSInterruptionLevel { get; set; }

            [NameInMap("iOSMusic")]
            [Validation(Required=false)]
            public string IOSMusic { get; set; }

            [NameInMap("iOSMutableContent")]
            [Validation(Required=false)]
            public bool? IOSMutableContent { get; set; }

            [NameInMap("iOSNotificationCategory")]
            [Validation(Required=false)]
            public string IOSNotificationCategory { get; set; }

            [NameInMap("iOSNotificationCollapseId")]
            [Validation(Required=false)]
            public string IOSNotificationCollapseId { get; set; }

            [NameInMap("iOSNotificationThreadId")]
            [Validation(Required=false)]
            public string IOSNotificationThreadId { get; set; }

            [NameInMap("iOSRelevanceScore")]
            [Validation(Required=false)]
            public double? IOSRelevanceScore { get; set; }

            [NameInMap("iOSRemind")]
            [Validation(Required=false)]
            public bool? IOSRemind { get; set; }

            [NameInMap("iOSRemindBody")]
            [Validation(Required=false)]
            public string IOSRemindBody { get; set; }

            [NameInMap("iOSSilentNotification")]
            [Validation(Required=false)]
            public bool? IOSSilentNotification { get; set; }

            [NameInMap("iOSSubtitle")]
            [Validation(Required=false)]
            public string IOSSubtitle { get; set; }

        }

    }

}
