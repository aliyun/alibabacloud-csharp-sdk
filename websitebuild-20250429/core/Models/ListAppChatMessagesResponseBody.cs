// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ListAppChatMessagesResponseBody : TeaModel {
        /// <summary>
        /// <para>permission denied information</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>is retry allowed</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>App name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dewuApp</para>
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
        /// <para>dynamic error message used to replace <c>%s</c> in the <b>ErrMessage</b> error message.</para>
        /// <remarks>
        /// <para>If <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>DtsJobId</b>, it indicates that the request parameter <b>DtsJobId</b> is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>returned error parameters</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>Number of results per query.</para>
        /// <para>Value range: 10 to 100. Default Value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Response data</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public List<ListAppChatMessagesResponseBodyModule> Module { get; set; }
        public class ListAppChatMessagesResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>Bot ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zero2</para>
            /// </summary>
            [NameInMap("BotId")]
            [Validation(Required=false)]
            public string BotId { get; set; }

            /// <summary>
            /// <para>Unique ID of a single message</para>
            /// 
            /// <b>Example:</b>
            /// <para>chat-xrz3etcl2bsygwlx8g</para>
            /// </summary>
            [NameInMap("ChatId")]
            [Validation(Required=false)]
            public string ChatId { get; set; }

            /// <summary>
            /// <para>Current chat status</para>
            /// 
            /// <b>Example:</b>
            /// <para>created</para>
            /// </summary>
            [NameInMap("ChatStatus")]
            [Validation(Required=false)]
            public string ChatStatus { get; set; }

            /// <summary>
            /// <para>ID of the data class API being invoked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;code\&quot;: \&quot;200\&quot;, \&quot;success\&quot;: True, \&quot;content\&quot;: True, \&quot;requestId\&quot;: \&quot;028993DE-097E-5F4E-AC48-64A2D5ED5F30\&quot;, \&quot;businessError\&quot;: False, \&quot;message\&quot;: \&quot;success\&quot;, \&quot;httpStatusCode\&quot;: 200}</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>Content type</para>
            /// 
            /// <b>Example:</b>
            /// <para>image/png</para>
            /// </summary>
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <para>Session ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>872be9bc-3097-433d-b462-596202455102</para>
            /// </summary>
            [NameInMap("ConversationId")]
            [Validation(Required=false)]
            public string ConversationId { get; set; }

            /// <summary>
            /// <para>Creation Time</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>1740479834</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>Updated At</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-08-28T02:25:41Z</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <para>Message ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>ee60f5a6-88ca-4074-ad37-515f065bbbd2</para>
            /// </summary>
            [NameInMap("MessageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            /// <summary>
            /// <para>Business extension metadata (in Map format, must be a JSON string)</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;appId\&quot;:\&quot;WS20260506101154000001\&quot;,\&quot;inputTokens\&quot;:1148,\&quot;outputTokens\&quot;:60}</para>
            /// </summary>
            [NameInMap("MetaData")]
            [Validation(Required=false)]
            public string MetaData { get; set; }

            /// <summary>
            /// <para>Region ordinal number. This parameter is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("No")]
            [Validation(Required=false)]
            public int? No { get; set; }

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
            /// <para>LoC</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>Section ID of the checklist item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("SectionId")]
            [Validation(Required=false)]
            public string SectionId { get; set; }

            /// <summary>
            /// <para>Site ID, which can be obtained by invoking the <a href="~~ListSites~~">ListSites</a> API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>865181640657408</para>
            /// </summary>
            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public string SiteId { get; set; }

            /// <summary>
            /// <para>File type</para>
            /// 
            /// <b>Example:</b>
            /// <para>IMAGE</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Token for starting the next query. It is empty when there is no next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0l45bkwM022Dt+rOvPi/oQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// <para>SYSTEM.EROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        /// <summary>
        /// <para>abnormal message</para>
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
