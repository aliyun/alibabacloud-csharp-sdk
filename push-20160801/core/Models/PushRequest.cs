// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class PushRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>com.alibaba.cloudpushdemo.bizactivity</para>
        /// </summary>
        [NameInMap("AndroidActivity")]
        [Validation(Required=false)]
        public string AndroidActivity { get; set; }

        [NameInMap("AndroidBadgeAddNum")]
        [Validation(Required=false)]
        public int? AndroidBadgeAddNum { get; set; }

        [NameInMap("AndroidBadgeClass")]
        [Validation(Required=false)]
        public string AndroidBadgeClass { get; set; }

        [NameInMap("AndroidBadgeSetNum")]
        [Validation(Required=false)]
        public int? AndroidBadgeSetNum { get; set; }

        [NameInMap("AndroidBigBody")]
        [Validation(Required=false)]
        public string AndroidBigBody { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://imag.example.com/image.png">https://imag.example.com/image.png</a></para>
        /// </summary>
        [NameInMap("AndroidBigPictureUrl")]
        [Validation(Required=false)]
        public string AndroidBigPictureUrl { get; set; }

        [NameInMap("AndroidBigTitle")]
        [Validation(Required=false)]
        public string AndroidBigTitle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;key1&quot;:&quot;value1&quot;,&quot;api_name&quot;:&quot;PushNoticeToAndroidRequest&quot;}</para>
        /// </summary>
        [NameInMap("AndroidExtParameters")]
        [Validation(Required=false)]
        public string AndroidExtParameters { get; set; }

        [NameInMap("AndroidHonorTargetUserType")]
        [Validation(Required=false)]
        public int? AndroidHonorTargetUserType { get; set; }

        [NameInMap("AndroidHuaweiLiveNotificationPayload")]
        [Validation(Required=false)]
        public string AndroidHuaweiLiveNotificationPayload { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RCP4C123456</para>
        /// </summary>
        [NameInMap("AndroidHuaweiReceiptId")]
        [Validation(Required=false)]
        public string AndroidHuaweiReceiptId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AndroidHuaweiTargetUserType")]
        [Validation(Required=false)]
        public int? AndroidHuaweiTargetUserType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://imag.example.com/image.png">https://imag.example.com/image.png</a></para>
        /// </summary>
        [NameInMap("AndroidImageUrl")]
        [Validation(Required=false)]
        public string AndroidImageUrl { get; set; }

        [NameInMap("AndroidInboxBody")]
        [Validation(Required=false)]
        public string AndroidInboxBody { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("AndroidMeizuNoticeMsgType")]
        [Validation(Required=false)]
        public int? AndroidMeizuNoticeMsgType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>VOIP</para>
        /// </summary>
        [NameInMap("AndroidMessageHuaweiCategory")]
        [Validation(Required=false)]
        public string AndroidMessageHuaweiCategory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HIGH</para>
        /// </summary>
        [NameInMap("AndroidMessageHuaweiUrgency")]
        [Validation(Required=false)]
        public string AndroidMessageHuaweiUrgency { get; set; }

        [NameInMap("AndroidMessageOppoCategory")]
        [Validation(Required=false)]
        public string AndroidMessageOppoCategory { get; set; }

        [NameInMap("AndroidMessageOppoNotifyLevel")]
        [Validation(Required=false)]
        public int? AndroidMessageOppoNotifyLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TODO</para>
        /// </summary>
        [NameInMap("AndroidMessageVivoCategory")]
        [Validation(Required=false)]
        public string AndroidMessageVivoCategory { get; set; }

        [NameInMap("AndroidMusic")]
        [Validation(Required=false)]
        public string AndroidMusic { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AndroidNotificationBarPriority")]
        [Validation(Required=false)]
        public int? AndroidNotificationBarPriority { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AndroidNotificationBarType")]
        [Validation(Required=false)]
        public int? AndroidNotificationBarType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AndroidNotificationChannel")]
        [Validation(Required=false)]
        public string AndroidNotificationChannel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>group-1</para>
        /// </summary>
        [NameInMap("AndroidNotificationGroup")]
        [Validation(Required=false)]
        public string AndroidNotificationGroup { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>LOW</para>
        /// </summary>
        [NameInMap("AndroidNotificationHonorChannel")]
        [Validation(Required=false)]
        public string AndroidNotificationHonorChannel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>LOW</para>
        /// </summary>
        [NameInMap("AndroidNotificationHuaweiChannel")]
        [Validation(Required=false)]
        public string AndroidNotificationHuaweiChannel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100001</para>
        /// </summary>
        [NameInMap("AndroidNotificationNotifyId")]
        [Validation(Required=false)]
        public int? AndroidNotificationNotifyId { get; set; }

        [NameInMap("AndroidNotificationThreadId")]
        [Validation(Required=false)]
        public string AndroidNotificationThreadId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>classification</para>
        /// </summary>
        [NameInMap("AndroidNotificationVivoChannel")]
        [Validation(Required=false)]
        public string AndroidNotificationVivoChannel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>michannel</para>
        /// </summary>
        [NameInMap("AndroidNotificationXiaomiChannel")]
        [Validation(Required=false)]
        public string AndroidNotificationXiaomiChannel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BOTH</para>
        /// </summary>
        [NameInMap("AndroidNotifyType")]
        [Validation(Required=false)]
        public string AndroidNotifyType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>APPLICATION</para>
        /// </summary>
        [NameInMap("AndroidOpenType")]
        [Validation(Required=false)]
        public string AndroidOpenType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://xxxx.xxx">https://xxxx.xxx</a></para>
        /// </summary>
        [NameInMap("AndroidOpenUrl")]
        [Validation(Required=false)]
        public string AndroidOpenUrl { get; set; }

        [NameInMap("AndroidOppoDeleteIntentData")]
        [Validation(Required=false)]
        public string AndroidOppoDeleteIntentData { get; set; }

        [NameInMap("AndroidOppoIntelligentIntent")]
        [Validation(Required=false)]
        public string AndroidOppoIntelligentIntent { get; set; }

        [NameInMap("AndroidOppoIntentEnv")]
        [Validation(Required=false)]
        public int? AndroidOppoIntentEnv { get; set; }

        [NameInMap("AndroidOppoPrivateContentParameters")]
        [Validation(Required=false)]
        public Dictionary<string, string> AndroidOppoPrivateContentParameters { get; set; }

        [NameInMap("AndroidOppoPrivateMsgTemplateId")]
        [Validation(Required=false)]
        public string AndroidOppoPrivateMsgTemplateId { get; set; }

        [NameInMap("AndroidOppoPrivateTitleParameters")]
        [Validation(Required=false)]
        public Dictionary<string, string> AndroidOppoPrivateTitleParameters { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>com.alibaba.cloudpushdemo.bizactivity</para>
        /// </summary>
        [NameInMap("AndroidPopupActivity")]
        [Validation(Required=false)]
        public string AndroidPopupActivity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hello</para>
        /// </summary>
        [NameInMap("AndroidPopupBody")]
        [Validation(Required=false)]
        public string AndroidPopupBody { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hello</para>
        /// </summary>
        [NameInMap("AndroidPopupTitle")]
        [Validation(Required=false)]
        public string AndroidPopupTitle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AndroidRemind")]
        [Validation(Required=false)]
        public bool? AndroidRemind { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AndroidRenderStyle")]
        [Validation(Required=false)]
        public int? AndroidRenderStyle { get; set; }

        [NameInMap("AndroidTargetUserType")]
        [Validation(Required=false)]
        public int? AndroidTargetUserType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AndroidVivoPushMode")]
        [Validation(Required=false)]
        public int? AndroidVivoPushMode { get; set; }

        [NameInMap("AndroidVivoReceiptId")]
        [Validation(Required=false)]
        public string AndroidVivoReceiptId { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("AndroidXiaoMiActivity")]
        [Validation(Required=false)]
        [Obsolete]
        public string AndroidXiaoMiActivity { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("AndroidXiaoMiNotifyBody")]
        [Validation(Required=false)]
        [Obsolete]
        public string AndroidXiaoMiNotifyBody { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("AndroidXiaoMiNotifyTitle")]
        [Validation(Required=false)]
        [Obsolete]
        public string AndroidXiaoMiNotifyTitle { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://f6.market.xiaomi.com/download/MiPass/aaa/bbb.png">https://f6.market.xiaomi.com/download/MiPass/aaa/bbb.png</a></para>
        /// </summary>
        [NameInMap("AndroidXiaomiBigPictureUrl")]
        [Validation(Required=false)]
        [Obsolete]
        public string AndroidXiaomiBigPictureUrl { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://imag.example.com/image.png">https://imag.example.com/image.png</a></para>
        /// </summary>
        [NameInMap("AndroidXiaomiImageUrl")]
        [Validation(Required=false)]
        [Obsolete]
        public string AndroidXiaomiImageUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23267207</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hello</para>
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("DeviceType")]
        [Validation(Required=false)]
        public string DeviceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2019-02-20T00:00:00Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("HarmonyAction")]
        [Validation(Required=false)]
        public string HarmonyAction { get; set; }

        [NameInMap("HarmonyActionType")]
        [Validation(Required=false)]
        public string HarmonyActionType { get; set; }

        [NameInMap("HarmonyBadgeAddNum")]
        [Validation(Required=false)]
        public int? HarmonyBadgeAddNum { get; set; }

        [NameInMap("HarmonyBadgeSetNum")]
        [Validation(Required=false)]
        public int? HarmonyBadgeSetNum { get; set; }

        [NameInMap("HarmonyCategory")]
        [Validation(Required=false)]
        public string HarmonyCategory { get; set; }

        [NameInMap("HarmonyExtParameters")]
        [Validation(Required=false)]
        public string HarmonyExtParameters { get; set; }

        [NameInMap("HarmonyExtensionExtraData")]
        [Validation(Required=false)]
        public string HarmonyExtensionExtraData { get; set; }

        [NameInMap("HarmonyExtensionPush")]
        [Validation(Required=false)]
        public bool? HarmonyExtensionPush { get; set; }

        [NameInMap("HarmonyImageUrl")]
        [Validation(Required=false)]
        public string HarmonyImageUrl { get; set; }

        [NameInMap("HarmonyInboxContent")]
        [Validation(Required=false)]
        public string HarmonyInboxContent { get; set; }

        [NameInMap("HarmonyLiveViewPayload")]
        [Validation(Required=false)]
        public string HarmonyLiveViewPayload { get; set; }

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

        [NameInMap("IdempotentToken")]
        [Validation(Required=false)]
        public string IdempotentToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("JobKey")]
        [Validation(Required=false)]
        public string JobKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2019-02-20T00:00:00Z</para>
        /// </summary>
        [NameInMap("PushTime")]
        [Validation(Required=false)]
        public string PushTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MESSAGE</para>
        /// </summary>
        [NameInMap("PushType")]
        [Validation(Required=false)]
        public string PushType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>accs,huawei,xiaomi</para>
        /// </summary>
        [NameInMap("SendChannels")]
        [Validation(Required=false)]
        public string SendChannels { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SendSpeed")]
        [Validation(Required=false)]
        [Obsolete]
        public int? SendSpeed { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("SmsDelaySecs")]
        [Validation(Required=false)]
        public int? SmsDelaySecs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>key1=value1</para>
        /// </summary>
        [NameInMap("SmsParams")]
        [Validation(Required=false)]
        public string SmsParams { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SmsSendPolicy")]
        [Validation(Required=false)]
        public int? SmsSendPolicy { get; set; }

        [NameInMap("SmsSignName")]
        [Validation(Required=false)]
        public string SmsSignName { get; set; }

        [NameInMap("SmsTemplateName")]
        [Validation(Required=false)]
        public string SmsTemplateName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("StoreOffline")]
        [Validation(Required=false)]
        public bool? StoreOffline { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("TargetValue")]
        [Validation(Required=false)]
        public string TargetValue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>title</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Trim")]
        [Validation(Required=false)]
        public bool? Trim { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DEV</para>
        /// </summary>
        [NameInMap("iOSApnsEnv")]
        [Validation(Required=false)]
        public string IOSApnsEnv { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("iOSBadge")]
        [Validation(Required=false)]
        public int? IOSBadge { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("iOSBadgeAutoIncrement")]
        [Validation(Required=false)]
        public bool? IOSBadgeAutoIncrement { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{“attachment”: “<a href="https://xxxx.xxx/notification_pic.png%22%7D">https://xxxx.xxx/notification_pic.png&quot;}</a></para>
        /// </summary>
        [NameInMap("iOSExtParameters")]
        [Validation(Required=false)]
        public string IOSExtParameters { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("iOSInterruptionLevel")]
        [Validation(Required=false)]
        public string IOSInterruptionLevel { get; set; }

        [NameInMap("iOSLiveActivityAttributes")]
        [Validation(Required=false)]
        public string IOSLiveActivityAttributes { get; set; }

        [NameInMap("iOSLiveActivityAttributesType")]
        [Validation(Required=false)]
        public string IOSLiveActivityAttributesType { get; set; }

        [NameInMap("iOSLiveActivityContentState")]
        [Validation(Required=false)]
        public string IOSLiveActivityContentState { get; set; }

        [NameInMap("iOSLiveActivityDismissalDate")]
        [Validation(Required=false)]
        public long? IOSLiveActivityDismissalDate { get; set; }

        [NameInMap("iOSLiveActivityEvent")]
        [Validation(Required=false)]
        public string IOSLiveActivityEvent { get; set; }

        [NameInMap("iOSLiveActivityId")]
        [Validation(Required=false)]
        public string IOSLiveActivityId { get; set; }

        [NameInMap("iOSLiveActivityStaleDate")]
        [Validation(Required=false)]
        public long? IOSLiveActivityStaleDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("iOSMusic")]
        [Validation(Required=false)]
        public string IOSMusic { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("iOSMutableContent")]
        [Validation(Required=false)]
        public bool? IOSMutableContent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ios</para>
        /// </summary>
        [NameInMap("iOSNotificationCategory")]
        [Validation(Required=false)]
        public string IOSNotificationCategory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ZD2011</para>
        /// </summary>
        [NameInMap("iOSNotificationCollapseId")]
        [Validation(Required=false)]
        public string IOSNotificationCollapseId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("iOSNotificationThreadId")]
        [Validation(Required=false)]
        public string IOSNotificationThreadId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.01</para>
        /// </summary>
        [NameInMap("iOSRelevanceScore")]
        [Validation(Required=false)]
        public double? IOSRelevanceScore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("iOSRemind")]
        [Validation(Required=false)]
        public bool? IOSRemind { get; set; }

        [NameInMap("iOSRemindBody")]
        [Validation(Required=false)]
        public string IOSRemindBody { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("iOSSilentNotification")]
        [Validation(Required=false)]
        public bool? IOSSilentNotification { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>su\&quot;b</para>
        /// </summary>
        [NameInMap("iOSSubtitle")]
        [Validation(Required=false)]
        public string IOSSubtitle { get; set; }

    }

}
