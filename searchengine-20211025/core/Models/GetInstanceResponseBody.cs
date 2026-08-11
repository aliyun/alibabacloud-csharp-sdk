// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E7B7D598-B080-5C8E-AA35-D43EC0D5F886</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyResult Result { get; set; }
        public class GetInstanceResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The BS version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bs_3.13.2</para>
            /// </summary>
            [NameInMap("bsVersion")]
            [Validation(Required=false)]
            public string BsVersion { get; set; }

            /// <summary>
            /// <para>The billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POSYPAY</para>
            /// </summary>
            [NameInMap("chargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The commodity code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>opensearch_ha3post_public_cn</para>
            /// </summary>
            [NameInMap("commodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-06-17T02:01:26Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The edition of the instance. Valid values: - vector: Vector Search Edition - engine: Recall Engine Edition</para>
            /// 
            /// <b>Example:</b>
            /// <para>vector</para>
            /// </summary>
            [NameInMap("edition")]
            [Validation(Required=false)]
            public string Edition { get; set; }

            /// <summary>
            /// <para>The expiration time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>024-05-21 16:49:31.0</para>
            /// </summary>
            [NameInMap("expiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the payment for the instance is overdue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("inDebt")]
            [Validation(Required=false)]
            public bool? InDebt { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ha-cn-pl32rf0****</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The lock status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Unlock</para>
            /// </summary>
            [NameInMap("lockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            /// <summary>
            /// <para>The network information of the search engine instance.</para>
            /// </summary>
            [NameInMap("network")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyResultNetwork Network { get; set; }
            public class GetInstanceResponseBodyResultNetwork : TeaModel {
                /// <summary>
                /// <para>The whitelist for the public domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>127.0.0.1</para>
                /// </summary>
                [NameInMap("allow")]
                [Validation(Required=false)]
                public string Allow { get; set; }

                /// <summary>
                /// <para>The gateway endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ha-cn-35t3r****.ha.aliyuncs.com</para>
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The public domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ha-cn-35t3ni****.public.ha.aliyuncs.com</para>
                /// </summary>
                [NameInMap("publicEndpoint")]
                [Validation(Required=false)]
                public string PublicEndpoint { get; set; }

                /// <summary>
                /// <para>The ID of the virtual switch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp11ldcf59q2n****</para>
                /// </summary>
                [NameInMap("vSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The ID of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-wz9axk41d9vff****</para>
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the new version of the console is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("newMode")]
            [Validation(Required=false)]
            public bool? NewMode { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance is a standalone instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("noQrs")]
            [Validation(Required=false)]
            public bool? NoQrs { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzjvw24****</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The node specifications.</para>
            /// </summary>
            [NameInMap("spec")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyResultSpec Spec { get; set; }
            public class GetInstanceResponseBodyResultSpec : TeaModel {
                /// <summary>
                /// <para>The specifications of the query node.</para>
                /// </summary>
                [NameInMap("qrsResource")]
                [Validation(Required=false)]
                public GetInstanceResponseBodyResultSpecQrsResource QrsResource { get; set; }
                public class GetInstanceResponseBodyResultSpecQrsResource : TeaModel {
                    /// <summary>
                    /// <para>The type of the instance. The value local_ssd indicates the local SSD type, and the value cloud indicates the disk type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>local_ssd</para>
                    /// </summary>
                    [NameInMap("category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <para>The number of CPU cores.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    /// <summary>
                    /// <para>The storage space of the node in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("disk")]
                    [Validation(Required=false)]
                    public int? Disk { get; set; }

                    /// <summary>
                    /// <para>The memory size in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("mem")]
                    [Validation(Required=false)]
                    public int? Mem { get; set; }

                    /// <summary>
                    /// <para>The number of nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("nodeCount")]
                    [Validation(Required=false)]
                    public int? NodeCount { get; set; }

                }

                /// <summary>
                /// <para>The specifications of the data node.</para>
                /// </summary>
                [NameInMap("searchResource")]
                [Validation(Required=false)]
                public GetInstanceResponseBodyResultSpecSearchResource SearchResource { get; set; }
                public class GetInstanceResponseBodyResultSpecSearchResource : TeaModel {
                    /// <summary>
                    /// <para>The machine type. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>local_ssd</para>
                    /// </summary>
                    [NameInMap("category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <para>The number of CPU cores.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    /// <summary>
                    /// <para>The storage space of the node in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("disk")]
                    [Validation(Required=false)]
                    public int? Disk { get; set; }

                    /// <summary>
                    /// <para>The memory size in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("mem")]
                    [Validation(Required=false)]
                    public int? Mem { get; set; }

                    /// <summary>
                    /// <para>The number of nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("nodeCount")]
                    [Validation(Required=false)]
                    public int? NodeCount { get; set; }

                }

            }

            /// <summary>
            /// <para>The status of the instance.</para>
            /// <list type="bullet">
            /// <item><description><para>INIT: The instance is being initialized.</para>
            /// </description></item>
            /// <item><description><para>WAIT_CONFIG: The instance is pending configuration.</para>
            /// </description></item>
            /// <item><description><para>CONFIG_UPDATING: The configuration is being applied.</para>
            /// </description></item>
            /// <item><description><para>READY: The instance is running.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INIT</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyResultTags> Tags { get; set; }
            public class GetInstanceResponseBodyResultTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>opensearch</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>opensearch</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The time when the instance was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>024-05-21 16:49:31.0</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>The engine version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ha3_3.10.0</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The number of zones.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("zoneCount")]
            [Validation(Required=false)]
            public int? ZoneCount { get; set; }

        }

    }

}
