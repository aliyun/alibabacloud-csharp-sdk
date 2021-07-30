// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class MassPushRequest : TeaModel {
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        [NameInMap("PushTask")]
        [Validation(Required=false)]
        public List<MassPushRequestPushTask> PushTask { get; set; }
        public class MassPushRequestPushTask : TeaModel {
            [NameInMap("JobKey")]
            [Validation(Required=false)]
            public string JobKey { get; set; }

            [NameInMap("iOSSilentNotification")]
            [Validation(Required=false)]
            public bool? IOSSilentNotification { get; set; }

            [NameInMap("iOSNotificationCollapseId")]
            [Validation(Required=false)]
            public string IOSNotificationCollapseId { get; set; }

            [NameInMap("AndroidRenderStyle")]
            [Validation(Required=false)]
            public string AndroidRenderStyle { get; set; }

            [NameInMap("StoreOffline")]
            [Validation(Required=false)]
            public bool? StoreOffline { get; set; }

            [NameInMap("iOSSubtitle")]
            [Validation(Required=false)]
            public string IOSSubtitle { get; set; }

            [NameInMap("iOSNotificationCategory")]
            [Validation(Required=false)]
            public string IOSNotificationCategory { get; set; }

            [NameInMap("AndroidNotificationChannel")]
            [Validation(Required=false)]
            public string AndroidNotificationChannel { get; set; }

            [NameInMap("AndroidNotificationHuaweiChannel")]
            [Validation(Required=false)]
            public string AndroidNotificationHuaweiChannel { get; set; }

            [NameInMap("iOSApnsEnv")]
            [Validation(Required=false)]
            public string IOSApnsEnv { get; set; }

            [NameInMap("iOSBadgeAutoIncrement")]
            [Validation(Required=false)]
            public bool? IOSBadgeAutoIncrement { get; set; }

            [NameInMap("AndroidXiaoMiNotifyTitle")]
            [Validation(Required=false)]
            public string AndroidXiaoMiNotifyTitle { get; set; }

            [NameInMap("AndroidNotificationXiaomiChannel")]
            [Validation(Required=false)]
            public string AndroidNotificationXiaomiChannel { get; set; }

            [NameInMap("AndroidXiaoMiActivity")]
            [Validation(Required=false)]
            public string AndroidXiaoMiActivity { get; set; }

            [NameInMap("AndroidPopupTitle")]
            [Validation(Required=false)]
            public string AndroidPopupTitle { get; set; }

            [NameInMap("iOSRemindBody")]
            [Validation(Required=false)]
            public string IOSRemindBody { get; set; }

            [NameInMap("AndroidActivity")]
            [Validation(Required=false)]
            public string AndroidActivity { get; set; }

            [NameInMap("AndroidNotifyType")]
            [Validation(Required=false)]
            public string AndroidNotifyType { get; set; }

            [NameInMap("AndroidBigBody")]
            [Validation(Required=false)]
            public string AndroidBigBody { get; set; }

            [NameInMap("iOSMutableContent")]
            [Validation(Required=false)]
            public bool? IOSMutableContent { get; set; }

            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            [NameInMap("AndroidOpenUrl")]
            [Validation(Required=false)]
            public string AndroidOpenUrl { get; set; }

            [NameInMap("AndroidBigTitle")]
            [Validation(Required=false)]
            public string AndroidBigTitle { get; set; }

            [NameInMap("AndroidNotificationNotifyId")]
            [Validation(Required=false)]
            public int? AndroidNotificationNotifyId { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("AndroidNotificationVivoChannel")]
            [Validation(Required=false)]
            public string AndroidNotificationVivoChannel { get; set; }

            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            [NameInMap("AndroidOpenType")]
            [Validation(Required=false)]
            public string AndroidOpenType { get; set; }

            [NameInMap("AndroidPopupActivity")]
            [Validation(Required=false)]
            public string AndroidPopupActivity { get; set; }

            [NameInMap("AndroidRemind")]
            [Validation(Required=false)]
            public bool? AndroidRemind { get; set; }

            [NameInMap("AndroidPopupBody")]
            [Validation(Required=false)]
            public string AndroidPopupBody { get; set; }

            [NameInMap("AndroidExtParameters")]
            [Validation(Required=false)]
            public string AndroidExtParameters { get; set; }

            [NameInMap("iOSExtParameters")]
            [Validation(Required=false)]
            public string IOSExtParameters { get; set; }

            [NameInMap("AndroidXiaoMiNotifyBody")]
            [Validation(Required=false)]
            public string AndroidXiaoMiNotifyBody { get; set; }

            [NameInMap("Body")]
            [Validation(Required=false)]
            public string Body { get; set; }

            [NameInMap("AndroidNotificationBarType")]
            [Validation(Required=false)]
            public int? AndroidNotificationBarType { get; set; }

            [NameInMap("AndroidNotificationBarPriority")]
            [Validation(Required=false)]
            public int? AndroidNotificationBarPriority { get; set; }

            [NameInMap("AndroidXiaomiBigPictureUrl")]
            [Validation(Required=false)]
            public string AndroidXiaomiBigPictureUrl { get; set; }

            [NameInMap("TargetValue")]
            [Validation(Required=false)]
            public string TargetValue { get; set; }

            [NameInMap("iOSMusic")]
            [Validation(Required=false)]
            public string IOSMusic { get; set; }

            [NameInMap("iOSRemind")]
            [Validation(Required=false)]
            public bool? IOSRemind { get; set; }

            [NameInMap("PushType")]
            [Validation(Required=false)]
            public string PushType { get; set; }

            [NameInMap("SendSpeed")]
            [Validation(Required=false)]
            public int? SendSpeed { get; set; }

            [NameInMap("iOSBadge")]
            [Validation(Required=false)]
            public int? IOSBadge { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("PushTime")]
            [Validation(Required=false)]
            public string PushTime { get; set; }

            [NameInMap("AndroidMusic")]
            [Validation(Required=false)]
            public string AndroidMusic { get; set; }

        }

    }

}
