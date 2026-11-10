// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class PushTask : TeaModel {
        /// <summary>
        /// <para>The push method. This parameter is optional. Default value: PUSH_IMMEDIATELY (push immediately).</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>The MassPushV2 batch push API supports only the following push methods:</para>
        /// <list type="bullet">
        /// <item><description>PUSH_IMMEDIATELY (push immediately)</description></item>
        /// <item><description>SCHEDULED_PUSH (scheduled push)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUSH_IMMEDIATELY</para>
        /// </summary>
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>The pass-through message data sent to the device. The total length cannot exceed 4,000 bytes.</para>
        /// <remarks>
        /// <para>Length calculation rules</para>
        /// <list type="bullet">
        /// <item><description>The length is calculated based on the byte length of the UTF-8 encoded string after the Message object is serialized into JSON.</description></item>
        /// <item><description>A Chinese character typically occupies 3 bytes in UTF-8 encoding.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public PushTaskMessage Message { get; set; }
        public class PushTaskMessage : TeaModel {
            /// <summary>
            /// <para>The body of the message to be sent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;key&quot;: &quot;value&quot;}</para>
            /// </summary>
            [NameInMap("Body")]
            [Validation(Required=false)]
            public string Body { get; set; }

            /// <summary>
            /// <para>The title of the message to be sent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>title</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The vendor notification data sent to the device.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>If both Message and Notification are configured, the device receives only one of them based on the following rules:</para>
        /// <list type="bullet">
        /// <item><description>If the device is online, the pass-through message data is sent.</description></item>
        /// <item><description>If the device is offline, the system notification is sent.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public PushTaskNotification Notification { get; set; }
        public class PushTaskNotification : TeaModel {
            /// <summary>
            /// <para>The Android notification configuration.</para>
            /// </summary>
            [NameInMap("Android")]
            [Validation(Required=false)]
            public PushTaskNotificationAndroid Android { get; set; }
            public class PushTaskNotificationAndroid : TeaModel {
                /// <summary>
                /// <para>The fully qualified class name of the application entry activity for badge settings.</para>
                /// <remarks>
                /// <para>Valid only for Huawei and Honor vendor channel pushes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>com.alibaba.cloudpushdemo.bizactivity</para>
                /// </summary>
                [NameInMap("BadgeActivity")]
                [Validation(Required=false)]
                public string BadgeActivity { get; set; }

                /// <summary>
                /// <para>Sets the increment value for the badge, which is added to the original badge number.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Supported by Huawei and Honor channels.</description></item>
                /// <item><description>If both BadgeAddNum and BadgeSetNum are specified, BadgeSetNum takes precedence.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BadgeAddNum")]
                [Validation(Required=false)]
                public int? BadgeAddNum { get; set; }

                /// <summary>
                /// <para>Sets a fixed value for the badge number. Valid values: 1 to 99.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>This parameter takes effect only for Huawei and Honor vendor channel pushes. </description></item>
                /// <item><description>For Alibaba Cloud proprietary channel pushes, this parameter takes effect only on Huawei, Honor, and vivo devices.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("BadgeSetNum")]
                [Validation(Required=false)]
                public int? BadgeSetNum { get; set; }

                /// <summary>
                /// <para>Sets the channel ID of the Android application. The channel ID must match the channel ID in the vendor application.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Because the channel_id of the OPPO private message channel is the same as the channel ID of the application, this value is used as the channel_id when pushing through the OPPO channel.</description></item>
                /// <item><description>This value is also used as the channel_id for Huawei, FCM, and Alibaba Cloud proprietary channel pushes.</description></item>
                /// <item><description>For specific use cases, see the FAQ: <a href="https://help.aliyun.com/document_detail/67398.html">Notifications are not received on devices running Android 8.0 or later</a>.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>8.0up</para>
                /// </summary>
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                /// <summary>
                /// <para>The custom extension attributes for Android notifications.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>The parameter must be passed in standard JSON map format. Incorrect formats will cause parsing failures.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;key1&quot;:&quot;value1&quot;}</para>
                /// </summary>
                [NameInMap("ExtParameters")]
                [Validation(Required=false)]
                public string ExtParameters { get; set; }

                /// <summary>
                /// <para>The message group. For messages in the same group, only the latest message and the total number of received messages in the group are displayed in the notification bar. All messages are not displayed and cannot be expanded. Currently supported by:</para>
                /// <list type="bullet">
                /// <item><description>Huawei vendor channel.</description></item>
                /// <item><description>Honor vendor channel.</description></item>
                /// <item><description>Proprietary channels with Android SDK 3.9.1 or earlier.</description></item>
                /// </list>
                /// <remarks>
                /// <para>Proprietary channels no longer support this parameter in Android SDK 3.9.2 or later.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>group-1</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The URL of the icon on the right side. Currently supported by:</para>
                /// <list type="bullet">
                /// <item><description>Huawei EMUI (applicable only in long text mode and Inbox mode).</description></item>
                /// <item><description>Honor Magic UI (applicable only in long text mode).</description></item>
                /// <item><description>Proprietary channels (Android SDK 3.5.0 or later).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://imag.example.com/image.png">https://imag.example.com/image.png</a></para>
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// <para>The body text in Inbox mode. The content must be a valid JSON array with a maximum of five elements. Currently supported by:</para>
                /// <list type="bullet">
                /// <item><description>Huawei: EMUI 9 or later.</description></item>
                /// <item><description>Honor: Magic UI 4.0 or later.</description></item>
                /// <item><description>Xiaomi: MIUI 10 or later.</description></item>
                /// <item><description>OPPO: ColorOS 5.0 or later.</description></item>
                /// <item><description>Proprietary channels: Android SDK 3.6.0 or later.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("InboxContent")]
                [Validation(Required=false)]
                public List<string> InboxContent { get; set; }

                /// <summary>
                /// <para>The notification sound for the Huawei vendor channel. Specify the audio file name stored in the <c>app/src/main/res/raw/</c> directory of the client project. Do not include the file format extension. If not set, the default ringtone is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alicloud_notification_sound</para>
                /// </summary>
                [NameInMap("Music")]
                [Validation(Required=false)]
                public string Music { get; set; }

                /// <summary>
                /// <para>The unique identifier of the Android notification bar message, used to control the override and replacement behavior of notifications. A new notification with the same NotifyId automatically overrides the old notification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>233856727</para>
                /// </summary>
                [NameInMap("NotifyId")]
                [Validation(Required=false)]
                public int? NotifyId { get; set; }

                /// <summary>
                /// <para>The detailed channel configuration.</para>
                /// </summary>
                [NameInMap("Options")]
                [Validation(Required=false)]
                public PushTaskNotificationAndroidOptions Options { get; set; }
                public class PushTaskNotificationAndroidOptions : TeaModel {
                    /// <summary>
                    /// <para>The Alibaba Cloud proprietary configuration.</para>
                    /// <remarks>
                    /// <para>Valid only when the Alibaba Cloud proprietary channel is used.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("Accs")]
                    [Validation(Required=false)]
                    public PushTaskNotificationAndroidOptionsAccs Accs { get; set; }
                    public class PushTaskNotificationAndroidOptionsAccs : TeaModel {
                        /// <summary>
                        /// <para>The custom notification bar style for Android. Valid values: 1 to 100.</para>
                        /// <remarks>
                        /// <para>The client must complete the style preset configuration. References: <a href="https://help.aliyun.com/document_detail/2834944.html">Custom notification style API</a>.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("CustomStyle")]
                        [Validation(Required=false)]
                        public int? CustomStyle { get; set; }

                        /// <summary>
                        /// <para>The reminder method for the notification. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>VIBRATE: Vibration (default).</description></item>
                        /// <item><description>SOUND: Sound.</description></item>
                        /// <item><description>BOTH: Sound and vibration.</description></item>
                        /// <item><description>NONE: Silent.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NONE</para>
                        /// </summary>
                        [NameInMap("NotifyType")]
                        [Validation(Required=false)]
                        public string NotifyType { get; set; }

                        /// <summary>
                        /// <para>Specifies the activity to open when the notification is clicked. Valid only when OpenType is set to ACTIVITY.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>com.alibaba.cloudpushdemo.bizactivity</para>
                        /// </summary>
                        [NameInMap("OpenActivity")]
                        [Validation(Required=false)]
                        public string OpenActivity { get; set; }

                        /// <summary>
                        /// <para>The action to perform when the notification is clicked. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>APPLICATION: Open the application (default).</description></item>
                        /// <item><description>ACTIVITY: Open the specified activity OpenActivity.</description></item>
                        /// <item><description>URL: Open a URL.</description></item>
                        /// <item><description>NONE: No redirection.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>APPLICATION</para>
                        /// </summary>
                        [NameInMap("OpenType")]
                        [Validation(Required=false)]
                        public string OpenType { get; set; }

                        /// <summary>
                        /// <para>The URL to open when the notification is clicked after an Android device receives the push message. Valid only when OpenType is set to URL.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="http://www.example.com">www.example.com</a></para>
                        /// </summary>
                        [NameInMap("OpenUrl")]
                        [Validation(Required=false)]
                        public string OpenUrl { get; set; }

                        /// <summary>
                        /// <para>The priority of the display position for Android notifications in the notification bar. Valid values: -2, -1, 0, 1, and 2.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Priority")]
                        [Validation(Required=false)]
                        public int? Priority { get; set; }

                        /// <summary>
                        /// <para>The message group. Messages in the same group are collapsed and can be expanded in the notification bar. Notifications from different groups are displayed separately.</para>
                        /// <remarks>
                        /// <para>Supported by Android SDK 3.9.2 or later.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>order_ORD20231201001</para>
                        /// </summary>
                        [NameInMap("ThreadId")]
                        [Validation(Required=false)]
                        public string ThreadId { get; set; }

                    }

                    /// <summary>
                    /// <para>The Honor configuration.</para>
                    /// </summary>
                    [NameInMap("Honor")]
                    [Validation(Required=false)]
                    public PushTaskNotificationAndroidOptionsHonor Honor { get; set; }
                    public class PushTaskNotificationAndroidOptionsHonor : TeaModel {
                        /// <summary>
                        /// <para>Sets the importance parameter for Honor notification message classification, which determines the notification behavior on user devices. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>0: Information and marketing messages.</description></item>
                        /// <item><description>1: Service and communication messages.</description></item>
                        /// </list>
                        /// <para>You must apply on the Honor platform. See <a href="https://developer.honor.com/cn/docs/11002/guides/notification-class#%E8%87%AA%E5%88%86%E7%B1%BB%E6%9D%83%E7%9B%8A%E7%94%B3%E8%AF%B7">Application link</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Importance")]
                        [Validation(Required=false)]
                        public int? Importance { get; set; }

                    }

                    /// <summary>
                    /// <para>The Huawei configuration.</para>
                    /// </summary>
                    [NameInMap("Huawei")]
                    [Validation(Required=false)]
                    public PushTaskNotificationAndroidOptionsHuawei Huawei { get; set; }
                    public class PushTaskNotificationAndroidOptionsHuawei : TeaModel {
                        /// <summary>
                        /// <para>Sets the Huawei fast notification parameter. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>0</b>: Send standard Huawei notifications (default).</description></item>
                        /// <item><description><b>1</b>: Send Huawei fast notifications.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("BusinessType")]
                        [Validation(Required=false)]
                        public int? BusinessType { get; set; }

                        /// <summary>
                        /// <para>Purpose 1: After applying for <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/message-classification-0000001149358835?#section3410731125514">self-classification benefits</a>, this parameter is used to identify the message type, determine the <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/message-classification-0000001149358835#ZH-CN_TOPIC_0000001149358835__p3850133955718">message reminder method</a>, and accelerate the delivery of specific types of messages. For valid values, refer to the <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/message-classification-0000001149358835#section1076611477914">message classification standards</a> in the official Huawei push documentation, and fill in the &quot;Cloud notification category value&quot; or &quot;Local notification category value&quot; from the documentation table.</para>
                        /// <para>Purpose 2: After <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/faq-0000001050042183#section037425218509">applying for special permissions</a>, this parameter is used to identify high-priority pass-through scenarios. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>VOIP: Audio and video calls.</description></item>
                        /// <item><description>PLAY_VOICE: Voice broadcast.</description></item>
                        /// </list>
                        /// <remarks>
                        /// <list type="bullet">
                        /// <item><description>If the &quot;Cloud notification category value&quot; is &quot;Not applicable&quot;, the message is sent through the Alibaba Cloud proprietary channel.</description></item>
                        /// <item><description>If the &quot;Local notification category value&quot; is &quot;Not applicable&quot;, the message is sent through the Huawei channel.</description></item>
                        /// </list>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>VOIP</para>
                        /// </summary>
                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        /// <summary>
                        /// <para>Sets the importance parameter for Huawei notification message classification, which determines the notification behavior on user devices. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>0: Information and marketing messages.</description></item>
                        /// <item><description>1: Service and communication messages.</description></item>
                        /// </list>
                        /// <remarks>
                        /// <para>We recommend that you use Category for notification classification. You must apply on the Huawei platform. See <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/message-classification-0000001149358835#section893184112272">Application link</a>.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Importance")]
                        [Validation(Required=false)]
                        public int? Importance { get; set; }

                        /// <summary>
                        /// <para>The JSON string of the Huawei Android Live Window data structure <a href="https://developer.huawei.com/consumer/cn/doc/HMSCore-References/rest-live-0000001562939968#ZH-CN_TOPIC_0000001700850537__p195121620102511">LiveNotificationPayload</a>. For development and integration, refer to the <a href="https://help.aliyun.com/document_detail/2983768.html">Huawei Live Window push guide</a>.</para>
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
                        [NameInMap("LiveNotificationPayload")]
                        [Validation(Required=false)]
                        public string LiveNotificationPayload { get; set; }

                        /// <summary>
                        /// <para>The receipt ID of the Huawei channel. You can view this receipt ID in the receipt parameter settings of the Huawei channel push operations platform.</para>
                        /// <remarks>
                        /// <para>If the default receipt configuration on the Huawei channel push operations platform is set to Alibaba Cloud receipt, you do not need to provide this parameter. Otherwise, we recommend that you configure the default receipt ID for the Huawei channel in the Alibaba Cloud EMAS shift push console first.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>RCP4C123456</para>
                        /// </summary>
                        [NameInMap("ReceiptId")]
                        [Validation(Required=false)]
                        public string ReceiptId { get; set; }

                        /// <summary>
                        /// <para>The delivery priority for Huawei channel notifications. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>HIGH</description></item>
                        /// <item><description>NORMAL</description></item>
                        /// </list>
                        /// <para>You must apply for permissions. For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/faq-0000001050042183#section037425218509">Application link</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NORMAL</para>
                        /// </summary>
                        [NameInMap("Urgency")]
                        [Validation(Required=false)]
                        public string Urgency { get; set; }

                    }

                    /// <summary>
                    /// <para>The Meizu configuration.</para>
                    /// </summary>
                    [NameInMap("Meizu")]
                    [Validation(Required=false)]
                    public PushTaskNotificationAndroidOptionsMeizu Meizu { get; set; }
                    public class PushTaskNotificationAndroidOptionsMeizu : TeaModel {
                        /// <summary>
                        /// <para>The Meizu message type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>0: Public message (default).</description></item>
                        /// <item><description>1: Private message.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("NoticeMsgType")]
                        [Validation(Required=false)]
                        public int? NoticeMsgType { get; set; }

                    }

                    /// <summary>
                    /// <para>The OPPO configuration.</para>
                    /// </summary>
                    [NameInMap("Oppo")]
                    [Validation(Required=false)]
                    public PushTaskNotificationAndroidOptionsOppo Oppo { get; set; }
                    public class PushTaskNotificationAndroidOptionsOppo : TeaModel {
                        /// <summary>
                        /// <para>OPPO message categorization includes two categories for management: communication and service, and content and marketing. </para>
                        /// <para><b>Communication and service (requires permission application):</b></para>
                        /// <list type="bullet">
                        /// <item><description>IM: Instant messages.</description></item>
                        /// <item><description>ACCOUNT: Accounts and assets.</description></item>
                        /// <item><description>TODO: Schedules and to-do lists.</description></item>
                        /// <item><description>DEVICE_REMINDER: Device information.</description></item>
                        /// <item><description>ORDER: Orders and logistics.</description></item>
                        /// <item><description>SUBSCRIPTION: subscribe reminders.</description></item>
                        /// </list>
                        /// <para><b>Content and marketing:</b></para>
                        /// <list type="bullet">
                        /// <item><description>NEWS: News.</description></item>
                        /// <item><description>CONTENT: Content recommendations.</description></item>
                        /// <item><description>MARKETING: operational activity.</description></item>
                        /// <item><description>SOCIAL: Social updates.</description></item>
                        /// </list>
                        /// <para>For more information, see the <a href="https://open.oppomobile.com/new/developmentDoc/info?id=13189">OPPO categorization description</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NEWS</para>
                        /// </summary>
                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        /// <summary>
                        /// <para>The JSON character string of the OPPO Fluid Cloud intent delete data structure <a href="https://open.oppomobile.com/documentation/page/info?id=13578">data</a>. This parameter is invalid if the AndroidOppoIntelligentIntent parameter is already specified. For development and integration, References: <a href="https://help.aliyun.com/document_detail/2997310.html">OPPO Fluid Cloud push guide</a>.</para>
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
                        [NameInMap("DeleteIntentData")]
                        [Validation(Required=false)]
                        public string DeleteIntentData { get; set; }

                        /// <summary>
                        /// <para>The JSON character string of the OPPO Fluid Cloud intent sharing data structure <a href="https://open.oppomobile.com/documentation/page/info?id=13565">IntelligentIntent</a>. For development and integration, References: <a href="https://help.aliyun.com/document_detail/2997310.html">OPPO Fluid Cloud push guide</a>.</para>
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
                        [NameInMap("IntelligentIntent")]
                        [Validation(Required=false)]
                        public string IntelligentIntent { get; set; }

                        /// <summary>
                        /// <para>The reminder level for OPPO channel notification bar messages. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>1: Notification bar.</description></item>
                        /// <item><description>2: Notification bar, lock screen, ringtone, and vibration (default notification level for communication and service messages).</description></item>
                        /// <item><description>16: Notification bar, lock screen, ringtone, vibration, and banner (requires permission application).</description></item>
                        /// </list>
                        /// <remarks>
                        /// <para>When you use the NotifyLevel parameter, you must also pass the Category parameter.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("NotifyLevel")]
                        [Validation(Required=false)]
                        public long? NotifyLevel { get; set; }

                        /// <summary>
                        /// <para>The OPPO private message template content parameters.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{
                        /// &quot;key1&quot;: &quot;value1&quot;,
                        /// &quot;key2&quot;: &quot;value2&quot;
                        /// }</para>
                        /// </summary>
                        [NameInMap("PrivateContentParameters")]
                        [Validation(Required=false)]
                        public string PrivateContentParameters { get; set; }

                        /// <summary>
                        /// <para>The OPPO private message template ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>687557242b1634hzefs3d5013</para>
                        /// </summary>
                        [NameInMap("PrivateMsgTemplateId")]
                        [Validation(Required=false)]
                        public string PrivateMsgTemplateId { get; set; }

                        /// <summary>
                        /// <para>The OPPO private message template title parameters.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{&quot;name&quot;: &quot;Zhang San&quot;}</para>
                        /// </summary>
                        [NameInMap("PrivateTitleParameters")]
                        [Validation(Required=false)]
                        public string PrivateTitleParameters { get; set; }

                    }

                    /// <summary>
                    /// <para>The vivo configuration.</para>
                    /// </summary>
                    [NameInMap("Vivo")]
                    [Validation(Required=false)]
                    public PushTaskNotificationAndroidOptionsVivo Vivo { get; set; }
                    public class PushTaskNotificationAndroidOptionsVivo : TeaModel {
                        /// <summary>
                        /// <para>Sets the increment value for the vivo channel badge.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("AddBadge")]
                        [Validation(Required=false)]
                        public bool? AddBadge { get; set; }

                        /// <summary>
                        /// <para>vivo message categorization includes two categories for management: system messages and operation messages. </para>
                        /// <para><b>System messages:</b></para>
                        /// <list type="bullet">
                        /// <item><description>IM: Instant messages.</description></item>
                        /// <item><description>ACCOUNT: Accounts and assets.</description></item>
                        /// <item><description>TODO: Schedules and to-do lists.</description></item>
                        /// <item><description>DEVICE_REMINDER: Device information.</description></item>
                        /// <item><description>ORDER: Orders and logistics.</description></item>
                        /// <item><description>SUBSCRIPTION: subscribe reminders.</description></item>
                        /// </list>
                        /// <para><b>Operation messages:</b></para>
                        /// <list type="bullet">
                        /// <item><description>NEWS: News.</description></item>
                        /// <item><description>CONTENT: Content recommendations.</description></item>
                        /// <item><description>MARKETING: operational activity.</description></item>
                        /// <item><description>SOCIAL: Social updates.</description></item>
                        /// </list>
                        /// <para>For more information, see <a href="https://dev.vivo.com.cn/documentCenter/doc/359#s-ef3qugc3">vivo categorization description</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MARKETING</para>
                        /// </summary>
                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        /// <summary>
                        /// <para>Sets the vivo notification message classification. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>0: Operation messages (default).</description></item>
                        /// <item><description>1: System messages.</description></item>
                        /// </list>
                        /// <remarks>
                        /// <para>We recommend that you use Category for notification classification. You must apply on the vivo platform. For more information, see <a href="https://dev.vivo.com.cn/documentCenter/doc/359">Application link</a>.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Importance")]
                        [Validation(Required=false)]
                        public int? Importance { get; set; }

                        /// <summary>
                        /// <para>The JSON character string of the vivo Atomic Island data structure <a href="https://dev.vivo.com.cn/documentCenter/doc/896#s-fdagzbd4">liveMessage</a>. For development and integration, References: <a href="https://www.alibabacloud.com/help/en/document_detail/3030718.html">vivo Atomic Island push guide</a>.</para>
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
                        [NameInMap("LiveMessage")]
                        [Validation(Required=false)]
                        public string LiveMessage { get; set; }

                        /// <summary>
                        /// <para>The message receipt identifier for the vivo vendor push channel, used to receive callback notifications for push results.</para>
                        /// <remarks>
                        /// <list type="bullet">
                        /// <item><description>Location: vivo Open Platform &gt; Push Service &gt; Application Information &gt; Receipt Configuration.</description></item>
                        /// <item><description>Configuration recommendation: Configure the default receipt ID in the Alibaba Cloud EMAS console first.</description></item>
                        /// <item><description>Usage condition: Required only when the default receipt on the vivo platform is not the Alibaba Cloud receipt.</description></item>
                        /// </list>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1232221</para>
                        /// </summary>
                        [NameInMap("ReceiptId")]
                        [Validation(Required=false)]
                        public string ReceiptId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>t1-ge3-lq</para>
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>{&quot;keywords1&quot;:&quot;S123&quot;}</para>
                        /// </summary>
                        [NameInMap("TemplateParams")]
                        [Validation(Required=false)]
                        public string TemplateParams { get; set; }

                    }

                    /// <summary>
                    /// <para>The Xiaomi configuration.</para>
                    /// </summary>
                    [NameInMap("Xiaomi")]
                    [Validation(Required=false)]
                    public PushTaskNotificationAndroidOptionsXiaomi Xiaomi { get; set; }
                    public class PushTaskNotificationAndroidOptionsXiaomi : TeaModel {
                        /// <summary>
                        /// <para>Sets the channel ID for the Xiaomi notification type. You must apply on the Xiaomi platform. For more information, see <a href="https://dev.mi.com/console/doc/detail?pId=2422#_4">Application link</a>.</para>
                        /// <remarks>
                        /// <para>A single application can apply for a maximum of eight channels on the Xiaomi channel. Plan accordingly in advance.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>michannel</para>
                        /// </summary>
                        [NameInMap("Channel")]
                        [Validation(Required=false)]
                        public string Channel { get; set; }

                        /// <summary>
                        /// <para>The JSON character string of the Xiaomi Super Island data structure <a href="https://dev.mi.com/xiaomihyperos/documentation/detail?pId=2131">miui.focus.param</a>. For development and integration, References: <a href="https://www.alibabacloud.com/help/en/document_detail/3037956.html">Xiaomi Super Island push guide</a>.</para>
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
                        [NameInMap("FocusParam")]
                        [Validation(Required=false)]
                        public string FocusParam { get; set; }

                        /// <summary>
                        /// <para>The JSON character string of the Xiaomi Super Island data images <a href="https://dev.mi.com/xiaomihyperos/documentation/detail?pId=2131">miui.focus.pic_xxx</a>. For development and integration, References: <a href="https://www.alibabacloud.com/help/en/document_detail/3037956.html">Xiaomi Super Island push guide</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{
                        ///     &quot;miui.focus.pic_ticker&quot;: &quot;<a href="https://example.com/ticker.jpg">https://example.com/ticker.jpg</a>&quot;,
                        ///     &quot;miui.focus.pic_aod&quot;: &quot;<a href="https://example.com/aod.jpg">https://example.com/aod.jpg</a>&quot;,
                        ///     &quot;miui.focus.pic_imageText&quot;: &quot;<a href="https://example.com/imageText.jpg">https://example.com/imageText.jpg</a>&quot;
                        /// }</para>
                        /// </summary>
                        [NameInMap("FocusPics")]
                        [Validation(Required=false)]
                        public string FocusPics { get; set; }

                        /// <summary>
                        /// <para>The Xiaomi private message template ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>P10645</para>
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                        /// <summary>
                        /// <para>The Xiaomi private message template parameters, as a JSON string.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{&quot;keywords1&quot;:&quot;Tom&quot;,&quot;keywords2&quot;:&quot;phone&quot;}</para>
                        /// </summary>
                        [NameInMap("TemplateParams")]
                        [Validation(Required=false)]
                        public string TemplateParams { get; set; }

                    }

                }

                /// <summary>
                /// <para>The image URL in large image mode. Currently supported by proprietary channels with Android SDK 3.6.0 or later.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://imag.example.com/image.png">https://imag.example.com/image.png</a></para>
                /// </summary>
                [NameInMap("PictureUrl")]
                [Validation(Required=false)]
                public string PictureUrl { get; set; }

                /// <summary>
                /// <para>The notification style. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Standard mode (default).</description></item>
                /// <item><description>1: Long text mode (supported by Huawei, Honor, Xiaomi, OPPO, Meizu, and proprietary channels).</description></item>
                /// <item><description>2: Large image mode (supported by proprietary channels).</description></item>
                /// <item><description>3: List mode (supported by Huawei, Honor, Xiaomi, OPPO, and proprietary channels).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RenderStyle")]
                [Validation(Required=false)]
                public string RenderStyle { get; set; }

                /// <summary>
                /// <para>Sets the notification type for vendor channels. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>false: Formal notification (default).</description></item>
                /// <item><description>true: Test notification.</description></item>
                /// </list>
                /// <remarks>
                /// <para>Currently supported by Huawei channel, Honor channel, vivo channel, and OPPO Fluid Cloud.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("TestMessage")]
                [Validation(Required=false)]
                public bool? TestMessage { get; set; }

                /// <summary>
                /// <para>Specifies the activity to open when the notification is clicked.</para>
                /// <remarks>
                /// <para>Warning: This parameter is required when you use Android vendor channels.</warning></para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>com.alibaba.cloudpushdemo.bizactivity</para>
                /// </summary>
                [NameInMap("VendorChannelActivity")]
                [Validation(Required=false)]
                public string VendorChannelActivity { get; set; }

            }

            /// <summary>
            /// <para>The body of the notification to be pushed.</para>
            /// <remarks>
            /// <para>Length limits:</para>
            /// <list type="bullet">
            /// <item><description>iOS/HarmonyOS/Android: the <b>character length</b> cannot exceed 200.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Dear customer, your reservation has been successfully canceled</para>
            /// </summary>
            [NameInMap("Body")]
            [Validation(Required=false)]
            public string Body { get; set; }

            /// <summary>
            /// <para>HarmonyOS notification configuration.</para>
            /// </summary>
            [NameInMap("Hmos")]
            [Validation(Required=false)]
            public PushTaskNotificationHmos Hmos { get; set; }
            public class PushTaskNotificationHmos : TeaModel {
                /// <summary>
                /// <para>The action corresponding to the ability of the in-app page.</para>
                /// <remarks>
                /// <para>For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section152462191216">ClickAction.action</a> on the HarmonyOS official website.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>com.example.action</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The number to add to the HarmonyOS application badge.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Supported by HarmonyOS SDK 1.2.0 and later.</description></item>
                /// <item><description>For more information, see the <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section266310382145">addNum field description</a> for HarmonyOS badges.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BadgeAddNum")]
                [Validation(Required=false)]
                public int? BadgeAddNum { get; set; }

                /// <summary>
                /// <para>The number to set for the HarmonyOS application badge.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>For more information, see the <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section266310382145">setNum field</a> description for HarmonyOS badges.</description></item>
                /// <item><description>Supported by HarmonyOS SDK 1.2.0 and later.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BadgeSetNum")]
                [Validation(Required=false)]
                public int? BadgeSetNum { get; set; }

                /// <summary>
                /// <para>The category of the notification message. This parameter is optional. Default value: MARKETING.</para>
                /// <remarks>
                /// <para>After you apply for the notification message auto-classification permission, this parameter is used to identify the message type. Different notification message types affect the message display and reminder methods. For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section17371529101117">Notification.category</a> on the HarmonyOS official website.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>IM</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>Sets the custom extension attributes of the notification message to pass additional business data.</para>
                /// <remarks>
                /// <para>The parameter must be passed in standard JSON map format. Incorrect formats will cause parsing failures.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;key&quot;: &quot;value&quot;}</para>
                /// </summary>
                [NameInMap("ExtParameters")]
                [Validation(Required=false)]
                public string ExtParameters { get; set; }

                /// <summary>
                /// <para>The additional data for notification extension messages.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Valid only when sending HarmonyOS notification extension messages.</description></item>
                /// <item><description>Conceptually equivalent to the extraData field of HarmonyOS notification extension messages. For specific definitions, see the <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section161192514234">ExtensionPayload</a> description in HarmonyOS.</description></item>
                /// <item><description>Supported by HarmonyOS SDK 1.2.0 and later.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("ExtensionExtraData")]
                [Validation(Required=false)]
                public string ExtensionExtraData { get; set; }

                /// <summary>
                /// <para>Enables HarmonyOS notification extensions.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>To send notification extension messages, you must first apply for permissions on the HarmonyOS official website. For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-guides-V5/push-send-extend-noti-V5">HarmonyOS documentation</a>.</description></item>
                /// <item><description>Supported by HarmonyOS SDK 1.2.0 and later.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ExtensionPush")]
                [Validation(Required=false)]
                public bool? ExtensionPush { get; set; }

                /// <summary>
                /// <para>The URL of the large icon on the right side of the notification. The URL must use the HTTPS protocol.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Supported image formats: PNG, JPG, JPEG, HEIF, GIF, and BMP. The total number of pixels (width × height) must be less than 25,000.</description></item>
                /// <item><description>For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section17371529101117">Notification.image</a> on the HarmonyOS official website.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/xxx.png">https://example.com/xxx.png</a></para>
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// <para>When RenderStyle is set to MULTI_LINE, this field is required to define the content for the multi-line text style. A maximum of three content items are supported.</para>
                /// </summary>
                [NameInMap("InboxContent")]
                [Validation(Required=false)]
                public List<string> InboxContent { get; set; }

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
                [NameInMap("LiveViewPayload")]
                [Validation(Required=false)]
                public string LiveViewPayload { get; set; }

                /// <summary>
                /// <para>The unique identifier (notifyId) for each message displayed in the notification bar. If this parameter is not provided, the push service automatically generates a unique identifier. Different notification messages can use the same notifyId to allow new messages to overwrite old ones. For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section17371529101117">Notification.notifyId</a> on the HarmonyOS official website.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("NotifyId")]
                [Validation(Required=false)]
                public int? NotifyId { get; set; }

                /// <summary>
                /// <para>The receipt ID of the HarmonyOS channel. You can view this receipt ID in the receipt parameter settings of the HarmonyOS channel push operations platform.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>If the default receipt configuration on the HarmonyOS channel push operations platform is set to Alibaba Cloud receipt, you do not need to provide this parameter. Otherwise, we recommend that you configure the default receipt ID for the HarmonyOS channel in the Alibaba Cloud EMAS shift push console first.</description></item>
                /// <item><description>For details, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section418321011212">pushOptions.receiptId</a> on the HarmonyOS official website.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>RCPB***DFD5</para>
                /// </summary>
                [NameInMap("ReceiptId")]
                [Validation(Required=false)]
                public string ReceiptId { get; set; }

                /// <summary>
                /// <para>The notification message style. This parameter is optional. Default value: NORMAL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("RenderStyle")]
                [Validation(Required=false)]
                public string RenderStyle { get; set; }

                /// <summary>
                /// <para>Uses a notification channel of the specified type.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>This parameter is valid only for Alibaba Cloud proprietary channels.</description></item>
                /// <item><description>For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/js-apis-notificationmanager-V5#slottype">SlotType</a> on the HarmonyOS official website.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>SOCIAL_COMMUNICATION</para>
                /// </summary>
                [NameInMap("SlotType")]
                [Validation(Required=false)]
                public string SlotType { get; set; }

                /// <summary>
                /// <para>The custom ringtone file name for HarmonyOS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>music.mp3</para>
                /// </summary>
                [NameInMap("Sound")]
                [Validation(Required=false)]
                public string Sound { get; set; }

                /// <summary>
                /// <para>The duration of the custom message notification ringtone, in seconds. Valid values: 1 to 60. If the ringtone duration is shorter than the notification display time, the ringtone loops.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("SoundDuration")]
                [Validation(Required=false)]
                public int? SoundDuration { get; set; }

                /// <summary>
                /// <para>Enables test messages.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section418321011212">TestMessage</a> in the HarmonyOS push parameters.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("TestMessage")]
                [Validation(Required=false)]
                public bool? TestMessage { get; set; }

                /// <summary>
                /// <para>The URI corresponding to the ability of the built-in app page.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>If multiple abilities exist, specify the action and URI for each ability. The action is prioritized when searching for the corresponding built-in app page.</description></item>
                /// <item><description>For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section152462191216">ClickAction.uri</a> on the HarmonyOS official website.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.example.com:8080/push/example">https://www.example.com:8080/push/example</a></para>
                /// </summary>
                [NameInMap("Uri")]
                [Validation(Required=false)]
                public string Uri { get; set; }

            }

            /// <summary>
            /// <para>iOS notification configuration.</para>
            /// </summary>
            [NameInMap("Ios")]
            [Validation(Required=false)]
            public PushTaskNotificationIos Ios { get; set; }
            public class PushTaskNotificationIos : TeaModel {
                /// <summary>
                /// <para>To send iOS notifications through the APNs center, you must specify the corresponding environment context. This parameter is optional. Default value: production environment.</para>
                /// <list type="bullet">
                /// <item><description>DEV: the development environment, which applies to applications directly installed and debugged by using Xcode.</description></item>
                /// <item><description>PRODUCT: the production environment, which applies to applications distributed through the App Store, TestFlight, Ad Hoc, and enterprise distribution.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DEV</para>
                /// </summary>
                [NameInMap("ApnsEnv")]
                [Validation(Required=false)]
                public string ApnsEnv { get; set; }

                /// <summary>
                /// <para>The badge of the iOS application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Badge")]
                [Validation(Required=false)]
                public int? Badge { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable the automatic badge increment feature. This parameter is optional. Default value: false.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>This parameter cannot be used together with the badge setting parameter.</description></item>
                /// <item><description>The automatic badge increment feature maintains the badge count for each device on the Alibaba Cloud push server. You must use SDK version 1.9.5 or later to actively synchronize the badge count to the server.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("BadgeAutoIncrement")]
                [Validation(Required=false)]
                public bool? BadgeAutoIncrement { get; set; }

                /// <summary>
                /// <para>The category identifier of the iOS notification, which is used to define the interactive behavior and display style of the notification.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>The category must be pre-registered in the application to take effect.</description></item>
                /// <item><description>Different categories can define different sets of actions.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>MESSAGE_REPLY</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The unique identifier used to control notification grouping. Notifications with the same identifier are overwritten.</para>
                /// 
                /// <b>Example:</b>
                /// <para>order_status_update_12345</para>
                /// </summary>
                [NameInMap("CollapseId")]
                [Validation(Required=false)]
                public string CollapseId { get; set; }

                /// <summary>
                /// <para>The custom extension attributes of the iOS notification.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>The parameter must be passed in standard JSON map format. Incorrect formats cause parsing failures.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;attachment&quot;: &quot;<a href="https://www.example.com/notification_pic.png%22%7D">https://www.example.com/notification_pic.png&quot;}</a></para>
                /// </summary>
                [NameInMap("ExtParameters")]
                [Validation(Required=false)]
                public string ExtParameters { get; set; }

                /// <summary>
                /// <para>The interruption level. This parameter is optional. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>passive: The system adds the notification to the notification list without lighting up the screen or playing a sound.</description></item>
                /// <item><description>active: The system displays the notification immediately, lights up the screen, and may play a sound.</description></item>
                /// <item><description>time-sensitive: The system presents the notification immediately, lights up the screen, and may play a sound, but does not bypass the system notification controls.</description></item>
                /// <item><description>critical: The system displays the notification immediately, lights up the screen, and plays a sound bypassing the silent switch.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("InterruptionLevel")]
                [Validation(Required=false)]
                public string InterruptionLevel { get; set; }

                /// <summary>
                /// <para>The Live Activity parameter object.</para>
                /// <remarks>
                /// <para>Notice: </para>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description>Live Activity push supports pushing to a <b>single device</b> only by using the DEVICE type.</description></item>
                /// <item><description>When pushing to a Live Activity, you do not need to specify the title and body parameters.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("LiveActivity")]
                [Validation(Required=false)]
                public PushTaskNotificationIosLiveActivity LiveActivity { get; set; }
                public class PushTaskNotificationIosLiveActivity : TeaModel {
                    /// <summary>
                    /// <para>The static pass-through parameters for iOS Live Activity push, which are used to pass unchanged business identification information.</para>
                    /// <remarks>
                    /// <para>This parameter is required when Event is set to start.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{
                    ///   &quot;orderId&quot;: &quot;ORD20231201001&quot;,
                    ///   &quot;restaurantName&quot;: &quot;Tasty Restaurant&quot;,
                    ///   &quot;customerAddress&quot;: &quot;No. xx, xx Road, xx District&quot;,
                    ///   &quot;orderType&quot;: &quot;delivery&quot;
                    /// }</para>
                    /// </summary>
                    [NameInMap("Attributes")]
                    [Validation(Required=false)]
                    public string Attributes { get; set; }

                    /// <summary>
                    /// <para>The type of the Live Activity to be started.</para>
                    /// <remarks>
                    /// <para>This parameter is required when Event is set to start.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OrderActivityAttributes</para>
                    /// </summary>
                    [NameInMap("AttributesType")]
                    [Validation(Required=false)]
                    public string AttributesType { get; set; }

                    /// <summary>
                    /// <para>The dynamic pass-through parameters for the Live Activity, which contain status information and changing data that can be updated in real time.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Avoid excessively frequent updates. An interval of 5 seconds or more is recommended.</description></item>
                    /// <item><description>Update multiple fields in batches to reduce the number of pushes.</description></item>
                    /// <item><description>Consider the user experience and avoid interface flickering.</description></item>
                    /// <item><description>Must be a valid JSON string.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{
                    ///     &quot;status&quot;: &quot;delivering&quot;,
                    ///     &quot;estimatedTime&quot;: &quot;10 minutes&quot;,
                    ///     &quot;progress&quot;: 80,
                    ///     &quot;driverName&quot;: &quot;Driver Li&quot;,
                    ///     &quot;currentStep&quot;: &quot;The courier is on the way&quot;
                    /// }</para>
                    /// </summary>
                    [NameInMap("ContentState")]
                    [Validation(Required=false)]
                    public string ContentState { get; set; }

                    /// <summary>
                    /// <para>The retention time of a completed Live Activity on the Lock Screen, which allows users to view the information after the activity ends. The value is a UNIX timestamp in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1701439800</para>
                    /// </summary>
                    [NameInMap("DismissalDate")]
                    [Validation(Required=false)]
                    public long? DismissalDate { get; set; }

                    /// <summary>
                    /// <para>Starts, updates, or ends a live activity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>start</para>
                    /// </summary>
                    [NameInMap("Event")]
                    [Validation(Required=false)]
                    public string Event { get; set; }

                    /// <summary>
                    /// <para>The unique identifier of the Live Activity, which is used to associate the activity instance on the device with the push target on the server.</para>
                    /// <remarks>
                    /// <para>Notice: </para>
                    /// </remarks>
                    /// <list type="bullet">
                    /// <item><description><para>The ID must be the same as the forActivityId parameter in the registerLiveActivityPushToken method of the client SDK.</para>
                    /// </description></item>
                    /// <item><description><para>The server uses this ID to locate the specific activity instance during a push.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FOOD_DELIVERY_ORD20231201001</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The expiration timestamp for the content of the iOS Live Activity. The value is a UNIX timestamp in seconds.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>After the specified time is reached, the system automatically marks the activity as stale.</description></item>
                    /// <item><description>Stale activities are removed from the Dynamic Island and the Lock Screen.</description></item>
                    /// <item><description>This prevents outdated information from occupying the user interface for a long time.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1701425400</para>
                    /// </summary>
                    [NameInMap("StaleDate")]
                    [Validation(Required=false)]
                    public long? StaleDate { get; set; }

                }

                /// <summary>
                /// <para>The sound of the iOS notification. Specify the name of the audio file stored in the app bundle or the Library/Sounds directory of the sandbox. For more information, see <a href="https://help.aliyun.com/document_detail/48906.html">How to set the notification sound for iOS push</a>.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>If an empty string (&quot;&quot;) is specified, the notification is silent.</description></item>
                /// <item><description>If this parameter is not set, the default value default is used, which indicates the system prompt sound.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("Music")]
                [Validation(Required=false)]
                public string Music { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable extended notifications and allow iOS notifications to be processed by the Notification Service Extension.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>This parameter must be set to true when sending silent notifications.</description></item>
                /// <item><description>The processing time of the extension cannot exceed 30 seconds.</description></item>
                /// <item><description>A timeout causes the notification to display the original content.</description></item>
                /// <item><description>You must add the Notification Service Extension to your application.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Mutable")]
                [Validation(Required=false)]
                public bool? Mutable { get; set; }

                /// <summary>
                /// <para>The relevance score of the notification message, which is used to control the priority and display strategy of the notification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("RelevanceScore")]
                [Validation(Required=false)]
                public double? RelevanceScore { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable the silent push mode.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>When sending a silent notification, you do not need to specify the title and body parameters.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Silent")]
                [Validation(Required=false)]
                public bool? Silent { get; set; }

                /// <summary>
                /// <para>The subtitle of the iOS notification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Please check your order</para>
                /// </summary>
                [NameInMap("Subtitle")]
                [Validation(Required=false)]
                public string Subtitle { get; set; }

                /// <summary>
                /// <para>The thread identifier for iOS notification grouping, which is used to group and collapse related notifications.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Notifications with the same thread ID are automatically grouped.</description></item>
                /// <item><description>Multiple related notifications are collapsed into a single notification group.</description></item>
                /// <item><description>Users can expand the group to view all notifications within it.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>news_category_tech</para>
                /// </summary>
                [NameInMap("ThreadId")]
                [Validation(Required=false)]
                public string ThreadId { get; set; }

            }

            /// <summary>
            /// <para>The title of the notification to be pushed.</para>
            /// <remarks>
            /// <para>Length limits:</para>
            /// <list type="bullet">
            /// <item><description>iOS/HarmonyOS: the <b>byte length</b> cannot exceed 200.</description></item>
            /// <item><description>Android: the <b>character length</b> cannot exceed 50.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>You have a new message</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The push options.</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public PushTaskOptions Options { get; set; }
        public class PushTaskOptions : TeaModel {
            /// <summary>
            /// <para>The expiration time of the message. The message is not sent after it expires. The maximum retention period is 72 hours.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>The time must follow the ISO 8601 standard and use UTC time in the YYYY-MM-DDThh:mm:ssZ format.</description></item>
            /// <item><description>The expiration time must meet the following condition: ExpireTime &gt; PushTime + 3 seconds. The 3 seconds are reserved for network and system latency.</description></item>
            /// <item><description>Set the expiration time to at least 1 minute for single-target push tasks and at least 10 minutes for full or batch push tasks.</description></item>
            /// </list>
            /// </remarks>
            /// <remarks>
            /// <para>Notice: For pass-through messages, if the expiration time is not set, the message is sent only to online devices. If the device is offline, the message is discarded.</notice></para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-21T12:00:00Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The custom identifier of the push task. If JobKey is not empty, this field is included in the receipt log. For more information, see <a href="https://help.aliyun.com/document_detail/434651.html">Receipt logs</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jobkey1727749697913</para>
            /// </summary>
            [NameInMap("JobKey")]
            [Validation(Required=false)]
            public string JobKey { get; set; }

            /// <summary>
            /// <para>The unique identity of the message. This parameter is valid only when the Action parameter is set to CONTINUOUS_PUSH.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1174754033128****</para>
            /// </summary>
            [NameInMap("MessageId")]
            [Validation(Required=false)]
            public long? MessageId { get; set; }

            /// <summary>
            /// <para>Specifies the sending time of the message, which can be up to seven days later. Valid only when the Action parameter is set to SCHEDULED_PUSH.</para>
            /// <remarks>
            /// <para>The time must follow the ISO 8601 standard and use UTC time in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-19T12:00:00Z</para>
            /// </summary>
            [NameInMap("PushTime")]
            [Validation(Required=false)]
            public string PushTime { get; set; }

            /// <summary>
            /// <para>The fallback SMS message configuration.</para>
            /// <remarks>
            /// <para>Currently, only Android and HarmonyOS devices are supported.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Sms")]
            [Validation(Required=false)]
            public PushTaskOptionsSms Sms { get; set; }
            public class PushTaskOptionsSms : TeaModel {
                /// <summary>
                /// <para>The delay time before the SMS message is triggered. Unit: seconds.</para>
                /// <para>If you use SMS linkage, this parameter is required. Set this parameter to at least 15 seconds and no more than 3 days to avoid duplicate SMS and push messages.</para>
                /// <remarks>
                /// <para>When SMS linkage is used, the ExpireTime parameter becomes invalid. The expiration time of the notification is calculated based on the DelaySecs parameter. The expiration time is the current time plus the DelaySecs value.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>150</para>
                /// </summary>
                [NameInMap("DelaySecs")]
                [Validation(Required=false)]
                public long? DelaySecs { get; set; }

                /// <summary>
                /// <para>The key-value pairs of the variables in the SMS template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key1=value1&amp;key2=value2</para>
                /// </summary>
                [NameInMap("Params")]
                [Validation(Required=false)]
                public string Params { get; set; }

                /// <summary>
                /// <para>The SMS sending policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PUSH_NOT_RECEIVED</para>
                /// </summary>
                [NameInMap("SendPolicy")]
                [Validation(Required=false)]
                public string SendPolicy { get; set; }

                /// <summary>
                /// <para>The SMS signature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SampleTech</para>
                /// </summary>
                [NameInMap("SignName")]
                [Validation(Required=false)]
                public string SignName { get; set; }

                /// <summary>
                /// <para>The name of the SMS template. You can obtain the name from the SMS template management page. The name is assigned by the system, not specified by the developer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SMS_123456789</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to automatically truncate excessively long titles and content.</para>
            /// <remarks>
            /// <para>This parameter applies only to vendor channels that explicitly limit the title and content length. It does not apply to channels such as APNs, Huawei, and Honor, which do not limit the title and content length but only limit the total request body size.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Trim")]
            [Validation(Required=false)]
            public bool? Trim { get; set; }

            /// <summary>
            /// <para>Specifies the sending channels. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>accs: Alibaba Cloud proprietary channel.</description></item>
            /// <item><description>huawei: Huawei channel.</description></item>
            /// <item><description>honor: Honor channel.</description></item>
            /// <item><description>xiaomi: Xiaomi channel.</description></item>
            /// <item><description>oppo: OPPO channel.</description></item>
            /// <item><description>vivo: vivo channel.</description></item>
            /// <item><description>meizu: Meizu channel.</description></item>
            /// <item><description>fcm: Google Firebase channel (HTTP v1 API).</description></item>
            /// <item><description>apns: APNs channel.</description></item>
            /// <item><description>harmony: HarmonyOS channel.</description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>If this parameter is not configured, all channels are available.</description></item>
            /// <item><description>If this parameter is configured, only the specified channels are used.</description></item>
            /// <item><description>If the configured channels conflict with the sending policy (for example, iOS notifications only use the APNs channel, but apns is not included in this parameter), the message is not sent.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>accs,apns</para>
            /// </summary>
            [NameInMap("UseChannels")]
            [Validation(Required=false)]
            public string UseChannels { get; set; }

        }

        /// <summary>
        /// <para>The target object for the message push. This parameter is optional when the Action parameter is set to CREATE_CONTINUOUS_PUSH (create a continuous push task).</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public PushTaskTarget Target { get; set; }
        public class PushTaskTarget : TeaModel {
            /// <summary>
            /// <para>The platform type. This parameter is optional.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IOS</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <para>The type of the push target.</para>
            /// <remarks>
            /// <para>Notice: </para>
            /// </remarks>
            /// <para>The MassPushV2 batch push API and the CONTINUOUS_PUSH continuous push support only the following three target types:</para>
            /// <list type="bullet">
            /// <item><description>DEVICE (device)</description></item>
            /// <item><description>ACCOUNT (account)</description></item>
            /// <item><description>ALIAS (alias)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DEVICE</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The push targets based on Target.Type. Separate multiple targets with commas. The following section describes the target types and target values in detail:</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>DEVICE: device IDs, such as deviceid1,deviceid2. Maximum of 1,000.</description></item>
            /// <item><description>ACCOUNT: account IDs, such as account1,account2. Maximum of 1,000.</description></item>
            /// <item><description>ALIAS: aliases, such as alias1,alias2. Maximum of 1,000.</description></item>
            /// <item><description>TAG: one or more tags. For the format, see <a href="https://help.aliyun.com/document_detail/434847.html">Tag format specifications</a>.</description></item>
            /// <item><description>ALL: all targets. No value is required. Pushing to all targets may increase costs. Use this option with caution.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
