// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeInstanceStatisticsResponseBody : TeaModel {
        [NameInMap("InstanceStatistics")]
        [Validation(Required=false)]
        public List<DescribeInstanceStatisticsResponseBodyInstanceStatistics> InstanceStatistics { get; set; }
        public class DescribeInstanceStatisticsResponseBodyInstanceStatistics : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DefenseCountUsage")]
            [Validation(Required=false)]
            public int? DefenseCountUsage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("DomainUsage")]
            [Validation(Required=false)]
            public int? DomainUsage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ddoscoo-cn-XXXXX</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PortUsage")]
            [Validation(Required=false)]
            public int? PortUsage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SiteUsage")]
            [Validation(Required=false)]
            public int? SiteUsage { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
