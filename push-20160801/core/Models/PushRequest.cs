// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class PushRequest : TeaModel {
        /// <summary>
        /// <para>The activity to be opened by the notification.</para>
        /// <para>This parameter is passed only when AndroidOpenType is set to ACTIVITY. Example: <c>com.alibaba.cloudpushdemo.bizactivity</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.alibaba.cloudpushdemo.bizactivity</para>
        /// </summary>
        [NameInMap("AndroidActivity")]
        [Validation(Required=false)]
        public string AndroidActivity { get; set; }

        /// <summary>
        /// <para>The increment value for the badge. The value is added to the current badge number. Valid values: 1 to 99.</para>
        /// <remarks>
        /// <para>This parameter is valid only for push notifications sent through the Huawei or Honor vendor channel. If both AndroidBadgeAddNum and AndroidBadgeSetNum are specified, AndroidBadgeSetNum takes precedence.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AndroidBadgeAddNum")]
        [Validation(Required=false)]
        public int? AndroidBadgeAddNum { get; set; }

        /// <summary>
        /// <para>The fully qualified class name of the entry Activity for badge settings.</para>
        /// <remarks>
        /// <para>This parameter is valid only for push notifications sent through the Huawei or Honor vendor channel.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>com.alibaba.cloudpushdemo.bizactivity</para>
        /// </summary>
        [NameInMap("AndroidBadgeClass")]
        [Validation(Required=false)]
        public string AndroidBadgeClass { get; set; }

        /// <summary>
        /// <para>The fixed number for the badge. Valid values: 0 to 99.</para>
        /// <remarks>
        /// <para>This parameter takes effect only on the Huawei and Honor channels when push notifications are sent through vendor channels. When push notifications are sent through the Alibaba Cloud proprietary channel, this parameter takes effect only on Huawei, Honor, and vivo devices.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("AndroidBadgeSetNum")]
        [Validation(Required=false)]
        public int? AndroidBadgeSetNum { get; set; }

        /// <summary>
        /// <para>The body in long text mode. Maximum length: 1,000 bytes. One Chinese character counts as 3 bytes. The actual limit is subject to the specific vendor channel during delivery.</para>
        /// <para>Currently supported by:</para>
        /// <list type="bullet">
        /// <item><description><para>Huawei: EMUI 10 and later.</para>
        /// </description></item>
        /// <item><description><para>Honor: Magic UI 4.0 and later.</para>
        /// </description></item>
        /// <item><description><para>Xiaomi: MIUI 10 and later.</para>
        /// </description></item>
        /// <item><description><para>OPPO: ColorOS 5.0 and later.</para>
        /// </description></item>
        /// <item><description><para>Meizu: Flyme. </para>
        /// </description></item>
        /// <item><description><para>Proprietary channel: Android SDK 3.6.0 and later.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not provided in long text mode, the first non-empty value from Body and AndroidPopupBody is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Sample long text</para>
        /// </summary>
        [NameInMap("AndroidBigBody")]
        [Validation(Required=false)]
        public string AndroidBigBody { get; set; }

        /// <summary>
        /// <para>The image URL in big image mode. Currently supported by the proprietary channel for Android SDK 3.6.0 and later.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://imag.example.com/image.png">https://imag.example.com/image.png</a></para>
        /// </summary>
        [NameInMap("AndroidBigPictureUrl")]
        [Validation(Required=false)]
        public string AndroidBigPictureUrl { get; set; }

        /// <summary>
        /// <para>The title in long text mode. Maximum length: 200 bytes. One Chinese character counts as 3 bytes.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is currently supported only by the Honor channel and the Huawei channel for EMUI 11 and later.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is not provided in long text mode, the first non-empty value from Title and AndroidPopupTitle is used.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Sample long title</para>
        /// </summary>
        [NameInMap("AndroidBigTitle")]
        [Validation(Required=false)]
        public string AndroidBigTitle { get; set; }

        /// <summary>
        /// <para>The extended attributes of the notification. This attribute does not take effect when the push type PushType is set to MESSAGE.</para>
        /// <para>This parameter must be passed in JSON map format. Otherwise, a parsing error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key1&quot;:&quot;value1&quot;,&quot;api_name&quot;:&quot;PushNoticeToAndroidRequest&quot;}</para>
        /// </summary>
        [NameInMap("AndroidExtParameters")]
        [Validation(Required=false)]
        public string AndroidExtParameters { get; set; }

        /// <summary>
        /// <para>The notification type for the Honor channel. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Formal notification. This is the default value.</description></item>
        /// <item><description><b>1</b>: Test notification.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Each app can send 1,000 test notifications per day, which is not subject to the daily push limit per device.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AndroidHonorTargetUserType")]
        [Validation(Required=false)]
        public int? AndroidHonorTargetUserType { get; set; }

        /// <summary>
        /// <para>The Huawei fast notification parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Send Huawei standard notifications. This is the default value.</description></item>
        /// <item><description><b>1</b>: Send Huawei fast notifications.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AndroidHuaweiBusinessType")]
        [Validation(Required=false)]
        public int? AndroidHuaweiBusinessType { get; set; }

        /// <summary>
        /// <para>The JSON string of the Huawei Android Live Notification data structure <a href="https://developer.huawei.com/consumer/cn/doc/HMSCore-References/rest-live-0000001562939968#ZH-CN_TOPIC_0000001700850537__p195121620102511">LiveNotificationPayload</a>. For development and integration, refer to the <a href="https://help.aliyun.com/document_detail/2983768.html">Huawei Live Notification push guide</a>.</para>
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
        /// <para>The receipt ID for the Huawei channel. You can view this receipt ID in the receipt parameter settings of the Huawei push operations platform.</para>
        /// <remarks>
        /// <para>If the default receipt configuration on the Huawei push operations platform is set to the Alibaba Cloud receipt, this parameter is not required. Otherwise, we recommend that you configure the default receipt ID for the Huawei channel in the Alibaba Cloud EMAS Mobile Push console first.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RCP4C123456</para>
        /// </summary>
        [NameInMap("AndroidHuaweiReceiptId")]
        [Validation(Required=false)]
        public string AndroidHuaweiReceiptId { get; set; }

        /// <summary>
        /// <para>The notification type for the Huawei channel. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Formal notification. This is the default value.</description></item>
        /// <item><description><b>1</b>: Test notification.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Each app can send 500 test notifications per day, which is not subject to the daily push limit per device.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AndroidHuaweiTargetUserType")]
        [Validation(Required=false)]
        public int? AndroidHuaweiTargetUserType { get; set; }

        /// <summary>
        /// <para>The URL of the right-side icon. Currently supported by:</para>
        /// <list type="bullet">
        /// <item><description><para>Huawei EMUI: applicable only in long text mode and inbox mode.</para>
        /// </description></item>
        /// <item><description><para>Honor Magic UI: applicable only in long text mode.</para>
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
        /// <para>The body in inbox mode. The content must be a valid JSON array with no more than 5 elements. Currently supported by:</para>
        /// <list type="bullet">
        /// <item><description>Huawei: EMUI 9 and later.</description></item>
        /// <item><description>Honor: Magic UI 4.0 and later.</description></item>
        /// <item><description>Xiaomi: MIUI 10 and later.</description></item>
        /// <item><description>OPPO: ColorOS 5.0 and later.</description></item>
        /// <item><description>Proprietary channel: Android SDK 3.6.0 and later.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;First line&quot;,&quot;Second line&quot;]</para>
        /// </summary>
        [NameInMap("AndroidInboxBody")]
        [Validation(Required=false)]
        public string AndroidInboxBody { get; set; }

        /// <summary>
        /// <para>The Meizu message type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Public message. This is the default value.</description></item>
        /// <item><description>1: Private message.</description></item>
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
        /// <para>Purpose 1: After you complete the <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/message-classification-0000001149358835?#section3410731125514">self-classification permission application</a>, this parameter is used to identify the message type and determine the <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/message-classification-0000001149358835#ZH-CN_TOPIC_0000001149358835__p3850133955718">message reminder method</a>. It accelerates the delivery of specific types of messages. For valid values, refer to the <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/message-classification-0000001149358835#section1076611477914">message classification standards</a> in the official Huawei push documentation, and fill in the &quot;Cloud notification category value&quot; or &quot;Local notification category value&quot; in the documentation table.</para>
        /// <para>Purpose 2: After you <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/faq-0000001050042183#section037425218509">apply for special permissions</a>, this parameter is used to identify high-priority pass-through scenarios. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>VOIP: Audio and video calls.</description></item>
        /// <item><description>PLAY_VOICE: Voice broadcast.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For messages whose &quot;Cloud notification category value&quot; is &quot;Not involved&quot;, the Alibaba Cloud proprietary channel is used. For messages whose &quot;Local notification category value&quot; is &quot;Not involved&quot;, the Huawei channel is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>VOIP</para>
        /// </summary>
        [NameInMap("AndroidMessageHuaweiCategory")]
        [Validation(Required=false)]
        public string AndroidMessageHuaweiCategory { get; set; }

        /// <summary>
        /// <para>The delivery priority of Huawei channel notifications. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HIGH</b></description></item>
        /// <item><description><b>NORMAL</b></description></item>
        /// </list>
        /// <para>You must apply for the permission. For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/faq-0000001050042183#section037425218509">Application link</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HIGH</para>
        /// </summary>
        [NameInMap("AndroidMessageHuaweiUrgency")]
        [Validation(Required=false)]
        public string AndroidMessageHuaweiUrgency { get; set; }

        /// <summary>
        /// <para>OPPO message categorization includes two categories for management: Communication and Service, and Content and Marketing.</para>
        /// <para>Communication and Service (permission application required):</para>
        /// <list type="bullet">
        /// <item><description>IM: Instant chat, audio, and video calls.</description></item>
        /// <item><description>ACCOUNT: Individual account and asset changes.</description></item>
        /// <item><description>DEVICE_REMINDER: Personal device reminders.</description></item>
        /// <item><description>ORDER: Personal order and logistics status changes.</description></item>
        /// <item><description>TODO: Personal schedules and to-dos.</description></item>
        /// <item><description>SUBSCRIPTION: Individual subscribe.</description></item>
        /// </list>
        /// <para>Content and Marketing:</para>
        /// <list type="bullet">
        /// <item><description>NEWS: News and information.</description></item>
        /// <item><description>CONTENT: Content recommendations.</description></item>
        /// <item><description>MARKETING: Platform activities.</description></item>
        /// <item><description>SOCIAL: Social updates.</description></item>
        /// </list>
        /// <para>For more information, see <a href="https://open.oppomobile.com/new/developmentDoc/info?id=13189">OPUSH message classification rules</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MARKETING</para>
        /// </summary>
        [NameInMap("AndroidMessageOppoCategory")]
        [Validation(Required=false)]
        public string AndroidMessageOppoCategory { get; set; }

        /// <summary>
        /// <para>The reminder level of OPPO channel notification bar messages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Notification bar.</description></item>
        /// <item><description>2: Notification bar, lock screen, ringtone, and vibrate. This is the default notification level for Communication and Service messages.</description></item>
        /// <item><description>16: Notification bar, lock screen, ringtone, vibrate, and banner. Permission application is required.</description></item>
        /// </list>
        /// <remarks>
        /// <para>When you use the AndroidMessageOppoNotifyLevel parameter, you must also pass the AndroidMessageOppoCategory parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AndroidMessageOppoNotifyLevel")]
        [Validation(Required=false)]
        public int? AndroidMessageOppoNotifyLevel { get; set; }

        /// <summary>
        /// <para>vivo message categorization includes two categories for management: System Messages and Operation Messages.
        /// System Messages:</para>
        /// <list type="bullet">
        /// <item><description>IM: Instant messages.</description></item>
        /// <item><description>ACCOUNT: Accounts and assets.</description></item>
        /// <item><description>TODO: Schedules and to-dos.</description></item>
        /// <item><description>DEVICE_REMINDER: Device information.</description></item>
        /// <item><description>ORDER: Orders and logistics.</description></item>
        /// <item><description>SUBSCRIPTION: subscribe reminders.</description></item>
        /// </list>
        /// <para>Operation Messages:</para>
        /// <list type="bullet">
        /// <item><description>NEWS: News.</description></item>
        /// <item><description>CONTENT: Content recommendations.</description></item>
        /// <item><description>MARKETING: Operational activity.</description></item>
        /// <item><description>SOCIAL: Social updates.</description></item>
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
        /// <para>The notification sound for the Huawei vendor channel. Specify the name of the audio file stored in the <c>app/src/main/res/raw/</c> directory of the client project. Do not include the file extension.
        /// If this parameter is not specified, the default ringtone is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alicloud_notification_sound</para>
        /// </summary>
        [NameInMap("AndroidMusic")]
        [Validation(Required=false)]
        public string AndroidMusic { get; set; }

        /// <summary>
        /// <para>The priority of the Android notification display position in the notification bar. Valid values: -2, -1, 0, 1, and 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AndroidNotificationBarPriority")]
        [Validation(Required=false)]
        public int? AndroidNotificationBarPriority { get; set; }

        /// <summary>
        /// <para>The custom notification bar style for Android. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AndroidNotificationBarType")]
        [Validation(Required=false)]
        public int? AndroidNotificationBarType { get; set; }

        /// <summary>
        /// <para>The channel ID of the Android app. It must correspond to the channel ID in the app.</para>
        /// <list type="bullet">
        /// <item><description>For more information about how to set the NotificationChannel parameter, see <a href="https://help.aliyun.com/document_detail/67398.html">FAQ: Notifications are not received on Android 8.0 and later devices</a>.</description></item>
        /// <item><description>Because the channel_id of the OPPO private message channel is the same as the channel ID of the app, this value is used as the channel_id when pushing through the OPPO channel.</description></item>
        /// <item><description>This value is used as the channel_id when pushing through the Huawei, FCM, and Alibaba Cloud proprietary channels.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AndroidNotificationChannel")]
        [Validation(Required=false)]
        public string AndroidNotificationChannel { get; set; }

        /// <summary>
        /// <para>The message group. For messages in the same group, only the latest message and the total number of messages received by the group are displayed in the notification bar. All messages are not displayed and cannot be expanded. Currently supported by:</para>
        /// <list type="bullet">
        /// <item><description>Huawei vendor channel.</description></item>
        /// <item><description>Honor vendor channel.</description></item>
        /// <item><description>Proprietary channel: Android SDK 3.9.1 and earlier.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The proprietary channel no longer supports this parameter in Android SDK 3.9.2 and later.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>group-1</para>
        /// </summary>
        [NameInMap("AndroidNotificationGroup")]
        [Validation(Required=false)]
        public string AndroidNotificationGroup { get; set; }

        /// <summary>
        /// <para>The importance parameter for Honor notification message classification, which determines the notification behavior on user devices. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>LOW</b>: Information and marketing messages.</description></item>
        /// <item><description><b>NORMAL</b>: Service and communication messages.</description></item>
        /// </list>
        /// <para>You must apply for this permission on the Honor platform. For more information, see <a href="https://developer.honor.com/cn/docs/11002/guides/notification-class#%E8%87%AA%E5%88%86%E7%B1%BB%E6%9D%83%E7%9B%8A%E7%94%B3%E8%AF%B7">Application link</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LOW</para>
        /// </summary>
        [NameInMap("AndroidNotificationHonorChannel")]
        [Validation(Required=false)]
        public string AndroidNotificationHonorChannel { get; set; }

        /// <summary>
        /// <para>The importance parameter for Huawei notification message classification, which determines the notification behavior on user devices. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>LOW: Information and marketing messages.</description></item>
        /// <item><description>NORMAL: Service and communication messages.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Use AndroidMessageHuaweiCategory for notification classification in the Huawei channel. AndroidNotificationHuaweiChannel is no longer required.</description></item>
        /// <item><description>You must apply for this permission on the Huawei platform. For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/message-classification-0000001149358835#section893184112272">Application link</a>.</description></item>
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
        /// <para>The unique identifier of each message when displayed in the notification bar. Different notification bar messages can use the same NotifyId to allow new notification bar messages to overwrite old ones.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100001</para>
        /// </summary>
        [NameInMap("AndroidNotificationNotifyId")]
        [Validation(Required=false)]
        public int? AndroidNotificationNotifyId { get; set; }

        /// <summary>
        /// <para>The message thread ID. Messages in the same group are collapsed and can be expanded in the notification bar. Notifications in different groups are displayed separately. Currently supported by:</para>
        /// <list type="bullet">
        /// <item><description>Proprietary channel: Android SDK 3.9.2 and later.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>thread-1</para>
        /// </summary>
        [NameInMap("AndroidNotificationThreadId")]
        [Validation(Required=false)]
        public string AndroidNotificationThreadId { get; set; }

        /// <summary>
        /// <para>The vivo notification message classification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Operation messages. This is the default value.</description></item>
        /// <item><description>1: System messages.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Use AndroidMessageVivoCategory for notification classification in the vivo channel. AndroidNotificationVivoChannel is no longer required.</description></item>
        /// <item><description>You must apply for this permission on the vivo platform. For more information, see <a href="https://dev.vivo.com.cn/documentCenter/doc/359">Application link</a>.</description></item>
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
        /// <para>The channel ID for Xiaomi notification types. You must apply for it on the Xiaomi platform. For more information, see <a href="https://dev.mi.com/console/doc/detail?pId=2422#_4">Application link</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>A single app can apply for a maximum of 8 channels on the Xiaomi channel. Plan ahead.</description></item>
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
        /// <para>The reminder method of the notification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VIBRATE</b>: Vibrate. This is the default value.</description></item>
        /// <item><description><b>SOUND</b>: Sound.</description></item>
        /// <item><description><b>BOTH</b>: Sound and vibrate.</description></item>
        /// <item><description><b>NONE</b>: Silent.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BOTH</para>
        /// </summary>
        [NameInMap("AndroidNotifyType")]
        [Validation(Required=false)]
        public string AndroidNotifyType { get; set; }

        /// <summary>
        /// <para>The action performed after the notification is clicked. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>APPLICATION</b>: Open the app. This is the default value.</description></item>
        /// <item><description><b>ACTIVITY</b>: Open the specified Android activity.</description></item>
        /// <item><description><b>URL</b>: Open the specified URL.</description></item>
        /// <item><description><b>NONE</b>: No redirection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>APPLICATION</para>
        /// </summary>
        [NameInMap("AndroidOpenType")]
        [Validation(Required=false)]
        public string AndroidOpenType { get; set; }

        /// <summary>
        /// <para>The URL to be opened after the Android device receives the push.</para>
        /// <para>This parameter is passed only when AndroidOpenType is set to URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.example.com">https://www.example.com</a></para>
        /// </summary>
        [NameInMap("AndroidOpenUrl")]
        [Validation(Required=false)]
        public string AndroidOpenUrl { get; set; }

        /// <summary>
        /// <para>The JSON character string of the OPPO Fluid Cloud intent delete data structure <a href="https://open.oppomobile.com/documentation/page/info?id=13578">data</a>. This parameter is invalid when the AndroidOppoIntelligentIntent parameter is specified. For development and integration, see References: <a href="https://help.aliyun.com/document_detail/2997310.html">OPPO Fluid Cloud push guide</a>.</para>
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
        /// <para>The JSON character string of the OPPO Fluid Cloud intent sharing data structure <a href="https://open.oppomobile.com/documentation/page/info?id=13565">IntelligentIntent</a>. For development and integration, see References: <a href="https://help.aliyun.com/document_detail/2997310.html">OPPO Fluid Cloud push guide</a>.</para>
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
        /// <para>The push environment for OPPO Fluid Cloud. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Formal environment. This is the default value.</description></item>
        /// <item><description><b>1</b>: Test environment.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For the OPPO Fluid Cloud test environment, refer to <a href="https://open.oppomobile.com/documentation/page/info?id=13590">Environment setup</a> to set up the client.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AndroidOppoIntentEnv")]
        [Validation(Required=false)]
        public int? AndroidOppoIntentEnv { get; set; }

        /// <summary>
        /// <para>The content parameters for the OPPO private message template.</para>
        /// </summary>
        [NameInMap("AndroidOppoPrivateContentParameters")]
        [Validation(Required=false)]
        public Dictionary<string, string> AndroidOppoPrivateContentParameters { get; set; }

        /// <summary>
        /// <para>The OPPO private message template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>687557242b1634hzefs3d5013</para>
        /// </summary>
        [NameInMap("AndroidOppoPrivateMsgTemplateId")]
        [Validation(Required=false)]
        public string AndroidOppoPrivateMsgTemplateId { get; set; }

        /// <summary>
        /// <para>The title parameters for the OPPO private message template.</para>
        /// </summary>
        [NameInMap("AndroidOppoPrivateTitleParameters")]
        [Validation(Required=false)]
        public Dictionary<string, string> AndroidOppoPrivateTitleParameters { get; set; }

        /// <summary>
        /// <para>The activity to which the user is redirected after the notification is clicked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.alibaba.cloudpushdemo.bizactivity</para>
        /// </summary>
        [NameInMap("AndroidPopupActivity")]
        [Validation(Required=false)]
        public string AndroidPopupActivity { get; set; }

        /// <summary>
        /// <para>The body content in auxiliary pop-up window mode. This parameter is required when the <b>AndroidPopupActivity</b> parameter is not empty.</para>
        /// <para>Maximum length: 200 characters. Both Chinese and English characters count as one character.</para>
        /// <para>If a vendor channel is used, the limits of the vendor channel must also be met. For more information, see <a href="https://help.aliyun.com/document_detail/165253.html">Limits on auxiliary channel pushes for Android</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello</para>
        /// </summary>
        [NameInMap("AndroidPopupBody")]
        [Validation(Required=false)]
        public string AndroidPopupBody { get; set; }

        /// <summary>
        /// <para>The title content in auxiliary pop-up window mode. This parameter is required when the <b>AndroidPopupActivity</b> parameter is not empty. </para>
        /// <para>Maximum length: 50 characters. Both Chinese and English characters count as one character.</para>
        /// <para>If a vendor channel is used, the limits of the vendor channel must also be met. For more information, see <a href="https://help.aliyun.com/document_detail/165253.html">Limits on auxiliary channel pushes for Android</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello</para>
        /// </summary>
        [NameInMap("AndroidPopupTitle")]
        [Validation(Required=false)]
        public string AndroidPopupTitle { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the auxiliary pop-up window feature when the device is offline during a message push. Default value: false. This parameter takes effect only when PushType is set to MESSAGE.</para>
        /// <para>If the message is successfully converted into a notification and pushed, the data displayed in the received notification is the values of the AndroidPopupTitle and AndroidPopupBody parameters set on the server. The data obtained in the onSysNoticeOpened method of the auxiliary pop-up window when the notification is clicked is the values of the Title and Body parameters set on the server.</para>
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
        /// <item><description><b>0</b>: Standard mode. This is the default value.</description></item>
        /// <item><description><b>1</b>: Long text mode. Supported by Huawei, Honor, Xiaomi, OPPO, Meizu, and the proprietary channel.</description></item>
        /// <item><description><b>2</b>: Big image mode. Supported by the proprietary channel, but not supported by Xiaomi devices.</description></item>
        /// <item><description><b>3</b>: Inbox mode. Supported by Huawei, Honor, Xiaomi, OPPO, and the proprietary channel.<remarks>
        /// <para>If a non-standard mode is used, this parameter must be provided.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AndroidRenderStyle")]
        [Validation(Required=false)]
        public int? AndroidRenderStyle { get; set; }

        /// <summary>
        /// <para>Settings for the vendor channel notification type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Formal notification. This is the default value.</description></item>
        /// <item><description><b>1</b>: Test notification.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>These parameter settings are equivalent to configuring the AndroidHuaweiTargetUserType, AndroidHonorTargetUserType, AndroidVivoPushMode, and AndroidOppoIntentEnv parameters at the same time. The corresponding parameters for specific vendor channels can overwrite this parameter.</description></item>
        /// <item><description>Currently supported by: Huawei channel, Honor channel, vivo channel, and OPPO Fluid Cloud.</description></item>
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
        /// <para>The JSON character string of the vivo Atomic Island data structure <a href="https://dev.vivo.com.cn/documentCenter/doc/896#s-fdagzbd4">liveMessage</a>. For development and integration, see References: <a href="https://www.alibabacloud.com/help/en/document_detail/3030718.html">vivo Atomic Island push guide</a>.</para>
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
        /// <para>The notification type for the vivo channel. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Formal push. This is the default value.</description></item>
        /// <item><description><b>1</b>: Test push.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For test pushes, configure test devices in the vivo console in advance. You can search for &quot;onReceiveRegId regId&quot; in the device startup logs to obtain the RegId of the test device.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AndroidVivoPushMode")]
        [Validation(Required=false)]
        public int? AndroidVivoPushMode { get; set; }

        /// <summary>
        /// <para>The receipt ID for the vivo channel. You can view this receipt ID in the application information of the push service on the vivo Open Platform.</para>
        /// <remarks>
        /// <para>If the default receipt configuration on the vivo Open Platform is set to the Alibaba Cloud receipt, this parameter is not required. Otherwise, we recommend that you configure the default receipt ID for the vivo channel in the Alibaba Cloud EMAS Mobile Push console first.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("AndroidVivoReceiptId")]
        [Validation(Required=false)]
        public string AndroidVivoReceiptId { get; set; }

        /// <summary>
        /// <para>The vivo template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t1-ge3-lq</para>
        /// </summary>
        [NameInMap("AndroidVivoTemplateId")]
        [Validation(Required=false)]
        public string AndroidVivoTemplateId { get; set; }

        /// <summary>
        /// <para>The parameters for the vivo template. The value is a JSON object string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;keywords1&quot;:&quot;S123&quot;}</para>
        /// </summary>
        [NameInMap("AndroidVivoTemplateParams")]
        [Validation(Required=false)]
        public string AndroidVivoTemplateParams { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> This parameter is deprecated. All third-party auxiliary pop-up windows are uniformly supported by the new <b>AndroidPopupActivity</b> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AndroidXiaoMiActivity")]
        [Validation(Required=false)]
        [Obsolete]
        public string AndroidXiaoMiActivity { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> This parameter is deprecated. All third-party auxiliary pop-up windows are uniformly supported by the new <b>AndroidPopupBody</b> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AndroidXiaoMiNotifyBody")]
        [Validation(Required=false)]
        [Obsolete]
        public string AndroidXiaoMiNotifyBody { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> This parameter is deprecated. All third-party auxiliary pop-up windows are uniformly supported by the new <b>AndroidPopupTitle</b> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AndroidXiaoMiNotifyTitle")]
        [Validation(Required=false)]
        [Obsolete]
        public string AndroidXiaoMiNotifyTitle { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Starting from August 2023, Xiaomi officially no longer supports dynamically setting small icons, right-side icons, and big images during pushes on new devices and systems.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://f6.market.xiaomi.com/download/MiPass/aaa/bbb.png">https://f6.market.xiaomi.com/download/MiPass/aaa/bbb.png</a></para>
        /// </summary>
        [NameInMap("AndroidXiaomiBigPictureUrl")]
        [Validation(Required=false)]
        [Obsolete]
        public string AndroidXiaomiBigPictureUrl { get; set; }

        /// <summary>
        /// <para>The JSON character string of the Xiaomi Hyper Island data structure <a href="https://dev.mi.com/xiaomihyperos/documentation/detail?pId=2131">miui.focus.param</a>. For development and integration, see References: <a href="https://www.alibabacloud.com/help/en/document_detail/3037956.html">Xiaomi Hyper Island push guide</a>.</para>
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
        /// <para>The JSON character string of the Xiaomi Hyper Island image data <a href="https://dev.mi.com/xiaomihyperos/documentation/detail?pId=2131">miui.focus.pic_xxx</a>. For development and integration, see References: <a href="https://www.alibabacloud.com/help/en/document_detail/3037956.html">Xiaomi Hyper Island push guide</a>.</para>
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
        /// <para><b>[Deprecated]</b> Starting from August 2023, Xiaomi officially no longer supports dynamically setting small icons, right-side icons, and big images during pushes on new devices and systems.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://imag.example.com/image.png">https://imag.example.com/image.png</a></para>
        /// </summary>
        [NameInMap("AndroidXiaomiImageUrl")]
        [Validation(Required=false)]
        [Obsolete]
        public string AndroidXiaomiImageUrl { get; set; }

        /// <summary>
        /// <para>The Xiaomi private message template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>P10645</para>
        /// </summary>
        [NameInMap("AndroidXiaomiTemplateId")]
        [Validation(Required=false)]
        public string AndroidXiaomiTemplateId { get; set; }

        /// <summary>
        /// <para>The parameters for the Xiaomi private message template. The value is a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;keywords1&quot;:&quot;Tom&quot;,&quot;keywords2&quot;:&quot;phone&quot;}</para>
        /// </summary>
        [NameInMap("AndroidXiaomiTemplateParams")]
        [Validation(Required=false)]
        public string AndroidXiaomiTemplateParams { get; set; }

        /// <summary>
        /// <para>The AppKey information.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23267207</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        /// <summary>
        /// <para>The content of the notification or message for Android and HarmonyOS pushes, or the content of the iOS message or notification. The content size is limited. For more information, see <a href="https://help.aliyun.com/document_detail/434629.html">Limits</a>.</para>
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
        /// <item><description><b>HARMONY</b>: HarmonyOS devices.</description></item>
        /// <item><description><b>iOS</b>: iOS devices.</description></item>
        /// <item><description><b>ANDROID</b>: Android devices.</description></item>
        /// <item><description><b>ALL</b>: If the AppKey belongs to a legacy dual-platform app, this value indicates that the push is sent to both Android and iOS devices. If the AppKey belongs to a new single-platform app, this value has the same effect as specifying the device type corresponding to the app type.</description></item>
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
        /// <para>The expiration time of offline messages and notifications. This parameter is used together with StoreOffline. Expired messages and notifications are not delivered. The maximum retention period is 72 hours. Default value: 72 hours.</para>
        /// <para>The time must be in the ISO 8601 standard format and use UTC time. Format: YYYY-MM-DDThh:mm:ssZ. The expiration time cannot be earlier than the current time or the scheduled delivery time plus 3 seconds (ExpireTime &gt; PushTime + 3 seconds). The 3 seconds are reserved to compensate for network and system latency. Set the expiration time to at least 1 minute for single pushes and at least 10 minutes for full pushes and batch pushes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-02-20T00:00:00Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The action corresponding to the ability of the built-in page in the application.</para>
        /// <remarks>
        /// <para>Notice: When HarmonyActionType is set to APP_CUSTOM_PAGE, you must specify at least one of the HarmonyUri and HarmonyAction fields.
        /// For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section152462191216">ClickAction.action</a> on the HarmonyOS official website.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>com.example.action</para>
        /// </summary>
        [NameInMap("HarmonyAction")]
        [Validation(Required=false)]
        public string HarmonyAction { get; set; }

        /// <summary>
        /// <para>The action to perform after the notification is tapped. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>APP_HOME_PAGE: Opens the application home page.</description></item>
        /// <item><description>APP_CUSTOM_PAGE: Opens a custom page in the application.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>APP_HOME_PAGE</para>
        /// </summary>
        [NameInMap("HarmonyActionType")]
        [Validation(Required=false)]
        public string HarmonyActionType { get; set; }

        /// <summary>
        /// <para>The increment value for the badge of the HarmonyOS application. For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section266310382145">Description of the addNum field for HarmonyOS badges</a>.</br>
        /// This parameter is supported in HarmonyOS SDK 1.2.0 and later.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HarmonyBadgeAddNum")]
        [Validation(Required=false)]
        public int? HarmonyBadgeAddNum { get; set; }

        /// <summary>
        /// <para>The fixed number for the badge of the HarmonyOS application. For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section266310382145">Description of the setNum field for HarmonyOS badges</a>.
        /// This parameter is supported in HarmonyOS SDK 1.2.0 and later.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HarmonyBadgeSetNum")]
        [Validation(Required=false)]
        public int? HarmonyBadgeSetNum { get; set; }

        /// <summary>
        /// <para>The category of the notification message. After you apply for the notification message auto-categorization permission, this parameter is used as the identity of the message type. Different notification message types affect the display and reminder methods of the message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IM: Instant chat.</description></item>
        /// <item><description>VOIP: Audio and video calls.</description></item>
        /// <item><description>SUBSCRIPTION: subscribe.</description></item>
        /// <item><description>TRAVEL: Travel.</description></item>
        /// <item><description>HEALTH: Health.</description></item>
        /// <item><description>WORK: Work reminders.</description></item>
        /// <item><description>ACCOUNT: Account updates.</description></item>
        /// <item><description>EXPRESS: Orders and logistics.</description></item>
        /// <item><description>FINANCE: Finance.</description></item>
        /// <item><description>DEVICE_REMINDER: Device reminders.</description></item>
        /// <item><description>MAIL: Emails.</description></item>
        /// <item><description>CUSTOMER_SERVICE: Customer service messages.</description></item>
        /// <item><description>MARKETING: News, content recommendations, social updates, product promotions, financial updates, lifestyle information, surveys, feature recommendations, and operational activity. This category only serves as the identity for the content and does not send messages faster. These are collectively referred to as information and marketing messages.</description></item>
        /// </list>
        /// <para>For details, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section17371529101117">Notification.category</a> on the HarmonyOS official website.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IM</para>
        /// </summary>
        [NameInMap("HarmonyCategory")]
        [Validation(Required=false)]
        public string HarmonyCategory { get; set; }

        /// <summary>
        /// <para>The extended attributes of the notification. This attribute does not take effect when the push type PushType is set to MESSAGE.</para>
        /// <para>This parameter must be passed in JSON map format. Otherwise, a parsing error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key1&quot;:&quot;value1&quot;,&quot;api_name&quot;:&quot;PushNoticeToAndroidRequest&quot;}</para>
        /// </summary>
        [NameInMap("HarmonyExtParameters")]
        [Validation(Required=false)]
        public string HarmonyExtParameters { get; set; }

        /// <summary>
        /// <para>The extra data for the extended notification message.</br>
        /// This parameter is valid when you send HarmonyOS extended notification messages.</br>
        /// This parameter is conceptually equivalent to the extraData field of a HarmonyOS extended notification message. For the specific definition, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section161192514234">HarmonyOS ExtensionPayload description</a>.</br>
        /// This parameter is supported in HarmonyOS SDK 1.2.0 and later.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample extra data</para>
        /// </summary>
        [NameInMap("HarmonyExtensionExtraData")]
        [Validation(Required=false)]
        public string HarmonyExtensionExtraData { get; set; }

        /// <summary>
        /// <para>Specifies whether to send a HarmonyOS extended notification message when PushType is set to NOTICE. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Sends an extended notification message.</description></item>
        /// <item><description>false: Sends a normal notification message. This is the default value.
        /// You must apply for the required permissions on the HarmonyOS side before you can send extended notification messages. For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-guides-V5/push-send-extend-noti-V5">Sending extended notification messages</a> in the HarmonyOS documentation.</br>
        /// This parameter is supported in HarmonyOS SDK 1.2.0 and later.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HarmonyExtensionPush")]
        [Validation(Required=false)]
        public bool? HarmonyExtensionPush { get; set; }

        /// <summary>
        /// <para>The URL of the large icon on the right side of the notification. The URL must use the HTTPS protocol.</para>
        /// <remarks>
        /// <para>Supported image formats include PNG, JPG, JPEG, HEIF, GIF, and BMP. The product of the image width and height must be less than 25,000 pixels.
        /// For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section17371529101117">Notification.image</a> on the HarmonyOS official website.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/xxx.png">https://example.com/xxx.png</a></para>
        /// </summary>
        [NameInMap("HarmonyImageUrl")]
        [Validation(Required=false)]
        public string HarmonyImageUrl { get; set; }

        /// <summary>
        /// <para>The content for the multi-line text style. This field is required when HarmonyRenderStyle is set to MULTI_LINE. A maximum of three content items are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;1.content1&quot;,&quot;2.content2&quot;,&quot;3.content3&quot;]</para>
        /// </summary>
        [NameInMap("HarmonyInboxContent")]
        [Validation(Required=false)]
        public string HarmonyInboxContent { get; set; }

        /// <summary>
        /// <para>The JSON string of the HarmonyOS Live View data structure <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V13/push-scenariozed-api-request-param-V13#section66881469306">LiveViewPayload</a>. For development and integration, refer to the <a href="https://help.aliyun.com/document_detail/2982112.html">HarmonyOS Live View push guide</a>.</para>
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
        /// <para>The type of the notification channel to use. This parameter is valid only when the Alibaba Cloud proprietary channel is online. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SOCIAL_COMMUNICATION: Social communication.</description></item>
        /// <item><description>SERVICE_INFORMATION: Service reminders.</description></item>
        /// <item><description>CONTENT_INFORMATION: Content information.</description></item>
        /// <item><description>CUSTOMER_SERVICE: Customer service messages. This type is used for customer service messages between users and merchants, and must be initiated by the user.</description></item>
        /// <item><description>OTHER_TYPES: Other types.
        /// For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/js-apis-notificationmanager-V5#slottype">SlotType</a> on the HarmonyOS official website.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SOCIAL_COMMUNICATION</para>
        /// </summary>
        [NameInMap("HarmonyNotificationSlotType")]
        [Validation(Required=false)]
        public string HarmonyNotificationSlotType { get; set; }

        /// <summary>
        /// <para>The unique identifier of each message when the notification is displayed. If this parameter is not specified, the push service automatically generates a unique identifier for each message. Different notification messages can have the same notifyId to allow new messages to overwrite old ones.
        /// For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section17371529101117">Notification.notifyId</a> on the HarmonyOS official website.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HarmonyNotifyId")]
        [Validation(Required=false)]
        public int? HarmonyNotifyId { get; set; }

        /// <summary>
        /// <para>The receipt ID for the HarmonyOS channel. You can view this receipt ID in the receipt parameter settings of the HarmonyOS push operations platform.</para>
        /// <remarks>
        /// <para>If the default receipt configuration on the HarmonyOS push operations platform is set to the Alibaba Cloud receipt, this parameter is not required. Otherwise, we recommend that you configure the default receipt ID for the HarmonyOS channel in the Alibaba Cloud EMAS Mobile Push console first.
        /// For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section418321011212">pushOptions.receiptId</a> on the HarmonyOS official website.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RCPB***DFD5</para>
        /// </summary>
        [NameInMap("HarmonyReceiptId")]
        [Validation(Required=false)]
        public string HarmonyReceiptId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the auxiliary pop-up window feature when the device is offline and the push type is message. Default value: false. This parameter takes effect only when PushType is set to MESSAGE.
        /// If the message-to-notification push is successful, the notification displays the data specified by the HarmonyRemindTitle and HarmonyRemindBody parameters on the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HarmonyRemind")]
        [Validation(Required=false)]
        public bool? HarmonyRemind { get; set; }

        /// <summary>
        /// <para>The HarmonyOS notification content used when a message is converted to a notification. This parameter is valid only when HarmonyRemind is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You have a new message. Please check it</para>
        /// </summary>
        [NameInMap("HarmonyRemindBody")]
        [Validation(Required=false)]
        public string HarmonyRemindBody { get; set; }

        /// <summary>
        /// <para>The HarmonyOS notification title used when a message is converted to a notification. This parameter is valid only when HarmonyRemind is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>New message</para>
        /// </summary>
        [NameInMap("HarmonyRemindTitle")]
        [Validation(Required=false)]
        public string HarmonyRemindTitle { get; set; }

        /// <summary>
        /// <para>The style of the notification message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NORMAL: Normal notification. This is the default value.</description></item>
        /// <item><description>MULTI_LINE: Multi-line text style.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("HarmonyRenderStyle")]
        [Validation(Required=false)]
        public string HarmonyRenderStyle { get; set; }

        /// <summary>
        /// <para>The test message identifier. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: Normal message. This is the default value.</description></item>
        /// <item><description>true: Test message.
        /// For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section418321011212">pushOptions.testMessage</a> on the HarmonyOS official website.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HarmonyTestMessage")]
        [Validation(Required=false)]
        public bool? HarmonyTestMessage { get; set; }

        /// <summary>
        /// <para>The URI corresponding to the ability of the built-in page in the application.</para>
        /// <remarks>
        /// <para>Notice: When HarmonyActionType is set to APP_CUSTOM_PAGE, you must specify at least one of the HarmonyUri and HarmonyAction fields. If multiple abilities exist, specify the action and URI for each ability. The action is used first to find the corresponding built-in page in the application.
        /// For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section152462191216">ClickAction.uri</a> on the HarmonyOS official website.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.example.com:8080/push/example">https://www.example.com:8080/push/example</a></para>
        /// </summary>
        [NameInMap("HarmonyUri")]
        [Validation(Required=false)]
        public string HarmonyUri { get; set; }

        /// <summary>
        /// <para>An idempotent parameter used to prevent duplicate push notifications on the server caused by retries from the API client. If the same IdempotentToken is used for calls within 15 minutes, only one push notification is sent, and subsequent calls return the result of the first successful push.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The parameter format is a standard 36-character UUID (8-4-4-4-12). Each valid character is a hexadecimal digit in the range of 0-9 or a-f, and it is case-insensitive.</description></item>
        /// <item><description>This parameter is used only to prevent duplicate push notifications caused by retries. It cannot prevent duplicate push notifications caused by concurrent calls.</description></item>
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
        /// <para>The custom identifier of the push task. If JobKey is not empty, this field is included in the receipt log. For more information, see <a href="https://help.aliyun.com/document_detail/434651.html">Receipt logs</a>.</para>
        /// <remarks>
        /// <para>Format requirements: The value can only contain letters, digits, underscores (_), and hyphens (-), and cannot exceed 32 characters in length.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("JobKey")]
        [Validation(Required=false)]
        public string JobKey { get; set; }

        /// <summary>
        /// <para>The scheduled delivery time. If this parameter is not set, the push is delivered immediately.
        /// The scheduled delivery time cannot be later than 7 days from the current time.</para>
        /// <para>The time must be in the ISO 8601 standard format and use UTC time. Format: YYYY-MM-DDThh:mm:ssZ.</para>
        /// <remarks>
        /// <para>This parameter is not supported when Target is set to TBD (continuous push).</para>
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
        /// <item><description><b>NOTICE</b>: Notification. Notifications are delivered to device endpoints through vendor channels such as APNs, Huawei, Xiaomi, and HarmonyOS, and are displayed directly in the notification bar of the device. When an Android device is online (the app process is alive), the notification is preferentially delivered through the Alibaba Cloud proprietary channel. The push SDK constructs and displays the notification to achieve better push performance and save vendor push message quotas in certain scenarios.</description></item>
        /// <item><description><b>MESSAGE</b>: Message. Messages are delivered through the Alibaba Cloud proprietary online channel. They are not displayed in the notification bar by default. Instead, the app must receive and process them when the process is active, and the business logic determines whether to trigger specific business behaviors. When the device is offline (the app process is inactive), messages cannot be received in a timely manner. In this case, you can use the iOSRemind or AndroidRemind parameter described below to convert messages into notifications for delivery when the device is offline. Alternatively, you can set the StoreOffline parameter described below to allow the push system to save the message when the device is offline and automatically deliver it when the device comes online.</description></item>
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
        /// <para>The specified delivery channels. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>accs: Alibaba Cloud proprietary channel.</description></item>
        /// <item><description>huawei: Huawei channel.</description></item>
        /// <item><description>honor: Honor channel.</description></item>
        /// <item><description>xiaomi: Xiaomi channel.</description></item>
        /// <item><description>oppo: OPPO channel.</description></item>
        /// <item><description>vivo: vivo channel.</description></item>
        /// <item><description>meizu: Meizu channel.</description></item>
        /// <item><description>gcm: Google GCM channel (legacy HTTP).</description></item>
        /// <item><description>fcm: Google Firebase channel (HTTP v1 API).</description></item>
        /// <item><description>apns: APNs channel.</description></item>
        /// <item><description>harmony: HarmonyOS channel.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If this parameter is not configured, all channels can be used.</description></item>
        /// <item><description>If this parameter is configured, only the specified channels are used.</description></item>
        /// <item><description>If the configured channels conflict with the delivery policy (for example, iOS notifications can only be delivered through the APNs channel, but apns is not included in this parameter), the push is not delivered.</description></item>
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
        /// <para><b>[Deprecated]</b> This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SendSpeed")]
        [Validation(Required=false)]
        [Obsolete]
        public int? SendSpeed { get; set; }

        /// <summary>
        /// <para>The delay time before the SMS message is triggered. Unit: seconds.
        /// This parameter is required if you use the SMS linkage feature. We recommend that you set this parameter to 15 seconds or more, and the maximum value cannot exceed 3 days. This prevents duplicate SMS and push messages.</para>
        /// <remarks>
        /// <para>When the SMS linkage feature is used, the ExpireTime parameter becomes invalid. The expiration time of the notification is calculated based on the SmsDelaySecs parameter. The expiration time is the current time plus the value of SmsDelaySecs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("SmsDelaySecs")]
        [Validation(Required=false)]
        public int? SmsDelaySecs { get; set; }

        /// <summary>
        /// <para>The key-value pairs of the variables in the SMS template. Format: <c>key1=value1&amp;key2=value2</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key1=value1</para>
        /// </summary>
        [NameInMap("SmsParams")]
        [Validation(Required=false)]
        public string SmsParams { get; set; }

        /// <summary>
        /// <para>The condition that triggers the SMS message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Triggered when the push message is not received.</description></item>
        /// <item><description><b>1</b>: Triggered when the user does not open the push message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SmsSendPolicy")]
        [Validation(Required=false)]
        public int? SmsSendPolicy { get; set; }

        /// <summary>
        /// <para>The signature for the fallback SMS message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMS signature</para>
        /// </summary>
        [NameInMap("SmsSignName")]
        [Validation(Required=false)]
        public string SmsSignName { get; set; }

        /// <summary>
        /// <para>The name of the SMS template used for fallback SMS messages. You can obtain this name on the SMS template management page. This is the name assigned by the system, not the name set by the developer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMS template name</para>
        /// </summary>
        [NameInMap("SmsTemplateName")]
        [Validation(Required=false)]
        public string SmsTemplateName { get; set; }

        /// <summary>
        /// <para>Specifies whether to save offline messages and notifications. Default value: <b>false</b>.</para>
        /// <para>If this parameter is set to true and the user is offline during the push, the message or notification is sent again when the user comes online within the expiration time specified by ExpireTime. The default value of ExpireTime is 72 hours. iOS notifications are delivered through the APNs channel and are not affected by StoreOffline.</para>
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
        /// <item><description><b>DEVICE</b>: Push by device.</description></item>
        /// <item><description><b>ACCOUNT</b>: Push by account.</description></item>
        /// <item><description><b>ALIAS</b>: Push by alias.</description></item>
        /// <item><description><b>TAG</b>: Push by tag.</description></item>
        /// <item><description><b>ALL</b>: Push to all devices. The interval between two full pushes of the same DeviceType must be at least 1 second.<remarks>
        /// <para>For a full push to iOS devices, the push is sent to devices that have been active within the last 24 months and have not been uninstalled. Once Apple Push Notification service (APNs) receives the push request and does not return an error message, the push is considered delivered. This may cause a surge in the number of active devices and incur high costs. Use this value with caution.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><b>TBD</b>: Initialize a continuous push. The push target is specified by the subsequent <a href="https://help.aliyun.com/document_detail/2249917.html">ContinuouslyPush</a> operation.</description></item>
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
        /// <para>The target value, which is set based on the Target type. Separate multiple values with commas. If the number of values exceeds the limit, you must send the push in multiple batches.</para>
        /// <list type="bullet">
        /// <item><description>If Target is set to DEVICE, the value is in the format of <c>deviceid1,deviceid2</c>. A maximum of 1,000 devices are supported.</description></item>
        /// <item><description>If Target is set to ACCOUNT, the value is in the format of <c>account1,account2</c>. A maximum of 1,000 accounts are supported.</description></item>
        /// <item><description>If Target is set to ALIAS, the value is in the format of <c>alias1,alias2</c>. A maximum of 1,000 aliases are supported.</description></item>
        /// <item><description>If Target is set to TAG, single or multiple tags are supported. For more information about the format, see <a href="https://help.aliyun.com/document_detail/434847.html">Tag format</a>.</description></item>
        /// <item><description>If Target is set to ALL, the value is <b>ALL</b>, which is a fixed parameter combination for full pushes.</description></item>
        /// <item><description>If Target is set to TBD, the value is <b>TBD</b>, which is a fixed parameter combination for continuous pushes.</description></item>
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
        /// <para>The title of the notification or message during the push. Maximum length: 200 bytes.</para>
        /// <para>This parameter is required for Android and HarmonyOS pushes. This parameter is optional for iOS notifications. If this parameter is specified:</para>
        /// <list type="bullet">
        /// <item><description><para>For iOS 10 and later, the title is displayed in the notification.</para>
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
        /// <para>Specifies whether to automatically truncate excessively long titles and content.</para>
        /// <remarks>
        /// <para>This parameter applies only to vendor channels that explicitly limit the length of titles and content. It does not apply to channels such as APNs, Huawei, and Honor, which do not limit the length of titles and content but only limit the total request body size.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Trim")]
        [Validation(Required=false)]
        public bool? Trim { get; set; }

        /// <summary>
        /// <para>To send iOS notifications through the APNs center, you must specify the corresponding environment context. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DEV</b>: Development environment. This value applies to apps that are directly installed and debugged by using Xcode.</description></item>
        /// <item><description><b>PRODUCT</b>: Production environment. This value applies to apps distributed through the App Store, TestFlight, Ad Hoc, and enterprise distribution.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DEV</para>
        /// </summary>
        [NameInMap("iOSApnsEnv")]
        [Validation(Required=false)]
        public string IOSApnsEnv { get; set; }

        /// <summary>
        /// <para>The badge number displayed in the upper-right corner of the iOS app icon.</para>
        /// <remarks>
        /// <para>If iOSBadgeAutoIncrement is set to true, this parameter must be left empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("iOSBadge")]
        [Validation(Required=false)]
        public int? IOSBadge { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the automatic badge increment feature. Default value: false.</para>
        /// <remarks>
        /// <para>When this parameter is set to true, iOSBadge must be left empty.</para>
        /// </remarks>
        /// <para>The automatic badge increment feature maintains the badge count for each device on the push server. To use this feature, you must use SDK version 1.9.5 or later and actively synchronize the badge number to the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("iOSBadgeAutoIncrement")]
        [Validation(Required=false)]
        public bool? IOSBadgeAutoIncrement { get; set; }

        /// <summary>
        /// <para>The extension property of the iOS notification.</para>
        /// <para>For iOS 10 and later, you can specify the resource URL for rich media push notifications in this parameter: <c>{&quot;attachment&quot;: &quot;https://www.example.com/notification_pic.png&quot;}</c>. This parameter must be passed in JSON map format. Otherwise, a parse error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;attachment&quot;: &quot;<a href="https://www.example.com/notification_pic.png%22%7D">https://www.example.com/notification_pic.png&quot;}</a></para>
        /// </summary>
        [NameInMap("iOSExtParameters")]
        [Validation(Required=false)]
        public string IOSExtParameters { get; set; }

        /// <summary>
        /// <para>The interruption level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>passive</b>: The system adds the notification to the notification list without lighting up the screen or playing a sound.</description></item>
        /// <item><description><b>active</b>: The system immediately displays the notification, lights up the screen, and can play a sound.</description></item>
        /// <item><description><b>time-sensitive</b>: The system immediately presents the notification, lights up the screen, and can play a sound, but does not break through the system notification controls.</description></item>
        /// <item><description><b>critical</b>: The system immediately displays the notification, lights up the screen, and plays a sound bypassing the silent switch.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("iOSInterruptionLevel")]
        [Validation(Required=false)]
        public string IOSInterruptionLevel { get; set; }

        /// <summary>
        /// <para>The JSON character string that contains the pass-through static parameter for Dynamic Island pushes. It includes static user-defined information, such as product IDs and order information.</para>
        /// <remarks>
        /// <para>This parameter is required when iOSLiveActivityEvent is set to start.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;orderId&quot;: &quot;12345&quot;, &quot;product&quot;: &quot;Shoes&quot;}</para>
        /// </summary>
        [NameInMap("iOSLiveActivityAttributes")]
        [Validation(Required=false)]
        public string IOSLiveActivityAttributes { get; set; }

        /// <summary>
        /// <para>The type of the Live Activity to be started.</para>
        /// <remarks>
        /// <para>This parameter is required when iOSLiveActivityEvent is set to start.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>OrderActivityAttributes</para>
        /// </summary>
        [NameInMap("iOSLiveActivityAttributesType")]
        [Validation(Required=false)]
        public string IOSLiveActivityAttributesType { get; set; }

        /// <summary>
        /// <para>The pass-through dynamic parameter for Dynamic Island pushes. It includes real-time update information, such as price and inventory changes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;status&quot;: &quot;delivered&quot;, &quot;estimatedArrival&quot;: &quot;2023-12-31T12:00:00Z&quot;}</para>
        /// </summary>
        [NameInMap("iOSLiveActivityContentState")]
        [Validation(Required=false)]
        public string IOSLiveActivityContentState { get; set; }

        /// <summary>
        /// <para>The UNIX timestamp in seconds. The ended Live Activity is retained on the Lock Screen until the specified time. The maximum retention period is 4 hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1743131967</para>
        /// </summary>
        [NameInMap("iOSLiveActivityDismissalDate")]
        [Validation(Required=false)]
        public long? IOSLiveActivityDismissalDate { get; set; }

        /// <summary>
        /// <para>The event to start, update, or end a Live Activity. Valid values: start, update, and end.</para>
        /// 
        /// <b>Example:</b>
        /// <para>start</para>
        /// </summary>
        [NameInMap("iOSLiveActivityEvent")]
        [Validation(Required=false)]
        public string IOSLiveActivityEvent { get; set; }

        /// <summary>
        /// <para>The Live Activity ID reported by the device to the user server. It is the unique identifier of the Live Activity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66B94673-B32E-4CA7-863C-3E523054FD46</para>
        /// </summary>
        [NameInMap("iOSLiveActivityId")]
        [Validation(Required=false)]
        public string IOSLiveActivityId { get; set; }

        /// <summary>
        /// <para>The UNIX timestamp in seconds that marks the expiration time of the activity content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1743131967</para>
        /// </summary>
        [NameInMap("iOSLiveActivityStaleDate")]
        [Validation(Required=false)]
        public long? IOSLiveActivityStaleDate { get; set; }

        /// <summary>
        /// <para>The sound of the iOS notification. Specify the name of the audio file stored in the app bundle or the sandbox Library/Sounds directory. For more information, see <a href="https://help.aliyun.com/document_detail/48906.html">How to set the notification sound for iOS pushes</a>.</para>
        /// <para>If this parameter is set to an empty string (&quot;&quot;), the notification is silent. If this parameter is not set, the default value is default, which indicates the system prompt sound.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("iOSMusic")]
        [Validation(Required=false)]
        public string IOSMusic { get; set; }

        /// <summary>
        /// <para>The iOS notification processing extension flag (iOS 10 and later). If this parameter is set to true, notifications pushed by APNs can be processed by the extension before they are displayed. This parameter must be set to true for silent notifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("iOSMutableContent")]
        [Validation(Required=false)]
        public bool? IOSMutableContent { get; set; }

        /// <summary>
        /// <para>The category of the iOS notification (iOS 10 and later).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ios</para>
        /// </summary>
        [NameInMap("iOSNotificationCategory")]
        [Validation(Required=false)]
        public string IOSNotificationCategory { get; set; }

        /// <summary>
        /// <para>The collapse ID of the iOS notification. If a device receives messages with the same CollapseId, the messages are merged into one. If the device is offline and continuously receives messages with the same CollapseId, only one notification is displayed in the notification bar. This parameter is supported in iOS 10 and later.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZD2011</para>
        /// </summary>
        [NameInMap("iOSNotificationCollapseId")]
        [Validation(Required=false)]
        public string IOSNotificationCollapseId { get; set; }

        /// <summary>
        /// <para>The thread ID used to group iOS remote notifications and mark the identifier of the collapsed group. This parameter is supported only in iOS 12.0 and later.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("iOSNotificationThreadId")]
        [Validation(Required=false)]
        public string IOSNotificationThreadId { get; set; }

        /// <summary>
        /// <para>The relevance score for summary highlighting. Valid values: a floating-point number in the range of [0,1\].</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.01</para>
        /// </summary>
        [NameInMap("iOSRelevanceScore")]
        [Validation(Required=false)]
        public double? IOSRelevanceScore { get; set; }

        /// <summary>
        /// <para>Specifies whether to convert a message into a notification and deliver it once through the Apple APNs channel when the device is offline (that is, the persistent connection channel to the Mobile Push server is disconnected) during a message push.</para>
        /// <remarks>
        /// <para>Converting offline messages into notifications applies only to the production environment.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("iOSRemind")]
        [Validation(Required=false)]
        public bool? IOSRemind { get; set; }

        /// <summary>
        /// <para>The iOS notification content used when an iOS message is converted into a notification. This parameter is valid only when iOSApnsEnv is set to PRODUCT and iOSRemind is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iOS notification body</para>
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
        /// <para>The subtitle of the iOS notification (iOS 10 and later).</para>
        /// 
        /// <b>Example:</b>
        /// <para>su\&quot;b</para>
        /// </summary>
        [NameInMap("iOSSubtitle")]
        [Validation(Required=false)]
        public string IOSSubtitle { get; set; }

    }

}
