// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeConsoleMessagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of console messages queried for the current page. If no messages match, an empty list is returned.</para>
        /// </summary>
        [NameInMap("MessageList")]
        [Validation(Required=false)]
        public List<DescribeConsoleMessagesResponseBodyMessageList> MessageList { get; set; }
        public class DescribeConsoleMessagesResponseBodyMessageList : TeaModel {
            /// <summary>
            /// <para>The list of client types to which the message applies. Standard names are returned: Windows, Mac, Web, and Hardware.</para>
            /// </summary>
            [NameInMap("ClientTypes")]
            [Validation(Required=false)]
            public List<string> ClientTypes { get; set; }

            /// <summary>
            /// <para>The list of message body configurations for each language.</para>
            /// </summary>
            [NameInMap("ContentConfigs")]
            [Validation(Required=false)]
            public List<DescribeConsoleMessagesResponseBodyMessageListContentConfigs> ContentConfigs { get; set; }
            public class DescribeConsoleMessagesResponseBodyMessageListContentConfigs : TeaModel {
                /// <summary>
                /// <para>The color of the body text. The color value saved when the message is created or modified is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>#666666</para>
                /// </summary>
                [NameInMap("Color")]
                [Validation(Required=false)]
                public string Color { get; set; }

                /// <summary>
                /// <para>The message body text in the specified language.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The cloud computer will undergo routine maintenance. Please save your work in advance</para>
                /// </summary>
                [NameInMap("ContentText")]
                [Validation(Required=false)]
                public string ContentText { get; set; }

                /// <summary>
                /// <para>The body language. Valid values: CN (Chinese), EN (English), and JP (Japanese). The query returns the language value saved when the message is created or modified, retaining the original case.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("LangType")]
                [Validation(Required=false)]
                public string LangType { get; set; }

            }

            /// <summary>
            /// <para>The time when the operational message stops taking effect. The time is in ISO 8601 format. A time zone offset of +00:00 indicates UTC time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-11T02:00:00.000+00:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The time when the message was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-10T00:00:00.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the message was last modified. This time is also updated when the message status changes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-10T01:00:00.000+00:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The list of hyperlink button configurations in the message.</para>
            /// </summary>
            [NameInMap("HyperLinkConfigs")]
            [Validation(Required=false)]
            public List<DescribeConsoleMessagesResponseBodyMessageListHyperLinkConfigs> HyperLinkConfigs { get; set; }
            public class DescribeConsoleMessagesResponseBodyMessageListHyperLinkConfigs : TeaModel {
                /// <summary>
                /// <para>The text displayed on the hyperlink button.</para>
                /// 
                /// <b>Example:</b>
                /// <para>View Details</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The URL accessed after the hyperlink button is clicked.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/announcements/maintenance">https://example.com/announcements/maintenance</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The storage path of the image file for the operational message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>image_file/OPERATIONAL/00000000-0000-console-message.png</para>
            /// </summary>
            [NameInMap("ImageFilePath")]
            [Validation(Required=false)]
            public string ImageFilePath { get; set; }

            /// <summary>
            /// <para>The list of image configurations, which is mainly used for custom wallpaper messages. Each item includes the image name, image type, storage path, and temporary download URL.</para>
            /// </summary>
            [NameInMap("ImageInfoList")]
            [Validation(Required=false)]
            public List<DescribeConsoleMessagesResponseBodyMessageListImageInfoList> ImageInfoList { get; set; }
            public class DescribeConsoleMessagesResponseBodyMessageListImageInfoList : TeaModel {
                /// <summary>
                /// <para>The name of the image file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>img0.jpg</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The storage path of the image file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>image_file/CUSTOM_WALLPAPER/00000000-0000-img0.jpg</para>
                /// </summary>
                [NameInMap("ImageFilePath")]
                [Validation(Required=false)]
                public string ImageFilePath { get; set; }

                /// <summary>
                /// <para>The image type. Configuration types defined by the backend include Operational (operational message image), WallpaperBasic (basic wallpaper image), and WallpaperAppend (appended wallpaper image). The query returns the image type value saved when the message is created or modified, retaining the original case.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WallpaperBasic</para>
                /// </summary>
                [NameInMap("ImageType")]
                [Validation(Required=false)]
                public string ImageType { get; set; }

                /// <summary>
                /// <para>The temporary download URL of the image file. The link has a limited validity period. If the link expires, you can query again to obtain a new one.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/images/img0.jpg">https://example.com/images/img0.jpg</a></para>
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

            }

            /// <summary>
            /// <para>The temporary download URL of the operational message image. The link has a limited validity period. If the link expires, you can query again to obtain a new one.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/images/console-message.png">https://example.com/images/console-message.png</a></para>
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// <para>The message ID, which can be used to send, modify, or delete a specified message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>msg-123456</para>
            /// </summary>
            [NameInMap("MessageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            /// <summary>
            /// <para>The message level of the notification message. Valid values: STRONG (strong message) and WEAK (weak message).</para>
            /// 
            /// <b>Example:</b>
            /// <para>STRONG</para>
            /// </summary>
            [NameInMap("MessageLevel")]
            [Validation(Required=false)]
            public string MessageLevel { get; set; }

            /// <summary>
            /// <para>The message type. Valid values: OPERATIONAL (client operational message), WALLPAPER (desktop wallpaper text message), NOTIFICATION (message center notification), and CUSTOM_WALLPAPER (custom desktop wallpaper).</para>
            /// 
            /// <b>Example:</b>
            /// <para>NOTIFICATION</para>
            /// </summary>
            [NameInMap("MessageType")]
            [Validation(Required=false)]
            public string MessageType { get; set; }

            /// <summary>
            /// <para>The additional configuration of the message, including the associated workspace, AD domain name, and scheduled sending configuration. Whether specific fields are returned depends on the message type and its saved configuration.</para>
            /// </summary>
            [NameInMap("MetaData")]
            [Validation(Required=false)]
            public DescribeConsoleMessagesResponseBodyMessageListMetaData MetaData { get; set; }
            public class DescribeConsoleMessagesResponseBodyMessageListMetaData : TeaModel {
                /// <summary>
                /// <para>The AD domain name associated with the message configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ad.example.com</para>
                /// </summary>
                [NameInMap("AdDomain")]
                [Validation(Required=false)]
                public string AdDomain { get; set; }

                /// <summary>
                /// <para>The workspace ID associated with the message configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai+dir-example01</para>
                /// </summary>
                [NameInMap("OfficeSiteId")]
                [Validation(Required=false)]
                public string OfficeSiteId { get; set; }

                /// <summary>
                /// <para>The list of scheduled sending configurations. If TimerType is CRON, the elements are cron expressions. If TimerType is Timestamp, the elements are millisecond timestamps represented as strings.</para>
                /// </summary>
                [NameInMap("Timer")]
                [Validation(Required=false)]
                public List<string> Timer { get; set; }

                /// <summary>
                /// <para>The scheduled sending type. Valid values: CRON (cron expression) and Timestamp (timestamp). The configuration values are case-sensitive.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CRON</para>
                /// </summary>
                [NameInMap("TimerType")]
                [Validation(Required=false)]
                public string TimerType { get; set; }

            }

            /// <summary>
            /// <para>The display position of the message. For wallpaper text messages, valid values are CENTER (center), TOP_RIGHT (top right), BOTTOM_RIGHT (bottom right), and BOTTOM_LEFT (bottom left). For client operational messages, valid values are CLIENT_ENTERPRISE_RESOURCE_PAGE (Enterprise Edition client cloud resource page) and CLIENT_BUSINESS_RESOURCE_PAGE (Business Edition client cloud resource page).</para>
            /// 
            /// <b>Example:</b>
            /// <para>CENTER</para>
            /// </summary>
            [NameInMap("Position")]
            [Validation(Required=false)]
            public string Position { get; set; }

            /// <summary>
            /// <para>The time when the operational message starts taking effect. The time is in ISO 8601 format. A time zone offset of +00:00 indicates UTC time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-10T02:00:00.000+00:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The current status of the message. Valid values: Init (initializing), Pushing (pushing), Published (published), Expired (expired), Deleting (deleting), and Failed (failed). Published indicates that the message has been published or the server-side push processing has finished, but it does not indicate that all target terminals have successfully received the message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Published</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The JSON string of the list of targets to which the message applies. For Organization and AdOrg, it is an array of objects containing orgId (organization ID) and orgName (organization name). The organization name may be empty, and records in the old format may not contain orgName. For Tag, it is an array of objects containing tagKey (tag key), tagValue (tag value), and regionId (region ID). For other target types, it is an array of strings. The all-users target is represented by ALL_USERS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;user01&quot;]</para>
            /// </summary>
            [NameInMap("TargetIds")]
            [Validation(Required=false)]
            public string TargetIds { get; set; }

            /// <summary>
            /// <para>The type of the target to which the message applies. Valid values: AllUsers (all convenience users), EndUser (specified convenience user), Organization (specified convenience user organization), Desktop (cloud computer), ResourceGroup (resource group), Region (region), Tag (tag), AdAllUsers (all AD users), AdUser (specified AD user), and AdOrg (specified AD organization).</para>
            /// 
            /// <b>Example:</b>
            /// <para>EndUser</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>The list of message title configurations for each language.</para>
            /// </summary>
            [NameInMap("TitleConfigs")]
            [Validation(Required=false)]
            public List<DescribeConsoleMessagesResponseBodyMessageListTitleConfigs> TitleConfigs { get; set; }
            public class DescribeConsoleMessagesResponseBodyMessageListTitleConfigs : TeaModel {
                /// <summary>
                /// <para>The color of the title text. The color value saved when the message is created or modified is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>#333333</para>
                /// </summary>
                [NameInMap("Color")]
                [Validation(Required=false)]
                public string Color { get; set; }

                /// <summary>
                /// <para>The title language. Valid values: CN (Chinese), EN (English), and JP (Japanese). The query returns the language value saved when the message is created or modified, retaining the original case.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("LangType")]
                [Validation(Required=false)]
                public string LangType { get; set; }

                /// <summary>
                /// <para>The message title text in the specified language.</para>
                /// 
                /// <b>Example:</b>
                /// <para>System Maintenance Notice</para>
                /// </summary>
                [NameInMap("TitleText")]
                [Validation(Required=false)]
                public string TitleText { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the current request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9F1D7E42-06A8-4B50-9A21-6E0C8D3F5B72</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of messages that match the query conditions, not the number of messages returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
