// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class PushRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the activity to open when the notification is tapped.</para>
        /// <para>This is required only when \<c>AndroidOpenType\\</c> is \<c>Activity\\</c>. For example: \<c>com.alibaba.cloudpushdemo.bizactivity\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.alibaba.cloudpushdemo.bizactivity</para>
        /// </summary>
        [NameInMap("AndroidActivity")]
        [Validation(Required=false)]
        public string AndroidActivity { get; set; }

        /// <summary>
        /// <para>Sets the value to add to the badge number. This value is added to the original badge number. The value must be between 1 and 99.</para>
        /// <remarks>
        /// <para>This is effective only for pushes through Huawei/Honor vendor channels. If both \<c>AndroidBadgeAddNum\\</c> and \<c>AndroidBadgeSetNum\\</c> are present, \<c>AndroidBadgeSetNum\\</c> takes precedence.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AndroidBadgeAddNum")]
        [Validation(Required=false)]
        public int? AndroidBadgeAddNum { get; set; }

        /// <summary>
        /// <para>The fully qualified class name of the app\&quot;s entry Activity for badge setting.</para>
        /// <remarks>
        /// <para>This is effective only for pushes through Huawei/Honor vendor channels.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>com.alibaba.cloudpushdemo.bizactivity</para>
        /// </summary>
        [NameInMap("AndroidBadgeClass")]
        [Validation(Required=false)]
        public string AndroidBadgeClass { get; set; }

        /// <summary>
        /// <para>Sets a fixed number for the badge. The value must be between 0 and 99.</para>
        /// <remarks>
        /// <para>For vendor channel pushes, this is effective only for Huawei and Honor channels. For pushes through Alibaba Cloud\&quot;s proprietary channel, this is effective only on Huawei, Honor, and vivo models.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("AndroidBadgeSetNum")]
        [Validation(Required=false)]
        public int? AndroidBadgeSetNum { get; set; }

        /// <summary>
        /// <para>The body in long text mode. Length limit: 1,000 bytes (1 Chinese character is counted as 3 bytes). The actual limit depends on the specific vendor channel.</para>
        /// <para>Currently supported on:</para>
        /// <list type="bullet">
        /// <item><description><para>Huawei: EMUI 10 and later</para>
        /// </description></item>
        /// <item><description><para>Honor: Magic UI 4.0 and later</para>
        /// </description></item>
        /// <item><description><para>Xiaomi: MIUI 10 and later</para>
        /// </description></item>
        /// <item><description><para>OPPO: ColorOS 5.0 and later</para>
        /// </description></item>
        /// <item><description><para>Meizu: Flyme</para>
        /// </description></item>
        /// <item><description><para>Proprietary channel: Android SDK 3.6.0 and later</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not provided in long text mode, the system uses the first non-empty value from \<c>Body\\</c> or \<c>AndroidPopupBody\\</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>示例长文本</para>
        /// </summary>
        [NameInMap("AndroidBigBody")]
        [Validation(Required=false)]
        public string AndroidBigBody { get; set; }

        /// <summary>
        /// <para>The image URL for big picture mode. Currently supported by the proprietary channel on Android SDK 3.6.0 and later.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://imag.example.com/image.png">https://imag.example.com/image.png</a></para>
        /// </summary>
        [NameInMap("AndroidBigPictureUrl")]
        [Validation(Required=false)]
        public string AndroidBigPictureUrl { get; set; }

        /// <summary>
        /// <para>The title in long text mode. Length limit: 200 bytes (1 Chinese character is counted as 3 bytes).</para>
        /// <list type="bullet">
        /// <item><description><para>Currently, this is only supported by Honor channels and Huawei channels on EMUI 11 and later.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is not provided in long text mode, the system uses the first non-empty value from \<c>Title\\</c> or \<c>AndroidPopupTitle\\</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>示例长标题</para>
        /// </summary>
        [NameInMap("AndroidBigTitle")]
        [Validation(Required=false)]
        public string AndroidBigTitle { get; set; }

        /// <summary>
        /// <para>Sets the extended properties of the notification. This property is not effective when \<c>PushType\\</c> is \<c>MESSAGE\\</c>.</para>
        /// <para>This parameter must be in JSON map format to avoid parsing errors.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key1&quot;:&quot;value1&quot;,&quot;api_name&quot;:&quot;PushNoticeToAndroidRequest&quot;}</para>
        /// </summary>
        [NameInMap("AndroidExtParameters")]
        [Validation(Required=false)]
        public string AndroidExtParameters { get; set; }

        /// <summary>
        /// <para>Sets the Honor channel notification type:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Formal notification (default).</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Test notification.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Each app can send 1,000 test notifications per day. These are not subject to the daily push limit per device.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AndroidHonorTargetUserType")]
        [Validation(Required=false)]
        public int? AndroidHonorTargetUserType { get; set; }

        /// <summary>
        /// <para>Sets the Huawei quick notification parameter.</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Send a standard Huawei notification (default).</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Send a Huawei quick notification.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AndroidHuaweiBusinessType")]
        [Validation(Required=false)]
        public int? AndroidHuaweiBusinessType { get; set; }

        /// <summary>
        /// <para>A JSON string of the Huawei Android Live Notification data structure <a href="https://developer.huawei.com/consumer/cn/doc/HMSCore-References/rest-live-0000001562939968#ZH-CN_TOPIC_0000001700850537__p195121620102511">LiveNotificationPayload</a>. For development and integration, see <a href="https://help.aliyun.com/document_detail/2983768.html">Huawei Live Notification Push Guide</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;activityId&quot;: 1,
        ///   &quot;operation&quot;: 1,
        ///   &quot;event&quot;: &quot;TAXI&quot;,
        ///   &quot;activityData&quot;: {
        ///     &quot;notificationData&quot;: {
        ///       &quot;type&quot;: 3
        ///     }
        ///   }
        /// }</para>
        /// </summary>
        [NameInMap("AndroidHuaweiLiveNotificationPayload")]
        [Validation(Required=false)]
        public string AndroidHuaweiLiveNotificationPayload { get; set; }

        /// <summary>
        /// <para>The receipt ID for the Huawei channel. You can find this ID in the receipt parameter configuration on the Huawei Push service platform.</para>
        /// <remarks>
        /// <para>If the default receipt configuration on the Huawei Push service platform is the Alibaba Cloud receipt, do not provide this. If not, first configure the default Huawei channel receipt ID in the Alibaba Cloud EMAS Mobile Push console.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RCP4C123456</para>
        /// </summary>
        [NameInMap("AndroidHuaweiReceiptId")]
        [Validation(Required=false)]
        public string AndroidHuaweiReceiptId { get; set; }

        /// <summary>
        /// <para>Sets the Huawei channel notification type:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Formal notification (default).</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Test notification.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Each app can send 500 test notifications per day. These are not subject to the daily push limit per device.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AndroidHuaweiTargetUserType")]
        [Validation(Required=false)]
        public int? AndroidHuaweiTargetUserType { get; set; }

        /// <summary>
        /// <para>The URL for the right-side icon.
        /// Currently supported on:</para>
        /// <list type="bullet">
        /// <item><description><para>Huawei EMUI (only in long text and inbox modes).</para>
        /// </description></item>
        /// <item><description><para>Honor Magic UI (only in long text mode).</para>
        /// </description></item>
        /// <item><description><para>Proprietary channel: Android SDK 3.5.0 and later.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://imag.example.com/image.png">https://imag.example.com/image.png</a></para>
        /// </summary>
        [NameInMap("AndroidImageUrl")]
        [Validation(Required=false)]
        public string AndroidImageUrl { get; set; }

        /// <summary>
        /// <para>The body content for inbox mode. The content must be a valid JSON array with no more than 5 elements. Currently supported on:</para>
        /// <list type="bullet">
        /// <item><description><para>Huawei: EMUI 9 and later</para>
        /// </description></item>
        /// <item><description><para>Honor: Magic UI 4.0 and later</para>
        /// </description></item>
        /// <item><description><para>Xiaomi: MIUI 10 and later</para>
        /// </description></item>
        /// <item><description><para>OPPO: ColorOS 5.0 and later</para>
        /// </description></item>
        /// <item><description><para>Proprietary channel: Android SDK 3.6.0 and later</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;第一行&quot;,&quot;第二行&quot;]</para>
        /// </summary>
        [NameInMap("AndroidInboxBody")]
        [Validation(Required=false)]
        public string AndroidInboxBody { get; set; }

        /// <summary>
        /// <para>Meizu message type</para>
        /// <list type="bullet">
        /// <item><description><para>0 Public message (default)</para>
        /// </description></item>
        /// <item><description><para>1 Private message</para>
        /// </description></item>
        /// </list>
        /// 
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
        /// <para>Function 1: After applying for <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/message-classification-0000001149358835?#section3410731125514">self-classification rights</a>, this is used to identify the message type and determine the <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/message-classification-0000001149358835#ZH-CN_TOPIC_0000001149358835__p3850133955718">message alert method</a>. It accelerates the sending of specific message types. For valid values, refer to the <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/message-classification-0000001149358835#section1076611477914">message classification standards</a> in the official Huawei Push documentation. Fill in the \&quot;Cloud notification category value\&quot; or \&quot;Local notification category value\&quot; from the document\&quot;s table.</para>
        /// <para>Function 2: After applying for <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/faq-0000001050042183#section037425218509">special permissions</a>, this is used to identify high-priority pass-through scenarios. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>VOIP: Voice and video calls</para>
        /// </description></item>
        /// <item><description><para>PLAY_VOICE: Voice playback</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If the \&quot;Cloud notification category value\&quot; is \&quot;Not applicable\&quot;, the push is sent through Alibaba Cloud\&quot;s proprietary channel. If the \&quot;Local notification category value\&quot; is \&quot;Not applicable\&quot;, the push is sent through the Huawei channel.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>VOIP</para>
        /// </summary>
        [NameInMap("AndroidMessageHuaweiCategory")]
        [Validation(Required=false)]
        public string AndroidMessageHuaweiCategory { get; set; }

        /// <summary>
        /// <para>The delivery priority for notifications on the Huawei channel. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HIGH</b></para>
        /// </description></item>
        /// <item><description><para><b>NORMAL</b></para>
        /// </description></item>
        /// </list>
        /// <para>Apply for permission. For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/faq-0000001050042183#section037425218509">Application link</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HIGH</para>
        /// </summary>
        [NameInMap("AndroidMessageHuaweiUrgency")]
        [Validation(Required=false)]
        public string AndroidMessageHuaweiUrgency { get; set; }

        /// <summary>
        /// <para>OPPO classifies and manages messages in two categories: Communication &amp; Service, and Content &amp; Marketing.</para>
        /// <para>Communication &amp; Service (requires permission):</para>
        /// <list type="bullet">
        /// <item><description><para>IM: Instant messaging, audio, and video calls</para>
        /// </description></item>
        /// <item><description><para>ACCOUNT: Personal account and asset changes</para>
        /// </description></item>
        /// <item><description><para>DEVICE_REMINDER: Personal device reminders</para>
        /// </description></item>
        /// <item><description><para>ORDER: Personal order/logistics status changes</para>
        /// </description></item>
        /// <item><description><para>TODO: Personal schedule/to-do items</para>
        /// </description></item>
        /// <item><description><para>SUBSCRIPTION: Personal subscriptions</para>
        /// </description></item>
        /// </list>
        /// <para>Content &amp; Marketing:</para>
        /// <list type="bullet">
        /// <item><description><para>NEWS: News and information</para>
        /// </description></item>
        /// <item><description><para>CONTENT: Content recommendations</para>
        /// </description></item>
        /// <item><description><para>MARKETING: Platform activities</para>
        /// </description></item>
        /// <item><description><para>SOCIAL: Social updates</para>
        /// </description></item>
        /// </list>
        /// <para>For more information, see <a href="https://open.oppomobile.com/new/developmentDoc/info?id=13189">OPUSH Message Classification Rules</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MARKETING</para>
        /// </summary>
        [NameInMap("AndroidMessageOppoCategory")]
        [Validation(Required=false)]
        public string AndroidMessageOppoCategory { get; set; }

        /// <summary>
        /// <para>The alert level for notification bar messages on the OPPO channel. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>1: Notification bar</para>
        /// </description></item>
        /// <item><description><para>2: Notification bar, lock screen, ringtone, vibration (default level for Communication &amp; Service messages)</para>
        /// </description></item>
        /// <item><description><para>16: Notification bar, lock screen, ringtone, vibration, banner (requires permission)</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>When using the \<c>AndroidMessageOppoNotifyLevel\\</c> parameter, you must also pass the \<c>AndroidMessageOppoCategory\\</c> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AndroidMessageOppoNotifyLevel")]
        [Validation(Required=false)]
        public int? AndroidMessageOppoNotifyLevel { get; set; }

        /// <summary>
        /// <para>vivo classifies and manages messages in two categories: System messages and Operational messages.
        /// System messages:</para>
        /// <list type="bullet">
        /// <item><description><para>IM: Instant messages</para>
        /// </description></item>
        /// <item><description><para>ACCOUNT: Account and assets</para>
        /// </description></item>
        /// <item><description><para>TODO: Schedule and to-do</para>
        /// </description></item>
        /// <item><description><para>DEVICE_REMINDER: Device information</para>
        /// </description></item>
        /// <item><description><para>ORDER: Orders and logistics</para>
        /// </description></item>
        /// <item><description><para>SUBSCRIPTION: Subscription reminders</para>
        /// </description></item>
        /// </list>
        /// <para>Operational messages:</para>
        /// <list type="bullet">
        /// <item><description><para>NEWS: News</para>
        /// </description></item>
        /// <item><description><para>CONTENT: Content recommendations</para>
        /// </description></item>
        /// <item><description><para>MARKETING: Operational activities</para>
        /// </description></item>
        /// <item><description><para>SOCIAL: Social updates</para>
        /// </description></item>
        /// </list>
        /// <para>For more information, see <a href="https://dev.vivo.com.cn/documentCenter/doc/359#s-ef3qugc3">Classification description</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TODO</para>
        /// </summary>
        [NameInMap("AndroidMessageVivoCategory")]
        [Validation(Required=false)]
        public string AndroidMessageVivoCategory { get; set; }

        /// <summary>
        /// <para>The notification sound for the Huawei vendor channel. Specify the name of the audio file located in the \<c>app/src/main/res/raw/\\</c> directory of the client project. Do not include the file format suffix.</para>
        /// <para>If this is not set, the default ringtone is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alicloud_notification_sound</para>
        /// </summary>
        [NameInMap("AndroidMusic")]
        [Validation(Required=false)]
        public string AndroidMusic { get; set; }

        /// <summary>
        /// <para>The priority for arranging the Android notification in the notification bar. Valid values: -2, -1, 0, 1, 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AndroidNotificationBarPriority")]
        [Validation(Required=false)]
        public int? AndroidNotificationBarPriority { get; set; }

        /// <summary>
        /// <para>The custom Android notification bar style. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AndroidNotificationBarType")]
        [Validation(Required=false)]
        public int? AndroidNotificationBarType { get; set; }

        /// <summary>
        /// <para>The \<c>channelId\\</c> for the Android app. This must correspond to a \<c>channelId\\</c> in the app.</para>
        /// <list type="bullet">
        /// <item><description><para>Set the \<c>NotificationChannel\\</c> parameter. For more information about its usage, see <a href="https://help.aliyun.com/document_detail/67398.html">FAQ: Why are notifications not received on devices running Android 8.0 or later?</a>.</para>
        /// </description></item>
        /// <item><description><para>Because the \<c>channel_id\\</c> for the OPPO private message channel is the same as the app\&quot;s \<c>channelId\\</c>, this value is used for pushes through the OPPO channel.</para>
        /// </description></item>
        /// <item><description><para>This value is used for pushes through Huawei, FCM, and Alibaba Cloud\&quot;s proprietary channels.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AndroidNotificationChannel")]
        [Validation(Required=false)]
        public string AndroidNotificationChannel { get; set; }

        /// <summary>
        /// <para>Message grouping. For messages in the same group, the notification bar shows only the latest message and the total number of messages received for that group. It does not display all messages and cannot be expanded. Currently supported on:</para>
        /// <list type="bullet">
        /// <item><description><para>Huawei vendor channel</para>
        /// </description></item>
        /// <item><description><para>Honor vendor channel</para>
        /// </description></item>
        /// <item><description><para>Proprietary channel for Android SDK 3.9.1 and earlier</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is no longer supported by the proprietary channel for Android SDK 3.9.2 and later.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>group-1</para>
        /// </summary>
        [NameInMap("AndroidNotificationGroup")]
        [Validation(Required=false)]
        public string AndroidNotificationGroup { get; set; }

        /// <summary>
        /// <para>Sets the \<c>importance\\</c> parameter for Honor notification message classification. This determines the notification behavior on the user\&quot;s device. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>LOW</b>: For informational and marketing messages.</para>
        /// </description></item>
        /// <item><description><para><b>NORMAL</b>: For service and communication messages.</para>
        /// </description></item>
        /// </list>
        /// <para>Apply for this on the Honor platform. <a href="https://developer.honor.com/cn/docs/11002/guides/notification-class#%E8%87%AA%E5%88%86%E7%B1%BB%E6%9D%83%E7%9B%8A%E7%94%B3%E8%AF%B7">Application link</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LOW</para>
        /// </summary>
        [NameInMap("AndroidNotificationHonorChannel")]
        [Validation(Required=false)]
        public string AndroidNotificationHonorChannel { get; set; }

        /// <summary>
        /// <para>Sets the \<c>importance\\</c> parameter for Huawei notification message classification. This determines the notification behavior on the user\&quot;s device. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>LOW: For informational and marketing messages.</para>
        /// </description></item>
        /// <item><description><para>NORMAL: For service and communication messages.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>For the Huawei channel, use \<c>AndroidMessageHuaweiCategory\\</c> for notification classification. You may no longer need to use \<c>AndroidNotificationHuaweiChannel\\</c>.</para>
        /// </description></item>
        /// <item><description><para>Apply for this on the Huawei platform. <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/message-classification-0000001149358835#section893184112272">Application link</a>.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>LOW</para>
        /// </summary>
        [NameInMap("AndroidNotificationHuaweiChannel")]
        [Validation(Required=false)]
        public string AndroidNotificationHuaweiChannel { get; set; }

        /// <summary>
        /// <para>A unique identifier for each message when it is displayed as a notification. Different notifications can have the same \<c>NotifyId\\</c>, which allows a new notification to overwrite an old one.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100001</para>
        /// </summary>
        [NameInMap("AndroidNotificationNotifyId")]
        [Validation(Required=false)]
        public int? AndroidNotificationNotifyId { get; set; }

        /// <summary>
        /// <para>Message grouping. Messages in the same group are displayed in a collapsed state in the notification bar and can be expanded. Notifications from different groups are displayed separately. Currently supported on:</para>
        /// <list type="bullet">
        /// <item><description>Proprietary channel for Android SDK 3.9.2 and later</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>thread-1</para>
        /// </summary>
        [NameInMap("AndroidNotificationThreadId")]
        [Validation(Required=false)]
        public string AndroidNotificationThreadId { get; set; }

        /// <summary>
        /// <para>Sets the classification for vivo notification messages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: Operational messages (default)</para>
        /// </description></item>
        /// <item><description><para>1: System messages</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>For the vivo channel, use \<c>AndroidMessageVivoCategory\\</c> for notification classification. You may no longer need to use \<c>AndroidNotificationVivoChannel\\</c>.</para>
        /// </description></item>
        /// <item><description><para>Apply for this on the vivo platform. For more information, see <a href="https://dev.vivo.com.cn/documentCenter/doc/359">Application link</a>.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>classification</para>
        /// </summary>
        [NameInMap("AndroidNotificationVivoChannel")]
        [Validation(Required=false)]
        public string AndroidNotificationVivoChannel { get; set; }

        /// <summary>
        /// <para>Sets the \<c>channelId\\</c> for the Xiaomi notification type. Apply for this on the Xiaomi platform. For more information, see <a href="https://dev.mi.com/console/doc/detail?pId=2422#_4">Application link</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>A single app can apply for a maximum of 8 channels through the Xiaomi channel. Plan accordingly.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>michannel</para>
        /// </summary>
        [NameInMap("AndroidNotificationXiaomiChannel")]
        [Validation(Required=false)]
        public string AndroidNotificationXiaomiChannel { get; set; }

        /// <summary>
        /// <para>The notification alert type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>VIBRATE</b>: Vibrate (default)</para>
        /// </description></item>
        /// <item><description><para><b>SOUND</b>: Sound</para>
        /// </description></item>
        /// <item><description><para><b>BOTH</b>: Sound and vibrate</para>
        /// </description></item>
        /// <item><description><para><b>NONE</b>: Silent</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BOTH</para>
        /// </summary>
        [NameInMap("AndroidNotifyType")]
        [Validation(Required=false)]
        public string AndroidNotifyType { get; set; }

        /// <summary>
        /// <para>The action to take after a notification is tapped. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>APPLICATION</b>: Open the application (default).</para>
        /// </description></item>
        /// <item><description><para><b>ACTIVITY</b>: Open a specific Android Activity.</para>
        /// </description></item>
        /// <item><description><para><b>URL</b>: Open a URL.</para>
        /// </description></item>
        /// <item><description><para><b>NONE</b>: No action.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>APPLICATION</para>
        /// </summary>
        [NameInMap("AndroidOpenType")]
        [Validation(Required=false)]
        public string AndroidOpenType { get; set; }

        /// <summary>
        /// <para>The URL to open after the Android device receives the push.</para>
        /// <para>This is required only when \<c>AndroidOpenType\\</c> is \<c>URL\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxxx.xxx">https://xxxx.xxx</a></para>
        /// </summary>
        [NameInMap("AndroidOpenUrl")]
        [Validation(Required=false)]
        public string AndroidOpenUrl { get; set; }

        /// <summary>
        /// <para>A JSON string of the OPPO Fluid Cloud intent deletion data structure <a href="https://open.oppomobile.com/documentation/page/info?id=13578">data</a>. This parameter is invalid if the \<c>AndroidOppoIntelligentIntent\\</c> parameter is filled. For development and integration, see <a href="https://help.aliyun.com/document_detail/2997310.html">OPPO Fluid Cloud Push Guide</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;intentName&quot;: &quot;Example.Progress&quot;,
        ///     &quot;entityIds&quot;: [
        ///         &quot;A580202509130712&quot;
        ///     ],
        ///     &quot;serviceId&quot;: {
        ///         &quot;launcher&quot;: &quot;999800001&quot;,
        ///         &quot;fluidCloud&quot;: &quot;999900001&quot;
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("AndroidOppoDeleteIntentData")]
        [Validation(Required=false)]
        public string AndroidOppoDeleteIntentData { get; set; }

        /// <summary>
        /// <para>A JSON string of the OPPO Fluid Cloud intent sharing data structure <a href="https://open.oppomobile.com/documentation/page/info?id=13565">IntelligentIntent</a>. For development and integration, see <a href="https://help.aliyun.com/document_detail/2997310.html">OPPO Fluid Cloud Push Guide</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;intentName&quot;: &quot;Example.Progress&quot;,
        ///     &quot;identifier&quot;: &quot;d71ebd3119877b12ecdb6c4fe96b068e&quot;,
        ///     &quot;timestamp&quot;: 1729485000989,
        ///     &quot;serviceId&quot;: {
        ///         &quot;launcher&quot;: &quot;999800001&quot;,
        ///         &quot;fluidCloud&quot;: &quot;999900001&quot;
        ///     },
        ///     &quot;intentAction&quot;: {
        ///         &quot;actionStatus&quot;: 0
        ///     },
        ///     &quot;intentEntity&quot;: {
        ///         &quot;entityName&quot;: &quot;TAXI&quot;
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("AndroidOppoIntelligentIntent")]
        [Validation(Required=false)]
        public string AndroidOppoIntelligentIntent { get; set; }

        /// <summary>
        /// <para>Sets the OPPO Fluid Cloud push environment.</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Production environment (default).</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Staging environment.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The OPPO Fluid Cloud staging environment must be set up on the client side. For more information, see <a href="https://open.oppomobile.com/documentation/page/info?id=13590">Environment setup</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AndroidOppoIntentEnv")]
        [Validation(Required=false)]
        public int? AndroidOppoIntentEnv { get; set; }

        /// <summary>
        /// <para>OPPO private message template content parameters</para>
        /// </summary>
        [NameInMap("AndroidOppoPrivateContentParameters")]
        [Validation(Required=false)]
        public Dictionary<string, string> AndroidOppoPrivateContentParameters { get; set; }

        /// <summary>
        /// <para>OPPO private message template ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>687557242b1634hzefs3d5013</para>
        /// </summary>
        [NameInMap("AndroidOppoPrivateMsgTemplateId")]
        [Validation(Required=false)]
        public string AndroidOppoPrivateMsgTemplateId { get; set; }

        /// <summary>
        /// <para>OPPO private message template title parameters</para>
        /// </summary>
        [NameInMap("AndroidOppoPrivateTitleParameters")]
        [Validation(Required=false)]
        public Dictionary<string, string> AndroidOppoPrivateTitleParameters { get; set; }

        /// <summary>
        /// <para>Specifies the Activity to launch after the notification is tapped.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.alibaba.cloudpushdemo.bizactivity</para>
        /// </summary>
        [NameInMap("AndroidPopupActivity")]
        [Validation(Required=false)]
        public string AndroidPopupActivity { get; set; }

        /// <summary>
        /// <para>The body content in auxiliary pop-up mode. This parameter is required if \<c>AndroidPopupActivity\\</c> is not empty.</para>
        /// <para>Length limit: 200 characters. Both Chinese and English characters count as one.</para>
        /// <para>If you use a vendor channel, comply with its restrictions. For more information, see <a href="https://help.aliyun.com/document_detail/165253.html">Limits on pushes through auxiliary channels on Android</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello</para>
        /// </summary>
        [NameInMap("AndroidPopupBody")]
        [Validation(Required=false)]
        public string AndroidPopupBody { get; set; }

        /// <summary>
        /// <para>The title content in auxiliary pop-up mode. This parameter is required if \<c>AndroidPopupActivity\\</c> is not empty.</para>
        /// <para>Length limit: 50 characters. Both Chinese and English characters count as one.</para>
        /// <para>If you use a vendor channel, comply with its restrictions. For more information, see <a href="https://help.aliyun.com/document_detail/165253.html">Limits on pushes through auxiliary channels on Android</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello</para>
        /// </summary>
        [NameInMap("AndroidPopupTitle")]
        [Validation(Required=false)]
        public string AndroidPopupTitle { get; set; }

        /// <summary>
        /// <para>If the device is offline when a message is pushed, this push uses the auxiliary pop-up feature. The default value is \<c>false\\</c>. This is effective only when \<c>PushType\\</c> is \<c>MESSAGE\\</c>.</para>
        /// <para>If the message is successfully converted to a notification, the data displayed in the notification is the value of the \<c>AndroidPopupTitle\\</c> and \<c>AndroidPopupBody\\</c> parameters set on the server. When the notification is tapped, the data obtained in the \<c>onSysNoticeOpened\\</c> method of the auxiliary pop-up is the value of the \<c>Title\\</c> and \<c>Body\\</c> parameters set on the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AndroidRemind")]
        [Validation(Required=false)]
        public bool? AndroidRemind { get; set; }

        /// <summary>
        /// <para>The notification style. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Standard mode (default)</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Long text mode (supported by Huawei, Honor, Xiaomi, OPPO, Meizu, and proprietary channels)</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Big picture mode (supported by proprietary channels, but not by Xiaomi models)</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: List mode (supported by Huawei, Honor, Xiaomi, OPPO, and proprietary channels)</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required if you use a non-standard mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AndroidRenderStyle")]
        [Validation(Required=false)]
        public int? AndroidRenderStyle { get; set; }

        /// <summary>
        /// <para>Sets the vendor channel notification type:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Formal notification (default).</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Test notification.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Configuring this parameter is equivalent to configuring \<c>AndroidHuaweiTargetUserType\\</c>, \<c>AndroidHonorTargetUserType\\</c>, \<c>AndroidVivoPushMode\\</c>, and \<c>AndroidOppoIntentEnv\\</c> simultaneously. Specific vendor channel parameters can override this setting.</para>
        /// </description></item>
        /// <item><description><para>Currently supported by: Huawei channel, Honor channel, vivo channel, and OPPO Fluid Cloud.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AndroidTargetUserType")]
        [Validation(Required=false)]
        public int? AndroidTargetUserType { get; set; }

        /// <summary>
        /// <para>A JSON string of the vivo Atomic Island data structure <a href="https://dev.vivo.com.cn/documentCenter/doc/896#s-fdagzbd4">liveMessage</a>. For development and integration, see <a href="https://help.aliyun.com/zh/document_detail/3030718.html">vivo Atomic Island Push Guide</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;operation&quot;: 0,
        ///     &quot;scene&quot;: &quot;HEALTH_REGISTER&quot;,
        ///     &quot;templateType&quot;: 1,
        ///     &quot;showNotify&quot;: true,
        ///     &quot;changeRecord&quot;: 999,
        ///     &quot;capsuleData&quot;: {
        ///         &quot;bgColor&quot;: &quot;#32d4d4&quot;
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("AndroidVivoLiveMessage")]
        [Validation(Required=false)]
        public string AndroidVivoLiveMessage { get; set; }

        /// <summary>
        /// <para>Sets the vivo channel notification type:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Formal push (default).</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Test push.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For test pushes, configure test devices in the vivo console beforehand. Find the test device\&quot;s \<c>RegId\\</c> by searching for &quot;onReceiveRegId regId&quot; in the device startup logs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AndroidVivoPushMode")]
        [Validation(Required=false)]
        public int? AndroidVivoPushMode { get; set; }

        /// <summary>
        /// <para>The receipt ID for the vivo channel. You can find this ID in the application information section of the vivo open platform\&quot;s push service.</para>
        /// <remarks>
        /// <para>If the default receipt configuration on the vivo open platform is the Alibaba Cloud receipt, do not provide this. If not, first configure the default vivo channel receipt ID in the Alibaba Cloud EMAS Mobile Push console.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("AndroidVivoReceiptId")]
        [Validation(Required=false)]
        public string AndroidVivoReceiptId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated. All third-party auxiliary pop-ups are now supported by the new parameter <b>AndroidPopupActivity</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("AndroidXiaoMiActivity")]
        [Validation(Required=false)]
        [Obsolete]
        public string AndroidXiaoMiActivity { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated. All third-party auxiliary pop-ups are now supported by the new parameter <b>AndroidPopupBody</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("AndroidXiaoMiNotifyBody")]
        [Validation(Required=false)]
        [Obsolete]
        public string AndroidXiaoMiNotifyBody { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated. All third-party auxiliary pop-ups are now supported by the new parameter <b>AndroidPopupTitle</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("AndroidXiaoMiNotifyTitle")]
        [Validation(Required=false)]
        [Obsolete]
        public string AndroidXiaoMiNotifyTitle { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated. Starting from August 2023, Xiaomi no longer supports dynamically setting small icons, right-side icons, or large pictures during pushes on new devices/systems.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://f6.market.xiaomi.com/download/MiPass/aaa/bbb.png">https://f6.market.xiaomi.com/download/MiPass/aaa/bbb.png</a></para>
        /// </summary>
        [NameInMap("AndroidXiaomiBigPictureUrl")]
        [Validation(Required=false)]
        [Obsolete]
        public string AndroidXiaomiBigPictureUrl { get; set; }

        /// <summary>
        /// <para>A JSON string of the Xiaomi Super Island data structure <a href="https://dev.mi.com/xiaomihyperos/documentation/detail?pId=2131">miui.focus.param</a>. For development and integration, see <a href="https://help.aliyun.com/zh/document_detail/3037956.html">Xiaomi Super Island Push Guide</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;param_v2&quot;: {
        ///         &quot;business&quot;: &quot;taxi&quot;,
        ///         &quot;updatable&quot;: true,
        ///         &quot;orderId&quot;: &quot;A580202509130712&quot;,
        ///         &quot;param_island&quot;: {
        ///             &quot;islandProperty&quot;: 1,
        ///             &quot;bigIslandArea&quot;: {
        ///                 &quot;imageTextInfoLeft&quot;: {
        ///                     &quot;type&quot;: 1
        ///                 }
        ///             }
        ///         }
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("AndroidXiaomiFocusParam")]
        [Validation(Required=false)]
        public string AndroidXiaomiFocusParam { get; set; }

        /// <summary>
        /// <para>A JSON string of the Xiaomi Super Island data images <a href="https://dev.mi.com/xiaomihyperos/documentation/detail?pId=2131">miui.focus.pic_xxx</a>. For development and integration, see <a href="https://help.aliyun.com/zh/document_detail/3037956.html">Xiaomi Super Island Push Guide</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;miui.focus.pic_ticker&quot;: &quot;<a href="https://example.com/ticker.jpg">https://example.com/ticker.jpg</a>&quot;,
        ///     &quot;miui.focus.pic_aod&quot;: &quot;<a href="https://example.com/aod.jpg">https://example.com/aod.jpg</a>&quot;,
        ///     &quot;miui.focus.pic_imageText&quot;: &quot;<a href="https://example.com/imageText.jpg">https://example.com/imageText.jpg</a>&quot;
        /// }</para>
        /// </summary>
        [NameInMap("AndroidXiaomiFocusPics")]
        [Validation(Required=false)]
        public string AndroidXiaomiFocusPics { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated. Starting from August 2023, Xiaomi no longer supports dynamically setting small icons, right-side icons, or large pictures during pushes on new devices/systems.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://imag.example.com/image.png">https://imag.example.com/image.png</a></para>
        /// </summary>
        [NameInMap("AndroidXiaomiImageUrl")]
        [Validation(Required=false)]
        [Obsolete]
        public string AndroidXiaomiImageUrl { get; set; }

        [NameInMap("AndroidXiaomiTemplateId")]
        [Validation(Required=false)]
        public string AndroidXiaomiTemplateId { get; set; }

        [NameInMap("AndroidXiaomiTemplateParams")]
        [Validation(Required=false)]
        public string AndroidXiaomiTemplateParams { get; set; }

        /// <summary>
        /// <para>The AppKey.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23267207</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        /// <summary>
        /// <para>The content of the notification or message for Android and HarmonyOS pushes. The content of the message or notification for iOS. The size of the push content is limited. For more information, see <a href="https://help.aliyun.com/document_detail/434629.html">Product limits</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello</para>
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// <para>The device type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HARMONY</b>: A HarmonyOS device.</para>
        /// </description></item>
        /// <item><description><para><b>iOS</b>: An iOS device.</para>
        /// </description></item>
        /// <item><description><para><b>ANDROID</b>: An Android device.</para>
        /// </description></item>
        /// <item><description><para><b>ALL</b>: For older dual-platform apps, this sends pushes to both Android and iOS devices. For newer single-platform apps, this has the same effect as specifying the device type for that app.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HARMONY</para>
        /// </summary>
        [NameInMap("DeviceType")]
        [Validation(Required=false)]
        public string DeviceType { get; set; }

        /// <summary>
        /// <para>The expiration time for offline messages or notifications. Use this with \<c>StoreOffline\\</c>. The message is not sent after this time. The maximum retention period is 72 hours, which is also the default.</para>
        /// <para>The time must be in ISO 8601 format and in UTC: \<c>YYYY-MM-DDThh:mm:ssZ\\</c>. The expiration time must be at least 3 seconds after the current time or the scheduled push time (\<c>ExpireTime\\</c> &gt; \<c>PushTime\\</c> + 3 seconds). The 3-second buffer accounts for network and system delays. For single pushes, use a value of at least 1 minute. For batch pushes or pushes to all devices, use a value of at least 10 minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-02-20T00:00:00Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The action corresponding to the in-app page ability.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>When \<c>HarmonyActionType\\</c> is \<c>APP_CUSTOM_PAGE\\</c>, fill in at least one of \<c>HarmonyUri\\</c> or \<c>HarmonyAction\\</c>.</para>
        /// <para>For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section152462191216">ClickAction.action</a> in the HarmonyOS documentation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.example.action</para>
        /// </summary>
        [NameInMap("HarmonyAction")]
        [Validation(Required=false)]
        public string HarmonyAction { get; set; }

        /// <summary>
        /// <para>The action to take after a notification is tapped. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>APP_HOME_PAGE: Open the app\&quot;s home page.</para>
        /// </description></item>
        /// <item><description><para>APP_CUSTOM_PAGE: Open a custom page in the app.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>APP_HOME_PAGE</para>
        /// </summary>
        [NameInMap("HarmonyActionType")]
        [Validation(Required=false)]
        public string HarmonyActionType { get; set; }

        /// <summary>
        /// <para>The number to add to the HarmonyOS app badge. See the description of the <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section266310382145">HarmonyOS badge addNum field</a>.<br>
        /// Supported starting from HarmonyOS SDK version 1.2.0.<br></para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HarmonyBadgeAddNum")]
        [Validation(Required=false)]
        public int? HarmonyBadgeAddNum { get; set; }

        /// <summary>
        /// <para>The number to set for the HarmonyOS app badge. See the description of the <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section266310382145">HarmonyOS badge setNum field</a>.
        /// Supported starting from HarmonyOS SDK version 1.2.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HarmonyBadgeSetNum")]
        [Validation(Required=false)]
        public int? HarmonyBadgeSetNum { get; set; }

        /// <summary>
        /// <para>The notification message category. After you apply for notification message self-classification rights, this is used to identify the message type. Different notification message types affect how messages are displayed and alerted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>IM: Instant messaging</para>
        /// </description></item>
        /// <item><description><para>VOIP: Voice and video calls</para>
        /// </description></item>
        /// <item><description><para>SUBSCRIPTION: Subscriptions</para>
        /// </description></item>
        /// <item><description><para>TRAVEL: Travel</para>
        /// </description></item>
        /// <item><description><para>HEALTH: Health</para>
        /// </description></item>
        /// <item><description><para>WORK: Work reminders</para>
        /// </description></item>
        /// <item><description><para>ACCOUNT: Account updates</para>
        /// </description></item>
        /// <item><description><para>EXPRESS: Orders &amp; logistics</para>
        /// </description></item>
        /// <item><description><para>FINANCE: Finance</para>
        /// </description></item>
        /// <item><description><para>DEVICE_REMINDER: Device reminders</para>
        /// </description></item>
        /// <item><description><para>MAIL: Mail</para>
        /// </description></item>
        /// <item><description><para>CUSTOMER_SERVICE: Customer service messages</para>
        /// </description></item>
        /// <item><description><para>MARKETING: News, content recommendations, social updates, product promotions, financial updates, lifestyle information, surveys, feature recommendations, and operational activities. This only identifies the content and does not speed up message delivery. These are collectively known as informational and marketing messages.</para>
        /// </description></item>
        /// </list>
        /// <para>For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section17371529101117">Notification.category</a> in the HarmonyOS documentation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IM</para>
        /// </summary>
        [NameInMap("HarmonyCategory")]
        [Validation(Required=false)]
        public string HarmonyCategory { get; set; }

        /// <summary>
        /// <para>Sets the extended properties of the notification. This property is not effective when \<c>PushType\\</c> is \<c>MESSAGE\\</c>.</para>
        /// <para>This parameter must be in JSON map format to avoid parsing errors.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key1&quot;:&quot;value1&quot;,&quot;api_name&quot;:&quot;PushNoticeToAndroidRequest&quot;}</para>
        /// </summary>
        [NameInMap("HarmonyExtParameters")]
        [Validation(Required=false)]
        public string HarmonyExtParameters { get; set; }

        /// <summary>
        /// <para>The extra data for the extended notification message.<br>
        /// This is effective when sending a HarmonyOS extended notification message.<br>
        /// Conceptually, this is equivalent to the \<c>extraData\\</c> field of a HarmonyOS extended notification message. For the specific definition, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section161192514234">HarmonyOS ExtensionPayload Description</a>.<br>
        /// Supported starting from HarmonyOS SDK version 1.2.0.<br><br><br></para>
        /// 
        /// <b>Example:</b>
        /// <para>示例额外数据</para>
        /// </summary>
        [NameInMap("HarmonyExtensionExtraData")]
        [Validation(Required=false)]
        public string HarmonyExtensionExtraData { get; set; }

        /// <summary>
        /// <para>When \<c>PushType\\</c> is \<c>NOTICE\\</c>, specifies whether this is a HarmonyOS extended notification message.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Send an extended notification message.</para>
        /// </description></item>
        /// <item><description><para>false: Send a normal notification (default).</para>
        /// </description></item>
        /// </list>
        /// <para>Apply for permission on the HarmonyOS side before you can send extended notification messages. For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-guides-V5/push-send-extend-noti-V5">Send Extended Notification Messages</a> in the HarmonyOS documentation.<br>
        /// Supported starting from HarmonyOS SDK version 1.2.0.<br></para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HarmonyExtensionPush")]
        [Validation(Required=false)]
        public bool? HarmonyExtensionPush { get; set; }

        /// <summary>
        /// <para>The URL for the large icon on the right of the notification. The URL must use the HTTPS protocol.</para>
        /// <remarks>
        /// <para>Supported image formats are PNG, JPG, JPEG, HEIF, GIF, and BMP. The image dimensions (height × width) must be less than 25,000 pixels.</para>
        /// </remarks>
        /// <para>For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section17371529101117">Notification.image</a> in the HarmonyOS documentation.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/xxx.png">https://example.com/xxx.png</a></para>
        /// </summary>
        [NameInMap("HarmonyImageUrl")]
        [Validation(Required=false)]
        public string HarmonyImageUrl { get; set; }

        /// <summary>
        /// <para>The content for the multi-line text style. This field is required when \<c>HarmonyRenderStyle\\</c> is \<c>MULTI_LINE\\</c>. It supports up to 3 lines of content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;1.content1&quot;,&quot;2.content2&quot;,&quot;3.content3&quot;]</para>
        /// </summary>
        [NameInMap("HarmonyInboxContent")]
        [Validation(Required=false)]
        public string HarmonyInboxContent { get; set; }

        /// <summary>
        /// <para>A JSON string of the HarmonyOS Live Window data structure <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V13/push-scenariozed-api-request-param-V13#section66881469306">LiveViewPayload</a>. For development and integration, see <a href="https://help.aliyun.com/document_detail/2982112.html">HarmonyOS Live Window Push Guide</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;activityId&quot;: 1,
        ///   &quot;operation&quot;: 0,
        ///   &quot;event&quot;: &quot;TAXI&quot;,
        ///   &quot;status&quot;: &quot;DRIVER_ON_THE_WAY&quot;,
        ///   &quot;activityData&quot;: {
        ///     &quot;notificationData&quot;: {
        ///       &quot;type&quot;: 3
        ///     }
        ///   }
        /// }</para>
        /// </summary>
        [NameInMap("HarmonyLiveViewPayload")]
        [Validation(Required=false)]
        public string HarmonyLiveViewPayload { get; set; }

        /// <summary>
        /// <para>Uses the specified type of notification channel. This is effective only when the Alibaba Cloud proprietary channel is online.</para>
        /// <list type="bullet">
        /// <item><description><para>SOCIAL_COMMUNICATION: Social communication.</para>
        /// </description></item>
        /// <item><description><para>SERVICE_INFORMATION: Service reminders.</para>
        /// </description></item>
        /// <item><description><para>CONTENT_INFORMATION: Content information.</para>
        /// </description></item>
        /// <item><description><para>CUSTOMER_SERVICE: Customer service messages. This type is for messages between users and businesses and must be initiated by the user.</para>
        /// </description></item>
        /// <item><description><para>OTHER_TYPES: Others.</para>
        /// </description></item>
        /// </list>
        /// <para>For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/js-apis-notificationmanager-V5#slottype">SlotType</a> in the HarmonyOS documentation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SOCIAL_COMMUNICATION</para>
        /// </summary>
        [NameInMap("HarmonyNotificationSlotType")]
        [Validation(Required=false)]
        public string HarmonyNotificationSlotType { get; set; }

        /// <summary>
        /// <para>A unique identifier for each message when it is displayed as a notification. If not provided, the push service automatically generates a unique ID for each message. Different notifications can have the same \<c>notifyId\\</c>, which allows a new message to overwrite an old one.</para>
        /// <para>For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section17371529101117">Notification.notifyId</a> in the HarmonyOS documentation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HarmonyNotifyId")]
        [Validation(Required=false)]
        public int? HarmonyNotifyId { get; set; }

        /// <summary>
        /// <para>The receipt ID for the HarmonyOS channel. You can find this ID in the receipt parameter configuration on the HarmonyOS Push service platform.</para>
        /// <remarks>
        /// <para>If the default receipt configuration on the HarmonyOS Push service platform is the Alibaba Cloud receipt, do not provide this. If not, first configure the default HarmonyOS channel receipt ID in the Alibaba Cloud EMAS Mobile Push console.</para>
        /// </remarks>
        /// <para>For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section418321011212">pushOptions.receiptId</a> in the HarmonyOS documentation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RCPB***DFD5</para>
        /// </summary>
        [NameInMap("HarmonyReceiptId")]
        [Validation(Required=false)]
        public string HarmonyReceiptId { get; set; }

        /// <summary>
        /// <para>If the device is offline when a message is pushed, this push uses the auxiliary pop-up feature. The default value is \<c>false\\</c>. This is effective only when \<c>PushType\\</c> is \<c>MESSAGE\\</c>.</para>
        /// <para>If the message is successfully converted to a notification, the data displayed in the notification is the value of the \<c>HarmonyRemindTitle\\</c> and \<c>HarmonyRemindBody\\</c> parameters set on the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HarmonyRemind")]
        [Validation(Required=false)]
        public bool? HarmonyRemind { get; set; }

        /// <summary>
        /// <para>The HarmonyOS notification content used when a message is converted to a notification. This is effective only when \<c>HarmonyRemind\\</c> is \<c>true\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>您有一条新消息，请查收</para>
        /// </summary>
        [NameInMap("HarmonyRemindBody")]
        [Validation(Required=false)]
        public string HarmonyRemindBody { get; set; }

        /// <summary>
        /// <para>The HarmonyOS notification title used when a message is converted to a notification. This is effective only when \<c>HarmonyRemind\\</c> is \<c>true\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>新消息</para>
        /// </summary>
        [NameInMap("HarmonyRemindTitle")]
        [Validation(Required=false)]
        public string HarmonyRemindTitle { get; set; }

        /// <summary>
        /// <para>The notification message style:</para>
        /// <list type="bullet">
        /// <item><description><para>NORMAL: Normal notification (default)</para>
        /// </description></item>
        /// <item><description><para>MULTI_LINE: Multi-line text style</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("HarmonyRenderStyle")]
        [Validation(Required=false)]
        public string HarmonyRenderStyle { get; set; }

        /// <summary>
        /// <para>Test message flag:</para>
        /// <list type="bullet">
        /// <item><description><para>false: Normal message (default)</para>
        /// </description></item>
        /// <item><description><para>true: Test message</para>
        /// </description></item>
        /// </list>
        /// <para>For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section418321011212">pushOptions.testMessage</a> in the HarmonyOS documentation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HarmonyTestMessage")]
        [Validation(Required=false)]
        public bool? HarmonyTestMessage { get; set; }

        /// <summary>
        /// <para>The URI corresponding to the in-app page ability.</para>
        /// <remarks>
        /// <para>Notice: When \<c>HarmonyActionType\\</c> is \<c>APP_CUSTOM_PAGE\\</c>, fill in at least one of \<c>HarmonyUri\\</c> or \<c>HarmonyAction\\</c>. If there are multiple abilities, fill in the action and URI for each. The action is used with priority to find the corresponding in-app page.</para>
        /// </remarks>
        /// <para>For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section152462191216">ClickAction.uri</a> in the HarmonyOS documentation.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.example.com:8080/push/example">https://www.example.com:8080/push/example</a></para>
        /// </summary>
        [NameInMap("HarmonyUri")]
        [Validation(Required=false)]
        public string HarmonyUri { get; set; }

        /// <summary>
        /// <para>An idempotent parameter to prevent duplicate pushes caused by API call retries. If you make a call with the same \<c>IdempotentToken\\</c> within 15 minutes, only one push is sent. Subsequent calls return the result of the first successful push.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>The parameter must be a standard 36-character UUID (8-4-4-4-12). Each valid character must be a hexadecimal digit from 0-9 or a-f, case-insensitive.</para>
        /// </description></item>
        /// <item><description><para>This parameter only prevents duplicate pushes from retries. It cannot prevent duplicate pushes from concurrent calls.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>c8016d13-6e76-410c-9bda-769383d11787</para>
        /// </summary>
        [NameInMap("IdempotentToken")]
        [Validation(Required=false)]
        public string IdempotentToken { get; set; }

        /// <summary>
        /// <para>A custom ID for the push task. If \<c>JobKey\\</c> is not empty, this field is included in the receipt logs. For more information about receipt logs, see <a href="https://help.aliyun.com/document_detail/434651.html">Receipt logs</a>.</para>
        /// <remarks>
        /// <para>The format must consist of letters, numbers, underscores (_), or hyphens (-). The length cannot exceed 32 characters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("JobKey")]
        [Validation(Required=false)]
        public string JobKey { get; set; }

        /// <summary>
        /// <para>Used for scheduled sending. If you do not set this parameter, the push is sent immediately.
        /// The scheduled time can be no more than 7 days in the future.</para>
        /// <para>The time must be in ISO 8601 format and in UTC: \<c>YYYY-MM-DDThh:mm:ssZ\\</c>.</para>
        /// <remarks>
        /// <para>Scheduled sending is not supported when \<c>Target\\</c> is \<c>TBD\\</c> (continuous push).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2019-02-20T00:00:00Z</para>
        /// </summary>
        [NameInMap("PushTime")]
        [Validation(Required=false)]
        public string PushTime { get; set; }

        /// <summary>
        /// <para>The push type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>NOTICE</b>: A notification. Notifications are sent to devices through vendor channels, such as APNs, Huawei, Xiaomi, and HarmonyOS, and appear directly in the device\&quot;s notification bar. When an Android device is online (the app process is active), the notification is preferentially sent through Alibaba Cloud\&quot;s proprietary channel. The Push software development kit (SDK) then constructs and displays the notification. This improves push performance and can save on vendor channel message quotas in some scenarios.</para>
        /// </description></item>
        /// <item><description><para><b>MESSAGE</b>: A message. Messages are sent through Alibaba Cloud\&quot;s proprietary online channel. They do not appear in the notification bar by default. Instead, the app must be active to receive and process them. Your business logic determines whether to trigger any actions. If a device is offline (the app process is inactive), it cannot receive messages immediately. In this case, use the \<c>iOSRemind\\</c> or \<c>AndroidRemind\\</c> parameter to convert the message into a notification. Alternatively, set the \<c>StoreOffline\\</c> parameter to have the push system save the message. The system then delivers the message automatically when the device comes back online.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MESSAGE</para>
        /// </summary>
        [NameInMap("PushType")]
        [Validation(Required=false)]
        public string PushType { get; set; }

        /// <summary>
        /// <para>Specifies the sending channels. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>accs: Alibaba Cloud\&quot;s proprietary channel</para>
        /// </description></item>
        /// <item><description><para>huawei: Huawei channel</para>
        /// </description></item>
        /// <item><description><para>honor: Honor channel</para>
        /// </description></item>
        /// <item><description><para>xiaomi: Xiaomi channel</para>
        /// </description></item>
        /// <item><description><para>oppo: OPPO channel</para>
        /// </description></item>
        /// <item><description><para>vivo: vivo channel</para>
        /// </description></item>
        /// <item><description><para>meizu: Meizu channel</para>
        /// </description></item>
        /// <item><description><para>gcm: Google GCM channel (legacy HTTP)</para>
        /// </description></item>
        /// <item><description><para>fcm: Google Firebase channel (HTTP v1 API)</para>
        /// </description></item>
        /// <item><description><para>apns: APNs channel</para>
        /// </description></item>
        /// <item><description><para>harmony: HarmonyOS channel</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If you do not set this parameter, all channels can be used.</para>
        /// </description></item>
        /// <item><description><para>If you set this parameter, only the specified channels are used.</para>
        /// </description></item>
        /// <item><description><para>If the specified channels conflict with the sending policy, the push is not sent. For example, if an iOS notification can only be sent through the APNs channel, but \<c>apns\\</c> is not included in this parameter, the push will fail.</para>
        /// </description></item>
        /// <item><description><para>If you specify \<c>gcm\\</c>, pushes can be sent through both Google GCM and FCM channels. If you specify \<c>fcm\\</c>, pushes can only be sent through the Google FCM channel.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>accs,huawei,xiaomi</para>
        /// </summary>
        [NameInMap("SendChannels")]
        [Validation(Required=false)]
        public string SendChannels { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SendSpeed")]
        [Validation(Required=false)]
        [Obsolete]
        public int? SendSpeed { get; set; }

        /// <summary>
        /// <para>The delay time in seconds before triggering the text message.</para>
        /// <para>This must be set if using SMS filter interaction. Set it to 15 seconds or more, with a maximum of 3 days, to avoid duplicate pushes and text messages.</para>
        /// <remarks>
        /// <para>When using SMS filter interaction, the \<c>ExpireTime\\</c> parameter is invalid. The notification expiration time is calculated based on the \<c>SmsDelaySecs\\</c> parameter. The expiration time is the current time plus the \<c>SmsDelaySecs\\</c> time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("SmsDelaySecs")]
        [Validation(Required=false)]
        public int? SmsDelaySecs { get; set; }

        /// <summary>
        /// <para>The key-value pairs for the variables in the SMS template. Format: <c>key1=value1&amp;key2=value2</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key1=value1</para>
        /// </summary>
        [NameInMap("SmsParams")]
        [Validation(Required=false)]
        public string SmsParams { get; set; }

        /// <summary>
        /// <para>The condition for triggering the text message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Triggered when the push is not received.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Triggered when the user does not open the push.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SmsSendPolicy")]
        [Validation(Required=false)]
        public int? SmsSendPolicy { get; set; }

        /// <summary>
        /// <para>The signature for the supplementary text message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>短信签名</para>
        /// </summary>
        [NameInMap("SmsSignName")]
        [Validation(Required=false)]
        public string SmsSignName { get; set; }

        /// <summary>
        /// <para>The name of the SMS template for supplementary sending. Get this from the SMS template management interface. This is the system-assigned name, not the name set by the developer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>短信模板名称</para>
        /// </summary>
        [NameInMap("SmsTemplateName")]
        [Validation(Required=false)]
        public string SmsTemplateName { get; set; }

        /// <summary>
        /// <para>Specifies whether to save offline messages and notifications. The default value is <b>false</b>.</para>
        /// <para>If set to true, and a user is offline, the message is sent again when the user comes online before the \<c>ExpireTime\\</c>. The default \<c>ExpireTime\\</c> is 72 hours. iOS notifications are sent through APNs and are not affected by this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("StoreOffline")]
        [Validation(Required=false)]
        public bool? StoreOffline { get; set; }

        /// <summary>
        /// <para>The push target. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>DEVICE</b>: Push to devices.</para>
        /// </description></item>
        /// <item><description><para><b>ACCOUNT</b>: Push to accounts.</para>
        /// </description></item>
        /// <item><description><para><b>ALIAS</b>: Push to aliases.</para>
        /// </description></item>
        /// <item><description><para><b>TAG</b>: Push to tags.</para>
        /// </description></item>
        /// <item><description><para><b>ALL</b>: Push to all devices. The interval between two consecutive pushes to all devices of the same \<c>DeviceType\\</c> must be at least 1 second.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>When pushing to all iOS devices, the push is sent to devices that have been active in the last 24 months and have not uninstalled the app. A push is considered delivered once the Apple Push Notification service (APNs) receives the request and does not return an error. This can cause a sharp increase in the number of active devices and lead to significant costs. Use this feature with caution.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>TBD</b>: Initializes a continuous push. The target is specified by a subsequent call to the <a href="https://help.aliyun.com/document_detail/2249917.html">ContinuouslyPush</a> API.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// <para>Set this based on the \<c>Target\\</c> type. Use commas to separate multiple values. If you exceed the limit, send multiple pushes.</para>
        /// <list type="bullet">
        /// <item><description><para>If \<c>Target\\</c> is \<c>DEVICE\\</c>, provide device IDs, such as \<c>deviceid1,deviceid2\\</c>. You can specify up to 1,000 device IDs.</para>
        /// </description></item>
        /// <item><description><para>If \<c>Target\\</c> is \<c>ACCOUNT\\</c>, provide account IDs, such as \<c>account1,account2\\</c>. You can specify up to 1,000 account IDs.</para>
        /// </description></item>
        /// <item><description><para>If \<c>Target\\</c> is \<c>ALIAS\\</c>, provide aliases, such as \<c>alias1,alias2\\</c>. You can specify up to 1,000 aliases.</para>
        /// </description></item>
        /// <item><description><para>If \<c>Target\\</c> is \<c>TAG\\</c>, you can use single or multiple tags. For more information about the format, see <a href="https://help.aliyun.com/document_detail/434847.html">Tag format</a>.</para>
        /// </description></item>
        /// <item><description><para>If \<c>Target\\</c> is \<c>ALL\\</c>, set the value to <b>ALL</b>. This is a fixed parameter combination for pushing to all devices.</para>
        /// </description></item>
        /// <item><description><para>If \<c>Target\\</c> is \<c>TBD\\</c>, set the value to <b>TBD</b>. This is a fixed parameter combination for continuous pushes.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("TargetValue")]
        [Validation(Required=false)]
        public string TargetValue { get; set; }

        /// <summary>
        /// <para>The title of the notification or message. The maximum length is 200 bytes.</para>
        /// <para>This is required for pushes to Android and HarmonyOS. It is optional for iOS notifications. If you provide a title for an iOS notification:</para>
        /// <list type="bullet">
        /// <item><description><para>For iOS 10 and later, the notification displays the title.</para>
        /// </description></item>
        /// <item><description><para>For iOS 8.2 to iOS 9.x, the title replaces the app name in the notification.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>title</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically truncate titles and content that are too long.</para>
        /// <remarks>
        /// <para>This only applies to vendor channels that have explicit limits on title and content length. It does not apply to channels like APNs, Huawei, and Honor, which only limit the total request body size.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Trim")]
        [Validation(Required=false)]
        public bool? Trim { get; set; }

        /// <summary>
        /// <para>iOS notifications are sent through APNs. Specify the environment.</para>
        /// <list type="bullet">
        /// <item><description><para><b>DEV</b>: The development environment. Use this for apps installed and debugged directly from Xcode.</para>
        /// </description></item>
        /// <item><description><para><b>PRODUCT</b>: The production environment. Use this for apps distributed through the App Store, TestFlight, Ad Hoc, or enterprise distribution.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DEV</para>
        /// </summary>
        [NameInMap("iOSApnsEnv")]
        [Validation(Required=false)]
        public string IOSApnsEnv { get; set; }

        /// <summary>
        /// <para>The badge number on the top-right corner of the app icon on iOS.</para>
        /// <remarks>
        /// <para>If \<c>iOSBadgeAutoIncrement\\</c> is set to \<c>true\\</c>, this parameter must be empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("iOSBadge")]
        [Validation(Required=false)]
        public int? IOSBadge { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the auto-increment feature for the badge number. The default value is \<c>false\\</c>.</para>
        /// <remarks>
        /// <para>When this is \<c>true\\</c>, \<c>iOSBadge\\</c> must be empty.</para>
        /// </remarks>
        /// <para>The auto-increment feature is managed by the push server, which maintains a badge count for each device. This requires SDK version 1.9.5 or later. The user must also actively sync the badge number to the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("iOSBadgeAutoIncrement")]
        [Validation(Required=false)]
        public bool? IOSBadgeAutoIncrement { get; set; }

        /// <summary>
        /// <para>The extended properties of the iOS notification.</para>
        /// <para>For iOS 10 and later, specify the resource URL for a rich push notification, such as \<c>{&quot;attachment&quot;: &quot;https\\://xxxx.xxx/notification_pic.png&quot;}\\</c>. This parameter must be in JSON map format to avoid parsing errors.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;attachment&quot;: &quot;<a href="https://xxxx.xxx/notification_pic.png%22%7D">https://xxxx.xxx/notification_pic.png&quot;}</a></para>
        /// </summary>
        [NameInMap("iOSExtParameters")]
        [Validation(Required=false)]
        public string IOSExtParameters { get; set; }

        /// <summary>
        /// <para>The interruption level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>passive</b>: The system adds the notification to the notification list without lighting up the screen or playing a sound.</para>
        /// </description></item>
        /// <item><description><para><b>active</b>: The system displays the notification immediately, lights up the screen, and can play a sound.</para>
        /// </description></item>
        /// <item><description><para><b>time-sensitive</b>: The system presents the notification immediately, lights up the screen, and can play a sound, but it does not break through system notification controls.</para>
        /// </description></item>
        /// <item><description><para><b>critical</b>: The system displays the notification immediately, lights up the screen, and plays a sound, bypassing the mute switch.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("iOSInterruptionLevel")]
        [Validation(Required=false)]
        public string IOSInterruptionLevel { get; set; }

        /// <summary>
        /// <para>A JSON string containing static pass-through parameters for Dynamic Island pushes. It includes static, custom user information, such as product numbers and order details.</para>
        /// <remarks>
        /// <para>This is required when \<c>iOSLiveActivityEvent\\</c> is \<c>start\\</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;orderId&quot;: &quot;12345&quot;, &quot;product&quot;: &quot;Shoes&quot;}</para>
        /// </summary>
        [NameInMap("iOSLiveActivityAttributes")]
        [Validation(Required=false)]
        public string IOSLiveActivityAttributes { get; set; }

        /// <summary>
        /// <para>The type of Live Activity to start.</para>
        /// <remarks>
        /// <para>This is required when \<c>iOSLiveActivityEvent\\</c> is \<c>start\\</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>OrderActivityAttributes</para>
        /// </summary>
        [NameInMap("iOSLiveActivityAttributesType")]
        [Validation(Required=false)]
        public string IOSLiveActivityAttributesType { get; set; }

        /// <summary>
        /// <para>Dynamic pass-through parameters for Dynamic Island pushes. It includes real-time updates, such as price or inventory changes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;status&quot;: &quot;delivered&quot;, &quot;estimatedArrival&quot;: &quot;2023-12-31T12:00:00Z&quot;}</para>
        /// </summary>
        [NameInMap("iOSLiveActivityContentState")]
        [Validation(Required=false)]
        public string IOSLiveActivityContentState { get; set; }

        /// <summary>
        /// <para>A UNIX timestamp in seconds. The ended Live Activity remains on the lock screen until this specified time. The maximum duration is 4 hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1743131967</para>
        /// </summary>
        [NameInMap("iOSLiveActivityDismissalDate")]
        [Validation(Required=false)]
        public long? IOSLiveActivityDismissalDate { get; set; }

        /// <summary>
        /// <para>Starts, updates, or ends a Live Activity.</para>
        /// <list type="bullet">
        /// <item><description>Enumeration: start | update | end</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>start</para>
        /// </summary>
        [NameInMap("iOSLiveActivityEvent")]
        [Validation(Required=false)]
        public string IOSLiveActivityEvent { get; set; }

        /// <summary>
        /// <para>The Live Activity ID reported by the device to your server. This is the unique identifier for the Live Activity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66B94673-B32E-4CA7-863C-3E523054FD46</para>
        /// </summary>
        [NameInMap("iOSLiveActivityId")]
        [Validation(Required=false)]
        public string IOSLiveActivityId { get; set; }

        /// <summary>
        /// <para>A UNIX timestamp in seconds. Marks the time when the activity\&quot;s content becomes outdated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1743131967</para>
        /// </summary>
        [NameInMap("iOSLiveActivityStaleDate")]
        [Validation(Required=false)]
        public long? IOSLiveActivityStaleDate { get; set; }

        /// <summary>
        /// <para>The sound for an iOS notification. Specify the name of an audio file located in the app bundle or the \<c>Library/Sounds\\</c> directory of the sandbox. For more information, see <a href="https://help.aliyun.com/document_detail/48906.html">How to set notification sounds for iOS pushes</a>.</para>
        /// <para>If you specify an empty string (&quot;&quot;), the notification is silent. If you do not set this parameter, the default system sound is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("iOSMusic")]
        [Validation(Required=false)]
        public string IOSMusic { get; set; }

        /// <summary>
        /// <para>The flag for the iOS notification content extension (iOS 10+). If set to \<c>true\\</c>, an APNs notification can be processed by the extension before it is displayed. This must be set to \<c>true\\</c> for silent notifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("iOSMutableContent")]
        [Validation(Required=false)]
        public bool? IOSMutableContent { get; set; }

        /// <summary>
        /// <para>Specifies the iOS notification category (iOS 10+).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ios</para>
        /// </summary>
        [NameInMap("iOSNotificationCategory")]
        [Validation(Required=false)]
        public string IOSNotificationCategory { get; set; }

        /// <summary>
        /// <para>If a device receives multiple notifications with the same \<c>CollapseId\\</c>, they are merged into a single notification. If the device is offline and receives consecutive notifications with the same \<c>CollapseId\\</c>, only one is shown in the notification bar. This parameter is supported on iOS 10 and later.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZD2011</para>
        /// </summary>
        [NameInMap("iOSNotificationCollapseId")]
        [Validation(Required=false)]
        public string IOSNotificationCollapseId { get; set; }

        /// <summary>
        /// <para>Groups iOS remote notifications using this property. It marks the identifier for the collapsed group.
        /// This is supported only on iOS 12.0 and later.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("iOSNotificationThreadId")]
        [Validation(Required=false)]
        public string IOSNotificationThreadId { get; set; }

        /// <summary>
        /// <para>The score for highlighting the summary. The value must be a floating-point number between 0 and 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.01</para>
        /// </summary>
        [NameInMap("iOSRelevanceScore")]
        [Validation(Required=false)]
        public double? IOSRelevanceScore { get; set; }

        /// <summary>
        /// <para>If a device is offline when a message is pushed (meaning the persistent connection to the Mobile Push server is down), the push is sent once as a notification through Apple\&quot;s APNs channel.</para>
        /// <remarks>
        /// <para>Converting offline messages to notifications is only supported in the production environment.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("iOSRemind")]
        [Validation(Required=false)]
        public bool? IOSRemind { get; set; }

        /// <summary>
        /// <para>The content of the iOS notification used when a message is converted to a notification. This is valid only when \<c>iOSApnsEnv\\</c> is \<c>PRODUCT\\</c> and \<c>iOSRemind\\</c> is \<c>true\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ios通知body</para>
        /// </summary>
        [NameInMap("iOSRemindBody")]
        [Validation(Required=false)]
        public string IOSRemindBody { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable iOS silent notifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("iOSSilentNotification")]
        [Validation(Required=false)]
        public bool? IOSSilentNotification { get; set; }

        /// <summary>
        /// <para>The subtitle of the iOS notification (iOS 10+).</para>
        /// 
        /// <b>Example:</b>
        /// <para>su\&quot;b</para>
        /// </summary>
        [NameInMap("iOSSubtitle")]
        [Validation(Required=false)]
        public string IOSSubtitle { get; set; }

    }

}
