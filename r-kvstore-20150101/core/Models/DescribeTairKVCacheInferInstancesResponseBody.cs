// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeTairKVCacheInferInstancesResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeTairKVCacheInferInstancesResponseBodyInstances Instances { get; set; }
        public class DescribeTairKVCacheInferInstancesResponseBodyInstances : TeaModel {
            [NameInMap("TairInferInstanceDTO")]
            [Validation(Required=false)]
            public List<DescribeTairKVCacheInferInstancesResponseBodyInstancesTairInferInstanceDTO> TairInferInstanceDTO { get; set; }
            public class DescribeTairKVCacheInferInstancesResponseBodyInstancesTairInferInstanceDTO : TeaModel {
                [NameInMap("AckId")]
                [Validation(Required=false)]
                public string AckId { get; set; }

                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public long? Capacity { get; set; }

                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                [NameInMap("ComputeUnitNum")]
                [Validation(Required=false)]
                public int? ComputeUnitNum { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DestroyTime")]
                [Validation(Required=false)]
                public string DestroyTime { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("InstanceClass")]
                [Validation(Required=false)]
                public string InstanceClass { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("InstanceStatus")]
                [Validation(Required=false)]
                public string InstanceStatus { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                [NameInMap("ModelServiceNum")]
                [Validation(Required=false)]
                public int? ModelServiceNum { get; set; }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("PrivateIp")]
                [Validation(Required=false)]
                public string PrivateIp { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeTairKVCacheInferInstancesResponseBodyInstancesTairInferInstanceDTOTags Tags { get; set; }
                public class DescribeTairKVCacheInferInstancesResponseBodyInstancesTairInferInstanceDTOTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeTairKVCacheInferInstancesResponseBodyInstancesTairInferInstanceDTOTagsTag> Tag { get; set; }
                    public class DescribeTairKVCacheInferInstancesResponseBodyInstancesTairInferInstanceDTOTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("VNodeCount")]
                [Validation(Required=false)]
                public int? VNodeCount { get; set; }

                [NameInMap("VNodeName")]
                [Validation(Required=false)]
                public string VNodeName { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

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
        public int? TotalCount { get; set; }

    }

}
