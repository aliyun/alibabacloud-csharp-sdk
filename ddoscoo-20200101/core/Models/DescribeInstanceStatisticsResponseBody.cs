// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeInstanceStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The statistics on the instance.</para>
        /// </summary>
        [NameInMap("InstanceStatistics")]
        [Validation(Required=false)]
        public List<DescribeInstanceStatisticsResponseBodyInstanceStatistics> InstanceStatistics { get; set; }
        public class DescribeInstanceStatisticsResponseBodyInstanceStatistics : TeaModel {
            /// <summary>
            /// <para>The number of advanced mitigation sessions that are used in this month.</para>
            /// <remarks>
            /// <para> This parameter is returned only if Anti-DDoS Proxy (Outside Chinese Mainland) instances are queried.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DefenseCountUsage")]
            [Validation(Required=false)]
            public int? DefenseCountUsage { get; set; }

            /// <summary>
            /// <para>The number of domain names that are protected by the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DomainUsage")]
            [Validation(Required=false)]
            public int? DomainUsage { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddoscoo-cn-mp91j1ao****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The number of ports that are protected by the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PortUsage")]
            [Validation(Required=false)]
            public int? PortUsage { get; set; }

            /// <summary>
            /// <para>The number of websites that are protected by the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SiteUsage")]
            [Validation(Required=false)]
            public int? SiteUsage { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>642319A9-D1F2-4459-A447-E57CFC599FDE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
