// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeProjectOperateLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e6037e86-657f-4194-bb6a-7b26973aec8d</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeProjectOperateLogsResponseBodyResult> Result { get; set; }
        public class DescribeProjectOperateLogsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The description of the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>进入分配服务商操作人</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The operation time (UNIX timestamp).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1587624497000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud UID of the operator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public long? Operator { get; set; }

            /// <summary>
            /// <para>The name of the operator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>系统</para>
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
            /// <para>System</para>
            /// </summary>
            [NameInMap("OperatorRole")]
            [Validation(Required=false)]
            public string OperatorRole { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
