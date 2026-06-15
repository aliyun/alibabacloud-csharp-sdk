// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class PushTask : TeaModel {
        /// <summary>
        /// <para>The push method. This is an optional parameter. The default value is <c>PUSH_IMMEDIATELY</c> (immediate push).</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>The <c>MassPushV2</c> batch push API supports only the following push methods:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PUSH_IMMEDIATELY</c> (immediate push)</para>
        /// </description></item>
        /// <item><description><para><c>SCHEDULED_PUSH</c> (scheduled push)</para>
        /// </description></item>
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
        /// <para>Length calculation</para>
        /// <list type="bullet">
        /// <item><description><para>The length is calculated based on the byte length of the UTF-8 encoded string after the Message object is serialized into JSON.</para>
        /// </description></item>
        /// <item><description><para>A Chinese character typically occupies 3 bytes in UTF-8 encoding.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public PushTaskMessage Message { get; set; }
        public class PushTaskMessage : TeaModel {
            /// <summary>
            /// <para>The content of the message to send.</para>
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
        /// <para>If you set both <c>Message</c> and <c>Notification</c>, the device receives only one. The sending rules are as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>If the device is online, pass-through message data is sent.</para>
        /// </description></item>
        /// <item><description><para>If the device is offline, a system notification is sent.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public PushTaskNotification Notification { get; set; }
        public class PushTaskNotification : TeaModel {
            /// <summary>
            /// <para>Android notification configuration</para>
            /// </summary>
            [NameInMap("Android")]
            [Validation(Required=false)]
            public PushTaskNotificationAndroid Android { get; set; }
            public class PushTaskNotificationAndroid : TeaModel {
                /// <summary>
                /// <para>The full class name of the application entry Activity for badge settings.</para>
                /// <remarks>
                /// <para>This is only valid when pushing through the Huawei or Honor vendor channel.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>com.alibaba.cloudpushdemo.bizactivity</para>
                /// </summary>
                [NameInMap("BadgeActivity")]
                [Validation(Required=false)]
                public string BadgeActivity { get; set; }

                /// <summary>
                /// <para>Sets a cumulative value for the badge, which is added to the original badge number.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>This is supported by <c>Huawei</c> and <c>Honor</c> channels.</para>
                /// </description></item>
                /// <item><description><para>If both <c>BadgeAddNum</c> and <c>BadgeSetNum</c> are present, the latter takes precedence.</para>
                /// </description></item>
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
                /// <para>Sets a fixed value for the badge number. The value range is [1, 99].</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>For vendor channel pushes, this is only effective for Huawei and Honor channels.</para>
                /// </description></item>
                /// <item><description><para>When pushing through Alibaba Cloud\&quot;s proprietary channel, this is only effective on Huawei, Honor, and vivo models.</para>
                /// </description></item>
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
                /// <para>Sets the channelId for the Android app. It must correspond to the channelId in the vendor\&quot;s app.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>Because the channel_id for OPPO\&quot;s private message notification channel is the same as the app\&quot;s channelId, the channel_id takes this value when pushing through the OPPO channel.</para>
                /// </description></item>
                /// <item><description><para>For pushes through Huawei, FCM, and Alibaba Cloud\&quot;s proprietary channels, the channel_id takes this value.</para>
                /// </description></item>
                /// <item><description><para>For specific uses, see the FAQ: <a href="https://help.aliyun.com/document_detail/67398.html">Notifications not received on Android 8.0 and later devices</a>.</para>
                /// </description></item>
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
                /// <para>Custom extension properties for Android notifications.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>The parameter must be passed in a standard JSON Map format. An incorrect format causes parsing to fail.</description></item>
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
                /// <para>Message grouping. For messages in the same group, only the latest one and the total number of messages received in that group are displayed in the notification bar. Not all messages are displayed, and they cannot be expanded. Currently supported by:</para>
                /// <list type="bullet">
                /// <item><description><para>Huawei vendor channel</para>
                /// </description></item>
                /// <item><description><para>Honor vendor channel</para>
                /// </description></item>
                /// <item><description><para>Proprietary channels with Android SDK 3.9.1 and earlier</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter is no longer supported by proprietary channels in Android SDK 3.9.2 and later versions.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>group-1</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The URL for the icon on the right. Currently supported by:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Huawei EMUI</c> (only applicable in long text mode and Inbox mode).</para>
                /// </description></item>
                /// <item><description><para><c>Honor Magic UI</c> (only applicable in long text mode).</para>
                /// </description></item>
                /// <item><description><para><c>Proprietary channels</c> (Android SDK 3.5.0 and later).</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://imag.example.com/image.png">https://imag.example.com/image.png</a></para>
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// <para>The body text in Inbox mode. The content is a valid JSON Array with no more than 5 elements. Currently supported by:</para>
                /// <list type="bullet">
                /// <item><description><para>Huawei: EMUI 9 and later</para>
                /// </description></item>
                /// <item><description><para>Honor: Magic UI 4.0 and later</para>
                /// </description></item>
                /// <item><description><para>Xiaomi: MIUI 10 and later</para>
                /// </description></item>
                /// <item><description><para>OPPO: ColorOS 5.0 and later</para>
                /// </description></item>
                /// <item><description><para>Proprietary channels: Android SDK 3.6.0 and later</para>
                /// </description></item>
                /// </list>
                /// </summary>
                [NameInMap("InboxContent")]
                [Validation(Required=false)]
                public List<string> InboxContent { get; set; }

                /// <summary>
                /// <para>The Huawei vendor channel notification sound. Specify the name of the audio file stored in the <c>app/src/main/res/raw/</c> directory of the client project, without the file format suffix. If not set, the default ringtone is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alicloud_notification_sound</para>
                /// </summary>
                [NameInMap("Music")]
                [Validation(Required=false)]
                public string Music { get; set; }

                /// <summary>
                /// <para>The unique identifier for an Android notification bar message. It controls the overwriting and replacement behavior of notifications. A new notification with the same NotifyId automatically overwrites the old one.</para>
                /// 
                /// <b>Example:</b>
                /// <para>233856727</para>
                /// </summary>
                [NameInMap("NotifyId")]
                [Validation(Required=false)]
                public int? NotifyId { get; set; }

                /// <summary>
                /// <para>Detailed channel configuration.</para>
                /// </summary>
                [NameInMap("Options")]
                [Validation(Required=false)]
                public PushTaskNotificationAndroidOptions Options { get; set; }
                public class PushTaskNotificationAndroidOptions : TeaModel {
                    /// <summary>
                    /// <para>Alibaba Cloud proprietary configuration</para>
                    /// <remarks>
                    /// <para>This is only valid when using Alibaba Cloud\&quot;s proprietary channel.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("Accs")]
                    [Validation(Required=false)]
                    public PushTaskNotificationAndroidOptionsAccs Accs { get; set; }
                    public class PushTaskNotificationAndroidOptionsAccs : TeaModel {
                        /// <summary>
                        /// <para>The custom Android notification bar style. The value can be from 1 to 100.</para>
                        /// <remarks>
                        /// <para>The client must complete the style preset configuration. For more information, see the <a href="https://help.aliyun.com/document_detail/2834944.html">Custom Notification Style API</a> document.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("CustomStyle")]
                        [Validation(Required=false)]
                        public int? CustomStyle { get; set; }

                        /// <summary>
                        /// <para>The notification reminder method. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para><c>VIBRATE</c>: Vibrate (default)</para>
                        /// </description></item>
                        /// <item><description><para><c>SOUND</c>: Sound</para>
                        /// </description></item>
                        /// <item><description><para><c>BOTH</c>: Sound and vibration</para>
                        /// </description></item>
                        /// <item><description><para><c>NONE</c>: Silent</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NONE</para>
                        /// </summary>
                        [NameInMap("NotifyType")]
                        [Validation(Required=false)]
                        public string NotifyType { get; set; }

                        /// <summary>
                        /// <para>Sets the activity to open when the notification is clicked. This is valid when <c>OpenType</c> is <c>ACTIVITY</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>com.alibaba.cloudpushdemo.bizactivity</para>
                        /// </summary>
                        [NameInMap("OpenActivity")]
                        [Validation(Required=false)]
                        public string OpenActivity { get; set; }

                        /// <summary>
                        /// <para>The action to take after the notification is clicked. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para><c>APPLICATION</c>: Open the application (default).</para>
                        /// </description></item>
                        /// <item><description><para><c>ACTIVITY</c>: Open the specified page <c>OpenActivity</c>.</para>
                        /// </description></item>
                        /// <item><description><para><c>URL</c>: Open a URL.</para>
                        /// </description></item>
                        /// <item><description><para><c>NONE</c>: No action.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>APPLICATION</para>
                        /// </summary>
                        [NameInMap("OpenType")]
                        [Validation(Required=false)]
                        public string OpenType { get; set; }

                        /// <summary>
                        /// <para>After an Android device receives a push, clicking the notification opens the corresponding URL. This is valid when <c>OpenType</c> is <c>URL</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="http://www.example.com">www.example.com</a></para>
                        /// </summary>
                        [NameInMap("OpenUrl")]
                        [Validation(Required=false)]
                        public string OpenUrl { get; set; }

                        /// <summary>
                        /// <para>The priority of the Android notification\&quot;s position in the notification bar. Valid values: -2, -1, 0, 1, 2.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Priority")]
                        [Validation(Required=false)]
                        public int? Priority { get; set; }

                        /// <summary>
                        /// <para>Message grouping. Messages in the same group are displayed collapsed in the notification bar and can be expanded. Different groups of notifications are displayed separately.</para>
                        /// <remarks>
                        /// <para>This is for Android SDK 3.9.2 and later.</para>
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
                    /// <para>Honor configuration</para>
                    /// </summary>
                    [NameInMap("Honor")]
                    [Validation(Required=false)]
                    public PushTaskNotificationAndroidOptionsHonor Honor { get; set; }
                    public class PushTaskNotificationAndroidOptionsHonor : TeaModel {
                        /// <summary>
                        /// <para>Sets the importance parameter for Honor notification message classification, which determines the notification behavior on the user\&quot;s device. Valid values are:</para>
                        /// <list type="bullet">
                        /// <item><description><para><c>0</c>: Marketing message</para>
                        /// </description></item>
                        /// <item><description><para><c>1</c>: Service and communication message</para>
                        /// </description></item>
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
                    /// <para>Huawei configuration</para>
                    /// </summary>
                    [NameInMap("Huawei")]
                    [Validation(Required=false)]
                    public PushTaskNotificationAndroidOptionsHuawei Huawei { get; set; }
                    public class PushTaskNotificationAndroidOptionsHuawei : TeaModel {
                        /// <summary>
                        /// <para>Sets the Huawei quick notification parameters.</para>
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
                        [NameInMap("BusinessType")]
                        [Validation(Required=false)]
                        public int? BusinessType { get; set; }

                        /// <summary>
                        /// <para>Function 1: After you apply for <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/message-classification-0000001149358835?#section3410731125514">self-classification rights</a>, this is used to identify the message type and determine the <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/message-classification-0000001149358835#ZH-CN_TOPIC_0000001149358835__p3850133955718">message reminder method</a>. It speeds up the sending of specific types of messages. For valid values, see the <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/message-classification-0000001149358835#section1076611477914">message classification standards</a> in the official Huawei Push documentation. Fill in the &quot;Cloud notification category value&quot; or &quot;Local notification category value&quot; from the document\&quot;s table.</para>
                        /// <para>Function 2: After <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/faq-0000001050042183#section037425218509">applying for special permissions</a>, this is used to identify high-priority pass-through scenarios. Valid values are:</para>
                        /// <list type="bullet">
                        /// <item><description><para><c>VOIP</c>: Video call</para>
                        /// </description></item>
                        /// <item><description><para><c>PLAY_VOICE</c>: Voice playback</para>
                        /// </description></item>
                        /// </list>
                        /// <remarks>
                        /// <list type="bullet">
                        /// <item><description><para>For &quot;Cloud notification category value&quot; that is &quot;Not applicable,&quot; all messages go through Alibaba Cloud\&quot;s proprietary channel.</para>
                        /// </description></item>
                        /// <item><description><para>For &quot;Local notification category value&quot; that is &quot;Not applicable,&quot; all messages go through the Huawei channel.</para>
                        /// </description></item>
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
                        /// <para>Sets the importance parameter for Huawei notification message classification, which determines the notification behavior on the user\&quot;s device. Valid values are:</para>
                        /// <list type="bullet">
                        /// <item><description><para><c>0</c>: Marketing message</para>
                        /// </description></item>
                        /// <item><description><para><c>1</c>: Service and communication message</para>
                        /// </description></item>
                        /// </list>
                        /// <remarks>
                        /// <para>We recommend using <c>Category</c> for notification classification. You must apply for this on the Huawei platform. <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/message-classification-0000001149358835#section893184112272">Application link</a>.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Importance")]
                        [Validation(Required=false)]
                        public int? Importance { get; set; }

                        /// <summary>
                        /// <para>The JSON string of the Huawei Android Live Window data structure <a href="https://developer.huawei.com/consumer/cn/doc/HMSCore-References/rest-live-0000001562939968#ZH-CN_TOPIC_0000001700850537__p195121620102511">LiveNotificationPayload</a>. For developer integration, see the document <a href="https://help.aliyun.com/document_detail/2983768.html">Huawei Live Window Push Guide</a>.</para>
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
                        /// <para>The receipt ID for the Huawei channel. This ID can be found in the receipt parameter settings on the Huawei channel push operations platform.</para>
                        /// <remarks>
                        /// <para>If the default receipt configuration on the Huawei channel push operations platform is the Alibaba Cloud receipt, you do not need to provide this. If not, we recommend that you first configure the default Huawei channel receipt ID in the Alibaba Cloud EMAS Mobile Push console.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>RCP4C123456</para>
                        /// </summary>
                        [NameInMap("ReceiptId")]
                        [Validation(Required=false)]
                        public string ReceiptId { get; set; }

                        /// <summary>
                        /// <para>The Huawei channel notification delivery priority. Valid values are:</para>
                        /// <list type="bullet">
                        /// <item><description><para><c>HIGH</c></para>
                        /// </description></item>
                        /// <item><description><para><c>NORMAL</c></para>
                        /// </description></item>
                        /// </list>
                        /// <para>You must apply for permission. For more information, see: <a href="https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/faq-0000001050042183#section037425218509">Application link</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NORMAL</para>
                        /// </summary>
                        [NameInMap("Urgency")]
                        [Validation(Required=false)]
                        public string Urgency { get; set; }

                    }

                    /// <summary>
                    /// <para>Meizu configuration</para>
                    /// </summary>
                    [NameInMap("Meizu")]
                    [Validation(Required=false)]
                    public PushTaskNotificationAndroidOptionsMeizu Meizu { get; set; }
                    public class PushTaskNotificationAndroidOptionsMeizu : TeaModel {
                        /// <summary>
                        /// <para>The Meizu message type.</para>
                        /// <list type="bullet">
                        /// <item><description><para>0 Public message (default)</para>
                        /// </description></item>
                        /// <item><description><para>1 Private message</para>
                        /// </description></item>
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
                    /// <para>OPPO configuration</para>
                    /// </summary>
                    [NameInMap("Oppo")]
                    [Validation(Required=false)]
                    public PushTaskNotificationAndroidOptionsOppo Oppo { get; set; }
                    public class PushTaskNotificationAndroidOptionsOppo : TeaModel {
                        /// <summary>
                        /// <para>OPPO classifies messages into two categories for management: communication and services, and content and marketing.</para>
                        /// <para><b>Communication and services (requires permission application):</b></para>
                        /// <list type="bullet">
                        /// <item><description><para>IM: Instant messages</para>
                        /// </description></item>
                        /// <item><description><para>ACCOUNT: Account and asset</para>
                        /// </description></item>
                        /// <item><description><para>TODO: To-do list</para>
                        /// </description></item>
                        /// <item><description><para>DEVICE_REMINDER: Device information</para>
                        /// </description></item>
                        /// <item><description><para>ORDER: Order and logistics</para>
                        /// </description></item>
                        /// <item><description><para>SUBSCRIPTION: Subscription reminder</para>
                        /// </description></item>
                        /// </list>
                        /// <para><b>Content and marketing:</b></para>
                        /// <list type="bullet">
                        /// <item><description><para>NEWS: News</para>
                        /// </description></item>
                        /// <item><description><para>CONTENT: Content recommendation</para>
                        /// </description></item>
                        /// <item><description><para>MARKETING: Operational activity</para>
                        /// </description></item>
                        /// <item><description><para>SOCIAL: Social dynamics</para>
                        /// </description></item>
                        /// </list>
                        /// <para>For more information, see <a href="https://open.oppomobile.com/new/developmentDoc/info?id=13189">vivo classification description</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>NEWS</para>
                        /// </summary>
                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        /// <summary>
                        /// <para>The JSON string of the OPPO Fluid Cloud\&quot;s intent deletion data structure <a href="https://open.oppomobile.com/documentation/page/info?id=13578">data</a>. This parameter is invalid if the AndroidOppoIntelligentIntent parameter is already filled. For developer integration, see the document <a href="https://help.aliyun.com/document_detail/2997310.html">OPPO Fluid Cloud Push Guide</a>.</para>
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
                        /// <para>The JSON string of the OPPO Fluid Cloud\&quot;s intent sharing data structure <a href="https://open.oppomobile.com/documentation/page/info?id=13565">IntelligentIntent</a>. For developer integration, see the document <a href="https://help.aliyun.com/document_detail/2997310.html">OPPO Fluid Cloud Push Guide</a>.</para>
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
                        /// <para>The OPPO channel notification bar message reminder level. Valid values are:</para>
                        /// <list type="bullet">
                        /// <item><description><para><c>1</c>: Notification bar</para>
                        /// </description></item>
                        /// <item><description><para><c>2</c>: Notification bar, lock screen, ringtone, vibration (default notification level for communication and service messages)</para>
                        /// </description></item>
                        /// <item><description><para><c>16</c>: Notification bar, lock screen, ringtone, vibration, banner (requires permission application)</para>
                        /// </description></item>
                        /// </list>
                        /// <remarks>
                        /// <para>When you use the <c>NotifyLevel</c> parameter, you must also pass the <c>Category</c> parameter.</para>
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
                        /// <para>{&quot;name&quot;: &quot;张三&quot;}</para>
                        /// </summary>
                        [NameInMap("PrivateTitleParameters")]
                        [Validation(Required=false)]
                        public string PrivateTitleParameters { get; set; }

                    }

                    /// <summary>
                    /// <para>vivo configuration</para>
                    /// </summary>
                    [NameInMap("Vivo")]
                    [Validation(Required=false)]
                    public PushTaskNotificationAndroidOptionsVivo Vivo { get; set; }
                    public class PushTaskNotificationAndroidOptionsVivo : TeaModel {
                        /// <summary>
                        /// <para>vivo classifies messages into two categories for management: system messages and operational messages.</para>
                        /// <para><b>System messages:</b></para>
                        /// <list type="bullet">
                        /// <item><description><para>IM: Instant messages</para>
                        /// </description></item>
                        /// <item><description><para>ACCOUNT: Account and asset</para>
                        /// </description></item>
                        /// <item><description><para>TODO: To-do list</para>
                        /// </description></item>
                        /// <item><description><para>DEVICE_REMINDER: Device information</para>
                        /// </description></item>
                        /// <item><description><para>ORDER: Order and logistics</para>
                        /// </description></item>
                        /// <item><description><para>SUBSCRIPTION: Subscription reminder</para>
                        /// </description></item>
                        /// </list>
                        /// <para><b>Operational messages:</b></para>
                        /// <list type="bullet">
                        /// <item><description><para>NEWS: News</para>
                        /// </description></item>
                        /// <item><description><para>CONTENT: Content recommendation</para>
                        /// </description></item>
                        /// <item><description><para>MARKETING: Operational activity</para>
                        /// </description></item>
                        /// <item><description><para>SOCIAL: Social dynamics</para>
                        /// </description></item>
                        /// </list>
                        /// <para>For more information, see <a href="https://dev.vivo.com.cn/documentCenter/doc/359#s-ef3qugc3">vivo classification description</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MARKETING</para>
                        /// </summary>
                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        /// <summary>
                        /// <para>Sets the vivo notification message classification. Valid values are:</para>
                        /// <list type="bullet">
                        /// <item><description><para><c>0</c>: Operational message (default)</para>
                        /// </description></item>
                        /// <item><description><para><c>1</c>: System message</para>
                        /// </description></item>
                        /// </list>
                        /// <remarks>
                        /// <para>We recommend using <c>Category</c> for notification classification. You must apply for this on the vivo platform. For more information, see: <a href="https://dev.vivo.com.cn/documentCenter/doc/359">Application link</a>.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Importance")]
                        [Validation(Required=false)]
                        public int? Importance { get; set; }

                        /// <summary>
                        /// <para>The JSON string of the vivo Atomic Island data structure <a href="https://dev.vivo.com.cn/documentCenter/doc/896#s-fdagzbd4">liveMessage</a>. For developer integration, see the document <a href="https://help.aliyun.com/zh/document_detail/3030718.html">vivo Atomic Island Push Guide</a>.</para>
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
                        /// <para>The message receipt identifier for the vivo vendor push channel. It is used to receive push result callback notifications.</para>
                        /// <remarks>
                        /// <list type="bullet">
                        /// <item><description><para>Location: vivo Open Platform → Push Service → Application Information → Receipt Configuration</para>
                        /// </description></item>
                        /// <item><description><para>Recommendation: First, configure the default receipt ID in the Alibaba Cloud EMAS console.</para>
                        /// </description></item>
                        /// <item><description><para>Condition: This must be configured only if the default receipt on the vivo platform is not the Alibaba Cloud receipt.</para>
                        /// </description></item>
                        /// </list>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1232221</para>
                        /// </summary>
                        [NameInMap("ReceiptId")]
                        [Validation(Required=false)]
                        public string ReceiptId { get; set; }

                    }

                    /// <summary>
                    /// <para>Xiaomi configuration</para>
                    /// </summary>
                    [NameInMap("Xiaomi")]
                    [Validation(Required=false)]
                    public PushTaskNotificationAndroidOptionsXiaomi Xiaomi { get; set; }
                    public class PushTaskNotificationAndroidOptionsXiaomi : TeaModel {
                        /// <summary>
                        /// <para>Sets the channelId for the Xiaomi notification type. You must apply for this on the Xiaomi platform. For more information, see: <a href="https://dev.mi.com/console/doc/detail?pId=2422#_4">Application link</a>.</para>
                        /// <remarks>
                        /// <para>A single application can apply for a maximum of 8 channels on the Xiaomi channel. Plan accordingly.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>michannel</para>
                        /// </summary>
                        [NameInMap("Channel")]
                        [Validation(Required=false)]
                        public string Channel { get; set; }

                        /// <summary>
                        /// <para>The JSON string of the Xiaomi Super Island data structure <a href="https://dev.mi.com/xiaomihyperos/documentation/detail?pId=2131">miui.focus.param</a>. For developer integration, see the document <a href="https://help.aliyun.com/zh/document_detail/3037956.html">Xiaomi Super Island Push Guide</a>.</para>
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
                        /// <para>The JSON string of the Xiaomi Super Island data image <a href="https://dev.mi.com/xiaomihyperos/documentation/detail?pId=2131">miui.focus.pic_xxx</a>. For developer integration, see the document <a href="https://help.aliyun.com/zh/document_detail/3037956.html">Xiaomi Super Island Push Guide</a>.</para>
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

                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                        [NameInMap("TemplateParams")]
                        [Validation(Required=false)]
                        public string TemplateParams { get; set; }

                    }

                }

                /// <summary>
                /// <para>The image URL in large image mode. Currently supported by: proprietary channels with Android SDK 3.6.0 and later.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://imag.example.com/image.png">https://imag.example.com/image.png</a></para>
                /// </summary>
                [NameInMap("PictureUrl")]
                [Validation(Required=false)]
                public string PictureUrl { get; set; }

                /// <summary>
                /// <para>The notification style. Valid values are:</para>
                /// <list type="bullet">
                /// <item><description><para><c>0</c>: Standard mode (default)</para>
                /// </description></item>
                /// <item><description><para><c>1</c>: Long text mode (supported by Huawei, Honor, Xiaomi, OPPO, Meizu, and proprietary channels)</para>
                /// </description></item>
                /// <item><description><para><c>2</c>: Large image mode (supported by proprietary channels)</para>
                /// </description></item>
                /// <item><description><para><c>3</c>: List mode (supported by Huawei, Honor, Xiaomi, OPPO, and proprietary channels)</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RenderStyle")]
                [Validation(Required=false)]
                public string RenderStyle { get; set; }

                /// <summary>
                /// <para>Sets the vendor channel notification type:</para>
                /// <list type="bullet">
                /// <item><description><para><c>false</c>: Formal notification (default).</para>
                /// </description></item>
                /// <item><description><para><c>true</c>: Test notification.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>Currently supported by: Huawei channel, Honor channel, vivo channel, and OPPO Fluid Cloud.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("TestMessage")]
                [Validation(Required=false)]
                public bool? TestMessage { get; set; }

                /// <summary>
                /// <para>Specifies the Activity to open after the notification is clicked.</para>
                /// <remarks>
                /// <para>Warning: </para>
                /// </remarks>
                /// <para>You must fill in this option when you use an Android vendor channel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>com.alibaba.cloudpushdemo.bizactivity</para>
                /// </summary>
                [NameInMap("VendorChannelActivity")]
                [Validation(Required=false)]
                public string VendorChannelActivity { get; set; }

            }

            /// <summary>
            /// <para>The content of the push notification.</para>
            /// <remarks>
            /// <para>The length limits are as follows:</para>
            /// <list type="bullet">
            /// <item><description>For iOS, HarmonyOS, and Android, the character length cannot exceed 200.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>尊敬的客户，您好！您的预约订单已取消成功。</para>
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
                /// <para>Specifies the action corresponding to the ability of an in-app page.</para>
                /// <remarks>
                /// <para>For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section152462191216">ClickAction.action</a> on the official HarmonyOS website.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>com.example.action</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The HarmonyOS application badge cumulative number.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>This is supported starting from HarmonyOS SDK 1.2.0.</para>
                /// </description></item>
                /// <item><description><para>See the description of the <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section266310382145">addNum field</a> for HarmonyOS badges.</para>
                /// </description></item>
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
                /// <para>The HarmonyOS application badge number setting.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>See the description of the <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section266310382145">setNum field</a> for HarmonyOS badges.</para>
                /// </description></item>
                /// <item><description><para>This is supported starting from HarmonyOS SDK 1.2.0.</para>
                /// </description></item>
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
                /// <para>The notification message category. This is an optional parameter. The default category is <c>MARKETING</c>.</para>
                /// <remarks>
                /// <para>After you apply for the right to self-classify notification messages, this parameter is used to identify the message type. Different notification message types affect how messages are displayed and how users are reminded. For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section17371529101117">Notification.category</a> on the official HarmonyOS website.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>IM</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>Sets custom extension properties for the notification message. This is used to pass additional business data.</para>
                /// <remarks>
                /// <para>The parameter must be passed in a standard JSON Map format. An incorrect format causes parsing to fail.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;key&quot;: &quot;value&quot;}</para>
                /// </summary>
                [NameInMap("ExtParameters")]
                [Validation(Required=false)]
                public string ExtParameters { get; set; }

                /// <summary>
                /// <para>Extra data for the notification extension message.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>This is valid when sending a HarmonyOS notification extension message.</para>
                /// </description></item>
                /// <item><description><para>It is conceptually equivalent to the extraData field of a HarmonyOS notification extension message. For a specific definition, see the HarmonyOS <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section161192514234">ExtensionPayload</a> description.</para>
                /// </description></item>
                /// <item><description><para>This is supported starting from HarmonyOS SDK 1.2.0.</para>
                /// </description></item>
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
                /// <para>Enables the HarmonyOS notification extension.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>You must first apply for permission on the official HarmonyOS website to send notification extension messages. For related content, see the <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-guides-V5/push-send-extend-noti-V5">HarmonyOS documentation</a> on sending notification extension messages.</para>
                /// </description></item>
                /// <item><description><para>This is supported starting from HarmonyOS SDK 1.2.0.</para>
                /// </description></item>
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
                /// <para>The URL for the large icon on the right side of the notification. The URL must use the HTTPS protocol.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>Supported image formats are png, jpg, jpeg, heif, gif, and bmp. The image dimensions (length × width) must be less than 25,000 pixels.</para>
                /// </description></item>
                /// <item><description><para>For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section17371529101117">Notification.image</a> on the official HarmonyOS website.</para>
                /// </description></item>
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
                /// <para>When <c>RenderStyle</c> is <c>MULTI_LINE</c>, you must fill in this field to define the content for the multi-line text style. It supports up to 3 lines of content.</para>
                /// </summary>
                [NameInMap("InboxContent")]
                [Validation(Required=false)]
                public List<string> InboxContent { get; set; }

                /// <summary>
                /// <para>The JSON string of the HarmonyOS Live Window data structure <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V13/push-scenariozed-api-request-param-V13#section66881469306">LiveViewPayload</a>. For developer integration, see the document <a href="https://help.aliyun.com/document_detail/2982112.html">HarmonyOS Live Window Push Guide</a>.</para>
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
                /// <para>Specifies the unique identifier (notifyId) for each message when it is displayed in the notification bar. If not provided, the push service automatically generates a unique identifier. Different notification messages can use the same notifyId to allow new messages to overwrite old ones. For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section17371529101117">Notification.notifyId</a> on the official HarmonyOS website.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("NotifyId")]
                [Validation(Required=false)]
                public int? NotifyId { get; set; }

                /// <summary>
                /// <para>The receipt ID for the HarmonyOS channel. This ID can be found in the receipt parameter settings on the HarmonyOS channel push operations platform.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>If the default receipt configuration on the HarmonyOS channel push operations platform is the Alibaba Cloud receipt, you do not need to provide this. If not, we recommend that you first configure the default HarmonyOS channel receipt ID in the Alibaba Cloud EMAS Mobile Push console.</para>
                /// </description></item>
                /// <item><description><para>For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section418321011212">pushOptions.receiptId</a> on the official HarmonyOS website.</para>
                /// </description></item>
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
                /// <para>The notification message style. This is an optional parameter. The default is a normal notification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("RenderStyle")]
                [Validation(Required=false)]
                public string RenderStyle { get; set; }

                /// <summary>
                /// <para>Uses the specified type of notification channel.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>This is only valid for Alibaba Cloud\&quot;s proprietary channels.</para>
                /// </description></item>
                /// <item><description><para>For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/js-apis-notificationmanager-V5#slottype">SlotType</a> on the official HarmonyOS website.</para>
                /// </description></item>
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
                /// <para>The duration of the custom message notification ringtone in seconds. The range is [1, 60]. If the ringtone duration is too short, it will loop.</para>
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
                /// <item><description>For more information, see the HarmonyOS push parameter <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section418321011212">TestMessage</a>.</description></item>
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
                /// <para>The URI corresponding to the ability of an in-app page.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>If there are multiple abilities, specify the action and URI for each ability separately. The system prioritizes using the action to find the corresponding in-app page.</para>
                /// </description></item>
                /// <item><description><para>For more information, see <a href="https://developer.huawei.com/consumer/cn/doc/harmonyos-references-V5/push-scenariozed-api-request-param-V5#section152462191216">ClickAction.uri</a> on the official HarmonyOS website.</para>
                /// </description></item>
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
            /// <para>iOS notification configuration</para>
            /// </summary>
            [NameInMap("Ios")]
            [Validation(Required=false)]
            public PushTaskNotificationIos Ios { get; set; }
            public class PushTaskNotificationIos : TeaModel {
                /// <summary>
                /// <para>iOS notifications are sent through the Apple Push Notification service (APNs) center. You must specify the environment information. This is an optional parameter. The default is the production environment.</para>
                /// <list type="bullet">
                /// <item><description><para>DEV: Development environment, for applications installed and tested directly from Xcode.</para>
                /// </description></item>
                /// <item><description><para>PRODUCT: Production environment, for applications distributed through the App Store, TestFlight, Ad Hoc, and enterprise channels.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DEV</para>
                /// </summary>
                [NameInMap("ApnsEnv")]
                [Validation(Required=false)]
                public string ApnsEnv { get; set; }

                /// <summary>
                /// <para>The iOS application badge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Badge")]
                [Validation(Required=false)]
                public int? Badge { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable the badge auto-increment feature. This is an optional parameter. The default value is false.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>This parameter cannot be used with the badge setting parameter.</para>
                /// </description></item>
                /// <item><description><para>The badge auto-increment feature is maintained by the Alibaba Cloud push server, which counts the badges for each device. You must use SDK version 1.9.5 or later and actively sync the badge number to the server through the SDK.</para>
                /// </description></item>
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
                /// <para>Specifies the category identifier for an iOS notification. This defines the notification\&quot;s interactive behavior and display style.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>The category must be pre-registered in the app to take effect.</para>
                /// </description></item>
                /// <item><description><para>Different categories can define different sets of actions.</para>
                /// </description></item>
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
                /// <para>A unique identifier that controls notification merging. Notifications with the same identifier are overwritten.</para>
                /// 
                /// <b>Example:</b>
                /// <para>order_status_update_12345</para>
                /// </summary>
                [NameInMap("CollapseId")]
                [Validation(Required=false)]
                public string CollapseId { get; set; }

                /// <summary>
                /// <para>Custom extension properties for iOS notifications.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>The parameter must be passed in a standard JSON Map format. An incorrect format causes parsing to fail.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;attachment&quot;: &quot;<a href="https://xxxx.xxx/notification_pic.png%22%7D">https://xxxx.xxx/notification_pic.png&quot;}</a></para>
                /// </summary>
                [NameInMap("ExtParameters")]
                [Validation(Required=false)]
                public string ExtParameters { get; set; }

                /// <summary>
                /// <para>The interruption level. This is an optional parameter. Valid values are:</para>
                /// <list type="bullet">
                /// <item><description><para><c>passive</c>: The system adds the notification to the notification list without lighting up the screen or playing a sound.</para>
                /// </description></item>
                /// <item><description><para><c>active</c>: The system displays the notification immediately, lights up the screen, and can play a sound.</para>
                /// </description></item>
                /// <item><description><para><c>time-sensitive</c>: The system presents the notification immediately, lights up the screen, and can play a sound, but does not override system notification controls.</para>
                /// </description></item>
                /// <item><description><para><c>critical</c>: The system displays the notification immediately, lights up the screen, and plays a sound, bypassing the mute switch.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("InterruptionLevel")]
                [Validation(Required=false)]
                public string InterruptionLevel { get; set; }

                /// <summary>
                /// <para>Live Activities parameter object.</para>
                /// <remarks>
                /// <para>Notice: </para>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>Live Activities push only supports pushing to a single device of the <c>DEVICE</c> type.</para>
                /// </description></item>
                /// <item><description><para>When you push to Live Activities, you can leave the title and body parameters empty.</para>
                /// </description></item>
                /// </list>
                /// </summary>
                [NameInMap("LiveActivity")]
                [Validation(Required=false)]
                public PushTaskNotificationIosLiveActivity LiveActivity { get; set; }
                public class PushTaskNotificationIosLiveActivity : TeaModel {
                    /// <summary>
                    /// <para>Static pass-through parameters for iOS Live Activities push. They are used to transmit immutable business identification information.</para>
                    /// <remarks>
                    /// <para>This is required when <c>Event</c> is \<c>start\\</c>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{
                    ///   &quot;orderId&quot;: &quot;ORD20231201001&quot;,
                    ///   &quot;restaurantName&quot;: &quot;美味餐厅&quot;,
                    ///   &quot;customerAddress&quot;: &quot;xx区xx路xx号&quot;,
                    ///   &quot;orderType&quot;: &quot;delivery&quot;
                    /// }</para>
                    /// </summary>
                    [NameInMap("Attributes")]
                    [Validation(Required=false)]
                    public string Attributes { get; set; }

                    /// <summary>
                    /// <para>The type of Live Activity to start.</para>
                    /// <remarks>
                    /// <para>This is required when <c>Event</c> is \<c>start\\</c>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OrderActivityAttributes</para>
                    /// </summary>
                    [NameInMap("AttributesType")]
                    [Validation(Required=false)]
                    public string AttributesType { get; set; }

                    /// <summary>
                    /// <para>Dynamic pass-through parameters for a Live Activity. They contain real-time updatable status information and changing data.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description><para>Avoid overly frequent updates. An interval of 5 seconds or more is recommended.</para>
                    /// </description></item>
                    /// <item><description><para>Update multiple fields in a batch to reduce the number of pushes.</para>
                    /// </description></item>
                    /// <item><description><para>Consider the user experience and avoid screen flickering.</para>
                    /// </description></item>
                    /// <item><description><para>Must be a valid JSON string.</para>
                    /// </description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{
                    ///     &quot;status&quot;: &quot;delivering&quot;,
                    ///     &quot;estimatedTime&quot;: &quot;10分钟&quot;,
                    ///     &quot;progress&quot;: 80,
                    ///     &quot;driverName&quot;: &quot;李师傅&quot;,
                    ///     &quot;currentStep&quot;: &quot;配送员正在路上&quot;}
                    /// }</para>
                    /// </summary>
                    [NameInMap("ContentState")]
                    [Validation(Required=false)]
                    public string ContentState { get; set; }

                    /// <summary>
                    /// <para>Sets the retention period for a finished Live Activity on the lock screen. This lets users view information after the activity has ended. It is a Unix timestamp in seconds.</para>
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
                    /// <para>The unique identifier for a Live Activity. It associates the activity instance on the device with the push target on the server.</para>
                    /// <remarks>
                    /// <para>Notice: </para>
                    /// </remarks>
                    /// <list type="bullet">
                    /// <item><description><para>This <c>ID</c> must be the same as the <c>forActivityId</c> parameter of the <c>registerLiveActivityPushToken</c> method in the client SDK.</para>
                    /// </description></item>
                    /// <item><description><para>The server uses this <c>ID</c> to locate the specific activity instance during a push.</para>
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
                    /// <para>Sets the expiration timestamp for the content of an iOS Live Activity. It is a Unix timestamp in seconds.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description><para>After the specified time is reached, the system automatically marks the activity as expired.</para>
                    /// </description></item>
                    /// <item><description><para>Expired activities are removed from the Live Activity and the lock screen.</para>
                    /// </description></item>
                    /// <item><description><para>This prevents outdated information from occupying the user interface for a long time.</para>
                    /// </description></item>
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
                /// <para>The iOS notification sound. Specify the name of the audio file stored in the app bundle or the sandbox Library/Sounds directory. For more information, see <a href="https://help.aliyun.com/document_detail/48906.html">How to set the notification sound for iOS push</a>.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>If you specify an empty string (&quot;&quot;), the notification is silent.</para>
                /// </description></item>
                /// <item><description><para>If this parameter is not set, the default value is \<c>default\\</c>, which is the system prompt sound.</para>
                /// </description></item>
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
                /// <para>Enables extended notifications and controls whether iOS notifications support processing by the Notification Service Extension.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>This must be set to true when you send a silent notification.</para>
                /// </description></item>
                /// <item><description><para>The extension processing time cannot exceed 30 seconds.</para>
                /// </description></item>
                /// <item><description><para>A timeout causes the notification to display the original content.</para>
                /// </description></item>
                /// <item><description><para>You must add a Notification Service Extension to your application.</para>
                /// </description></item>
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
                /// <para>The relevance score of the notification message. It is used to control the priority and display policy of the notification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("RelevanceScore")]
                [Validation(Required=false)]
                public double? RelevanceScore { get; set; }

                /// <summary>
                /// <para>Controls whether to enable silent push mode.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>When you send a silent notification, you can leave the <c>title</c> and <c>body</c> parameters empty.</description></item>
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
                /// <para>请查收订单。</para>
                /// </summary>
                [NameInMap("Subtitle")]
                [Validation(Required=false)]
                public string Subtitle { get; set; }

                /// <summary>
                /// <para>The thread identifier for iOS notification grouping. It is used to classify and collapse related notifications.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>Notifications with the same thread-id are automatically grouped.</para>
                /// </description></item>
                /// <item><description><para>Multiple related notifications are collapsed into one notification group.</para>
                /// </description></item>
                /// <item><description><para>Users can expand the group to view all notifications within it.</para>
                /// </description></item>
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
            /// <para>The length limits are as follows:</para>
            /// <list type="bullet">
            /// <item><description><para>For iOS/HarmonyOS, the byte length cannot exceed 200.</para>
            /// </description></item>
            /// <item><description><para>For Android, the character length cannot exceed 50.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>您有一条新消息</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>Push options</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public PushTaskOptions Options { get; set; }
        public class PushTaskOptions : TeaModel {
            /// <summary>
            /// <para>Sets the expiration time of the message. After this time, the message will no longer be sent. The maximum retention period is 72 hours.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>This uses the ISO 8601 standard and UTC time. The format is YYYY-MM-DDThh:mm:ssZ.</para>
            /// </description></item>
            /// <item><description><para>The expiration time must satisfy: ExpireTime &gt; PushTime + 3 seconds (3 seconds is a buffer for network and system delays).</para>
            /// </description></item>
            /// <item><description><para>Recommendation: The expiration time for a single push should be at least 1 minute. For a push to all or a batch push, it should be at least 10 minutes.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// <remarks>
            /// <para>Notice: </para>
            /// </remarks>
            /// <para>For pass-through messages, if you do not set an expiration time, the message is only sent to online devices. If the device is offline, the message is discarded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-21T12:00:00Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>A custom identifier for the push task. If JobKey is not empty, this field will be included in the receipt log. To view receipt logs, see <a href="https://help.aliyun.com/document_detail/434651.html">Receipt logs</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jobkey1727749697913</para>
            /// </summary>
            [NameInMap("JobKey")]
            [Validation(Required=false)]
            public string JobKey { get; set; }

            /// <summary>
            /// <para>A unique ID used to identify the message. This is only valid when the <c>Action</c> parameter is <c>CONTINUOUS_PUSH</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1174754033128****</para>
            /// </summary>
            [NameInMap("MessageId")]
            [Validation(Required=false)]
            public long? MessageId { get; set; }

            /// <summary>
            /// <para>Specifies the sending time of the message, up to 7 days in the future. This is only valid when the <c>Action</c> parameter is <c>SCHEDULED_PUSH</c>.</para>
            /// <remarks>
            /// <para>This uses the ISO 8601 standard and UTC time. The format is yyyy-MM-ddTHH:mm:ssZ.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-19T12:00:00Z</para>
            /// </summary>
            [NameInMap("PushTime")]
            [Validation(Required=false)]
            public string PushTime { get; set; }

            /// <summary>
            /// <para>Resends the message as a text message.</para>
            /// <remarks>
            /// <para>Currently, this is only supported for <c>Android</c> and <c>HarmonyOS</c> devices.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Sms")]
            [Validation(Required=false)]
            public PushTaskOptionsSms Sms { get; set; }
            public class PushTaskOptionsSms : TeaModel {
                /// <summary>
                /// <para>The delay time to trigger the text message, in seconds.</para>
                /// <para>This must be set if you use SMS filter interaction. We recommend setting it to 15 seconds or more, with a maximum of 3 days, to avoid duplicate text messages and pushes.</para>
                /// <remarks>
                /// <para>When you use SMS filter interaction, the ExpireTime parameter is invalid. The notification expiration time is calculated based on the DelaySecs parameter. The expiration time is the current time plus the DelaySecs time.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>150</para>
                /// </summary>
                [NameInMap("DelaySecs")]
                [Validation(Required=false)]
                public long? DelaySecs { get; set; }

                /// <summary>
                /// <para>Key-value pairs for the variables in the SMS template.</para>
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
                /// <para>某某科技</para>
                /// </summary>
                [NameInMap("SignName")]
                [Validation(Required=false)]
                public string SignName { get; set; }

                /// <summary>
                /// <para>The SMS template name. You can get this from the SMS template management interface. It is the name assigned by the system, not the name set by the developer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SMS_123456789</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to automatically truncate oversized titles and content.</para>
            /// <remarks>
            /// <para>This is only supported for vendor channels that have explicit limits on title and content length. It does not apply to channels like APNs, Huawei, and Honor, which do not limit title and content length but only the total request body size.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Trim")]
            [Validation(Required=false)]
            public bool? Trim { get; set; }

            /// <summary>
            /// <para>Specifies the sending channel. Valid values are:</para>
            /// <list type="bullet">
            /// <item><description><para><c>accs</c>: Alibaba Cloud proprietary channel</para>
            /// </description></item>
            /// <item><description><para><c>huawei</c>: Huawei channel</para>
            /// </description></item>
            /// <item><description><para><c>honor</c>: Honor channel</para>
            /// </description></item>
            /// <item><description><para><c>xiaomi</c>: Xiaomi channel</para>
            /// </description></item>
            /// <item><description><para><c>oppo</c>: OPPO channel</para>
            /// </description></item>
            /// <item><description><para><c>vivo</c>: vivo channel</para>
            /// </description></item>
            /// <item><description><para><c>meizu</c>: Meizu channel</para>
            /// </description></item>
            /// <item><description><para><c>fcm</c>: Google Firebase channel (HTTP v1 API)</para>
            /// </description></item>
            /// <item><description><para><c>apns</c>: APNs channel</para>
            /// </description></item>
            /// <item><description><para><c>harmony</c>: HarmonyOS channel</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>If this parameter is not configured, all channels can be used.</para>
            /// </description></item>
            /// <item><description><para>If this parameter is configured, only the channels specified in the parameter are used.</para>
            /// </description></item>
            /// <item><description><para>If the configured channel conflicts with the sending policy (for example, iOS notifications only go through the APNs channel, but this parameter does not include \<c>apns\\</c>), the message is not sent.</para>
            /// </description></item>
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
        /// <para>The target object for the message push. This parameter is optional when the <c>Action</c> operation type is <c>CREATE_CONTINUOUS_PUSH</c> (create a continuous push task).</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public PushTaskTarget Target { get; set; }
        public class PushTaskTarget : TeaModel {
            /// <summary>
            /// <para>The platform type. This is an optional parameter.</para>
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
            /// <para>The <c>MassPushV2</c> batch push API and <c>CONTINUOUS_PUSH</c> continuous push support only the following three target types:</para>
            /// <list type="bullet">
            /// <item><description><para><c>DEVICE</c></para>
            /// </description></item>
            /// <item><description><para><c>ACCOUNT</c></para>
            /// </description></item>
            /// <item><description><para><c>ALIAS</c></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DEVICE</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>Set the push target based on <c>Target.Type</c>. Separate multiple targets with commas. The target types and their values are described as follows:</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para><c>DEVICE</c>: Device ID, such as deviceid1,deviceid2. You can specify up to 1,000 device IDs.</para>
            /// </description></item>
            /// <item><description><para><c>ACCOUNT</c>: Account ID, such as account1,account2. You can specify up to 1,000 account IDs.</para>
            /// </description></item>
            /// <item><description><para><c>ALIAS</c>: Alias, such as alias1,alias2. You can specify up to 1,000 aliases.</para>
            /// </description></item>
            /// <item><description><para><c>TAG</c>: Supports one or more tags. For more information about the format, see <a href="https://help.aliyun.com/document_detail/434847.html">Tag format specifications</a>.</para>
            /// </description></item>
            /// <item><description><para><c>ALL</c>: Push to all devices. You do not need to set a value. Pushing to all devices may increase costs. Use this feature with caution.</para>
            /// </description></item>
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
