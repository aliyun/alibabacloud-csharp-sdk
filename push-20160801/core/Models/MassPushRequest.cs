// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class MassPushRequest : TeaModel {
        /// <summary>
        /// <para>The AppKey of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23267207</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        /// <summary>
        /// <para>An idempotency parameter that prevents duplicate pushes caused by API client retries. If you make a call with the same IdempotentToken within 15 minutes, only one push is performed, and subsequent calls return the result of the first successful push.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>The parameter format is a standard 36-character UUID (8-4-4-4-12). Each valid character is a hexadecimal digit from 0-9 or a-f, case-insensitive.</para>
        /// </description></item>
        /// <item><description><para>This parameter only prevents duplicate pushes caused by retries. It cannot prevent duplicate pushes caused by concurrent calls.</para>
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
        /// <para>An array of independent push tasks.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PushTask")]
        [Validation(Required=false)]
        public List<MassPushRequestPushTask> PushTask { get; set; }
        public class MassPushRequestPushTask : TeaModel {
            /// <summary>
            /// <para>Specifies the activity to open when the notification is tapped.</para>
            /// <para>This is required only when PushTask.N.AndroidOpenType is set to &quot;Activity&quot;. For example: <c>com.alibaba.cloudpushdemo.bizactivity</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.alibaba.cloudpushdemo.bizactivity</para>
            /// </summary>
            [NameInMap("AndroidActivity")]
            [Validation(Required=false)]
            public string AndroidActivity { get; set; }

            /// <summary>
            /// <para>Sets the value to add to the badge number. The value is added to the original badge number. The value range is [1, 99].</para>
            /// <remarks>
            /// <para>This is effective only for pushes through Huawei or Honor vendor channels. If both AndroidBadgeAddNum and AndroidBadgeSetNum are present, AndroidBadgeSetNum takes precedence.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AndroidBadgeAddNum")]
            [Validation(Required=false)]
            public int? AndroidBadgeAddNum { get; set; }

            /// <summary>
            /// <para>The full class name of the entry Activity of the application for badge settings.</para>
            /// <remarks>
            /// <para>This is effective only for pushes through Huawei or Honor vendor channels.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>com.alibaba.cloudpushdemo.bizactivity</para>
            /// </summary>
            [NameInMap("AndroidBadgeClass")]
            [Validation(Required=false)]
            public string AndroidBadgeClass { get; set; }

            /// <summary>
            /// <para>Sets a fixed number for the badge. The value range is [0, 99].</para>
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
            /// <para>The body in long text mode. Length limit: 1,000 bytes (one Chinese character is counted as 3 bytes). The actual limit depends on the specific vendor channel.</para>
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
            /// <item><description><para>Alibaba Cloud\&quot;s proprietary channel: Android SDK 3.6.0 and later</para>
            /// </description></item>
            /// </list>
            /// <para>If this parameter is not provided in long text mode, the first non-empty value from Body or AndroidPopupBody is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例长文本</para>
            /// </summary>
            [NameInMap("AndroidBigBody")]
            [Validation(Required=false)]
            public string AndroidBigBody { get; set; }

            /// <summary>
            /// <para>The image URL in big picture mode. Currently supported on: Alibaba Cloud\&quot;s proprietary channel with Android SDK 3.6.0 or later.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://imag.example.com/image.png">https://imag.example.com/image.png</a></para>
            /// </summary>
            [NameInMap("AndroidBigPictureUrl")]
            [Validation(Required=false)]
            public string AndroidBigPictureUrl { get; set; }

            /// <summary>
            /// <para>The title in long text mode. Length limit: 200 bytes (one Chinese character is counted as 3 bytes).</para>
            /// <list type="bullet">
            /// <item><description><para>Currently, this is only supported by Honor channels and Huawei channels on EMUI 11 and later.</para>
            /// </description></item>
            /// <item><description><para>If this parameter is not provided in long text mode, the first non-empty value from Title or AndroidPopupTitle is used.</para>
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
            /// <para>Sets the extended properties of the notification. This parameter does not take effect when the push type PushType is set to MESSAGE.</para>
            /// <para>This parameter must be passed in JSON map format, or it will fail to parse.</para>
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
            /// <para>Each application can send 1,000 test notifications per day, and these are not subject to the daily push limit per device.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AndroidHonorTargetUserType")]
            [Validation(Required=false)]
            public int? AndroidHonorTargetUserType { get; set; }

            /// <summary>
            /// <para>Sets the parameters for Huawei quick notifications</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Send a normal Huawei notification (default).</para>
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
            /// <para>A JSON string of the Huawei Android Live Notification data structure <a href="https://developer.huawei.com/consumer/cn/doc/HMSCore-References/rest-live-0000001562939968#ZH-CN_TOPIC_0000001700850537__p195121620102511">LiveNotificationPayload</a>. For development and integration, see the <a href="https://help.aliyun.com/document_detail/2983768.html">Huawei Live Notification Push Guide</a>.</para>
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
            /// <para>The receipt ID for the Huawei channel. View this receipt ID in the receipt parameter configuration on the Huawei Push operations platform.</para>
            /// <remarks>
            /// <para>If the default receipt configuration on the Huawei Push operations platform is the Alibaba Cloud receipt, you do not need to provide this. If not, we recommend that you first configure the default receipt ID for the Huawei channel in the Alibaba Cloud EMAS Mobile Push console.</para>
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
            /// <para>Each application can send 500 test notifications per day, and these are not subject to the daily push limit per device.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AndroidHuaweiTargetUserType")]
            [Validation(Required=false)]
            public int? AndroidHuaweiTargetUserType { get; set; }

            /// <summary>
            /// <para>The URL for the right-side icon. Currently supported on:</para>
            /// <list type="bullet">
            /// <item><description><para>Huawei EMUI (applicable only in long text mode and inbox mode)</para>
            /// </description></item>
            /// <item><description><para>Honor Magic UI (applicable only in long text mode)</para>
            /// </description></item>
            /// <item><description><para>Alibaba Cloud\&quot;s proprietary channel: Android SDK 3.5.0 and later</para>
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
            /// <para>The body in inbox mode. The content must be a valid JSON array with no more than 5 elements. Currently supported on:</para>
            /// <list type="bullet">
            /// <item><description><para>Huawei: EMUI 9 and later</para>
            /// </description></item>
            /// <item><description><para>Honor: Magic UI 4.0 and later</para>
            /// </description></item>
            /// <item><description><para>Xiaomi: MIUI 10 and later</para>
            /// </description></item>
            /// <item><description><para>OPPO: ColorOS 5.0 and later</para>
            /// </description></item>
            /// <item><description><para>Alibaba Cloud\&quot;s proprietary channel: Android SDK 3.6.0 and later</para>
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
            /// <c>false</c>
            /// </summary>
            [NameInMap("AndroidMeizuNoticeMsgType")]
            [Validation(Required=false)]
            public int? AndroidMeizuNoticeMsgType { get; set; }

            /// <summary>
            /// <para>Function 1: After applying for <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/message-classification-0000001149358835?#section3410731125514">self-classification permissions</a>, use this parameter to identify the message type, determine the <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/message-classification-0000001149358835#ZH-CN_TOPIC_0000001149358835__p3850133955718">message reminder method</a>, and expedite the sending of specific message types. For valid values, see the <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/message-classification-0000001149358835#section1076611477914">message classification standards</a> in the official Huawei Push documentation. Fill in the &quot;Cloud-side notification category value&quot; or &quot;Local notification category value&quot; from the documentation table.</para>
            /// <para>Function 2: After applying for <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/faq-0000001050042183#section037425218509">special permissions</a>, use this parameter to identify high-priority pass-through scenarios. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>VOIP: Video calls</para>
            /// </description></item>
            /// <item><description><para>PLAY_VOICE: Voice playback</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>For &quot;Cloud-side notification category values&quot; that are &quot;Not applicable&quot;, all pushes go through Alibaba Cloud\&quot;s proprietary channel. For &quot;Local notification category values&quot; that are &quot;Not applicable&quot;, all pushes go through the Huawei channel.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SUBSCRIPTION</para>
            /// </summary>
            [NameInMap("AndroidMessageHuaweiCategory")]
            [Validation(Required=false)]
            public string AndroidMessageHuaweiCategory { get; set; }

            /// <summary>
            /// <para>The delivery priority for Huawei channel notifications. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>HIGH</para>
            /// </description></item>
            /// <item><description><para>NORMAL</para>
            /// </description></item>
            /// </list>
            /// <para>You must apply for permissions. For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/faq-0000001050042183#section037425218509">Application Link</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HIGH</para>
            /// </summary>
            [NameInMap("AndroidMessageHuaweiUrgency")]
            [Validation(Required=false)]
            public string AndroidMessageHuaweiUrgency { get; set; }

            /// <summary>
            /// <para>OPPO manages messages in two categories: Communication and Services, and Content and Marketing.</para>
            /// <para>Communication and Services (requires permission application):</para>
            /// <list type="bullet">
            /// <item><description><para>IM: Instant messaging, audio, and video calls</para>
            /// </description></item>
            /// <item><description><para>ACCOUNT: Changes in personal accounts and assets</para>
            /// </description></item>
            /// <item><description><para>DEVICE_REMINDER: Personal device reminders</para>
            /// </description></item>
            /// <item><description><para>ORDER: Changes in personal order or logistics status</para>
            /// </description></item>
            /// <item><description><para>TODO: Personal schedules or to-do items</para>
            /// </description></item>
            /// <item><description><para>SUBSCRIPTION: Personal subscriptions</para>
            /// </description></item>
            /// </list>
            /// <para>Content and Marketing:</para>
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
            /// <para>For more information, see <a href="https://open.oppomobile.com/new/developmentDoc/info?id=13189">OPUSH Message Classification Rules</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>MARKETING</para>
            /// </summary>
            [NameInMap("AndroidMessageOppoCategory")]
            [Validation(Required=false)]
            public string AndroidMessageOppoCategory { get; set; }

            /// <summary>
            /// <para>The reminder level for OPPO channel notification bar messages. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>1: Notification bar</para>
            /// </description></item>
            /// <item><description><para>2: Notification bar, lock screen, ringtone, vibration (default notification level for Communication and Services messages)</para>
            /// </description></item>
            /// <item><description><para>16: Notification bar, lock screen, ringtone, vibration, banner (requires permission application)</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>When using the AndroidMessageOppoNotifyLevel parameter, you must also pass the AndroidMessageOppoCategory parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AndroidMessageOppoNotifyLevel")]
            [Validation(Required=false)]
            public int? AndroidMessageOppoNotifyLevel { get; set; }

            /// <summary>
            /// <para>vivo manages messages in two categories: system messages and operational messages.</para>
            /// <para>System messages:</para>
            /// <list type="bullet">
            /// <item><description><para>IM: Instant messages</para>
            /// </description></item>
            /// <item><description><para>ACCOUNT: Account and asset</para>
            /// </description></item>
            /// <item><description><para>TODO: Schedule and to-do</para>
            /// </description></item>
            /// <item><description><para>DEVICE_REMINDER: Device information</para>
            /// </description></item>
            /// <item><description><para>ORDER: Order and logistics</para>
            /// </description></item>
            /// <item><description><para>SUBSCRIPTION: Subscription reminder</para>
            /// </description></item>
            /// </list>
            /// <para>Operational messages:</para>
            /// <list type="bullet">
            /// <item><description><para>NEWS: News</para>
            /// </description></item>
            /// <item><description><para>CONTENT: Content recommendation</para>
            /// </description></item>
            /// <item><description><para>MARKETING: Operational activity</para>
            /// </description></item>
            /// <item><description><para>SOCIAL: Social updates</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>For more information, see <a href="https://dev.vivo.com.cn/documentCenter/doc/359#s-ef3qugc3">Classification Description</a></para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>TODO</para>
            /// </summary>
            [NameInMap("AndroidMessageVivoCategory")]
            [Validation(Required=false)]
            public string AndroidMessageVivoCategory { get; set; }

            /// <summary>
            /// <para>The notification sound for the Huawei vendor channel. Specify the name of the audio file stored in the app/src/main/res/raw/ directory of the client project. Do not include the file format suffix.</para>
            /// <para>If you do not set this parameter, the default ringtone is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alicloud_notification_sound</para>
            /// </summary>
            [NameInMap("AndroidMusic")]
            [Validation(Required=false)]
            public string AndroidMusic { get; set; }

            /// <summary>
            /// <para>The priority that determines the position of the Android notification in the notification bar. Valid values: -2, -1, 0, 1, and 2.</para>
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
            /// <para>The channel ID for the Android app. It must correspond to a channel ID in the app.</para>
            /// <list type="bullet">
            /// <item><description><para>Set the NotificationChannel parameter. For more information about its use, see <a href="https://help.aliyun.com/document_detail/67398.html">FAQ: Why are notifications not received on devices with Android 8.0 or later?</a>.</para>
            /// </description></item>
            /// <item><description><para>Because the channel_id for the OPPO private message channel is the same as the app\&quot;s channelId, this value is used for the channel_id when pushing through the OPPO channel.</para>
            /// </description></item>
            /// <item><description><para>For pushes through Huawei, FCM, and Alibaba Cloud\&quot;s proprietary channels, this value is used for the channel_id.</para>
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
            /// <para>Message grouping. For messages in the same group, the notification bar displays only the latest message and the total number of messages received for that group. It does not display all messages and cannot be expanded. Currently supported on:</para>
            /// <list type="bullet">
            /// <item><description><para>Huawei vendor channel</para>
            /// </description></item>
            /// <item><description><para>Honor vendor channel</para>
            /// </description></item>
            /// <item><description><para>Alibaba Cloud\&quot;s proprietary channel with Android SDK 3.9.1 and earlier</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is not supported by Alibaba Cloud\&quot;s proprietary channel on Android SDK 3.9.2 and later.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>group-1</para>
            /// </summary>
            [NameInMap("AndroidNotificationGroup")]
            [Validation(Required=false)]
            public string AndroidNotificationGroup { get; set; }

            /// <summary>
            /// <para>Sets the importance parameter for Honor notification message classification, which determines the notification behavior on the user\&quot;s device. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>LOW: Marketing messages</para>
            /// </description></item>
            /// <item><description><para>NORMAL: Service and communication messages</para>
            /// </description></item>
            /// </list>
            /// <para>Apply for this on the Honor platform. <a href="https://developer.honor.com/cn/docs/11002/guides/notification-class#%E8%87%AA%E5%88%86%E7%B1%BB%E6%9D%83%E7%9B%8A%E7%94%B3%E8%AF%B7">Application Link</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LOW</para>
            /// </summary>
            [NameInMap("AndroidNotificationHonorChannel")]
            [Validation(Required=false)]
            public string AndroidNotificationHonorChannel { get; set; }

            /// <summary>
            /// <para>Sets the importance parameter for Huawei notification message classification, which determines the notification behavior on the user\&quot;s device. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>LOW: Marketing messages</para>
            /// </description></item>
            /// <item><description><para>NORMAL: Service and communication messages</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>For the Huawei channel, use AndroidMessageHuaweiCategory for notification classification. AndroidNotificationHuaweiChannel is no longer required.</para>
            /// </description></item>
            /// <item><description><para>You must apply for this on the Huawei platform. <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/message-classification-0000001149358835#section893184112272">Application Link</a>.</para>
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
            /// <para>The unique ID for each message when it is displayed as a notification. Different notification messages can have the same NotifyId to allow new notifications to overwrite old ones.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100001</para>
            /// </summary>
            [NameInMap("AndroidNotificationNotifyId")]
            [Validation(Required=false)]
            public int? AndroidNotificationNotifyId { get; set; }

            /// <summary>
            /// <para>Message grouping. Messages in the same group are displayed collapsed in the notification bar and can be expanded. Notifications from different groups are displayed separately. Currently supported on:</para>
            /// <list type="bullet">
            /// <item><description>Alibaba Cloud\&quot;s proprietary channel with Android SDK 3.9.2 and later</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>thread-1</para>
            /// </summary>
            [NameInMap("AndroidNotificationThreadId")]
            [Validation(Required=false)]
            public string AndroidNotificationThreadId { get; set; }

            /// <summary>
            /// <para>Sets the vivo notification message classification. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: Operational messages (default)</para>
            /// </description></item>
            /// <item><description><para>1: System messages</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>For the vivo channel, use AndroidMessageVivoCategory for notification classification. AndroidNotificationVivoChannel is no longer required.</para>
            /// </description></item>
            /// <item><description><para>Apply for this on the vivo platform. For more information, see <a href="https://dev.vivo.com.cn/documentCenter/doc/359">Application Link</a>.</para>
            /// </description></item>
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
            /// <para>Sets the channel ID for the Xiaomi notification type. Apply for it on the Xiaomi platform. For more information, see <a href="https://dev.mi.com/console/doc/detail?pId=2422#_4">Application Link</a>.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>A single application can apply for a maximum of 8 channels on the Xiaomi platform. Plan accordingly.</description></item>
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
            /// <para>The notification reminder method. Valid values:</para>
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
            /// <para>VIBRATE</para>
            /// </summary>
            [NameInMap("AndroidNotifyType")]
            [Validation(Required=false)]
            public string AndroidNotifyType { get; set; }

            /// <summary>
            /// <para>The action to take after a notification is tapped. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>APPLICATION: Open the application (default)</para>
            /// </description></item>
            /// <item><description><para>ACTIVITY: Open the application\&quot;s AndroidActivity</para>
            /// </description></item>
            /// <item><description><para>URL: Open a URL</para>
            /// </description></item>
            /// <item><description><para>NONE: No action</para>
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
            /// <para>The URL to open after the Android device receives the push. This is required only when PushTask.N.AndroidOpenType is set to &quot;URL&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxxx.xxx">https://xxxx.xxx</a></para>
            /// </summary>
            [NameInMap("AndroidOpenUrl")]
            [Validation(Required=false)]
            public string AndroidOpenUrl { get; set; }

            /// <summary>
            /// <para>A JSON string of the OPPO Fluid Cloud intent deletion data structure <a href="https://open.oppomobile.com/documentation/page/info?id=13578">data</a>. This parameter is invalid if the AndroidOppoIntelligentIntent parameter is already filled. For development and integration, see the <a href="https://help.aliyun.com/document_detail/2997310.html">OPPO Fluid Cloud Push Guide</a>.</para>
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
            /// <para>A JSON string of the OPPO Fluid Cloud intent sharing data structure <a href="https://open.oppomobile.com/documentation/page/info?id=13565">IntelligentIntent</a>. For development and integration, see the <a href="https://help.aliyun.com/document_detail/2997310.html">OPPO Fluid Cloud Push Guide</a>.</para>
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
            /// <para>Sets the OPPO Fluid Cloud push environment</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Production environment (default).</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Staging environment.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>The OPPO Fluid Cloud staging environment needs to be set up on the client side. For more information, see <a href="https://open.oppomobile.com/documentation/page/info?id=13590">Environment Setup</a>.</para>
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
            /// <para>Warning: </para>
            /// </remarks>
            /// <para>The OPPO private message template feature is no longer supported by MaasPush. To use this feature, use the Push, PushV2, or MassPushV2 API instead.</para>
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
            /// <para>Specifies the Activity to which the user is redirected after tapping the notification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.alibaba.cloudpushdemo.bizactivity</para>
            /// </summary>
            [NameInMap("AndroidPopupActivity")]
            [Validation(Required=false)]
            public string AndroidPopupActivity { get; set; }

            /// <summary>
            /// <para>The body content in auxiliary pop-up mode. This parameter is required if the AndroidPopupActivity parameter is not empty.</para>
            /// <para>Length limit: 200 characters. Both Chinese and English characters count as one.</para>
            /// <para>If you use a vendor channel, comply with the vendor channel\&quot;s restrictions. For more information, see <a href="https://help.aliyun.com/document_detail/165253.html">Limits on auxiliary channel pushes for Android</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hello</para>
            /// </summary>
            [NameInMap("AndroidPopupBody")]
            [Validation(Required=false)]
            public string AndroidPopupBody { get; set; }

            /// <summary>
            /// <para>The title content in auxiliary pop-up mode. This parameter is required if the AndroidPopupActivity parameter is not empty.</para>
            /// <para>Length limit: 50 characters. Both Chinese and English characters count as one.</para>
            /// <para>If you use a vendor channel, comply with the vendor channel\&quot;s restrictions. For more information, see <a href="https://help.aliyun.com/document_detail/165253.html">Limits on auxiliary channel pushes for Android</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hello</para>
            /// </summary>
            [NameInMap("AndroidPopupTitle")]
            [Validation(Required=false)]
            public string AndroidPopupTitle { get; set; }

            /// <summary>
            /// <para>If the push type is MESSAGE and the device is offline, this push uses the auxiliary pop-up feature. The default value is false. This parameter takes effect only when PushType is MESSAGE.</para>
            /// <para>If a message is successfully converted to a notification, the displayed notification uses the values of the AndroidPopupTitle and AndroidPopupBody parameters. When the user taps the notification, the data retrieved by the onSysNoticeOpened method of the auxiliary pop-up uses the values of the Title and Body parameters.</para>
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
            /// <item><description><para><b>1</b>: Long text mode (supported by Huawei, Honor, Xiaomi, OPPO, Meizu, and Alibaba Cloud\&quot;s proprietary channel)</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Big picture mode (supported by Alibaba Cloud\&quot;s proprietary channel, not supported on Xiaomi models)</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: List mode (supported by Huawei, Honor, Xiaomi, OPPO, and Alibaba Cloud\&quot;s proprietary channel)</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is required for non-standard modes.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AndroidRenderStyle")]
            [Validation(Required=false)]
            public string AndroidRenderStyle { get; set; }

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
            /// <item><description><para>Configuring this parameter is equivalent to configuring the AndroidHuaweiTargetUserType, AndroidHonorTargetUserType, AndroidVivoPushMode, and AndroidOppoIntentEnv parameters at the same time. A specific vendor channel parameter can override this parameter.</para>
            /// </description></item>
            /// <item><description><para>Currently supported: Huawei channel, Honor channel, vivo channel, OPPO Fluid Cloud.</para>
            /// </description></item>
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
            /// <para>A JSON string of the vivo Atomic Island data structure <a href="https://dev.vivo.com.cn/documentCenter/doc/896#s-fdagzbd4">liveMessage</a>. For development and integration, see the <a href="https://help.aliyun.com/zh/document_detail/3030718.html">vivo Atomic Island Push Guide</a>.</para>
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
            /// <para>For test pushes, configure the test devices in the vivo console beforehand. You can obtain the test device\&quot;s RegId by searching for &quot;onReceiveRegId regId&quot; in the device startup logs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AndroidVivoPushMode")]
            [Validation(Required=false)]
            public int? AndroidVivoPushMode { get; set; }

            /// <summary>
            /// <para>The receipt ID for the vivo channel. View this receipt ID in the application information of the push service on the vivo open platform.</para>
            /// <remarks>
            /// <para>If the default receipt configuration on the vivo open platform is the Alibaba Cloud receipt, you do not need to provide this. If not, we recommend that you first configure the default receipt ID for the vivo channel in the Alibaba Cloud EMAS Mobile Push console.</para>
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
            /// <para>This parameter is deprecated. All third-party auxiliary pop-ups are now supported by the new <b>AndroidPopupActivity</b> parameter.</para>
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
            /// <para>This parameter is deprecated. All third-party auxiliary pop-ups are now supported by the new <b>AndroidPopupBody</b> parameter.</para>
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
            /// <para>This parameter is deprecated. All third-party auxiliary pop-ups are now supported by the new <b>AndroidPopupTitle</b> parameter.</para>
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
            /// <para>This parameter is deprecated. Since August 2023, Xiaomi no longer supports dynamically setting small icons, right-side icons, or large pictures during pushes on new devices or systems.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://f6.market.xiaomi.com/download/MiPass/aaa/bbb.png">https://f6.market.xiaomi.com/download/MiPass/aaa/bbb.png</a></para>
            /// </summary>
            [NameInMap("AndroidXiaomiBigPictureUrl")]
            [Validation(Required=false)]
            [Obsolete]
            public string AndroidXiaomiBigPictureUrl { get; set; }

            /// <summary>
            /// <para>A JSON string of the Xiaomi HyperOS Island data structure <a href="https://dev.mi.com/xiaomihyperos/documentation/detail?pId=2131">miui.focus.param</a>. For development and integration, see the <a href="https://help.aliyun.com/zh/document_detail/3037956.html">Xiaomi HyperOS Island Push Guide</a>.</para>
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
            /// <para>A JSON string of the Xiaomi HyperOS Island data image <a href="https://dev.mi.com/xiaomihyperos/documentation/detail?pId=2131">miui.focus.pic_xxx</a>. For development and integration, see the <a href="https://help.aliyun.com/zh/document_detail/3037956.html">Xiaomi HyperOS Island Push Guide</a>.</para>
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
            /// <para>This parameter is deprecated. Since August 2023, Xiaomi no longer supports dynamically setting small icons, right-side icons, or large pictures during pushes on new devices or systems.</para>
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
            /// <para>The content of the notification or message for Android and HarmonyOS pushes. The content of the message or notification for iOS. The content size is limited. For more information, see <a href="https://help.aliyun.com/document_detail/92832.html">Product limits</a>.</para>
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
            /// <item><description><para>HARMONY: HarmonyOS devices</para>
            /// </description></item>
            /// <item><description><para>iOS: iOS devices</para>
            /// </description></item>
            /// <item><description><para>ANDROID: Android devices</para>
            /// </description></item>
            /// <item><description><para>ALL: If the AppKey is for an old version of a dual-platform application, this value indicates that pushes are sent to both Android and iOS devices. If the AppKey is for a new version of a single-platform application, the effect is the same as specifying the device type corresponding to that application type.</para>
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
            /// <para>The time-to-live (TTL) for offline messages or notifications. Use this with StoreOffline. After the TTL expires, the message or notification is no longer sent. The maximum TTL is 72 hours. The default is 72 hours.</para>
            /// <para>The time must be in ISO 8601 format and in UTC: YYYY-MM-DDThh:mm:ssZ. The expiration time must be at least 3 seconds later than the current time or the scheduled push time (<c>ExpireTime &gt; PushTime + 3 seconds</c>). The 3-second buffer accounts for potential network and system latency. Set the TTL to at least 1 minute for individual pushes and at least 10 minutes for full or batch pushes.</para>
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
            /// <para>When HarmonyActionType is APP_CUSTOM_PAGE, at least one of HarmonyUri and HarmonyAction must be filled in.</para>
            /// <para>For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section152462191216">ClickAction.action</a> on the HarmonyOS website.</para>
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
            /// <item><description><para>APP_HOME_PAGE: Open the application home page</para>
            /// </description></item>
            /// <item><description><para>APP_CUSTOM_PAGE: Open a custom application page</para>
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
            /// <para>The number to add to the HarmonyOS application badge. See the <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section266310382145">HarmonyOS badge addNum field description</a>.<br>
            /// Supported starting from HarmonyOS SDK version 1.2.0.<br></para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HarmonyBadgeAddNum")]
            [Validation(Required=false)]
            public int? HarmonyBadgeAddNum { get; set; }

            /// <summary>
            /// <para>The number to set for the HarmonyOS application badge. See the <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section266310382145">HarmonyOS badge setNum field description</a>.<br>
            /// Supported starting from HarmonyOS SDK version 1.2.0.<br></para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HarmonyBadgeSetNum")]
            [Validation(Required=false)]
            public int? HarmonyBadgeSetNum { get; set; }

            /// <summary>
            /// <para>The notification message category. After applying for notification message self-classification permissions, use this to identify the message type. Different notification message types affect how messages are displayed and reminded. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>IM: Instant messaging</para>
            /// </description></item>
            /// <item><description><para>VOIP: Video call</para>
            /// </description></item>
            /// <item><description><para>SUBSCRIPTION: Subscription</para>
            /// </description></item>
            /// <item><description><para>TRAVEL: Travel</para>
            /// </description></item>
            /// <item><description><para>HEALTH: Health</para>
            /// </description></item>
            /// <item><description><para>WORK: Work item reminder</para>
            /// </description></item>
            /// <item><description><para>ACCOUNT: Account updates</para>
            /// </description></item>
            /// <item><description><para>EXPRESS: Order &amp; logistics</para>
            /// </description></item>
            /// <item><description><para>FINANCE: Finance</para>
            /// </description></item>
            /// <item><description><para>DEVICE_REMINDER: Device reminder</para>
            /// </description></item>
            /// <item><description><para>MAIL: Email</para>
            /// </description></item>
            /// <item><description><para>CUSTOMER_SERVICE: Customer service message</para>
            /// </description></item>
            /// <item><description><para>MARKETING: News, content recommendations, social updates, product promotions, financial updates, lifestyle information, surveys, feature recommendations, and operational activities (only identifies content, does not expedite message sending), collectively referred to as marketing messages.</para>
            /// </description></item>
            /// </list>
            /// <para>For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section17371529101117">Notification.category</a> on the HarmonyOS website.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IM</para>
            /// </summary>
            [NameInMap("HarmonyCategory")]
            [Validation(Required=false)]
            public string HarmonyCategory { get; set; }

            /// <summary>
            /// <para>Sets the extended properties of the notification. This parameter does not take effect when the push type PushType is set to MESSAGE.</para>
            /// <para>This parameter must be passed in JSON map format, or it will fail to parse.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;key1&quot;:&quot;value1&quot;,&quot;api_name&quot;:&quot;PushNoticeToAndroidRequest&quot;}</para>
            /// </summary>
            [NameInMap("HarmonyExtParameters")]
            [Validation(Required=false)]
            public string HarmonyExtParameters { get; set; }

            /// <summary>
            /// <para>Extra data for the extended notification message.<br>
            /// Effective when sending HarmonyOS extended notification messages.<br>
            /// Conceptually equivalent to the extraData field of a HarmonyOS extended notification message. For a detailed definition, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section161192514234">HarmonyOS ExtensionPayload Description</a>.<br>
            /// Supported starting from HarmonyOS SDK version 1.2.0.<br><br><br></para>
            /// 
            /// <b>Example:</b>
            /// <para>示例额外数据</para>
            /// </summary>
            [NameInMap("HarmonyExtensionExtraData")]
            [Validation(Required=false)]
            public string HarmonyExtensionExtraData { get; set; }

            /// <summary>
            /// <para>When PushType is NOTICE, specifies whether it is a HarmonyOS extended notification message.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Send an extended notification message</para>
            /// </description></item>
            /// <item><description><para>false: Send a normal notification (default)</para>
            /// </description></item>
            /// </list>
            /// <para>You must apply for permission on the HarmonyOS side before sending extended notification messages. For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-guides-V5/push-send-extend-noti-V5">Send Extended Notification Messages</a> in the HarmonyOS documentation.<br>
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
            /// <para>Supported image formats are png, jpg, jpeg, heif, gif, and bmp. The image length × width must be less than 25,000 pixels.</para>
            /// </remarks>
            /// <para>For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section17371529101117">Notification.image</a> on the HarmonyOS website.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/xxx.png">https://example.com/xxx.png</a></para>
            /// </summary>
            [NameInMap("HarmonyImageUrl")]
            [Validation(Required=false)]
            public string HarmonyImageUrl { get; set; }

            /// <summary>
            /// <para>The content for the multi-line text style. This field is required when HarmonyRenderStyle is MULTI_LINE. A maximum of 3 content entries are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;1.content1&quot;,&quot;2.content2&quot;,&quot;3.content3&quot;]</para>
            /// </summary>
            [NameInMap("HarmonyInboxContent")]
            [Validation(Required=false)]
            public string HarmonyInboxContent { get; set; }

            /// <summary>
            /// <para>A JSON string of the HarmonyOS Live Window data structure <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V13/push-scenariozed-api-request-param-V13#section66881469306">LiveViewPayload</a>. For development and integration, see the <a href="https://help.aliyun.com/document_detail/2982112.html">HarmonyOS Live Window Push Guide</a>.</para>
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
            /// <item><description><para>SERVICE_INFORMATION: Service reminder.</para>
            /// </description></item>
            /// <item><description><para>CONTENT_INFORMATION: Content information.</para>
            /// </description></item>
            /// <item><description><para>CUSTOMER_SERVICE: Customer service message. This type is used for customer service messages between users and businesses and must be initiated by the user.</para>
            /// </description></item>
            /// <item><description><para>OTHER_TYPES: Other.</para>
            /// </description></item>
            /// </list>
            /// <para>For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/js-apis-notificationmanager-V5#slottype">SlotType</a> on the HarmonyOS website.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SOCIAL_COMMUNICATION</para>
            /// </summary>
            [NameInMap("HarmonyNotificationSlotType")]
            [Validation(Required=false)]
            public string HarmonyNotificationSlotType { get; set; }

            /// <summary>
            /// <para>The unique ID for each message when it is displayed as a notification. If not included, the push service automatically generates a unique ID for each message. Different notification messages can have the same notifyId to allow new messages to overwrite old ones.</para>
            /// <para>For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section17371529101117">Notification.notifyId</a> on the HarmonyOS website.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("HarmonyNotifyId")]
            [Validation(Required=false)]
            public int? HarmonyNotifyId { get; set; }

            /// <summary>
            /// <para>The receipt ID for the HarmonyOS channel. View this receipt ID in the receipt parameter configuration on the HarmonyOS Push operations platform.</para>
            /// <remarks>
            /// <para>If the default receipt configuration on the HarmonyOS Push operations platform is the Alibaba Cloud receipt, you do not need to provide this. If not, we recommend that you first configure the default receipt ID for the HarmonyOS channel in the Alibaba Cloud EMAS Mobile Push console.</para>
            /// </remarks>
            /// <para>For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section418321011212">pushOptions.receiptId</a> on the HarmonyOS website.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RCPB***DFD5</para>
            /// </summary>
            [NameInMap("HarmonyReceiptId")]
            [Validation(Required=false)]
            public string HarmonyReceiptId { get; set; }

            /// <summary>
            /// <para>If the push type is MESSAGE and the device is offline, this push uses the auxiliary pop-up feature. The default value is false. This parameter is effective only when PushType is set to MESSAGE.</para>
            /// <para>If a message is successfully converted to a notification, the data displayed in the notification is the value of the server-side HarmonyRemindTitle and HarmonyRemindBody parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HarmonyRemind")]
            [Validation(Required=false)]
            public bool? HarmonyRemind { get; set; }

            /// <summary>
            /// <para>The HarmonyOS notification content used when a message is converted to a notification. This is effective only when HarmonyRemind is set to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>您有一条新消息，请查收</para>
            /// </summary>
            [NameInMap("HarmonyRemindBody")]
            [Validation(Required=false)]
            public string HarmonyRemindBody { get; set; }

            /// <summary>
            /// <para>The HarmonyOS notification title used when a message is converted to a notification. This is effective only when HarmonyRemind is set to true.</para>
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
            /// <para>The test message flag:</para>
            /// <list type="bullet">
            /// <item><description><para>false: Normal message (default)</para>
            /// </description></item>
            /// <item><description><para>true: Test message</para>
            /// </description></item>
            /// </list>
            /// <para>For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section418321011212">pushOptions.testMessage</a> on the HarmonyOS website.</para>
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
            /// <para>Notice: When HarmonyActionType is APP_CUSTOM_PAGE, at least one of HarmonyUri and HarmonyAction must be filled in. When there are multiple Abilities, fill in the action and URI for each Ability separately. The action is used with priority to find the corresponding in-app page.</para>
            /// </remarks>
            /// <para>For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section152462191216">ClickAction.uri</a> on the HarmonyOS website.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.example.com:8080/push/example">https://www.example.com:8080/push/example</a></para>
            /// </summary>
            [NameInMap("HarmonyUri")]
            [Validation(Required=false)]
            public string HarmonyUri { get; set; }

            /// <summary>
            /// <para>A custom ID for the push task. If JobKey is not empty, this field is included in the receipt logs. For more information about how to view receipt logs, see <a href="https://help.aliyun.com/document_detail/434651.html">Receipt logs</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("JobKey")]
            [Validation(Required=false)]
            public string JobKey { get; set; }

            /// <summary>
            /// <para>Specifies the time for a scheduled push. If you do not set this parameter, the push is sent immediately.</para>
            /// <para>The time must be in ISO 8601 format and in UTC: YYYY-MM-DDThh:mm:ssZ.</para>
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
            /// <item><description><para>MESSAGE: a message.</para>
            /// </description></item>
            /// <item><description><para>NOTICE: a notification.</para>
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
            /// <item><description><para>If you do not configure this parameter, all channels can be used.</para>
            /// </description></item>
            /// <item><description><para>If you configure this parameter, only the specified channels are used.</para>
            /// </description></item>
            /// <item><description><para>If the configured channels conflict with the sending policy (for example, iOS notifications are sent only through the APNs channel, but this parameter does not include apns), the push is not sent.</para>
            /// </description></item>
            /// <item><description><para>If you configure gcm, both Google GCM and FCM channels can be used. If you configure fcm, only the Google FCM channel can be used.</para>
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
            /// <para>Specifies whether to save offline messages or notifications. The default value is false.</para>
            /// <para>If you save them, and a user is offline, the message or notification is resent when the user comes online before the time-to-live (TTL) specified by ExpireTime expires. The default TTL is 72 hours. iOS notifications are sent through the APNs channel and are not affected by this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("StoreOffline")]
            [Validation(Required=false)]
            public bool? StoreOffline { get; set; }

            /// <summary>
            /// <para>The push target. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>DEVICE: Push by device.</para>
            /// </description></item>
            /// <item><description><para>ACCOUNT: Push by account.</para>
            /// </description></item>
            /// <item><description><para>ALIAS: Push by alias.</para>
            /// </description></item>
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
            /// <para>Set this parameter based on the value of Target. To specify multiple values, separate them with commas. If you exceed the limit, send multiple pushes.</para>
            /// <list type="bullet">
            /// <item><description><para>If you set Target to DEVICE, specify device IDs, such as <c>deviceid1,deviceid2</c>. You can specify up to 1,000 device IDs.</para>
            /// </description></item>
            /// <item><description><para>If you set Target to ACCOUNT, specify accounts, such as <c>account1,account2</c>. You can specify up to 1,000 accounts.</para>
            /// </description></item>
            /// <item><description><para>If you set Target to ALIAS, specify aliases, such as <c>alias1,alias2</c>. You can specify up to 1,000 aliases.</para>
            /// </description></item>
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
            /// <para>The title of the notification or message. The length is limited to 200 bytes.
            /// This parameter is required for Android and HarmonyOS pushes. It is optional for iOS notification pushes. If you specify it for iOS:</para>
            /// <list type="bullet">
            /// <item><description><para>For iOS 10 and later, the notification title is displayed.</para>
            /// </description></item>
            /// <item><description><para>For iOS versions from 8.2 to 10, it replaces the application name in the notification.</para>
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
            /// <para>Specifies whether to automatically truncate titles and content that are too long.
            /// Note: This applies only to vendor channels that have explicit limits on title and content length. It does not apply to channels such as APNs, Huawei, and Honor, which limit the total request body size instead of the title and content length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Trim")]
            [Validation(Required=false)]
            public bool? Trim { get; set; }

            /// <summary>
            /// <para>iOS notifications are sent through APNs. Specify the environment information.</para>
            /// <list type="bullet">
            /// <item><description><para>DEV: The development environment. This applies to applications installed and debugged directly from Xcode.</para>
            /// </description></item>
            /// <item><description><para>PRODUCT: The production environment. This applies to applications distributed through the App Store, TestFlight, Ad Hoc, or enterprise distribution.</para>
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
            /// <para>The badge number on the top-right corner of the iOS application icon.</para>
            /// <remarks>
            /// <para>If iOSBadgeAutoIncrement is set to true, this parameter must be empty.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("iOSBadge")]
            [Validation(Required=false)]
            public int? IOSBadge { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the auto-increment badge feature. The default value is false.</para>
            /// <remarks>
            /// <para>When this is set to true, iOSBadge must be empty.</para>
            /// </remarks>
            /// <para>The auto-increment badge feature is maintained by the push server, which keeps a badge count for each device. To use this feature, use SDK version 1.9.5 or later and actively sync the badge number to the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("iOSBadgeAutoIncrement")]
            [Validation(Required=false)]
            public bool? IOSBadgeAutoIncrement { get; set; }

            /// <summary>
            /// <para>The extended properties for iOS notifications.</para>
            /// <para>For iOS 10 and later, specify the resource URL for a rich push notification, such as <c>{&quot;attachment&quot;: &quot;https://xxxx.xxx/notification_pic.png&quot;}</c>. This parameter must be passed in JSON map format, or it will fail to parse.</para>
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
            /// <item><description><para>passive: The system adds the notification to the notification list without lighting up the screen or playing a sound.</para>
            /// </description></item>
            /// <item><description><para>active: The system immediately displays the notification, lights up the screen, and can play a sound.</para>
            /// </description></item>
            /// <item><description><para>time-sensitive: The system immediately presents the notification, lights up the screen, and can play a sound, but does not break through system notification controls.</para>
            /// </description></item>
            /// <item><description><para>critical: The system immediately displays the notification, lights up the screen, and plays a sound, bypassing the mute switch.</para>
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
            /// <para>A JSON string for the static pass-through parameters of a Dynamic Island push. It contains static, user-defined information, such as product numbers and order information.</para>
            /// <remarks>
            /// <para>Required when iOSLiveActivityEvent is set to start.</para>
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
            /// <para>Required when iOSLiveActivityEvent is set to start.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>OrderActivityAttributes</para>
            /// </summary>
            [NameInMap("iOSLiveActivityAttributesType")]
            [Validation(Required=false)]
            public string IOSLiveActivityAttributesType { get; set; }

            /// <summary>
            /// <para>The dynamic pass-through parameters for a Dynamic Island push. It contains real-time updated information, such as price or inventory changes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;status&quot;: &quot;delivered&quot;, &quot;estimatedArrival&quot;: &quot;2023-12-31T12:00:00Z&quot;}</para>
            /// </summary>
            [NameInMap("iOSLiveActivityContentState")]
            [Validation(Required=false)]
            public string IOSLiveActivityContentState { get; set; }

            /// <summary>
            /// <para>The time until which an ended Live Activity remains on the lock screen. The maximum duration is 4 hours.</para>
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
            /// <para>The Live Activity ID reported by the device to your server. This is the unique identifier for a Live Activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66B94673-B32E-4CA7-863C-3E523054FD46</para>
            /// </summary>
            [NameInMap("iOSLiveActivityId")]
            [Validation(Required=false)]
            public string IOSLiveActivityId { get; set; }

            /// <summary>
            /// <para>A UNIX timestamp in seconds that marks the content of the activity as outdated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1743131967</para>
            /// </summary>
            [NameInMap("iOSLiveActivityStaleDate")]
            [Validation(Required=false)]
            public long? IOSLiveActivityStaleDate { get; set; }

            /// <summary>
            /// <para>The sound for the iOS notification. Specify the name of the audio file stored in the app bundle or the Library/Sounds directory of the sandbox. For more information, see How to set notification sounds for iOS pushes.</para>
            /// <para>If you specify an empty string (&quot;&quot;), the notification is silent. If you do not set this parameter, the default value is \&quot;default\&quot;, which is the system alert sound.</para>
            /// 
            /// <b>Example:</b>
            /// <para>””</para>
            /// </summary>
            [NameInMap("iOSMusic")]
            [Validation(Required=false)]
            public string IOSMusic { get; set; }

            /// <summary>
            /// <para>The mutable content flag for iOS notifications (for iOS 10 and later). If set to true, notifications pushed through APNs can be processed by an extension before being displayed. For silent notifications, this must be set to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("iOSMutableContent")]
            [Validation(Required=false)]
            public bool? IOSMutableContent { get; set; }

            /// <summary>
            /// <para>Specifies the iOS notification category (for iOS 10 and later).</para>
            /// 
            /// <b>Example:</b>
            /// <para>ios</para>
            /// </summary>
            [NameInMap("iOSNotificationCategory")]
            [Validation(Required=false)]
            public string IOSNotificationCategory { get; set; }

            /// <summary>
            /// <para>If a device receives messages with the same CollapseId, they are merged into one. If the device is offline and receives multiple messages with the same CollapseId, only one is displayed in the notification bar. This parameter is supported on iOS 10 and later.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZD2011</para>
            /// </summary>
            [NameInMap("iOSNotificationCollapseId")]
            [Validation(Required=false)]
            public string IOSNotificationCollapseId { get; set; }

            /// <summary>
            /// <para>Groups iOS remote notifications using this property. It marks the identifier for a collapsed group. This is supported only on iOS 12.0 and later.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("iOSNotificationThreadId")]
            [Validation(Required=false)]
            public string IOSNotificationThreadId { get; set; }

            /// <summary>
            /// <para>The score for highlighting the summary. The value must be a floating-point number from 0 to 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.01</para>
            /// </summary>
            [NameInMap("iOSRelevanceScore")]
            [Validation(Required=false)]
            public double? IOSRelevanceScore { get; set; }

            /// <summary>
            /// <para>If a device is offline when a message is pushed (meaning the persistent connection to the Mobile Push server is unavailable), this push is sent once as a notification through the Apple APNs channel.</para>
            /// <remarks>
            /// <para>Converting offline messages to notifications is only applicable to the production environment.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("iOSRemind")]
            [Validation(Required=false)]
            public bool? IOSRemind { get; set; }

            /// <summary>
            /// <para>The content of the iOS notification when an iOS message is converted to a notification. This parameter is valid only when iOSApnsEnv is set to PRODUCT and iOSRemind is set to true.</para>
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
            /// <para>The subtitle of the iOS notification (for iOS 10 and later).</para>
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
