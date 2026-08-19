// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class PushTask : TeaModel {
        /// <summary>
        /// <para>The push method. Optional parameter. Default value: <c>PUSH_IMMEDIATELY</c> (push immediately).</para>
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
        /// <para>Length calculation notes</para>
        /// <list type="bullet">
        /// <item><description>The length is calculated based on the byte length of the UTF-8 encoded string after the Message object is serialized to JSON.</description></item>
        /// <item><description>Chinese characters typically occupy 3 bytes in UTF-8 encoding.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public PushTaskMessage Message { get; set; }
        public class PushTaskMessage : TeaModel {
            /// <summary>
            /// <para>The body of the message to send.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;key&quot;: &quot;value&quot;}</para>
            /// </summary>
            [NameInMap("Body")]
            [Validation(Required=false)]
            public string Body { get; set; }

            /// <summary>
            /// <para>The title of the message to send.</para>
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
        /// <para>When both <c>Message</c> and <c>Notification</c> are set, the device receives only one of them. The delivery rules are as follows:</para>
        /// <list type="bullet">
        /// <item><description>When the device is online, the pass-through message data is delivered.</description></item>
        /// <item><description>When the device is offline, the system notification is sent.</description></item>
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
                /// <para>The full class name of the Activity for the badge setting application entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>com.alibaba.cloudpushdemo.bizactivity</para>
                /// </summary>
                [NameInMap("BadgeActivity")]
                [Validation(Required=false)]
                public string BadgeActivity { get; set; }

                /// <summary>
                /// <para>The incremental badge count value, which is added to the current badge count.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Supported on <c>Huawei</c> and <c>Honor</c> channels.</description></item>
                /// <item><description>If both <c>BadgeAddNum</c> and <c>BadgeSetNum</c> are specified, <c>BadgeSetNum</c> takes precedence.</description></item>
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
                /// <para>The fixed badge number. Valid values: 1 to 99.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("BadgeSetNum")]
                [Validation(Required=false)]
                public int? BadgeSetNum { get; set; }

                /// <summary>
                /// <para>The channelId of the Android app. This must match the channelId configured in the vendor app.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8.0up</para>
                /// </summary>
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                /// <summary>
                /// <para>The custom extension attributes of the Android notification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;key1&quot;:&quot;value1&quot;}</para>
                /// </summary>
                [NameInMap("ExtParameters")]
                [Validation(Required=false)]
                public string ExtParameters { get; set; }

                /// <summary>
                /// <para>The message group. Only the latest message and the total number of messages received in the group are displayed in the notification bar. All messages are not displayed and cannot be expanded. Currently supported channels:</para>
                /// <list type="bullet">
                /// <item><description>Huawei channel</description></item>
                /// <item><description>Honor channel</description></item>
                /// <item><description>Chinese domestic channel with Android SDK 3.9.1 and earlier</description></item>
                /// </list>
                /// <remarks>
                /// <para>The Chinese domestic channel no longer supports this parameter in Android SDK 3.9.2 and later.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>group-1</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The URL of the right-side icon. Currently supported:</para>
                /// <list type="bullet">
                /// <item><description><c>Huawei EMUI</c> (applicable only in long text mode and Inbox mode).</description></item>
                /// <item><description><c>Honor Magic UI</c> (applicable only in long text mode).</description></item>
                /// <item><description><c>Custom channel</c> (Android SDK 3.5.0 and later).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://imag.example.com/image.png">https://imag.example.com/image.png</a></para>
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// <para>The body content in Inbox mode. The value must be a valid JSON array with no more than 5 elements. Currently supported on:</para>
                /// <list type="bullet">
                /// <item><description>Huawei: EMUI 9 and later</description></item>
                /// <item><description>Honor: Magic UI 4.0 and later</description></item>
                /// <item><description>Xiaomi: MIUI 10 and later</description></item>
                /// <item><description>OPPO: ColorOS later than 5.0</description></item>
                /// <item><description>Custom channel: Android SDK 3.6.0 and later</description></item>
                /// </list>
                /// </summary>
                [NameInMap("InboxContent")]
                [Validation(Required=false)]
                public List<string> InboxContent { get; set; }

                /// <summary>
                /// <para>The notification sound for the Huawei vendor channel. Specify the audio file name stored in the client project directory <c>app/src/main/res/raw/</c> without the file format extension. If not set, the default ringtone is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alicloud_notification_sound</para>
                /// </summary>
                [NameInMap("Music")]
                [Validation(Required=false)]
                public string Music { get; set; }

                /// <summary>
                /// <para>The unique identifier of the Android notification bar message, used to control notification override and replacement behavior. A new notification with the same NotifyId automatically overrides the old notification.</para>
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
                    /// <para>The Alibaba Cloud proprietary channel configuration.</para>
                    /// </summary>
                    [NameInMap("Accs")]
                    [Validation(Required=false)]
                    public PushTaskNotificationAndroidOptionsAccs Accs { get; set; }
                    public class PushTaskNotificationAndroidOptionsAccs : TeaModel {
                        /// <summary>
                        /// <para>The custom notification bar style for Android. Valid values: 1 to 100.</para>
                        /// <remarks>
                        /// <para>The style preset must be configured on the client. For more information, see <a href="https://help.aliyun.com/document_detail/2834944.html">Custom notification style API</a>.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("CustomStyle")]
                        [Validation(Required=false)]
                        public int? CustomStyle { get; set; }

                        /// <summary>
                        /// <para>The notification alert type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>VIBRATE</c>: vibration (default)</description></item>
                        /// <item><description><c>SOUND</c>: sound</description></item>
                        /// <item><description><c>BOTH</c>: sound and vibration</description></item>
                        /// <item><description><c>NONE</c>: silent</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NONE</para>
                        /// </summary>
                        [NameInMap("NotifyType")]
                        [Validation(Required=false)]
                        public string NotifyType { get; set; }

                        /// <summary>
                        /// <para>The activity to open when the notification is tapped. This parameter takes effect only when <c>OpenType</c> is set to <c>ACTIVITY</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>com.alibaba.cloudpushdemo.bizactivity</para>
                        /// </summary>
                        [NameInMap("OpenActivity")]
                        [Validation(Required=false)]
                        public string OpenActivity { get; set; }

                        /// <summary>
                        /// <para>The action after tapping the notification. Valid values:</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>APPLICATION</para>
                        /// </summary>
                        [NameInMap("OpenType")]
                        [Validation(Required=false)]
                        public string OpenType { get; set; }

                        /// <summary>
                        /// <para>The URL to open when the notification is tapped on Android. This is valid when <c>OpenType</c> is set to <c>URL</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="http://www.example.com">www.example.com</a></para>
                        /// </summary>
                        [NameInMap("OpenUrl")]
                        [Validation(Required=false)]
                        public string OpenUrl { get; set; }

                        /// <summary>
                        /// <para>The priority of the Android notification position in the notification bar. Valid values: -2, -1, 0, 1, 2.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Priority")]
                        [Validation(Required=false)]
                        public int? Priority { get; set; }

                        /// <summary>
                        /// <para>The message group. Messages in the same group are collapsed in the notification bar and can be expanded. Messages in different groups are displayed separately.</para>
                        /// <remarks>
                        /// <para>Android SDK 3.9.2 and later</para>
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
                    /// <para>The Honor channel configuration.</para>
                    /// </summary>
                    [NameInMap("Honor")]
                    [Validation(Required=false)]
                    public PushTaskNotificationAndroidOptionsHonor Honor { get; set; }
                    public class PushTaskNotificationAndroidOptionsHonor : TeaModel {
                        /// <summary>
                        /// <para>Specifies the importance parameter for Honor notification message classification, which determines the notification behavior on the user\&quot;s device. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>0</c>: informational and marketing messages</description></item>
                        /// <item><description><c>1</c>: service and communication messages</description></item>
                        /// </list>
                        /// <para>You must apply for this on the Honor platform. <a href="https://developer.honor.com/cn/docs/11002/guides/notification-class#%E8%87%AA%E5%88%86%E7%B1%BB%E6%9D%83%E7%9B%8A%E7%94%B3%E8%AF%B7">Application link</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Importance")]
                        [Validation(Required=false)]
                        public int? Importance { get; set; }

                    }

                    /// <summary>
                    /// <para>The Huawei channel configuration.</para>
                    /// </summary>
                    [NameInMap("Huawei")]
                    [Validation(Required=false)]
                    public PushTaskNotificationAndroidOptionsHuawei Huawei { get; set; }
                    public class PushTaskNotificationAndroidOptionsHuawei : TeaModel {
                        /// <summary>
                        /// <para>The Huawei quick notification parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("BusinessType")]
                        [Validation(Required=false)]
                        public int? BusinessType { get; set; }

                        /// <summary>
                        /// <para>Purpose 1: After completing the <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/message-classification-0000001149358835?#section3410731125514">self-classification privilege</a> application, this parameter identifies the message type, determines the <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/message-classification-0000001149358835#ZH-CN_TOPIC_0000001149358835__p3850133955718">notification method</a>, and accelerates delivery for specific message types. For valid values, refer to the <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/message-classification-0000001149358835#section1076611477914">message classification standard</a> in the official Huawei Push documentation. Use the value from the &quot;Cloud notification category value&quot; or &quot;Local notification category value&quot; column in the table.</para>
                        /// <para>Purpose 2: After <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/faq-0000001050042183#section037425218509">applying for special permissions</a>, this parameter identifies high-priority pass-through scenarios. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>VOIP</c>: audio and video calls</description></item>
                        /// <item><description><c>PLAY_VOICE</c>: voice broadcast</description></item>
                        /// </list>
                        /// <remarks>
                        /// <list type="bullet">
                        /// <item><description>For messages where the &quot;Cloud notification category value&quot; is &quot;Not applicable&quot;, messages are sent through the Alibaba Cloud proprietary channel.</description></item>
                        /// <item><description>For messages where the &quot;Local notification category value&quot; is &quot;Not applicable&quot;, messages are sent through the Huawei channel.</description></item>
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
                        /// <para>The importance parameter for Huawei notification message classification, which determines the notification behavior on the user device. Valid values:</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Importance")]
                        [Validation(Required=false)]
                        public int? Importance { get; set; }

                        /// <summary>
                        /// <para>The JSON string of the Huawei Android Live Notification data structure <a href="https://developer.huawei.com/consumer/cn/doc/HMSCore-References/rest-live-0000001562939968#ZH-CN_TOPIC_0000001700850537__p195121620102511">LiveNotificationPayload</a>. For development and integration, refer to <a href="https://help.aliyun.com/document_detail/2983768.html">Huawei Live Notification Push Guide</a>.</para>
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
                        /// <para>The receipt ID of the Huawei channel. You can view this receipt ID in the receipt parameter configuration on the Huawei channel push operation platform.</para>
                        /// <remarks>
                        /// <para>If the default receipt configuration on the Huawei channel push operation platform is set to Alibaba Cloud receipt, you do not need to provide this parameter. If not, configure the default Huawei channel receipt ID in the Alibaba Cloud EMAS Mobile Push console first.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>RCP4C123456</para>
                        /// </summary>
                        [NameInMap("ReceiptId")]
                        [Validation(Required=false)]
                        public string ReceiptId { get; set; }

                        /// <summary>
                        /// <para>The delivery priority of the Huawei channel notification. Valid values:</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NORMAL</para>
                        /// </summary>
                        [NameInMap("Urgency")]
                        [Validation(Required=false)]
                        public string Urgency { get; set; }

                    }

                    /// <summary>
                    /// <para>The Meizu channel configuration.</para>
                    /// </summary>
                    [NameInMap("Meizu")]
                    [Validation(Required=false)]
                    public PushTaskNotificationAndroidOptionsMeizu Meizu { get; set; }
                    public class PushTaskNotificationAndroidOptionsMeizu : TeaModel {
                        /// <summary>
                        /// <para>The Meizu message type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("NoticeMsgType")]
                        [Validation(Required=false)]
                        public int? NoticeMsgType { get; set; }

                    }

                    /// <summary>
                    /// <para>The OPPO channel configuration.</para>
                    /// </summary>
                    [NameInMap("Oppo")]
                    [Validation(Required=false)]
                    public PushTaskNotificationAndroidOptionsOppo Oppo { get; set; }
                    public class PushTaskNotificationAndroidOptionsOppo : TeaModel {
                        /// <summary>
                        /// <para>OPPO categorizes messages into two types for management: Communication &amp; Service, and Content &amp; Marketing.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NEWS</para>
                        /// </summary>
                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        /// <summary>
                        /// <para>The JSON character string of the OPPO Fluid Cloud intent delete data structure <a href="https://open.oppomobile.com/documentation/page/info?id=13578">data</a>. This parameter is invalid when the AndroidOppoIntelligentIntent parameter is already specified. References: <a href="https://help.aliyun.com/document_detail/2997310.html">OPPO Fluid Cloud Push Guide</a>.</para>
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
                        /// <para>The JSON character string of the OPPO Fluid Cloud intent sharing data structure <a href="https://open.oppomobile.com/documentation/page/info?id=13565">IntelligentIntent</a>. References: <a href="https://help.aliyun.com/document_detail/2997310.html">OPPO Fluid Cloud Push Guide</a>.</para>
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
                        /// <para>The notification bar message alert level for the OPPO channel. Valid values:</para>
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
                        /// <para>{&quot;name&quot;: &quot;John&quot;}</para>
                        /// </summary>
                        [NameInMap("PrivateTitleParameters")]
                        [Validation(Required=false)]
                        public string PrivateTitleParameters { get; set; }

                    }

                    /// <summary>
                    /// <para>The vivo channel configuration.</para>
                    /// </summary>
                    [NameInMap("Vivo")]
                    [Validation(Required=false)]
                    public PushTaskNotificationAndroidOptionsVivo Vivo { get; set; }
                    public class PushTaskNotificationAndroidOptionsVivo : TeaModel {
                        [NameInMap("AddBadge")]
                        [Validation(Required=false)]
                        public bool? AddBadge { get; set; }

                        /// <summary>
                        /// <para>vivo categorizes messages into two types: system messages and operational messages.</para>
                        /// <para><b>System messages:</b></para>
                        /// <list type="bullet">
                        /// <item><description>IM: instant messaging</description></item>
                        /// <item><description>ACCOUNT: accounts and assets</description></item>
                        /// <item><description>TODO: schedules and to-do items</description></item>
                        /// <item><description>DEVICE_REMINDER: device information</description></item>
                        /// <item><description>ORDER: orders and logistics</description></item>
                        /// <item><description>SUBSCRIPTION: subscription reminders</description></item>
                        /// </list>
                        /// <para><b>Operational messages:</b></para>
                        /// <list type="bullet">
                        /// <item><description>NEWS: news</description></item>
                        /// <item><description>CONTENT: content recommendation</description></item>
                        /// <item><description>MARKETING: operational activity</description></item>
                        /// <item><description>SOCIAL: social updates</description></item>
                        /// </list>
                        /// <para>For more information, refer to <a href="https://dev.vivo.com.cn/documentCenter/doc/359#s-ef3qugc3">vivo category description</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MARKETING</para>
                        /// </summary>
                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        /// <summary>
                        /// <para>Specifies the vivo notification message category. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>0</c>: Operational message (default).</description></item>
                        /// <item><description><c>1</c>: System message.</description></item>
                        /// </list>
                        /// <remarks>
                        /// <para>Use <c>Category</c> for notification classification. You need to apply on the vivo platform. For more information, see <a href="https://dev.vivo.com.cn/documentCenter/doc/359">Application link</a>.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Importance")]
                        [Validation(Required=false)]
                        public int? Importance { get; set; }

                        /// <summary>
                        /// <para>The JSON character string of the vivo Atomic Island data structure <a href="https://dev.vivo.com.cn/documentCenter/doc/896#s-fdagzbd4">liveMessage</a>. References: <a href="https://www.alibabacloud.com/help/en/document_detail/3030718.html">vivo Atomic Island Push Guide</a>.</para>
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
                        /// <para>The message receipt identifier for the vivo vendor push channel, used to receive push result callback notifications.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1232221</para>
                        /// </summary>
                        [NameInMap("ReceiptId")]
                        [Validation(Required=false)]
                        public string ReceiptId { get; set; }

                    }

                    /// <summary>
                    /// <para>The Xiaomi channel configuration.</para>
                    /// </summary>
                    [NameInMap("Xiaomi")]
                    [Validation(Required=false)]
                    public PushTaskNotificationAndroidOptionsXiaomi Xiaomi { get; set; }
                    public class PushTaskNotificationAndroidOptionsXiaomi : TeaModel {
                        /// <summary>
                        /// <para>The channel ID for Xiaomi notification types. You must apply for this on the Xiaomi platform. For more information, see <a href="https://dev.mi.com/console/doc/detail?pId=2422#_4">Application link</a>.</para>
                        /// <remarks>
                        /// <para>A single application can apply for a maximum of 8 channels on the Xiaomi channel. Plan ahead.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>michannel</para>
                        /// </summary>
                        [NameInMap("Channel")]
                        [Validation(Required=false)]
                        public string Channel { get; set; }

                        /// <summary>
                        /// <para>The JSON character string of the Xiaomi Super Island data structure <a href="https://dev.mi.com/xiaomihyperos/documentation/detail?pId=2131">miui.focus.param</a>. References: <a href="https://www.alibabacloud.com/help/en/document_detail/3037956.html">Xiaomi Super Island Push Guide</a>.</para>
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
                        /// <para>The JSON character string of the Xiaomi Super Island image data <a href="https://dev.mi.com/xiaomihyperos/documentation/detail?pId=2131">miui.focus.pic_xxx</a>. References: <a href="https://www.alibabacloud.com/help/en/document_detail/3037956.html">Xiaomi Super Island Push Guide</a>.</para>
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
                        /// <para>The Xiaomi private message template parameters in JSON string format.</para>
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
                /// <para>The image URL in big picture mode. Currently supported: proprietary channel: Android SDK 3.6.0 and later.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://imag.example.com/image.png">https://imag.example.com/image.png</a></para>
                /// </summary>
                [NameInMap("PictureUrl")]
                [Validation(Required=false)]
                public string PictureUrl { get; set; }

                /// <summary>
                /// <para>The notification style. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RenderStyle")]
                [Validation(Required=false)]
                public string RenderStyle { get; set; }

                /// <summary>
                /// <para>Specifies the notification type for the manufacturer channel. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>false</c>: Production notification. This is the default value.</description></item>
                /// <item><description><c>true</c>: Test notification.</description></item>
                /// </list>
                /// <remarks>
                /// <para>Currently supported: Huawei channel, Honor channel, vivo channel, and OPPO Fluid Cloud.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("TestMessage")]
                [Validation(Required=false)]
                public bool? TestMessage { get; set; }

                /// <summary>
                /// <para>The Activity to open when the notification is tapped.</para>
                /// 
                /// <b>Example:</b>
                /// <para>com.alibaba.cloudpushdemo.bizactivity</para>
                /// </summary>
                [NameInMap("VendorChannelActivity")]
                [Validation(Required=false)]
                public string VendorChannelActivity { get; set; }

            }

            /// <summary>
            /// <para>The body of the push notification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Dear customer, your reservation order has been successfully canceled</para>
            /// </summary>
            [NameInMap("Body")]
            [Validation(Required=false)]
            public string Body { get; set; }

            /// <summary>
            /// <para>The HarmonyOS notification configuration.</para>
            /// </summary>
            [NameInMap("Hmos")]
            [Validation(Required=false)]
            public PushTaskNotificationHmos Hmos { get; set; }
            public class PushTaskNotificationHmos : TeaModel {
                /// <summary>
                /// <para>The action that corresponds to the ability of the in-app page.</para>
                /// <remarks>
                /// <para>For more information, refer to <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section152462191216">ClickAction.action</a> on the HarmonyOS official website.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>com.example.action</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The incremental badge number for HarmonyOS applications.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Supported since HarmonyOS SDK 1.2.0.</description></item>
                /// <item><description>Refer to the HarmonyOS badge <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section266310382145">addNum field description</a>.</description></item>
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
                /// <para>The number to set for the HarmonyOS app badge.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Refer to the HarmonyOS badge <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section266310382145">setNum field</a> description.</description></item>
                /// <item><description>Supported since HarmonyOS SDK version 1.2.0.</description></item>
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
                /// <para>The category of the notification message. This is an optional parameter. Default value: <c>MARKETING</c>.</para>
                /// <remarks>
                /// <para>After you complete the application for the notification message self-classification privilege, this parameter identifies the message type. Different notification message types affect how messages are displayed and how reminders are triggered. For more information, refer to <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section17371529101117">Notification.category</a> on the HarmonyOS official website.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>IM</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The custom extension attributes of the notification message, used to pass additional business data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;key&quot;: &quot;value&quot;}</para>
                /// </summary>
                [NameInMap("ExtParameters")]
                [Validation(Required=false)]
                public string ExtParameters { get; set; }

                /// <summary>
                /// <para>The extra data of the notification extension message.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Valid when sending HarmonyOS notification extension messages.</description></item>
                /// <item><description>Conceptually equivalent to the extraData field of HarmonyOS notification extension messages. For the specific definition, refer to the HarmonyOS <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section161192514234">ExtensionPayload</a> documentation.</description></item>
                /// <item><description>Supported since HarmonyOS SDK 1.2.0.</description></item>
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
                /// <para>Enables HarmonyOS notification extension.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>To send notification extension messages, you must first apply for permissions on the HarmonyOS official website. For more information, refer to <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-guides-V5/push-send-extend-noti-V5">HarmonyOS documentation</a> on sending notification extension messages.</description></item>
                /// <item><description>Supported starting from HarmonyOS SDK 1.2.0.</description></item>
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
                /// <para>The URL of the large icon displayed on the right side of the notification. The URL must use the HTTPS protocol.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Supported image formats include png, jpg, jpeg, heif, gif, and bmp. The image length × width must be less than 25000 pixels.</description></item>
                /// <item><description>For more information, refer to the HarmonyOS official documentation <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section17371529101117">Notification.image</a>.</description></item>
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
                /// <para>When <c>RenderStyle</c> is set to <c>MULTI_LINE</c>, this field is required to define the content in multi-line text style. A maximum of 3 items are supported.</para>
                /// </summary>
                [NameInMap("InboxContent")]
                [Validation(Required=false)]
                public List<string> InboxContent { get; set; }

                /// <summary>
                /// <para>The JSON string of the HarmonyOS Live View data structure <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V13/push-scenariozed-api-request-param-V13#section66881469306">LiveViewPayload</a>. For development and integration, refer to <a href="https://help.aliyun.com/document_detail/2982112.html">HarmonyOS Live View Push Guide</a>.</para>
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
                /// <para>The unique identifier (notifyId) for each message displayed in the notification bar. If not provided, the push service automatically generates a unique identifier. Different notification messages can use the same notifyId to enable new messages to overwrite old messages. For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section17371529101117">Notification.notifyId</a> on the HarmonyOS official website.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("NotifyId")]
                [Validation(Required=false)]
                public int? NotifyId { get; set; }

                /// <summary>
                /// <para>The receipt ID of the HarmonyOS channel. You can view this receipt ID in the receipt parameter settings on the HarmonyOS channel push operation platform.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RCPB***DFD5</para>
                /// </summary>
                [NameInMap("ReceiptId")]
                [Validation(Required=false)]
                public string ReceiptId { get; set; }

                /// <summary>
                /// <para>The notification message style. This is an optional parameter. Default value: normal notification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("RenderStyle")]
                [Validation(Required=false)]
                public string RenderStyle { get; set; }

                /// <summary>
                /// <para>Specifies the notification channel type to use.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Valid only for the Alibaba Cloud proprietary channel.</description></item>
                /// <item><description>For more information, refer to the HarmonyOS official documentation <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/js-apis-notificationmanager-V5#slottype">SlotType</a>.</description></item>
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
                /// <para>The HarmonyOS custom ringtone file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>music.mp3</para>
                /// </summary>
                [NameInMap("Sound")]
                [Validation(Required=false)]
                public string Sound { get; set; }

                /// <summary>
                /// <para>The custom notification ringtone duration in seconds. Valid values: 1 to 60. The ringtone loops if its duration is shorter than the specified value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("SoundDuration")]
                [Validation(Required=false)]
                public int? SoundDuration { get; set; }

                /// <summary>
                /// <para>Enables the test message.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>For more information, refer to the HarmonyOS push parameter <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section418321011212">TestMessage</a>.</description></item>
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
                /// <para>The URI that corresponds to the in-app page ability.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>When multiple Abilities exist, specify the action and URI for each Ability separately. The action is used first to find the corresponding in-app page.</description></item>
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
            /// <para>The iOS notification configuration.</para>
            /// </summary>
            [NameInMap("Ios")]
            [Validation(Required=false)]
            public PushTaskNotificationIos Ios { get; set; }
            public class PushTaskNotificationIos : TeaModel {
                /// <summary>
                /// <para>iOS notifications are sent through the APNs center. You need to specify the corresponding environment information. Optional parameter. Default value: production environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEV</para>
                /// </summary>
                [NameInMap("ApnsEnv")]
                [Validation(Required=false)]
                public string ApnsEnv { get; set; }

                /// <summary>
                /// <para>The iOS application badge number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Badge")]
                [Validation(Required=false)]
                public int? Badge { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable the badge auto-increment feature. Optional parameter. Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("BadgeAutoIncrement")]
                [Validation(Required=false)]
                public bool? BadgeAutoIncrement { get; set; }

                /// <summary>
                /// <para>The category identifier for the iOS notification, which defines the interaction behavior and display style of the notification.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>The category must be pre-registered in the app to take effect.</description></item>
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
                /// <para>The unique identifier for notification collapsing. Notifications with the same identifier are overwritten and displayed as one.</para>
                /// 
                /// <b>Example:</b>
                /// <para>order_status_update_12345</para>
                /// </summary>
                [NameInMap("CollapseId")]
                [Validation(Required=false)]
                public string CollapseId { get; set; }

                /// <summary>
                /// <para>The custom extension attributes of the iOS notification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;attachment&quot;: &quot;<a href="https://xxxx.xxx/notification_pic.png%22%7D">https://xxxx.xxx/notification_pic.png&quot;}</a></para>
                /// </summary>
                [NameInMap("ExtParameters")]
                [Validation(Required=false)]
                public string ExtParameters { get; set; }

                /// <summary>
                /// <para>The interruption level. Optional parameter. Valid values:</para>
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
                /// <item><description>Live Activity push notifications can only be sent to a <b>single device</b> by specifying the <c>DEVICE</c> type.</description></item>
                /// <item><description>When pushing Live Activity notifications, the title and body parameters are optional.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("LiveActivity")]
                [Validation(Required=false)]
                public PushTaskNotificationIosLiveActivity LiveActivity { get; set; }
                public class PushTaskNotificationIosLiveActivity : TeaModel {
                    /// <summary>
                    /// <para>The static pass-through parameter for iOS Live Activities push notifications, used to pass immutable business identifier information.</para>
                    /// <remarks>
                    /// <para>Required when <c>Event</c> is set to start.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{
                    ///   &quot;orderId&quot;: &quot;ORD20231201001&quot;,
                    ///   &quot;restaurantName&quot;: &quot;Delicious Restaurant&quot;,
                    ///   &quot;customerAddress&quot;: &quot;No. xx, xx Road, xx District&quot;,
                    ///   &quot;orderType&quot;: &quot;delivery&quot;
                    /// }</para>
                    /// </summary>
                    [NameInMap("Attributes")]
                    [Validation(Required=false)]
                    public string Attributes { get; set; }

                    /// <summary>
                    /// <para>The type of the Live Activity to start.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OrderActivityAttributes</para>
                    /// </summary>
                    [NameInMap("AttributesType")]
                    [Validation(Required=false)]
                    public string AttributesType { get; set; }

                    /// <summary>
                    /// <para>The dynamic pass-through parameters of the Live Activity, containing real-time updatable status information and changing data.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{
                    ///     &quot;status&quot;: &quot;delivering&quot;,
                    ///     &quot;estimatedTime&quot;: &quot;10 minutes&quot;,
                    ///     &quot;progress&quot;: 80,
                    ///     &quot;driverName&quot;: &quot;Driver Li&quot;,
                    ///     &quot;currentStep&quot;: &quot;The delivery driver is on the way&quot;}
                    /// }</para>
                    /// </summary>
                    [NameInMap("ContentState")]
                    [Validation(Required=false)]
                    public string ContentState { get; set; }

                    /// <summary>
                    /// <para>The retention time of an ended Live Activity on the lock screen, allowing users to view information after the activity ends. The value is a UNIX timestamp in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1701439800</para>
                    /// </summary>
                    [NameInMap("DismissalDate")]
                    [Validation(Required=false)]
                    public long? DismissalDate { get; set; }

                    /// <summary>
                    /// <para>Starts, updates, or ends a Live Activity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>start</para>
                    /// </summary>
                    [NameInMap("Event")]
                    [Validation(Required=false)]
                    public string Event { get; set; }

                    /// <summary>
                    /// <para>The unique identifier of the Live Activity, used to associate the device-side activity instance with the server-side push target.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FOOD_DELIVERY_ORD20231201001</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The expiration timestamp for the iOS Live Activity content, specified as a Unix timestamp in seconds.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>After the specified time is reached, the system automatically marks the activity as expired.</description></item>
                    /// <item><description>Expired activities are removed from the Dynamic Island and Lock Screen.</description></item>
                    /// <item><description>This prevents outdated information from occupying the user interface for an extended period.</description></item>
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
                /// <para>The notification sound for iOS. Specify the name of an audio file stored in the app bundle or the Library/Sounds directory of the sandbox. For more information, see <a href="https://help.aliyun.com/document_detail/48906.html">How to set notification sounds for iOS push</a>.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>If set to an empty string (&quot;&quot;), the notification is silent.</description></item>
                /// <item><description>If not specified, the value defaults to &quot;default&quot;, which plays the system alert sound.</description></item>
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
                /// <para>Specifies whether to enable the notification extension, which controls whether iOS notifications support processing by Notification Service Extension.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>When sending silent notifications, this parameter must be set to true.</description></item>
                /// <item><description>The Extension processing time cannot exceed 30 seconds.</description></item>
                /// <item><description>A timeout causes the notification to display the original content.</description></item>
                /// <item><description>You must add a Notification Service Extension to your application.</description></item>
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
                /// <para>The relevance score of the notification message, used to control the priority and display strategy of the notification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("RelevanceScore")]
                [Validation(Required=false)]
                public double? RelevanceScore { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable silent push mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Silent")]
                [Validation(Required=false)]
                public bool? Silent { get; set; }

                /// <summary>
                /// <para>The subtitle content of the iOS notification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Please check your order</para>
                /// </summary>
                [NameInMap("Subtitle")]
                [Validation(Required=false)]
                public string Subtitle { get; set; }

                /// <summary>
                /// <para>The thread identifier for iOS notification grouping, which is used to categorize and collapse related notifications.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Notifications with the same thread-id are automatically grouped together.</description></item>
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
            /// <para>The title of the push notification.</para>
            /// <remarks>
            /// <para>Length limits:</para>
            /// <list type="bullet">
            /// <item><description>iOS/Harmony: The <b>byte length</b> cannot exceed 200.</description></item>
            /// <item><description>Android: The <b>character length</b> cannot exceed 50.</description></item>
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
            /// <para>The expiration time of the message. The message will not be sent after it expires. Messages can be retained for up to 72 hours.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>The time follows the ISO 8601 standard in UTC. Format: YYYY-MM-DDThh:mm:ssZ.</description></item>
            /// <item><description>The expiration time must meet the following condition: ExpireTime &gt; PushTime + 3 seconds (3 seconds is the redundancy for network and system latency).</description></item>
            /// <item><description>Recommendation: Set the expiration time to at least 1 minute for single push notifications and at least 10 minutes for full push or batch push notifications.</description></item>
            /// </list>
            /// </remarks>
            /// <remarks>
            /// <para>Notice: For pass-through messages, if no expiration time is set, the message is sent only to online devices. When the device is offline, the message is discarded.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-21T12:00:00Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The custom identifier for the push task. When JobKey is not empty, this field is included in the receipt log. For more information about receipt logs, see <a href="https://help.aliyun.com/document_detail/434651.html">Receipt logs</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jobkey1727749697913</para>
            /// </summary>
            [NameInMap("JobKey")]
            [Validation(Required=false)]
            public string JobKey { get; set; }

            /// <summary>
            /// <para>The unique ID used to identify the message. This parameter is valid only when the <c>Action</c> parameter is set to <c>CONTINUOUS_PUSH</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1174754033128****</para>
            /// </summary>
            [NameInMap("MessageId")]
            [Validation(Required=false)]
            public long? MessageId { get; set; }

            /// <summary>
            /// <para>The scheduled time to send the message. The value cannot be later than 7 days from the current time. This parameter takes effect only when <c>Action</c> is set to <c>SCHEDULED_PUSH</c>.</para>
            /// <remarks>
            /// <para>The time follows the ISO 8601 standard in UTC in the format of yyyy-MM-ddTHH:mm:ssZ.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-19T12:00:00Z</para>
            /// </summary>
            [NameInMap("PushTime")]
            [Validation(Required=false)]
            public string PushTime { get; set; }

            /// <summary>
            /// <para>The supplementary SMS settings.</para>
            /// </summary>
            [NameInMap("Sms")]
            [Validation(Required=false)]
            public PushTaskOptionsSms Sms { get; set; }
            public class PushTaskOptionsSms : TeaModel {
                /// <summary>
                /// <para>The delay before triggering the SMS message. Unit: seconds.</para>
                /// <para>This parameter is required when SMS linkage is used. We recommend that you set this parameter to at least 15 seconds and no more than 3 days to avoid duplicate notifications from both SMS and push.</para>
                /// <remarks>
                /// <para>When SMS linkage is used, the ExpireTime parameter does not take effect. The notification expiration time is calculated based on the DelaySecs parameter. The expiration time is the current time plus the DelaySecs value.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>150</para>
                /// </summary>
                [NameInMap("DelaySecs")]
                [Validation(Required=false)]
                public long? DelaySecs { get; set; }

                /// <summary>
                /// <para>The key-value pairs of variable names in the SMS template.</para>
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
                /// <para>The SMS template name. You can obtain this name from the SMS template management page. This is the system-assigned name, not the name set by the developer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SMS_123456789</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to automatically truncate titles and content that exceed the length limit.</para>
            /// <remarks>
            /// <para>This parameter applies only to vendor channels that explicitly limit the title and content length. It does not apply to channels such as APNs, Huawei, and Honor that do not limit the title or content length but only limit the total request body size.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Trim")]
            [Validation(Required=false)]
            public bool? Trim { get; set; }

            /// <summary>
            /// <para>Specifies the delivery channels. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>accs</c>: Alibaba Cloud proprietary channel</description></item>
            /// <item><description><c>huawei</c>: Huawei channel</description></item>
            /// <item><description><c>honor</c>: Honor channel</description></item>
            /// <item><description><c>xiaomi</c>: Xiaomi channel</description></item>
            /// <item><description><c>oppo</c>: OPPO channel</description></item>
            /// <item><description><c>vivo</c>: vivo channel</description></item>
            /// <item><description><c>meizu</c>: Meizu channel</description></item>
            /// <item><description><c>fcm</c>: Google Firebase channel (HTTP v1 API)</description></item>
            /// <item><description><c>apns</c>: APNs channel</description></item>
            /// <item><description><c>harmony</c>: HarmonyOS channel</description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>If this parameter is not specified, all channels are available.</description></item>
            /// <item><description>If this parameter is specified, only the specified channels are used.</description></item>
            /// <item><description>If the specified channels conflict with the delivery policy (for example, iOS notifications can only be delivered through the APNs channel, but apns is not included in this parameter), the message is not delivered.</description></item>
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
        /// <para>Specifies the target object for message push. This parameter is optional when the operation type <c>Action</c> is set to <c>CREATE_CONTINUOUS_PUSH</c> (create a continuous push task).</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public PushTaskTarget Target { get; set; }
        public class PushTaskTarget : TeaModel {
            /// <summary>
            /// <para>The platform type. Optional parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IOS</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <para>The push target type.</para>
            /// <remarks>
            /// <para>Notice: </para>
            /// </remarks>
            /// <para>The batch push operation <c>MassPushV2</c> and continuous push <c>CONTINUOUS_PUSH</c> support only the following three target types:</para>
            /// <list type="bullet">
            /// <item><description><c>DEVICE</c></description></item>
            /// <item><description><c>ACCOUNT</c></description></item>
            /// <item><description><c>ALIAS</c></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DEVICE</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The push target based on <c>Target.Type</c>. Separate multiple targets with commas. The following describes the target types and target values:</para>
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
