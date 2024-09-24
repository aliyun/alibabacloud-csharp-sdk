// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCloudProductFieldStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The statistics of cloud services that are protected by Security Center.</para>
        /// </summary>
        [NameInMap("GroupedFields")]
        [Validation(Required=false)]
        public DescribeCloudProductFieldStatisticsResponseBodyGroupedFields GroupedFields { get; set; }
        public class DescribeCloudProductFieldStatisticsResponseBodyGroupedFields : TeaModel {
            /// <summary>
            /// <para>The statistics of different types of assets. <b>MachineType</b> indicates the type of the asset. <b>Count</b> indicates the number of assets of a specific type.</para>
            /// <para>Valid values of <b>MachineType</b>:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Server Load Balancer (SLB) instance</description></item>
            /// <item><description><b>2</b>: NAT gateway instance</description></item>
            /// <item><description><b>3</b>: ApsaraDB RDS instance</description></item>
            /// <item><description><b>4</b>: ApsaraDB for MongoDB instance</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;MachineType&quot;:1,&quot;Count&quot;:11}]</para>
            /// </summary>
            [NameInMap("CategoryCount")]
            [Validation(Required=false)]
            public string CategoryCount { get; set; }

            /// <summary>
            /// <para>The total number of cloud services that are protected by Security Center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            /// <summary>
            /// <para>The number of cloud services that are at risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("RiskInstanceCount")]
            [Validation(Required=false)]
            public int? RiskInstanceCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E0618A9-D5EF-4220-9471-C42B5E92719F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
