// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListCallSummariesResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListCallSummariesResponseBodyData> Data { get; set; }
        public class ListCallSummariesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Call ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-544789******759424</para>
            /// </summary>
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }

            /// <summary>
            /// <para>Summary information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;_sys_field_config&quot;: [
            ///         {
            ///             &quot;Array&quot;: false,
            ///             &quot;Required&quot;: true,
            ///             &quot;DisplayName&quot;: &quot;主题&quot;,
            ///             &quot;Attributes&quot;: &quot;{}&quot;,
            ///             &quot;DataType&quot;: &quot;TEXT&quot;,
            ///             &quot;EditorType&quot;: &quot;TEXT&quot;,
            ///             &quot;MaxLength&quot;: 30,
            ///             &quot;System&quot;: true,
            ///             &quot;Name&quot;: &quot;summaryTitle&quot;
            ///         },
            ///         {
            ///             &quot;Array&quot;: false,
            ///             &quot;DisplayName&quot;: &quot;小结&quot;,
            ///             &quot;Attributes&quot;: &quot;{}&quot;,
            ///             &quot;DataType&quot;: &quot;TEXT&quot;,
            ///             &quot;EditorType&quot;: &quot;TEXTAREA&quot;,
            ///             &quot;MaxLength&quot;: 1000,
            ///             &quot;System&quot;: true,
            ///             &quot;Name&quot;: &quot;summaryContent&quot;
            ///         },
            ///         {
            ///             &quot;Array&quot;: true,
            ///             &quot;DisplayName&quot;: &quot;标签&quot;,
            ///             &quot;Attributes&quot;: &quot;{}&quot;,
            ///             &quot;DataType&quot;: &quot;TEXT&quot;,
            ///             &quot;EditorType&quot;: &quot;SELECT&quot;,
            ///             &quot;System&quot;: true,
            ///             &quot;Name&quot;: &quot;keywords&quot;
            ///         }
            ///     ],
            ///     &quot;summaryContent&quot;: &quot;小结内容&quot;,
            ///     &quot;creator&quot;: &quot;creator@ccc-test&quot;,
            ///     &quot;bizType&quot;: &quot;Summary&quot;,
            ///     &quot;keywords&quot;: [
            ///         &quot;标签1&quot;
            ///     ],
            ///     &quot;source&quot;: &quot;Console&quot;,
            ///     &quot;summaryTitle&quot;: &quot;测试会话小结&quot;,
            ///     &quot;instanceId&quot;: &quot;ccc-test&quot;,
            ///     &quot;externalInput&quot;: &quot;{\&quot;summaryTitle\&quot;:\&quot;测试会话小结\&quot;,\&quot;summaryContent\&quot;:\&quot;小结内容\&quot;,\&quot;keywords\&quot;:[\&quot;标签1\&quot;],\&quot;_sys_field_config\&quot;:[{\&quot;DisplayName\&quot;:\&quot;主题\&quot;,\&quot;Name\&quot;:\&quot;summaryTitle\&quot;,\&quot;Required\&quot;:true,\&quot;EditorType\&quot;:\&quot;TEXT\&quot;,\&quot;Array\&quot;:false,\&quot;DataType\&quot;:\&quot;TEXT\&quot;,\&quot;System\&quot;:true,\&quot;MaxLength\&quot;:30,\&quot;Attributes\&quot;:\&quot;{}\&quot;},{\&quot;DisplayName\&quot;:\&quot;小结\&quot;,\&quot;Name\&quot;:\&quot;summaryContent\&quot;,\&quot;EditorType\&quot;:\&quot;TEXTAREA\&quot;,\&quot;Array\&quot;:false,\&quot;DataType\&quot;:\&quot;TEXT\&quot;,\&quot;System\&quot;:true,\&quot;MaxLength\&quot;:1000,\&quot;Attributes\&quot;:\&quot;{}\&quot;},{\&quot;DisplayName\&quot;:\&quot;标签\&quot;,\&quot;Name\&quot;:\&quot;keywords\&quot;,\&quot;EditorType\&quot;:\&quot;SELECT\&quot;,\&quot;Array\&quot;:true,\&quot;DataType\&quot;:\&quot;TEXT\&quot;,\&quot;System\&quot;:true,\&quot;Attributes\&quot;:\&quot;{}\&quot;}]}&quot;,
            ///     &quot;templateName&quot;: &quot;Summary-Ticket&quot;,
            ///     &quot;bizId&quot;: &quot;job-544789<b><b><b>759424&quot;,
            ///     &quot;ticketStartTime&quot;: 1723449513735,
            ///     &quot;ticketId&quot;: &quot;ac0dd304-</b></b>-</b><b>-<b><b>-4a90010f0d38&quot;,
            ///     &quot;definitionId&quot;: &quot;Summary-Ticket:2:6881f43a-</b></b>-11ee-***</b>-6eb35a90a7a6&quot;
            /// }</para>
            /// </summary>
            [NameInMap("Context")]
            [Validation(Required=false)]
            public string Context { get; set; }

            /// <summary>
            /// <para>Creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1723449513735</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>Creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>creator@ccc-test</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>Editor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>editor@ccc-test</para>
            /// </summary>
            [NameInMap("Editor")]
            [Validation(Required=false)]
            public string Editor { get; set; }

            /// <summary>
            /// <para>Summary ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ac0dd304-<b><b>-</b></b>-****-4a90010f0d38</para>
            /// </summary>
            [NameInMap("TicketId")]
            [Validation(Required=false)]
            public string TicketId { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>List of error parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>932579BC-811A-503D-B322-4C2E57087CAA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
