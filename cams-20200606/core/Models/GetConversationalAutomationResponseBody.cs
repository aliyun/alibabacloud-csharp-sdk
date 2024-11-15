// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetConversationalAutomationResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description>The value OK indicates that the request was successful.</description></item>
        /// <item><description>For more information about other response codes, see <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetConversationalAutomationResponseBodyData Data { get; set; }
        public class GetConversationalAutomationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The commands.</para>
            /// </summary>
            [NameInMap("Commands")]
            [Validation(Required=false)]
            public List<GetConversationalAutomationResponseBodyDataCommands> Commands { get; set; }
            public class GetConversationalAutomationResponseBodyDataCommands : TeaModel {
                /// <summary>
                /// <para>The description of the command.</para>
                /// 
                /// <b>Example:</b>
                /// <para>description</para>
                /// </summary>
                [NameInMap("CommandDescription")]
                [Validation(Required=false)]
                public string CommandDescription { get; set; }

                /// <summary>
                /// <para>The name of the command.</para>
                /// 
                /// <b>Example:</b>
                /// <para>common1</para>
                /// </summary>
                [NameInMap("CommandName")]
                [Validation(Required=false)]
                public string CommandName { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the welcoming message is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableWelcomeMessage")]
            [Validation(Required=false)]
            public bool? EnableWelcomeMessage { get; set; }

            /// <summary>
            /// <para>The phone number of the enterprise.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86138****</para>
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// <para>The opening remarks.</para>
            /// </summary>
            [NameInMap("Prompts")]
            [Validation(Required=false)]
            public List<string> Prompts { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90E63D28-E31D-1EB2-8939-A94866411B2O</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
