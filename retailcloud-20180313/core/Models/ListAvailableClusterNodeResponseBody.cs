// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class ListAvailableClusterNodeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAvailableClusterNodeResponseBodyData> Data { get; set; }
        public class ListAvailableClusterNodeResponseBodyData : TeaModel {
            [NameInMap("BusinessCode")]
            [Validation(Required=false)]
            public string BusinessCode { get; set; }

            [NameInMap("EcsConfiguration")]
            [Validation(Required=false)]
            public string EcsConfiguration { get; set; }

            [NameInMap("EcsCpu")]
            [Validation(Required=false)]
            public string EcsCpu { get; set; }

            [NameInMap("EcsEip")]
            [Validation(Required=false)]
            public string EcsEip { get; set; }

            [NameInMap("EcsExpiredTime")]
            [Validation(Required=false)]
            public string EcsExpiredTime { get; set; }

            [NameInMap("EcsLocalStorageCapacity")]
            [Validation(Required=false)]
            public string EcsLocalStorageCapacity { get; set; }

            [NameInMap("EcsMemory")]
            [Validation(Required=false)]
            public string EcsMemory { get; set; }

            [NameInMap("EcsOsType")]
            [Validation(Required=false)]
            public string EcsOsType { get; set; }

            [NameInMap("EcsPrivateIp")]
            [Validation(Required=false)]
            public string EcsPrivateIp { get; set; }

            [NameInMap("EcsPublicIp")]
            [Validation(Required=false)]
            public string EcsPublicIp { get; set; }

            [NameInMap("EcsZone")]
            [Validation(Required=false)]
            public string EcsZone { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("InstanceNetworkType")]
            [Validation(Required=false)]
            public string InstanceNetworkType { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("InternetMaxBandwidthIn")]
            [Validation(Required=false)]
            public string InternetMaxBandwidthIn { get; set; }

            [NameInMap("InternetMaxBandwidthOut")]
            [Validation(Required=false)]
            public string InternetMaxBandwidthOut { get; set; }

            [NameInMap("OSName")]
            [Validation(Required=false)]
            public string OSName { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
