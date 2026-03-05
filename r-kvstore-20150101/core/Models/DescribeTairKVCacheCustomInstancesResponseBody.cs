// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeTairKVCacheCustomInstancesResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeTairKVCacheCustomInstancesResponseBodyInstances Instances { get; set; }
        public class DescribeTairKVCacheCustomInstancesResponseBodyInstances : TeaModel {
            [NameInMap("KVStoreInstance")]
            [Validation(Required=false)]
            public List<DescribeTairKVCacheCustomInstancesResponseBodyInstancesKVStoreInstance> KVStoreInstance { get; set; }
            public class DescribeTairKVCacheCustomInstancesResponseBodyInstancesKVStoreInstance : TeaModel {
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

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

                [NameInMap("Storage")]
                [Validation(Required=false)]
                public long? Storage { get; set; }

                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeTairKVCacheCustomInstancesResponseBodyInstancesKVStoreInstanceTags Tags { get; set; }
                public class DescribeTairKVCacheCustomInstancesResponseBodyInstancesKVStoreInstanceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeTairKVCacheCustomInstancesResponseBodyInstancesKVStoreInstanceTagsTag> Tag { get; set; }
                    public class DescribeTairKVCacheCustomInstancesResponseBodyInstancesKVStoreInstanceTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("UseEni")]
                [Validation(Required=false)]
                public bool? UseEni { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B79C1A90-495B-4E99-A2AA-A4DB13B8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
