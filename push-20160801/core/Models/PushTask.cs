// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class PushTask : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PUSH_IMMEDIATELY</para>
        /// </summary>
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public PushTaskMessage Message { get; set; }
        public class PushTaskMessage : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;key&quot;: &quot;value&quot;}</para>
            /// </summary>
            [NameInMap("Body")]
            [Validation(Required=false)]
            public string Body { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>title</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("Notification")]
        [Validation(Required=false)]
        public PushTaskNotification Notification { get; set; }
        public class PushTaskNotification : TeaModel {
            [NameInMap("Android")]
            [Validation(Required=false)]
            public PushTaskNotificationAndroid Android { get; set; }
            public class PushTaskNotificationAndroid : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>com.alibaba.cloudpushdemo.bizactivity</para>
                /// </summary>
                [NameInMap("BadgeActivity")]
                [Validation(Required=false)]
                public string BadgeActivity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BadgeAddNum")]
                [Validation(Required=false)]
                public int? BadgeAddNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("BadgeSetNum")]
                [Validation(Required=false)]
                public int? BadgeSetNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8.0up</para>
                /// </summary>
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;key1&quot;:&quot;value1&quot;}</para>
                /// </summary>
                [NameInMap("ExtParameters")]
                [Validation(Required=false)]
                public string ExtParameters { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>group-1</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://imag.example.com/image.png">https://imag.example.com/image.png</a></para>
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                [NameInMap("InboxContent")]
                [Validation(Required=false)]
                public List<string> InboxContent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>alicloud_notification_sound</para>
                /// </summary>
                [NameInMap("Music")]
                [Validation(Required=false)]
                public string Music { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>233856727</para>
                /// </summary>
                [NameInMap("NotifyId")]
                [Validation(Required=false)]
                public int? NotifyId { get; set; }

                [NameInMap("Options")]
                [Validation(Required=false)]
                public PushTaskNotificationAndroidOptions Options { get; set; }
                public class PushTaskNotificationAndroidOptions : TeaModel {
                    [NameInMap("Accs")]
                    [Validation(Required=false)]
                    public PushTaskNotificationAndroidOptionsAccs Accs { get; set; }
                    public class PushTaskNotificationAndroidOptionsAccs : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("CustomStyle")]
                        [Validation(Required=false)]
                        public int? CustomStyle { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>NONE</para>
                        /// </summary>
                        [NameInMap("NotifyType")]
                        [Validation(Required=false)]
                        public string NotifyType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>com.alibaba.cloudpushdemo.bizactivity</para>
                        /// </summary>
                        [NameInMap("OpenActivity")]
                        [Validation(Required=false)]
                        public string OpenActivity { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>APPLICATION</para>
                        /// </summary>
                        [NameInMap("OpenType")]
                        [Validation(Required=false)]
                        public string OpenType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="http://www.example.com">www.example.com</a></para>
                        /// </summary>
                        [NameInMap("OpenUrl")]
                        [Validation(Required=false)]
                        public string OpenUrl { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Priority")]
                        [Validation(Required=false)]
                        public int? Priority { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>order_ORD20231201001</para>
                        /// </summary>
                        [NameInMap("ThreadId")]
                        [Validation(Required=false)]
                        public string ThreadId { get; set; }

                    }

                    [NameInMap("Honor")]
                    [Validation(Required=false)]
                    public PushTaskNotificationAndroidOptionsHonor Honor { get; set; }
                    public class PushTaskNotificationAndroidOptionsHonor : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Importance")]
                        [Validation(Required=false)]
                        public int? Importance { get; set; }

                    }

                    [NameInMap("Huawei")]
                    [Validation(Required=false)]
                    public PushTaskNotificationAndroidOptionsHuawei Huawei { get; set; }
                    public class PushTaskNotificationAndroidOptionsHuawei : TeaModel {
                        [NameInMap("BusinessType")]
                        [Validation(Required=false)]
                        public int? BusinessType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>VOIP</para>
                        /// </summary>
                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Importance")]
                        [Validation(Required=false)]
                        public int? Importance { get; set; }

                        [NameInMap("LiveNotificationPayload")]
                        [Validation(Required=false)]
                        public string LiveNotificationPayload { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>RCP4C123456</para>
                        /// </summary>
                        [NameInMap("ReceiptId")]
                        [Validation(Required=false)]
                        public string ReceiptId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>NORMAL</para>
                        /// </summary>
                        [NameInMap("Urgency")]
                        [Validation(Required=false)]
                        public string Urgency { get; set; }

                    }

                    [NameInMap("Meizu")]
                    [Validation(Required=false)]
                    public PushTaskNotificationAndroidOptionsMeizu Meizu { get; set; }
                    public class PushTaskNotificationAndroidOptionsMeizu : TeaModel {
                        [NameInMap("NoticeMsgType")]
                        [Validation(Required=false)]
                        public int? NoticeMsgType { get; set; }

                    }

                    [NameInMap("Oppo")]
                    [Validation(Required=false)]
                    public PushTaskNotificationAndroidOptionsOppo Oppo { get; set; }
                    public class PushTaskNotificationAndroidOptionsOppo : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>NEWS</para>
                        /// </summary>
                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        [NameInMap("DeleteIntentData")]
                        [Validation(Required=false)]
                        public string DeleteIntentData { get; set; }

                        [NameInMap("IntelligentIntent")]
                        [Validation(Required=false)]
                        public string IntelligentIntent { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("NotifyLevel")]
                        [Validation(Required=false)]
                        public long? NotifyLevel { get; set; }

                        [NameInMap("PrivateContentParameters")]
                        [Validation(Required=false)]
                        public string PrivateContentParameters { get; set; }

                        [NameInMap("PrivateMsgTemplateId")]
                        [Validation(Required=false)]
                        public string PrivateMsgTemplateId { get; set; }

                        [NameInMap("PrivateTitleParameters")]
                        [Validation(Required=false)]
                        public string PrivateTitleParameters { get; set; }

                    }

                    [NameInMap("Vivo")]
                    [Validation(Required=false)]
                    public PushTaskNotificationAndroidOptionsVivo Vivo { get; set; }
                    public class PushTaskNotificationAndroidOptionsVivo : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>MARKETING</para>
                        /// </summary>
                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Importance")]
                        [Validation(Required=false)]
                        public int? Importance { get; set; }

                        [NameInMap("LiveMessage")]
                        [Validation(Required=false)]
                        public string LiveMessage { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1232221</para>
                        /// </summary>
                        [NameInMap("ReceiptId")]
                        [Validation(Required=false)]
                        public string ReceiptId { get; set; }

                    }

                    [NameInMap("Xiaomi")]
                    [Validation(Required=false)]
                    public PushTaskNotificationAndroidOptionsXiaomi Xiaomi { get; set; }
                    public class PushTaskNotificationAndroidOptionsXiaomi : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>michannel</para>
                        /// </summary>
                        [NameInMap("Channel")]
                        [Validation(Required=false)]
                        public string Channel { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://imag.example.com/image.png">https://imag.example.com/image.png</a></para>
                /// </summary>
                [NameInMap("PictureUrl")]
                [Validation(Required=false)]
                public string PictureUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RenderStyle")]
                [Validation(Required=false)]
                public string RenderStyle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("TestMessage")]
                [Validation(Required=false)]
                public bool? TestMessage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>com.alibaba.cloudpushdemo.bizactivity</para>
                /// </summary>
                [NameInMap("VendorChannelActivity")]
                [Validation(Required=false)]
                public string VendorChannelActivity { get; set; }

            }

            [NameInMap("Body")]
            [Validation(Required=false)]
            public string Body { get; set; }

            [NameInMap("Hmos")]
            [Validation(Required=false)]
            public PushTaskNotificationHmos Hmos { get; set; }
            public class PushTaskNotificationHmos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>com.example.action</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BadgeAddNum")]
                [Validation(Required=false)]
                public int? BadgeAddNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BadgeSetNum")]
                [Validation(Required=false)]
                public int? BadgeSetNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>IM</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;key&quot;: &quot;value&quot;}</para>
                /// </summary>
                [NameInMap("ExtParameters")]
                [Validation(Required=false)]
                public string ExtParameters { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("ExtensionExtraData")]
                [Validation(Required=false)]
                public string ExtensionExtraData { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ExtensionPush")]
                [Validation(Required=false)]
                public bool? ExtensionPush { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://example.com/xxx.png">https://example.com/xxx.png</a></para>
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                [NameInMap("InboxContent")]
                [Validation(Required=false)]
                public List<string> InboxContent { get; set; }

                [NameInMap("LiveViewPayload")]
                [Validation(Required=false)]
                public string LiveViewPayload { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("NotifyId")]
                [Validation(Required=false)]
                public int? NotifyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RCPB***DFD5</para>
                /// </summary>
                [NameInMap("ReceiptId")]
                [Validation(Required=false)]
                public string ReceiptId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("RenderStyle")]
                [Validation(Required=false)]
                public string RenderStyle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SOCIAL_COMMUNICATION</para>
                /// </summary>
                [NameInMap("SlotType")]
                [Validation(Required=false)]
                public string SlotType { get; set; }

                [NameInMap("Sound")]
                [Validation(Required=false)]
                public string Sound { get; set; }

                [NameInMap("SoundDuration")]
                [Validation(Required=false)]
                public int? SoundDuration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("TestMessage")]
                [Validation(Required=false)]
                public bool? TestMessage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://www.example.com:8080/push/example">https://www.example.com:8080/push/example</a></para>
                /// </summary>
                [NameInMap("Uri")]
                [Validation(Required=false)]
                public string Uri { get; set; }

            }

            [NameInMap("Ios")]
            [Validation(Required=false)]
            public PushTaskNotificationIos Ios { get; set; }
            public class PushTaskNotificationIos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>DEV</para>
                /// </summary>
                [NameInMap("ApnsEnv")]
                [Validation(Required=false)]
                public string ApnsEnv { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Badge")]
                [Validation(Required=false)]
                public int? Badge { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("BadgeAutoIncrement")]
                [Validation(Required=false)]
                public bool? BadgeAutoIncrement { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MESSAGE_REPLY</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>order_status_update_12345</para>
                /// </summary>
                [NameInMap("CollapseId")]
                [Validation(Required=false)]
                public string CollapseId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;attachment&quot;: &quot;<a href="https://xxxx.xxx/notification_pic.png%22%7D">https://xxxx.xxx/notification_pic.png&quot;}</a></para>
                /// </summary>
                [NameInMap("ExtParameters")]
                [Validation(Required=false)]
                public string ExtParameters { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("InterruptionLevel")]
                [Validation(Required=false)]
                public string InterruptionLevel { get; set; }

                [NameInMap("LiveActivity")]
                [Validation(Required=false)]
                public PushTaskNotificationIosLiveActivity LiveActivity { get; set; }
                public class PushTaskNotificationIosLiveActivity : TeaModel {
                    [NameInMap("Attributes")]
                    [Validation(Required=false)]
                    public string Attributes { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>OrderActivityAttributes</para>
                    /// </summary>
                    [NameInMap("AttributesType")]
                    [Validation(Required=false)]
                    public string AttributesType { get; set; }

                    [NameInMap("ContentState")]
                    [Validation(Required=false)]
                    public string ContentState { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1701439800</para>
                    /// </summary>
                    [NameInMap("DismissalDate")]
                    [Validation(Required=false)]
                    public long? DismissalDate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>start</para>
                    /// </summary>
                    [NameInMap("Event")]
                    [Validation(Required=false)]
                    public string Event { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>FOOD_DELIVERY_ORD20231201001</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1701425400</para>
                    /// </summary>
                    [NameInMap("StaleDate")]
                    [Validation(Required=false)]
                    public long? StaleDate { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("Music")]
                [Validation(Required=false)]
                public string Music { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Mutable")]
                [Validation(Required=false)]
                public bool? Mutable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("RelevanceScore")]
                [Validation(Required=false)]
                public double? RelevanceScore { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Silent")]
                [Validation(Required=false)]
                public bool? Silent { get; set; }

                [NameInMap("Subtitle")]
                [Validation(Required=false)]
                public string Subtitle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>news_category_tech</para>
                /// </summary>
                [NameInMap("ThreadId")]
                [Validation(Required=false)]
                public string ThreadId { get; set; }

            }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("Options")]
        [Validation(Required=false)]
        public PushTaskOptions Options { get; set; }
        public class PushTaskOptions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-06-21T12:00:00Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>jobkey1727749697913</para>
            /// </summary>
            [NameInMap("JobKey")]
            [Validation(Required=false)]
            public string JobKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1174754033128****</para>
            /// </summary>
            [NameInMap("MessageId")]
            [Validation(Required=false)]
            public long? MessageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-06-19T12:00:00Z</para>
            /// </summary>
            [NameInMap("PushTime")]
            [Validation(Required=false)]
            public string PushTime { get; set; }

            [NameInMap("Sms")]
            [Validation(Required=false)]
            public PushTaskOptionsSms Sms { get; set; }
            public class PushTaskOptionsSms : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>150</para>
                /// </summary>
                [NameInMap("DelaySecs")]
                [Validation(Required=false)]
                public long? DelaySecs { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>key1=value1&amp;key2=value2</para>
                /// </summary>
                [NameInMap("Params")]
                [Validation(Required=false)]
                public string Params { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PUSH_NOT_RECEIVED</para>
                /// </summary>
                [NameInMap("SendPolicy")]
                [Validation(Required=false)]
                public string SendPolicy { get; set; }

                [NameInMap("SignName")]
                [Validation(Required=false)]
                public string SignName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SMS_123456789</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Trim")]
            [Validation(Required=false)]
            public bool? Trim { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>accs,apns</para>
            /// </summary>
            [NameInMap("UseChannels")]
            [Validation(Required=false)]
            public string UseChannels { get; set; }

        }

        [NameInMap("Target")]
        [Validation(Required=false)]
        public PushTaskTarget Target { get; set; }
        public class PushTaskTarget : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>IOS</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DEVICE</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
