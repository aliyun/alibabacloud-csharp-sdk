// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetSasContainerWebDefenseRuleApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The application list.</para>
        /// </summary>
        [NameInMap("ContainerWebDefenseAppList")]
        [Validation(Required=false)]
        public List<GetSasContainerWebDefenseRuleApplicationResponseBodyContainerWebDefenseAppList> ContainerWebDefenseAppList { get; set; }
        public class GetSasContainerWebDefenseRuleApplicationResponseBodyContainerWebDefenseAppList : TeaModel {
            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5944922169365****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The ID of the container cluster.</para>
            /// <remarks>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/182997.html">DescribeGroupedContainerInstances</a> operation to obtain this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cfb41a869c71e4678a97021582dd8****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The creation time of the application, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1677839038000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The most recent modification time, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1667891185000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the current node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>143761</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>403327</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <para>The application tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app:test</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique ID for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09969D2C-4FAD-429E-BFBF-9A60DEF8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
