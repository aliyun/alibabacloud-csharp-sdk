// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetCopilotHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SysomOpenAPI.InvalidParameter</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of chat records. The length equals the requested count. If the actual number of chat records is less than the requested count, the actual number is returned. Format: [{&quot;user&quot;:&quot;&quot;,&quot;content&quot;:&quot;&quot;.question,&quot;time&quot;:&quot;&quot;},{...}].</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetCopilotHistoryResponseBodyData> Data { get; set; }
        public class GetCopilotHistoryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The text content of the chat message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>copilot回复的具体内容</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The time of the chat record. The value is of the STRING type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-09-02 10:02:39</para>
            /// </summary>
            [NameInMap("time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// <para>The role of the message sender. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>user: the user.</description></item>
            /// <item><description>copilot: the bot.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>user
            /// copilot</para>
            /// </summary>
            [NameInMap("user")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, this field is empty.</description></item>
        /// <item><description>Otherwise, this field contains the error message of the request.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SysomOpenAPIAssumeRoleException: EntityNotExist.Role The role not exists: acs:ram::xxxxx:role/aliyunserviceroleforsysom</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D693121-C925-5154-8DF6-C09A8B369822</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
