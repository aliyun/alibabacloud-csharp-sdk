// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeInstancesResponseBodyInstances> Instances { get; set; }
        public class DescribeInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DebtStatus")]
            [Validation(Required=false)]
            public int? DebtStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("Edition")]
            [Validation(Required=false)]
            public int? Edition { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public int? Enabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2308402384</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2308402384</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ddoscoo-cn-XXXXX</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testRemark</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
