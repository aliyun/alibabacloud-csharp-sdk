// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeInstanceStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The statistics on the instances.
        /// </summary>
        [NameInMap("InstanceStatistics")]
        [Validation(Required=false)]
        public List<DescribeInstanceStatisticsResponseBodyInstanceStatistics> InstanceStatistics { get; set; }
        public class DescribeInstanceStatisticsResponseBodyInstanceStatistics : TeaModel {
            /// <summary>
            /// The number of advanced mitigation sessions that are used in this month.
            /// 
            /// > This parameter is returned only if Anti-DDoS Premium instances are queried.
            /// </summary>
            [NameInMap("DefenseCountUsage")]
            [Validation(Required=false)]
            public int? DefenseCountUsage { get; set; }

            /// <summary>
            /// The number of domain names that are protected by the instance.
            /// </summary>
            [NameInMap("DomainUsage")]
            [Validation(Required=false)]
            public int? DomainUsage { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The number of ports that are protected by the instance.
            /// </summary>
            [NameInMap("PortUsage")]
            [Validation(Required=false)]
            public int? PortUsage { get; set; }

            /// <summary>
            /// The number of websites that are protected by the instance.
            /// </summary>
            [NameInMap("SiteUsage")]
            [Validation(Required=false)]
            public int? SiteUsage { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
