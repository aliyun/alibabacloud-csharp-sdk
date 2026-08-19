// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class MassPushRequest : TeaModel {
        /// <summary>
        /// <para>AppKey information.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23267207</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        /// <summary>
        /// <para>An idempotency parameter used to prevent duplicate pushes caused by API caller retries. When calls are made with the same IdempotentToken within 15 minutes, only one push is performed, and subsequent calls return the result of the first successful push.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The parameter format is a standard 36-character UUID (8-4-4-4-12). Each valid character is a hexadecimal digit in the range 0-9 or a-f, case-insensitive.</description></item>
        /// <item><description>This parameter is only used to prevent duplicate pushes caused by retries and cannot prevent duplicate pushes caused by concurrent calls.</description></item>
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
        /// <para>An array of independent push tasks.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PushTask")]
        [Validation(Required=false)]
        public List<MassPushRequestPushTask> PushTask { get; set; }
        public class MassPushRequestPushTask : TeaModel {
            /// <summary>
            /// <para>Specify the Activity to open from the notification.</para>
            /// <para>Only applicable when PushTask.N.AndroidOpenType=&quot;Activity&quot;, e.g., <c>com.alibaba.cloudpushdemo.bizactivity</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.alibaba.cloudpushdemo.bizactivity</para>
            /// </summary>
            [NameInMap("AndroidActivity")]
            [Validation(Required=false)]
            public string AndroidActivity { get; set; }

            /// <summary>
            /// <para>Set the badge increment value. The value is added to the existing badge count. Value range: [1-99].</para>
            /// <remarks>
            /// <para>Only valid for Huawei/Honor vendor channel pushes. When both AndroidBadgeAddNum and AndroidBadgeSetNum are present, AndroidBadgeSetNum takes precedence.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AndroidBadgeAddNum")]
            [Validation(Required=false)]
            public int? AndroidBadgeAddNum { get; set; }

            /// <summary>
            /// <para>Full class name of the app entry Activity for badge settings.</para>
            /// <remarks>
            /// <para>Only valid for Huawei/Honor vendor channel pushes.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>com.alibaba.cloudpushdemo.bizactivity</para>
            /// </summary>
            [NameInMap("AndroidBadgeClass")]
            [Validation(Required=false)]
            public string AndroidBadgeClass { get; set; }

            /// <summary>
            /// <para>Set the badge to a fixed number. Value range: [0-99].</para>
            /// <remarks>
            /// <para>For vendor channel pushes, this only takes effect on Huawei and Honor channels. For Alibaba Cloud proprietary channel pushes, this only takes effect on Huawei, Honor, and vivo devices.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("AndroidBadgeSetNum")]
            [Validation(Required=false)]
            public int? AndroidBadgeSetNum { get; set; }

            /// <summary>
            /// <para>Body in long text mode. Length limit: 1,000 bytes (1 Chinese character counts as 3 bytes). Subject to specific vendor channel restrictions when sending.</para>
            /// <para>Currently supported:</para>
            /// <list type="bullet">
            /// <item><description>Huawei: EMUI 10 and later</description></item>
            /// <item><description>Honor: Magic UI 4.0 and later</description></item>
            /// <item><description>Xiaomi: MIUI 10 and later</description></item>
            /// <item><description>OPPO: ColorOS 5.0 and later</description></item>
            /// <item><description>Meizu: Flyme</description></item>
            /// <item><description>Proprietary channel: Android SDK 3.6.0 and later</description></item>
            /// </list>
            /// <para>If this parameter is not provided in long text mode, the first non-empty value from Body and AndroidPopupBody is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例长文本</para>
            /// </summary>
            [NameInMap("AndroidBigBody")]
            [Validation(Required=false)]
            public string AndroidBigBody { get; set; }

            /// <summary>
            /// <para>Image URL in big picture mode. Currently supported: Proprietary channel: Android SDK 3.6.0 and later.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://imag.example.com/image.png">https://imag.example.com/image.png</a></para>
            /// </summary>
            [NameInMap("AndroidBigPictureUrl")]
            [Validation(Required=false)]
            public string AndroidBigPictureUrl { get; set; }

            /// <summary>
            /// <para>Title in long text mode. Length limit: 200 bytes (1 Chinese character counts as 3 bytes).</para>
            /// <list type="bullet">
            /// <item><description><para>Currently only supported by the Honor channel and Huawei channel EMUI 11 and later.</para>
            /// </description></item>
            /// <item><description><para>If this parameter is not provided in long text mode, the first non-empty value from Title and AndroidPopupTitle is used.</para>
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
            /// <para>Set notification extended properties. This property does not take effect when the push type PushType is set to MESSAGE.</para>
            /// <para>This parameter must be passed in JSON map format; otherwise, parsing errors will occur.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;key1&quot;:&quot;value1&quot;,&quot;api_name&quot;:&quot;PushNoticeToAndroidRequest&quot;}</para>
            /// </summary>
            [NameInMap("AndroidExtParameters")]
            [Validation(Required=false)]
            public string AndroidExtParameters { get; set; }

            /// <summary>
            /// <para>Set the Honor channel notification type:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Production notification (default).</description></item>
            /// <item><description><b>1</b>: Test notification.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Each application can send up to 1,000 test notifications per day, and this is not subject to the daily per-device push limit.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AndroidHonorTargetUserType")]
            [Validation(Required=false)]
            public int? AndroidHonorTargetUserType { get; set; }

            /// <summary>
            /// <para>Set the Huawei instant notification parameter:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Send a regular Huawei notification (default).</description></item>
            /// <item><description><b>1</b>: Send a Huawei instant notification.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AndroidHuaweiBusinessType")]
            [Validation(Required=false)]
            public int? AndroidHuaweiBusinessType { get; set; }

            /// <summary>
            /// <para>JSON string of the Huawei Android Live Notification data structure <a href="https://developer.huawei.com/consumer/cn/doc/HMSCore-References/rest-live-0000001562939968#ZH-CN_TOPIC_0000001700850537__p195121620102511">LiveNotificationPayload</a>. For development integration, see <a href="https://help.aliyun.com/document_detail/2983768.html">Huawei Live Notification Push Guide</a></para>
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
            /// <para>Huawei channel receipt ID. This receipt ID can be found in the receipt parameter configuration on the Huawei channel push operations platform.</para>
            /// <remarks>
            /// <para>If the default receipt configuration on the Huawei channel push operations platform is set to Alibaba Cloud receipt, this is not required. If not, we recommend configuring the default Huawei channel receipt ID in the Alibaba Cloud EMAS Mobile Push console first.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>RCP4C123456</para>
            /// </summary>
            [NameInMap("AndroidHuaweiReceiptId")]
            [Validation(Required=false)]
            public string AndroidHuaweiReceiptId { get; set; }

            /// <summary>
            /// <para>Set the Huawei channel notification type:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Production notification (default).</description></item>
            /// <item><description><b>1</b>: Test notification.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Each application can send up to 500 test notifications per day, and this is not subject to the daily per-device push limit.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AndroidHuaweiTargetUserType")]
            [Validation(Required=false)]
            public int? AndroidHuaweiTargetUserType { get; set; }

            /// <summary>
            /// <para>Right-side icon URL. Currently supported:</para>
            /// <list type="bullet">
            /// <item><description>Huawei EMUI (only applicable in long text mode and Inbox mode)</description></item>
            /// <item><description>Honor Magic UI (only applicable in long text mode)</description></item>
            /// <item><description>Proprietary channel: Android SDK 3.5.0 and later</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://imag.example.com/image.png">https://imag.example.com/image.png</a></para>
            /// </summary>
            [NameInMap("AndroidImageUrl")]
            [Validation(Required=false)]
            public string AndroidImageUrl { get; set; }

            /// <summary>
            /// <para>Body content in Inbox mode. The content must be a valid JSON Array with no more than 5 elements. Currently supported:</para>
            /// <list type="bullet">
            /// <item><description>Huawei: EMUI 9 and later</description></item>
            /// <item><description>Honor: Magic UI 4.0 and later</description></item>
            /// <item><description>Xiaomi: MIUI 10 and later</description></item>
            /// <item><description>OPPO: ColorOS 5.0 and later</description></item>
            /// <item><description>Proprietary channel: Android SDK 3.6.0 and later</description></item>
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
            /// <item><description>0: Public message (default)</description></item>
            /// <item><description>1: Private message</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>false</c>
            /// </summary>
            [NameInMap("AndroidMeizuNoticeMsgType")]
            [Validation(Required=false)]
            public int? AndroidMeizuNoticeMsgType { get; set; }

            /// <summary>
            /// <para>Purpose 1: After completing the <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/message-classification-0000001149358835?#section3410731125514">self-classification privilege application</a>, this is used to identify the message type, determine the <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/message-classification-0000001149358835#ZH-CN_TOPIC_0000001149358835__p3850133955718">notification alert method</a>, and speed up delivery for specific message types. For valid values, refer to the Huawei Push official documentation\&quot;s <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/message-classification-0000001149358835#section1076611477914">Message Classification Standard</a>. Use the &quot;Cloud notification category value&quot; or &quot;Local notification category value&quot; from the documentation table.</para>
            /// <para>Purpose 2: After <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/faq-0000001050042183#section037425218509">applying for special permissions</a>, this is used to identify high-priority pass-through scenarios. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>VOIP: Audio/video calls</description></item>
            /// <item><description>PLAY_VOICE: Voice playback</description></item>
            /// </list>
            /// <remarks>
            /// <para>For &quot;Cloud notification category values&quot; marked as &quot;Not applicable&quot;, the Alibaba Cloud proprietary channel is used. For &quot;Local notification category values&quot; marked as &quot;Not applicable&quot;, the Huawei channel is used.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SUBSCRIPTION</para>
            /// </summary>
            [NameInMap("AndroidMessageHuaweiCategory")]
            [Validation(Required=false)]
            public string AndroidMessageHuaweiCategory { get; set; }

            /// <summary>
            /// <para>Huawei channel notification delivery priority. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>HIGH</para>
            /// </description></item>
            /// <item><description><para>NORMAL</para>
            /// </description></item>
            /// </list>
            /// <para>Permission application is required. See: <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/faq-0000001050042183#section037425218509">Application link</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HIGH</para>
            /// </summary>
            [NameInMap("AndroidMessageHuaweiUrgency")]
            [Validation(Required=false)]
            public string AndroidMessageHuaweiUrgency { get; set; }

            /// <summary>
            /// <para>OPPO classifies messages into two categories: Communication &amp; Service, and Content &amp; Marketing.</para>
            /// <para>Communication &amp; Service (permission application required):</para>
            /// <list type="bullet">
            /// <item><description>IM: Instant messaging, audio, and video calls</description></item>
            /// <item><description>ACCOUNT: Personal account and asset changes</description></item>
            /// <item><description>DEVICE_REMINDER: Personal device reminders</description></item>
            /// <item><description>ORDER: Personal order/logistics status changes</description></item>
            /// <item><description>TODO: Personal schedule/to-do items</description></item>
            /// <item><description>SUBSCRIPTION: Personal subscriptions</description></item>
            /// </list>
            /// <para>Content &amp; Marketing:</para>
            /// <list type="bullet">
            /// <item><description>NEWS: News and information</description></item>
            /// <item><description>CONTENT: Content recommendations</description></item>
            /// <item><description>MARKETING: Platform promotions</description></item>
            /// <item><description>SOCIAL: Social updates</description></item>
            /// </list>
            /// <para>For details, see <a href="https://open.oppomobile.com/new/developmentDoc/info?id=13189">OPUSH Message Classification Rules</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>MARKETING</para>
            /// </summary>
            [NameInMap("AndroidMessageOppoCategory")]
            [Validation(Required=false)]
            public string AndroidMessageOppoCategory { get; set; }

            /// <summary>
            /// <para>OPPO channel notification bar message alert level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Notification bar</description></item>
            /// <item><description>2: Notification bar, lock screen, ringtone, and vibration (default notification level for Communication &amp; Service messages)</description></item>
            /// <item><description>16: Notification bar, lock screen, ringtone, vibration, and banner (permission application required)</description></item>
            /// </list>
            /// <remarks>
            /// <para>When using the AndroidMessageOppoNotifyLevel parameter, the AndroidMessageOppoCategory parameter must also be provided.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AndroidMessageOppoNotifyLevel")]
            [Validation(Required=false)]
            public int? AndroidMessageOppoNotifyLevel { get; set; }

            /// <summary>
            /// <para>vivo classifies messages into two categories: System messages and Operational messages.</para>
            /// <para>System messages:</para>
            /// <list type="bullet">
            /// <item><description>IM: Instant messages</description></item>
            /// <item><description>ACCOUNT: Account and assets</description></item>
            /// <item><description>TODO: Schedule and to-do items</description></item>
            /// <item><description>DEVICE_REMINDER: Device information</description></item>
            /// <item><description>ORDER: Orders and logistics</description></item>
            /// <item><description>SUBSCRIPTION: Subscription reminders</description></item>
            /// </list>
            /// <para>Operational messages:</para>
            /// <list type="bullet">
            /// <item><description>NEWS: News</description></item>
            /// <item><description>CONTENT: Content recommendations</description></item>
            /// <item><description>MARKETING: Operational campaigns</description></item>
            /// <item><description>SOCIAL: Social updates<remarks>
            /// <para>For details, see <a href="https://dev.vivo.com.cn/documentCenter/doc/359#s-ef3qugc3">Classification Description</a></para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TODO</para>
            /// </summary>
            [NameInMap("AndroidMessageVivoCategory")]
            [Validation(Required=false)]
            public string AndroidMessageVivoCategory { get; set; }

            /// <summary>
            /// <para>Huawei vendor channel notification sound. Specify the name of an audio file stored in the client project\&quot;s app/src/main/res/raw/ directory. The file extension is not required.</para>
            /// <para>If not set, the default ringtone is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alicloud_notification_sound</para>
            /// </summary>
            [NameInMap("AndroidMusic")]
            [Validation(Required=false)]
            public string AndroidMusic { get; set; }

            /// <summary>
            /// <para>Priority of the notification position in the Android notification bar. Valid values: -2, -1, 0, 1, 2.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AndroidNotificationBarPriority")]
            [Validation(Required=false)]
            public int? AndroidNotificationBarPriority { get; set; }

            /// <summary>
            /// <para>Android custom notification bar style. Value range: 1-100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AndroidNotificationBarType")]
            [Validation(Required=false)]
            public int? AndroidNotificationBarType { get; set; }

            /// <summary>
            /// <para>The channelId of the Android app. Must match the channelId configured in the app.</para>
            /// <list type="bullet">
            /// <item><description>Set the NotificationChannel parameter. For specific usage, see <a href="https://help.aliyun.com/document_detail/67398.html">FAQ: Notifications not received on Android 8.0+ devices</a>.</description></item>
            /// <item><description>Since the OPPO notification private channel\&quot;s channel_id is the same as the app\&quot;s channelId, the channel_id takes this value when pushing through the OPPO channel.</description></item>
            /// <item><description>For Huawei, FCM, and Alibaba Cloud proprietary channel pushes, the channel_id takes this value.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AndroidNotificationChannel")]
            [Validation(Required=false)]
            public string AndroidNotificationChannel { get; set; }

            /// <summary>
            /// <para>Message grouping. Messages in the same group display only the latest one and the total count of messages received in that group in the notification bar. All messages are not displayed and cannot be expanded. Currently supported:</para>
            /// <list type="bullet">
            /// <item><description>Huawei vendor channel</description></item>
            /// <item><description>Honor vendor channel</description></item>
            /// <item><description>Proprietary channel: Android SDK 3.9.1 and earlier</description></item>
            /// </list>
            /// <remarks>
            /// <para>The proprietary channel no longer supports this parameter on Android SDK 3.9.2 and later.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>group-1</para>
            /// </summary>
            [NameInMap("AndroidNotificationGroup")]
            [Validation(Required=false)]
            public string AndroidNotificationGroup { get; set; }

            /// <summary>
            /// <para>Set the Honor notification message classification importance parameter, which determines the notification behavior on user devices. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>LOW: Information and marketing messages</para>
            /// </description></item>
            /// <item><description><para>NORMAL: Service and communication messages</para>
            /// </description></item>
            /// </list>
            /// <para>Application is required on the Honor platform. <a href="https://developer.honor.com/cn/docs/11002/guides/notification-class#%E8%87%AA%E5%88%86%E7%B1%BB%E6%9D%83%E7%9B%8A%E7%94%B3%E8%AF%B7">Application link</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LOW</para>
            /// </summary>
            [NameInMap("AndroidNotificationHonorChannel")]
            [Validation(Required=false)]
            public string AndroidNotificationHonorChannel { get; set; }

            /// <summary>
            /// <para>Set the Huawei notification message classification importance parameter, which determines the notification behavior on user devices. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>LOW: Information and marketing messages</description></item>
            /// <item><description>NORMAL: Service and communication messages</description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>The Huawei channel now recommends using AndroidMessageHuaweiCategory for notification classification. AndroidNotificationHuaweiChannel is no longer required.</description></item>
            /// <item><description>Application is required on the Huawei platform. <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/message-classification-0000001149358835#section893184112272">Application link</a>.</description></item>
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
            /// <para>Unique identifier for each message displayed in the notification bar. Different notification bar messages can share the same NotifyId, allowing new notifications to replace old ones.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100001</para>
            /// </summary>
            [NameInMap("AndroidNotificationNotifyId")]
            [Validation(Required=false)]
            public int? AndroidNotificationNotifyId { get; set; }

            /// <summary>
            /// <para>Message grouping. Messages in the same group are displayed collapsed in the notification bar and can be expanded. Notifications from different groups are displayed separately. Currently supported:</para>
            /// <list type="bullet">
            /// <item><description>Proprietary channel: Android SDK 3.9.2 and later</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>thread-1</para>
            /// </summary>
            [NameInMap("AndroidNotificationThreadId")]
            [Validation(Required=false)]
            public string AndroidNotificationThreadId { get; set; }

            /// <summary>
            /// <para>Set the vivo notification message classification. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Operational messages (default)</description></item>
            /// <item><description>1: System messages</description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>The vivo channel now recommends using AndroidMessageVivoCategory for notification classification. AndroidNotificationVivoChannel is no longer required.</description></item>
            /// <item><description>Application is required on the vivo platform. See: <a href="https://dev.vivo.com.cn/documentCenter/doc/359">Application link</a>.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AndroidNotificationVivoChannel")]
            [Validation(Required=false)]
            public string AndroidNotificationVivoChannel { get; set; }

            /// <summary>
            /// <para>Set the channelId for Xiaomi notification types. Application is required on the Xiaomi platform. See: <a href="https://dev.mi.com/console/doc/detail?pId=2422#_4">Application link</a>.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>A single application on the Xiaomi channel can apply for up to 8 channels. Please plan ahead.</description></item>
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
            /// <para>Notification alert type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>VIBRATE</b>: Vibration (default)</description></item>
            /// <item><description><b>SOUND</b>: Sound</description></item>
            /// <item><description><b>BOTH</b>: Sound and vibration</description></item>
            /// <item><description><b>NONE</b>: Silent</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VIBRATE</para>
            /// </summary>
            [NameInMap("AndroidNotifyType")]
            [Validation(Required=false)]
            public string AndroidNotifyType { get; set; }

            /// <summary>
            /// <para>Action after clicking the notification. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>APPLICATION: Open the app (default)</description></item>
            /// <item><description>ACTIVITY: Open an Android Activity</description></item>
            /// <item><description>URL: Open a URL</description></item>
            /// <item><description>NONE: No navigation</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>APPLICATION</para>
            /// </summary>
            [NameInMap("AndroidOpenType")]
            [Validation(Required=false)]
            public string AndroidOpenType { get; set; }

            /// <summary>
            /// <para>The URL to open after Android receives the push. Only applicable when PushTask.N.AndroidOpenType=&quot;URL&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxxx.xxx">https://xxxx.xxx</a></para>
            /// </summary>
            [NameInMap("AndroidOpenUrl")]
            [Validation(Required=false)]
            public string AndroidOpenUrl { get; set; }

            /// <summary>
            /// <para>JSON string of the OPPO Fluid Cloud intent deletion data structure <a href="https://open.oppomobile.com/documentation/page/info?id=13578">data</a>. This parameter is ignored when the AndroidOppoIntelligentIntent parameter is already provided. For development integration, see <a href="https://help.aliyun.com/document_detail/2997310.html">OPPO Fluid Cloud Push Guide</a></para>
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
            /// <para>JSON string of the OPPO Fluid Cloud intent sharing data structure <a href="https://open.oppomobile.com/documentation/page/info?id=13565">IntelligentIntent</a>. For development integration, see <a href="https://help.aliyun.com/document_detail/2997310.html">OPPO Fluid Cloud Push Guide</a></para>
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
            /// <para>Set the OPPO Fluid Cloud push environment:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Production environment (default).</description></item>
            /// <item><description><b>1</b>: Test environment.</description></item>
            /// </list>
            /// <remarks>
            /// <para>The OPPO Fluid Cloud test environment requires client-side setup. See <a href="https://open.oppomobile.com/documentation/page/info?id=13590">Environment Setup</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AndroidOppoIntentEnv")]
            [Validation(Required=false)]
            public int? AndroidOppoIntentEnv { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>OPPO private message template content parameters</para>
            /// </summary>
            [NameInMap("AndroidOppoPrivateContentParameters")]
            [Validation(Required=false)]
            [Obsolete]
            public Dictionary<string, string> AndroidOppoPrivateContentParameters { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>OPPO private message template ID</para>
            /// <remarks>
            /// <para>Warning: The OPPO private message template feature is no longer supported by MaasPush. To use this feature, please use the Push, PushV2, or MassPushV2 API instead.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>687557242b1634hzef3zd5013</para>
            /// </summary>
            [NameInMap("AndroidOppoPrivateMsgTemplateId")]
            [Validation(Required=false)]
            [Obsolete]
            public string AndroidOppoPrivateMsgTemplateId { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>OPPO private message template title parameters</para>
            /// </summary>
            [NameInMap("AndroidOppoPrivateTitleParameters")]
            [Validation(Required=false)]
            [Obsolete]
            public Dictionary<string, string> AndroidOppoPrivateTitleParameters { get; set; }

            /// <summary>
            /// <para>Specify the Activity to navigate to when the notification is clicked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.alibaba.cloudpushdemo.bizactivity</para>
            /// </summary>
            [NameInMap("AndroidPopupActivity")]
            [Validation(Required=false)]
            public string AndroidPopupActivity { get; set; }

            /// <summary>
            /// <para>Body content in auxiliary popup mode. Required when the AndroidPopupActivity parameter is not empty.</para>
            /// <para>Length limit: 200 characters (both Chinese and English characters count as one character each).</para>
            /// <para>When using vendor channels, you must also comply with the vendor channel restrictions. For details, see <a href="https://help.aliyun.com/document_detail/165253.html">Android Auxiliary Channel Push Limits</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hello</para>
            /// </summary>
            [NameInMap("AndroidPopupBody")]
            [Validation(Required=false)]
            public string AndroidPopupBody { get; set; }

            /// <summary>
            /// <para>Title content in auxiliary popup mode. Required when the AndroidPopupActivity parameter is not empty.</para>
            /// <para>Length limit: 50 characters (both Chinese and English characters count as one character each).</para>
            /// <para>When using vendor channels, you must also comply with the vendor channel restrictions. For details, see <a href="https://help.aliyun.com/document_detail/165253.html">Android Auxiliary Channel Push Limits</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hello</para>
            /// </summary>
            [NameInMap("AndroidPopupTitle")]
            [Validation(Required=false)]
            public string AndroidPopupTitle { get; set; }

            /// <summary>
            /// <para>When the push type is message and the device is offline, this push will use the auxiliary popup feature. Defaults to false. Only takes effect when PushType=MESSAGE.</para>
            /// <para>If the message-to-notification conversion push is successful, the notification displays the data set by the server\&quot;s AndroidPopupTitle and AndroidPopupBody parameter values. The data obtained when clicking the notification in the auxiliary popup\&quot;s onSysNoticeOpened method is the server-set Title and Body parameter values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AndroidRemind")]
            [Validation(Required=false)]
            public bool? AndroidRemind { get; set; }

            /// <summary>
            /// <para>Notification style. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Standard mode (default)</description></item>
            /// <item><description><b>1</b>: Long text mode (supported by Huawei, Honor, Xiaomi, OPPO, Meizu, and proprietary channels)</description></item>
            /// <item><description><b>2</b>: Big picture mode (supported by proprietary channel, not supported on Xiaomi devices)</description></item>
            /// <item><description><b>3</b>: List mode (supported by Huawei, Honor, Xiaomi, OPPO, and proprietary channels)<remarks>
            /// <para>This parameter is required when using non-standard modes.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AndroidRenderStyle")]
            [Validation(Required=false)]
            public string AndroidRenderStyle { get; set; }

            /// <summary>
            /// <para>Set the vendor channel notification type:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Production notification (default).</description></item>
            /// <item><description><b>1</b>: Test notification.</description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Configuring this parameter is equivalent to simultaneously configuring the AndroidHuaweiTargetUserType, AndroidHonorTargetUserType, AndroidVivoPushMode, and AndroidOppoIntentEnv parameters. The corresponding parameter for a specific vendor channel can override this parameter.</description></item>
            /// <item><description>Currently supported: Huawei channel, Honor channel, vivo channel, and OPPO Fluid Cloud.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AndroidTargetUserType")]
            [Validation(Required=false)]
            public int? AndroidTargetUserType { get; set; }

            /// <summary>
            /// <para>JSON string of the vivo Atomic Island data structure <a href="https://dev.vivo.com.cn/documentCenter/doc/896#s-fdagzbd4">liveMessage</a>. For development integration, see <a href="https://help.aliyun.com/zh/document_detail/3030718.html">vivo Atomic Island Push Guide</a></para>
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
            /// <para>Set the vivo channel notification type:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Production push (default).</description></item>
            /// <item><description><b>1</b>: Test push.</description></item>
            /// </list>
            /// <remarks>
            /// <para>For test pushes, configure test devices in the vivo console in advance. The test device RegId can be obtained by searching for &quot;onReceiveRegId regId&quot; in the device startup logs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AndroidVivoPushMode")]
            [Validation(Required=false)]
            public int? AndroidVivoPushMode { get; set; }

            /// <summary>
            /// <para>vivo channel receipt ID. This receipt ID can be found in the app information section of the push service on the vivo open platform.</para>
            /// <remarks>
            /// <para>If the default receipt configuration on the vivo open platform is set to Alibaba Cloud receipt, this is not required. If not, we recommend configuring the default vivo channel receipt ID in the Alibaba Cloud EMAS Mobile Push console first.</para>
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
            /// <para>This parameter has been deprecated. All third-party auxiliary popups are now supported by the new parameter <b>AndroidPopupActivity</b>.</para>
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
            /// <para>This parameter has been deprecated. All third-party auxiliary popups are now supported by the new parameter <b>AndroidPopupBody</b>.</para>
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
            /// <para>This parameter has been deprecated. All third-party auxiliary popups are now supported by the new parameter <b>AndroidPopupTitle</b>.</para>
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
            /// <para>This parameter has been deprecated. Since August 2023, Xiaomi has officially discontinued support for dynamically setting small icons, right-side icons, and big pictures during push on new devices/systems.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://f6.market.xiaomi.com/download/MiPass/aaa/bbb.png">https://f6.market.xiaomi.com/download/MiPass/aaa/bbb.png</a></para>
            /// </summary>
            [NameInMap("AndroidXiaomiBigPictureUrl")]
            [Validation(Required=false)]
            [Obsolete]
            public string AndroidXiaomiBigPictureUrl { get; set; }

            /// <summary>
            /// <para>JSON string of the Xiaomi Super Island data structure <a href="https://dev.mi.com/xiaomihyperos/documentation/detail?pId=2131">miui.focus.param</a>. For development integration, see <a href="https://help.aliyun.com/zh/document_detail/3037956.html">Xiaomi Super Island Push Guide</a></para>
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
            /// <para>JSON string of the Xiaomi Super Island images <a href="https://dev.mi.com/xiaomihyperos/documentation/detail?pId=2131">miui.focus.pic_xxx</a>. For development integration, see <a href="https://help.aliyun.com/zh/document_detail/3037956.html">Xiaomi Super Island Push Guide</a></para>
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
            /// <para>This parameter has been deprecated. Since August 2023, Xiaomi has officially discontinued support for dynamically setting small icons, right-side icons, and big pictures during push on new devices/systems.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://imag.example.com/image.png">https://imag.example.com/image.png</a></para>
            /// </summary>
            [NameInMap("AndroidXiaomiImageUrl")]
            [Validation(Required=false)]
            [Obsolete]
            public string AndroidXiaomiImageUrl { get; set; }

            /// <summary>
            /// <para>Xiaomi private message template ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>P10645</para>
            /// </summary>
            [NameInMap("AndroidXiaomiTemplateId")]
            [Validation(Required=false)]
            public string AndroidXiaomiTemplateId { get; set; }

            /// <summary>
            /// <para>Xiaomi private message template parameters, JSON string</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;keywords1&quot;:&quot;Tom&quot;,&quot;keywords2&quot;:&quot;phone&quot;}</para>
            /// </summary>
            [NameInMap("AndroidXiaomiTemplateParams")]
            [Validation(Required=false)]
            public string AndroidXiaomiTemplateParams { get; set; }

            /// <summary>
            /// <para>Content of the notification/message for Android and HarmonyOS pushes; iOS message/notification content. The push content size is limited. See <a href="https://help.aliyun.com/document_detail/92832.html">Product Limits</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hello</para>
            /// </summary>
            [NameInMap("Body")]
            [Validation(Required=false)]
            public string Body { get; set; }

            /// <summary>
            /// <para>Device type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>HARMONY: HarmonyOS device</description></item>
            /// <item><description>iOS: iOS device</description></item>
            /// <item><description>ANDROID: Android device</description></item>
            /// <item><description>ALL: When the AppKey is for a legacy dual-platform app, this pushes to both Android and iOS devices simultaneously. When the AppKey is for a new single-platform app, the effect is the same as specifying the device type corresponding to the app type.</description></item>
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
            /// <para>Expiration time of offline messages/notifications. Used together with StoreOffline. Expired messages will no longer be sent. The maximum retention period is 72 hours. The default is 72 hours.</para>
            /// <para>The time format follows the ISO 8601 standard and must use UTC time in the format YYYY-MM-DDThh:mm:ssZ. The expiration time cannot be earlier than the current time or the scheduled push time plus 3 seconds (<c>ExpireTime &gt; PushTime + 3 seconds</c>). The 3-second buffer accounts for network and system latency. We recommend at least 1 minute for unicast pushes and at least 10 minutes for broadcast and batch pushes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-02-20T00:00:00Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The action corresponding to the built-in page ability of the app.</para>
            /// <remarks>
            /// <para>Notice: When HarmonyActionType is APP_CUSTOM_PAGE, at least one of HarmonyUri and HarmonyAction must be provided.</para>
            /// </remarks>
            /// <para>For details, see HarmonyOS official documentation <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section152462191216">ClickAction.action</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>com.example.action</para>
            /// </summary>
            [NameInMap("HarmonyAction")]
            [Validation(Required=false)]
            public string HarmonyAction { get; set; }

            /// <summary>
            /// <para>Action after clicking the notification. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>APP_HOME_PAGE: Open the app home page</description></item>
            /// <item><description>APP_CUSTOM_PAGE: Open a custom app page</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>APP_HOME_PAGE</para>
            /// </summary>
            [NameInMap("HarmonyActionType")]
            [Validation(Required=false)]
            public string HarmonyActionType { get; set; }

            /// <summary>
            /// <para>HarmonyOS app badge increment number. See <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section266310382145">HarmonyOS badge addNum field description</a>.</br>
            /// Supported from HarmonyOS SDK 1.2.0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HarmonyBadgeAddNum")]
            [Validation(Required=false)]
            public int? HarmonyBadgeAddNum { get; set; }

            /// <summary>
            /// <para>HarmonyOS app badge set number. See <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section266310382145">HarmonyOS badge setNum field description</a>.</br>
            /// Supported from HarmonyOS SDK 1.2.0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HarmonyBadgeSetNum")]
            [Validation(Required=false)]
            public int? HarmonyBadgeSetNum { get; set; }

            /// <summary>
            /// <para>Notification message category. After completing the notification message self-classification privilege application, this is used to identify the message type. Different notification message types affect the display and alert methods. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>IM: Instant messaging</description></item>
            /// <item><description>VOIP: Audio/video calls</description></item>
            /// <item><description>SUBSCRIPTION: Subscriptions</description></item>
            /// <item><description>TRAVEL: Travel</description></item>
            /// <item><description>HEALTH: Health</description></item>
            /// <item><description>WORK: Work task reminders</description></item>
            /// <item><description>ACCOUNT: Account updates</description></item>
            /// <item><description>EXPRESS: Orders &amp; logistics</description></item>
            /// <item><description>FINANCE: Finance</description></item>
            /// <item><description>DEVICE_REMINDER: Device reminders</description></item>
            /// <item><description>MAIL: Email</description></item>
            /// <item><description>CUSTOMER_SERVICE: Customer service messages</description></item>
            /// <item><description>MARKETING: News, content recommendations, social updates, product promotions, financial updates, lifestyle information, surveys, feature recommendations, and operational campaigns (only marks the content, does not speed up message delivery), collectively referred to as information and marketing messages</description></item>
            /// </list>
            /// <para>For details, see HarmonyOS official documentation <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section17371529101117">Notification.category</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>IM</para>
            /// </summary>
            [NameInMap("HarmonyCategory")]
            [Validation(Required=false)]
            public string HarmonyCategory { get; set; }

            /// <summary>
            /// <para>Set notification extended properties. This property does not take effect when the push type PushType is set to MESSAGE.</para>
            /// <para>This parameter must be passed in JSON map format; otherwise, parsing errors will occur.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;key1&quot;:&quot;value1&quot;,&quot;api_name&quot;:&quot;PushNoticeToAndroidRequest&quot;}</para>
            /// </summary>
            [NameInMap("HarmonyExtParameters")]
            [Validation(Required=false)]
            public string HarmonyExtParameters { get; set; }

            /// <summary>
            /// <para>Extra data for notification extension messages.</br>
            /// Valid when sending HarmonyOS notification extension messages.</br>
            /// Conceptually equivalent to the extraData field of HarmonyOS notification extension messages. For the specific definition, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section161192514234">HarmonyOS ExtensionPayload Description</a>.</br>
            /// Supported from HarmonyOS SDK 1.2.0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例额外数据</para>
            /// </summary>
            [NameInMap("HarmonyExtensionExtraData")]
            [Validation(Required=false)]
            public string HarmonyExtensionExtraData { get; set; }

            /// <summary>
            /// <para>When PushType is NOTICE, whether this is a HarmonyOS notification extension message.</para>
            /// <list type="bullet">
            /// <item><description>true: Send a notification extension message</description></item>
            /// <item><description>false: Send a regular notification (default)</description></item>
            /// </list>
            /// <para>Notification extension messages require permission to be applied for on the HarmonyOS side before sending. For details, see the HarmonyOS documentation <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-guides-V5/push-send-extend-noti-V5">Send Notification Extension Messages</a>.</br>
            /// Supported from HarmonyOS SDK 1.2.0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HarmonyExtensionPush")]
            [Validation(Required=false)]
            public bool? HarmonyExtensionPush { get; set; }

            /// <summary>
            /// <para>URL for the large icon on the right side of the notification. The URL must use the HTTPS protocol.</para>
            /// <remarks>
            /// <para>Supported image formats: png, jpg, jpeg, heif, gif, bmp. Image dimensions must satisfy height × width &lt; 25,000 pixels.</para>
            /// </remarks>
            /// <para>For details, see HarmonyOS official documentation <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section17371529101117">Notification.image</a></para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/xxx.png">https://example.com/xxx.png</a></para>
            /// </summary>
            [NameInMap("HarmonyImageUrl")]
            [Validation(Required=false)]
            public string HarmonyImageUrl { get; set; }

            /// <summary>
            /// <para>Content for multi-line text style. Required when HarmonyRenderStyle is MULTI_LINE. Up to 3 content items are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;1.content1&quot;,&quot;2.content2&quot;,&quot;3.content3&quot;]</para>
            /// </summary>
            [NameInMap("HarmonyInboxContent")]
            [Validation(Required=false)]
            public string HarmonyInboxContent { get; set; }

            /// <summary>
            /// <para>JSON string of the HarmonyOS Live View data structure <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V13/push-scenariozed-api-request-param-V13#section66881469306">LiveViewPayload</a>. For development integration, see <a href="https://help.aliyun.com/document_detail/2982112.html">HarmonyOS Live View Push Guide</a></para>
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
            /// <para>Use the specified type of notification slot. Only valid when the Alibaba Cloud proprietary channel is online.</para>
            /// <list type="bullet">
            /// <item><description>SOCIAL_COMMUNICATION: Social communication.</description></item>
            /// <item><description>SERVICE_INFORMATION: Service reminders.</description></item>
            /// <item><description>CONTENT_INFORMATION: Content information.</description></item>
            /// <item><description>CUSTOMER_SERVICE: Customer service messages. This type is used for customer service messages between users and merchants, and must be initiated by the user.</description></item>
            /// <item><description>OTHER_TYPES: Others.</description></item>
            /// </list>
            /// <para>For details, see HarmonyOS official documentation <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/js-apis-notificationmanager-V5#slottype">SlotType</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>SOCIAL_COMMUNICATION</para>
            /// </summary>
            [NameInMap("HarmonyNotificationSlotType")]
            [Validation(Required=false)]
            public string HarmonyNotificationSlotType { get; set; }

            /// <summary>
            /// <para>Unique identifier for each message displayed in the notification. When not provided, the push service automatically generates a unique identifier for each message. Different notification messages can share the same notifyId, enabling new messages to replace old ones.</para>
            /// <para>For details, see HarmonyOS official documentation <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section17371529101117">Notification.notifyId</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("HarmonyNotifyId")]
            [Validation(Required=false)]
            public int? HarmonyNotifyId { get; set; }

            /// <summary>
            /// <para>HarmonyOS channel receipt ID. This receipt ID can be found in the receipt parameter configuration on the HarmonyOS channel push operations platform.</para>
            /// <remarks>
            /// <para>If the default receipt configuration on the HarmonyOS channel push operations platform is set to Alibaba Cloud receipt, this is not required. If not, we recommend configuring the default HarmonyOS channel receipt ID in the Alibaba Cloud EMAS Mobile Push console first.</para>
            /// </remarks>
            /// <para>For details, see HarmonyOS official documentation <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section418321011212">pushOptions.receiptId</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>RCPB***DFD5</para>
            /// </summary>
            [NameInMap("HarmonyReceiptId")]
            [Validation(Required=false)]
            public string HarmonyReceiptId { get; set; }

            /// <summary>
            /// <para>When the push type is message and the device is offline, this push will use the auxiliary popup feature. Defaults to false. Only takes effect when PushType=MESSAGE.</para>
            /// <para>If the message-to-notification conversion push is successful, the notification displays the data set by the server\&quot;s HarmonyRemindTitle and HarmonyRemindBody parameter values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HarmonyRemind")]
            [Validation(Required=false)]
            public bool? HarmonyRemind { get; set; }

            /// <summary>
            /// <para>HarmonyOS notification content used when converting HarmonyOS messages to notifications. Only valid when HarmonyRemind is true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>您有一条新消息，请查收</para>
            /// </summary>
            [NameInMap("HarmonyRemindBody")]
            [Validation(Required=false)]
            public string HarmonyRemindBody { get; set; }

            /// <summary>
            /// <para>HarmonyOS notification title used when converting HarmonyOS messages to notifications. Only valid when HarmonyRemind is true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>新消息</para>
            /// </summary>
            [NameInMap("HarmonyRemindTitle")]
            [Validation(Required=false)]
            public string HarmonyRemindTitle { get; set; }

            /// <summary>
            /// <para>Notification message style:</para>
            /// <list type="bullet">
            /// <item><description>NORMAL: Standard notification (default)</description></item>
            /// <item><description>MULTI_LINE: Multi-line text style</description></item>
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
            /// <item><description>false: Normal message (default)</description></item>
            /// <item><description>true: Test message</description></item>
            /// </list>
            /// <para>For details, see HarmonyOS official documentation <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section418321011212">pushOptions.testMessage</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HarmonyTestMessage")]
            [Validation(Required=false)]
            public bool? HarmonyTestMessage { get; set; }

            /// <summary>
            /// <para>The URI corresponding to the built-in page ability of the app.</para>
            /// <remarks>
            /// <para>Notice: When HarmonyActionType is APP_CUSTOM_PAGE, at least one of HarmonyUri and HarmonyAction must be provided. When multiple Abilities exist, provide different action and URI values for each Ability. The action is prioritized when looking up the corresponding built-in app page.</para>
            /// </remarks>
            /// <para>For details, see HarmonyOS official documentation <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section152462191216">ClickAction.uri</a></para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.example.com:8080/push/example">https://www.example.com:8080/push/example</a></para>
            /// </summary>
            [NameInMap("HarmonyUri")]
            [Validation(Required=false)]
            public string HarmonyUri { get; set; }

            /// <summary>
            /// <para>Custom identifier for the push task. When JobKey is not empty, this field will be included in the receipt logs. For receipt log details, see <a href="https://help.aliyun.com/document_detail/434651.html">Receipt Logs</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("JobKey")]
            [Validation(Required=false)]
            public string JobKey { get; set; }

            /// <summary>
            /// <para>Used for scheduled sending. If not set, the default is immediate sending.</para>
            /// <para>The time format follows the ISO 8601 standard and must use UTC time in the format YYYY-MM-DDThh:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-02-20T00:00:00Z</para>
            /// </summary>
            [NameInMap("PushTime")]
            [Validation(Required=false)]
            public string PushTime { get; set; }

            /// <summary>
            /// <para>Push type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MESSAGE: indicates a message.</description></item>
            /// <item><description>NOTICE: indicates a notification.</description></item>
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
            /// <para>Specify sending channels. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>accs: Alibaba Cloud proprietary channel</description></item>
            /// <item><description>huawei: Huawei channel</description></item>
            /// <item><description>honor: Honor channel</description></item>
            /// <item><description>xiaomi: Xiaomi channel</description></item>
            /// <item><description>oppo: OPPO channel</description></item>
            /// <item><description>vivo: vivo channel</description></item>
            /// <item><description>meizu: Meizu channel</description></item>
            /// <item><description>gcm: Google GCM channel (legacy HTTP)</description></item>
            /// <item><description>fcm: Google Firebase channel (HTTP v1 API)</description></item>
            /// <item><description>apns: APNs channel</description></item>
            /// <item><description>harmony: HarmonyOS channel</description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>If this parameter is not configured, all channels are available.</description></item>
            /// <item><description>If this parameter is configured, only the specified channels are used.</description></item>
            /// <item><description>If the configured channels conflict with the sending strategy (e.g., iOS notifications only go through the APNs channel, but this parameter does not include apns), the push will not be sent.</description></item>
            /// <item><description>If gcm is configured, both Google GCM and FCM channels can be used. If fcm is configured, only the Google FCM channel can be used.</description></item>
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
            /// <para>This parameter has been deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SendSpeed")]
            [Validation(Required=false)]
            [Obsolete]
            public int? SendSpeed { get; set; }

            /// <summary>
            /// <para>Whether to store offline messages/notifications. StoreOffline defaults to false.</para>
            /// <para>If stored, when the user is offline during push, the message will be resent when the user comes online within the expiration time (ExpireTime). ExpireTime defaults to 72 hours. iOS notifications are delivered through the APNs channel and are not affected by StoreOffline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("StoreOffline")]
            [Validation(Required=false)]
            public bool? StoreOffline { get; set; }

            /// <summary>
            /// <para>Push target. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DEVICE: push by device.</description></item>
            /// <item><description>ACCOUNT: push by account.</description></item>
            /// <item><description>ALIAS: push by alias.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEVICE</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// <para>Set based on Target. Multiple values are separated by commas. If the limit is exceeded, you need to split the push into multiple calls.</para>
            /// <list type="bullet">
            /// <item><description>Target=DEVICE: values such as <c>deviceid1,deviceid2</c> (up to 1,000 supported).</description></item>
            /// <item><description>Target=ACCOUNT: values such as <c>account1,account2</c> (up to 1,000 supported).</description></item>
            /// <item><description>Target=ALIAS: values such as <c>alias1,alias2</c> (up to 1,000 supported).</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deviceid1,deviceid2</para>
            /// </summary>
            [NameInMap("TargetValue")]
            [Validation(Required=false)]
            public string TargetValue { get; set; }

            /// <summary>
            /// <para>Title of the notification/message during push. Length limit: 200 bytes.
            /// Required for Android and HarmonyOS pushes. Optional for iOS push notifications. If provided:</para>
            /// <list type="bullet">
            /// <item><description>iOS 10+: the notification displays the title.</description></item>
            /// <item><description>iOS 8.2 &lt;= iOS version &lt; iOS 10: replaces the notification app name.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>title</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>Whether to automatically truncate titles and content that are too long.
            /// Note: This only applies to vendor channels that explicitly limit title and content length. It does not apply to channels like APNs, Huawei, and Honor that do not limit title and content individually but only limit the total request body size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Trim")]
            [Validation(Required=false)]
            public bool? Trim { get; set; }

            /// <summary>
            /// <para>iOS notifications are sent through the APNs center. You need to specify the corresponding environment information.</para>
            /// <list type="bullet">
            /// <item><description>DEV: Development environment, applicable to apps installed and debugged directly via Xcode.</description></item>
            /// <item><description>PRODUCT: Production environment, applicable to apps distributed through App Store, TestFlight, Ad Hoc, and enterprise distribution.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DEV</para>
            /// </summary>
            [NameInMap("iOSApnsEnv")]
            [Validation(Required=false)]
            public string IOSApnsEnv { get; set; }

            /// <summary>
            /// <para>iOS app icon badge number in the upper-right corner.</para>
            /// <remarks>
            /// <para>If iOSBadgeAutoIncrement is set to True, this field must be empty.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("iOSBadge")]
            [Validation(Required=false)]
            public int? IOSBadge { get; set; }

            /// <summary>
            /// <para>Whether to enable badge auto-increment. Defaults to false.</para>
            /// <remarks>
            /// <para>When this is set to true, iOSBadge must be empty.</para>
            /// </remarks>
            /// <para>The badge auto-increment feature is maintained by the push server for each device\&quot;s badge count. Users must use SDK version V1.9.5 or later and actively sync the badge number to the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("iOSBadgeAutoIncrement")]
            [Validation(Required=false)]
            public bool? IOSBadgeAutoIncrement { get; set; }

            /// <summary>
            /// <para>Extended properties of iOS notifications.</para>
            /// <para>On iOS 10+, you can specify the resource URL for rich media push notifications here: <c>{&quot;attachment&quot;: &quot;https://xxxx.xxx/notification_pic.png&quot;} </c>. This parameter must be passed in JSON map format; otherwise, parsing errors will occur.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;attachment&quot;: &quot;<a href="https://xxxx.xxx/notification_pic.png%22%7D">https://xxxx.xxx/notification_pic.png&quot;}</a></para>
            /// </summary>
            [NameInMap("iOSExtParameters")]
            [Validation(Required=false)]
            public string IOSExtParameters { get; set; }

            /// <summary>
            /// <para>Interruption level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>passive: The system adds the notification to the notification list without lighting up the screen or playing sound.</para>
            /// </description></item>
            /// <item><description><para>active: The system immediately displays the notification, lights up the screen, and can play sound.</para>
            /// </description></item>
            /// <item><description><para>time-sensitive: The system immediately presents the notification, lights up the screen, and can play sound, but does not break through system notification controls.</para>
            /// </description></item>
            /// <item><description><para>critical: The system immediately displays the notification, lights up the screen, and plays sound bypassing the mute switch.</para>
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
            /// <para>JSON string. Static pass-through parameters for Dynamic Island push. Contains static user-defined information such as product ID and order information.</para>
            /// <remarks>
            /// <para>Required when iOSLiveActivityEvent is start.</para>
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
            /// <para>Required when iOSLiveActivityEvent is start.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>OrderActivityAttributes</para>
            /// </summary>
            [NameInMap("iOSLiveActivityAttributesType")]
            [Validation(Required=false)]
            public string IOSLiveActivityAttributesType { get; set; }

            /// <summary>
            /// <para>Dynamic pass-through parameters for Dynamic Island push. Contains real-time update information such as price and inventory changes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;status&quot;: &quot;delivered&quot;, &quot;estimatedArrival&quot;: &quot;2023-12-31T12:00:00Z&quot;}</para>
            /// </summary>
            [NameInMap("iOSLiveActivityContentState")]
            [Validation(Required=false)]
            public string IOSLiveActivityContentState { get; set; }

            /// <summary>
            /// <para>The ended Live Activity will remain on the lock screen until the specified time, up to a maximum of 4 hours.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1743131967</para>
            /// </summary>
            [NameInMap("iOSLiveActivityDismissalDate")]
            [Validation(Required=false)]
            public long? IOSLiveActivityDismissalDate { get; set; }

            /// <summary>
            /// <para>Start, update, or end a Live Activity.</para>
            /// <list type="bullet">
            /// <item><description>Enum: start | update | end</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>start</para>
            /// </summary>
            [NameInMap("iOSLiveActivityEvent")]
            [Validation(Required=false)]
            public string IOSLiveActivityEvent { get; set; }

            /// <summary>
            /// <para>The Live Activity ID reported by the device to the user\&quot;s server. A unique identifier for the Live Activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66B94673-B32E-4CA7-863C-3E523054FD46</para>
            /// </summary>
            [NameInMap("iOSLiveActivityId")]
            [Validation(Required=false)]
            public string IOSLiveActivityId { get; set; }

            /// <summary>
            /// <para>Timestamp in seconds, marking the expiration time of the activity content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1743131967</para>
            /// </summary>
            [NameInMap("iOSLiveActivityStaleDate")]
            [Validation(Required=false)]
            public long? IOSLiveActivityStaleDate { get; set; }

            /// <summary>
            /// <para>iOS notification sound. Specify the name of an audio file stored in the app bundle or the sandbox Library/Sounds directory. See: How to set notification sound for iOS push.</para>
            /// <para>If set to an empty string (&quot;&quot;), the notification is silent. If not set, the default system alert sound is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>””</para>
            /// </summary>
            [NameInMap("iOSMusic")]
            [Validation(Required=false)]
            public string IOSMusic { get; set; }

            /// <summary>
            /// <para>iOS notification processing extension flag (iOS 10+). If set to true, APNs push notifications can reach the Extension for processing before being displayed. Must be set to true for silent notifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("iOSMutableContent")]
            [Validation(Required=false)]
            public bool? IOSMutableContent { get; set; }

            /// <summary>
            /// <para>Specify the iOS notification Category (iOS 10+).</para>
            /// 
            /// <b>Example:</b>
            /// <para>ios</para>
            /// </summary>
            [NameInMap("iOSNotificationCategory")]
            [Validation(Required=false)]
            public string IOSNotificationCategory { get; set; }

            /// <summary>
            /// <para>When a device receives messages with the same CollapseId, they are merged into one. When the device is offline, consecutive messages with the same CollapseId will show only one notification in the notification bar. Supported on iOS 10+.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZD2011</para>
            /// </summary>
            [NameInMap("iOSNotificationCollapseId")]
            [Validation(Required=false)]
            public string IOSNotificationCollapseId { get; set; }

            /// <summary>
            /// <para>Groups iOS remote notifications using this property, marking the group identifier for collapsed notifications. Only supported on iOS 12.0+.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("iOSNotificationThreadId")]
            [Validation(Required=false)]
            public string IOSNotificationThreadId { get; set; }

            /// <summary>
            /// <para>Summary highlight score. Value range: a floating-point number in [0,1\].</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.01</para>
            /// </summary>
            [NameInMap("iOSRelevanceScore")]
            [Validation(Required=false)]
            public double? IOSRelevanceScore { get; set; }

            /// <summary>
            /// <para>When the device is offline during message push (i.e., the persistent connection channel to the Mobile Push server is disconnected), this push will be delivered as a notification through Apple\&quot;s APNs channel once.</para>
            /// <remarks>
            /// <para>Offline message-to-notification conversion only applies to the production environment.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("iOSRemind")]
            [Validation(Required=false)]
            public bool? IOSRemind { get; set; }

            /// <summary>
            /// <para>iOS notification content used when converting iOS messages to notifications. Only valid when iOSApnsEnv=PRODUCT and iOSRemind is true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ios通知body</para>
            /// </summary>
            [NameInMap("iOSRemindBody")]
            [Validation(Required=false)]
            public string IOSRemindBody { get; set; }

            /// <summary>
            /// <para>Whether to enable iOS silent notification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("iOSSilentNotification")]
            [Validation(Required=false)]
            public bool? IOSSilentNotification { get; set; }

            /// <summary>
            /// <para>iOS notification subtitle content (iOS 10+).</para>
            /// 
            /// <b>Example:</b>
            /// <para>subtitle</para>
            /// </summary>
            [NameInMap("iOSSubtitle")]
            [Validation(Required=false)]
            public string IOSSubtitle { get; set; }

        }

    }

}
