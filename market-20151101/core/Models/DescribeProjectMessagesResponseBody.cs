// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeProjectMessagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00eb4de1-6cff-4f56-833e-7b1e070e398d</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeProjectMessagesResponseBodyResult> Result { get; set; }
        public class DescribeProjectMessagesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The content of the message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>尊敬的客户您好，我们已经为您上传了方案，请您查阅，然后尽快将您的意见反馈给我们。</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The time when the message was created, in UNIX timestamp format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1589015560000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud UID of the user who left the message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>452611111****</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public long? Operator { get; set; }

            /// <summary>
            /// <para>The name of the user who left the message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>***科技技术有限公司</para>
            /// </summary>
            [NameInMap("OperatorName")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }

            /// <summary>
            /// <para>The role of the operator. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>System: system.</description></item>
            /// <item><description>Custom: customer.</description></item>
            /// <item><description>Provider: service provider.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Provider</para>
            /// </summary>
            [NameInMap("OperatorRole")]
            [Validation(Required=false)]
            public string OperatorRole { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of messages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
