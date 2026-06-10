// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ListAIStaffChatMessagesResponseBody : TeaModel {
        /// <summary>
        /// <para>Permission denied information</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Is retry allowed</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>App Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>or</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>Dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>Dynamic message. Not currently used. Please ignore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM_ERROR</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>Returned error parameters</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>Response data</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public ListAIStaffChatMessagesResponseBodyModule Module { get; set; }
        public class ListAIStaffChatMessagesResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>Sender type.  </para>
            /// <para>Enumeration values:  </para>
            /// <list type="bullet">
            /// <item><description><b>ADMIN</b>: System  </description></item>
            /// <item><description><b>CUSTOMER</b>: Visitor  </description></item>
            /// <item><description><b>AGENT</b>: Agent</description></item>
            /// </list>
            /// </summary>
            [NameInMap("Messages")]
            [Validation(Required=false)]
            public List<ListAIStaffChatMessagesResponseBodyModuleMessages> Messages { get; set; }
            public class ListAIStaffChatMessagesResponseBodyModuleMessages : TeaModel {
                /// <summary>
                /// <para>Bot ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zero2</para>
                /// </summary>
                [NameInMap("BotId")]
                [Validation(Required=false)]
                public string BotId { get; set; }

                /// <summary>
                /// <para>Current conversation round ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>54a0bfa0-41bd-4e96-acd9-fb13c0474452</para>
                /// </summary>
                [NameInMap("ChatId")]
                [Validation(Required=false)]
                public string ChatId { get; set; }

                /// <summary>
                /// <para>Current session status</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("ChatStatus")]
                [Validation(Required=false)]
                public string ChatStatus { get; set; }

                /// <summary>
                /// <para>ID of the invoked data class API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>domain cnamen<a href="http://www.buyhao8.com">www.buyhao8.com</a> <a href="http://www.buyhao8.com.a1.initrr.comn">www.buyhao8.com.a1.initrr.comn</a></para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>Content type</para>
                /// 
                /// <b>Example:</b>
                /// <para>application/octet-stream</para>
                /// </summary>
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                /// <summary>
                /// <para>Session ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>job-675163021891846144</para>
                /// </summary>
                [NameInMap("ConversationId")]
                [Validation(Required=false)]
                public string ConversationId { get; set; }

                /// <summary>
                /// <para>Creation Time</para>
                /// 
                /// <b>Example:</b>
                /// <para>1723532098</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>Updated At</para>
                /// 
                /// <b>Example:</b>
                /// <para>1591339051000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>Message ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1dafa033-e72b-44c2-99b7-bc202c5b6198</para>
                /// </summary>
                [NameInMap("MessageId")]
                [Validation(Required=false)]
                public string MessageId { get; set; }

                /// <summary>
                /// <para>Business extension metadata (in Map format, must be a JSON string)</para>
                /// </summary>
                [NameInMap("MetaData")]
                [Validation(Required=false)]
                public Dictionary<string, object> MetaData { get; set; }

                /// <summary>
                /// <para>Indicates the role of the participant in the conversation. Valid values include:</para>
                /// <list type="bullet">
                /// <item><description><para>user: User</para>
                /// </description></item>
                /// <item><description><para>assistant: Assistant</para>
                /// </description></item>
                /// <item><description><para>system: System</para>
                /// </description></item>
                /// <item><description><para>function: Function</para>
                /// </description></item>
                /// <item><description><para>plugin: Plugin</para>
                /// </description></item>
                /// <item><description><para>tool: Tool</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>Section ID of the inspection item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>324</para>
                /// </summary>
                [NameInMap("SectionId")]
                [Validation(Required=false)]
                public string SectionId { get; set; }

                /// <summary>
                /// <para>Site ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>928636774795776</para>
                /// </summary>
                [NameInMap("SiteId")]
                [Validation(Required=false)]
                public string SiteId { get; set; }

                /// <summary>
                /// <para>File type</para>
                /// 
                /// <b>Example:</b>
                /// <para>SINGLE</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C6B99AC-39EC-5350-874C-204128C905E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM.ERROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        /// <summary>
        /// <para>Abnormal message</para>
        /// 
        /// <b>Example:</b>
        /// <para>系统异常</para>
        /// </summary>
        [NameInMap("RootErrorMsg")]
        [Validation(Required=false)]
        public string RootErrorMsg { get; set; }

        /// <summary>
        /// <para>Reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
