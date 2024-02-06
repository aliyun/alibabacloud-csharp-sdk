// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEpnInstancesResponseBody : TeaModel {
        /// <summary>
        /// Details of EPN instances.
        /// </summary>
        [NameInMap("EPNInstances")]
        [Validation(Required=false)]
        public DescribeEpnInstancesResponseBodyEPNInstances EPNInstances { get; set; }
        public class DescribeEpnInstancesResponseBodyEPNInstances : TeaModel {
            [NameInMap("EPNInstance")]
            [Validation(Required=false)]
            public List<DescribeEpnInstancesResponseBodyEPNInstancesEPNInstance> EPNInstance { get; set; }
            public class DescribeEpnInstancesResponseBodyEPNInstancesEPNInstance : TeaModel {
                /// <summary>
                /// The time when the instance was created. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The ID of the EPN instance.
                /// </summary>
                [NameInMap("EPNInstanceId")]
                [Validation(Required=false)]
                public string EPNInstanceId { get; set; }

                /// <summary>
                /// The name of the EPN instance.
                /// </summary>
                [NameInMap("EPNInstanceName")]
                [Validation(Required=false)]
                public string EPNInstanceName { get; set; }

                /// <summary>
                /// Set the value to EdgeToEdge.
                /// </summary>
                [NameInMap("EPNInstanceType")]
                [Validation(Required=false)]
                public string EPNInstanceType { get; set; }

                /// <summary>
                /// The end of the time range during which the data was queried. The time is displayed in UTC.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The inbound bandwidth. Unit: Mbit/s.
                /// </summary>
                [NameInMap("InternetMaxBandwidthOut")]
                [Validation(Required=false)]
                public int? InternetMaxBandwidthOut { get; set; }

                /// <summary>
                /// The time when the instance was last modified. The time is displayed in UTC.
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// The networking mode. Valid values:
                /// 
                /// *   SpeedUp: intelligent acceleration network (Internet)
                /// *   Connection: internal network
                /// *   SpeedUpAndConnection: intelligent acceleration network and internal network
                /// </summary>
                [NameInMap("NetworkingModel")]
                [Validation(Required=false)]
                public string NetworkingModel { get; set; }

                /// <summary>
                /// The beginning of the time range during which the data was queried. The time is displayed in UTC.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The status of the instance. Valid values:
                /// 
                /// *   Running
                /// *   Excuting
                /// *   Stopped
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of pages returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
