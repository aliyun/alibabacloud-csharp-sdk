// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeTairKVCacheInferInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the returned Tair (Redis OSS-compatible) KVCache instance.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeTairKVCacheInferInstancesResponseBodyInstances Instances { get; set; }
        public class DescribeTairKVCacheInferInstancesResponseBodyInstances : TeaModel {
            [NameInMap("TairInferInstanceDTO")]
            [Validation(Required=false)]
            public List<DescribeTairKVCacheInferInstancesResponseBodyInstancesTairInferInstanceDTO> TairInferInstanceDTO { get; set; }
            public class DescribeTairKVCacheInferInstancesResponseBodyInstancesTairInferInstanceDTO : TeaModel {
                /// <summary>
                /// <para>The ACK cluster ID corresponding to the virtual cluster instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c809******************************</para>
                /// </summary>
                [NameInMap("AckId")]
                [Validation(Required=false)]
                public string AckId { get; set; }

                /// <summary>
                /// <para>The capacity of the KVCache. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>256</para>
                /// </summary>
                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public long? Capacity { get; set; }

                /// <summary>
                /// <para>The billing method of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PostPaid</para>
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <para>The number of compute units.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ComputeUnitNum")]
                [Validation(Required=false)]
                public int? ComputeUnitNum { get; set; }

                /// <summary>
                /// <para>The creation time of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-04-07T04:46Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The time when the instance was deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-04-07T04:46Z</para>
                /// </summary>
                [NameInMap("DestroyTime")]
                [Validation(Required=false)]
                public string DestroyTime { get; set; }

                [NameInMap("ElasticVNodeCount")]
                [Validation(Required=false)]
                public int? ElasticVNodeCount { get; set; }

                /// <summary>
                /// <para>The time when the subscription instance expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-11-04T02:09:26Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("FixedVNodeCount")]
                [Validation(Required=false)]
                public int? FixedVNodeCount { get; set; }

                /// <summary>
                /// <para>The instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kvcache.cu.g4b.2</para>
                /// </summary>
                [NameInMap("InstanceClass")]
                [Validation(Required=false)]
                public string InstanceClass { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tk-9dp7e37bab*****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kvcache-7</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The instance state. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b>: The instance is normal.</description></item>
                /// <item><description><b>Creating</b>: The instance is being created.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("InstanceStatus")]
                [Validation(Required=false)]
                public string InstanceStatus { get; set; }

                /// <summary>
                /// <para>The type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>TairInfer</b>: the inference operator instance</description></item>
                /// <item><description><b>TairKVCacheVnode</b>: the virtual cluster instance.</description></item>
                /// <item><description><b>TairKVCacheService</b>: the cache service instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TairInfer</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The built-in model of the inference operator instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DeepSeek-OCR</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <para>The number of model services of the inference operator instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ModelServiceNum")]
                [Validation(Required=false)]
                public int? ModelServiceNum { get; set; }

                /// <summary>
                /// <para>The network type of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The private IP address of the instance. This parameter is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.16.49.***</para>
                /// </summary>
                [NameInMap("PrivateIp")]
                [Validation(Required=false)]
                public string PrivateIp { get; set; }

                /// <summary>
                /// <para>The region ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The resource group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfm4bdru5z****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>Details of the tags.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeTairKVCacheInferInstancesResponseBodyInstancesTairInferInstanceDTOTags Tags { get; set; }
                public class DescribeTairKVCacheInferInstancesResponseBodyInstancesTairInferInstanceDTOTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeTairKVCacheInferInstancesResponseBodyInstancesTairInferInstanceDTOTagsTag> Tag { get; set; }
                    public class DescribeTairKVCacheInferInstancesResponseBodyInstancesTairInferInstanceDTOTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>thread</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>900</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The number of vNodes in the virtual cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("VNodeCount")]
                [Validation(Required=false)]
                public int? VNodeCount { get; set; }

                /// <summary>
                /// <para>The list of vNode instance names under the virtual cluster instance. This parameter is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tv-xxxxx</para>
                /// </summary>
                [NameInMap("VNodeName")]
                [Validation(Required=false)]
                public string VNodeName { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-8vbf0ksk774ai6q1d****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The VPC ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-2zef5w848p4j5g***</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-g</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD225838-7069-5CE4-89E1-67B83AC149C8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
