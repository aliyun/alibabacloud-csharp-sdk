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
        /// <para>Response parameters</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyResult Result { get; set; }
        public class GetInstanceResponseBodyResult : TeaModel {
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
            /// <para>The commodity code of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>commodityCode</para>
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
            /// <para>ha3_test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The edition of the instance. Valid values: vector and engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vector</para>
            /// </summary>
            [NameInMap("edition")]
            [Validation(Required=false)]
            public string Edition { get; set; }

            /// <summary>
            /// <para>The time when the instance expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1634609702</para>
            /// </summary>
            [NameInMap("expiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>Indicates whether an overdue payment is involved.</para>
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
            /// <para>ha-cn-7mz2qsgq301</para>
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
            /// <para>The network information of the instance.</para>
            /// </summary>
            [NameInMap("network")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyResultNetwork Network { get; set; }
            public class GetInstanceResponseBodyResultNetwork : TeaModel {
                /// <summary>
                /// <para>The public domain name whitelist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>127.0.0.1</para>
                /// </summary>
                [NameInMap("allow")]
                [Validation(Required=false)]
                public string Allow { get; set; }

                /// <summary>
                /// <para>The instance endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ha-cn-35t3r****.ha.aliyuncs.com</para>
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The public endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ha-cn-35t3ni****.public.ha.aliyuncs.com</para>
                /// </summary>
                [NameInMap("publicEndpoint")]
                [Validation(Required=false)]
                public string PublicEndpoint { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp11ldcf59q2n****</para>
                /// </summary>
                [NameInMap("vSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-wz9axk41d9vff****</para>
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether the instance is of the new version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("newMode")]
            [Validation(Required=false)]
            public bool? NewMode { get; set; }

            /// <summary>
            /// <para>Specifies whether the instance has only one node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("noQrs")]
            [Validation(Required=false)]
            public bool? NoQrs { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzjvw24el5lma</para>
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
                /// <para>The QRS worker specifications.</para>
                /// </summary>
                [NameInMap("qrsResource")]
                [Validation(Required=false)]
                public GetInstanceResponseBodyResultSpecQrsResource QrsResource { get; set; }
                public class GetInstanceResponseBodyResultSpecQrsResource : TeaModel {
                    /// <summary>
                    /// <para>The category. Valid values: local_ssd, SSD, and cloud.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>local_ssd</para>
                    /// </summary>
                    [NameInMap("category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <para>The number of vCPUs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    /// <summary>
                    /// <para>The storage capacity. Unit: GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("disk")]
                    [Validation(Required=false)]
                    public int? Disk { get; set; }

                    /// <summary>
                    /// <para>The memory of the instance. Unit: GB.</para>
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
                /// <para>The searcher worker specifications.</para>
                /// </summary>
                [NameInMap("searchResource")]
                [Validation(Required=false)]
                public GetInstanceResponseBodyResultSpecSearchResource SearchResource { get; set; }
                public class GetInstanceResponseBodyResultSpecSearchResource : TeaModel {
                    /// <summary>
                    /// <para>The category. Valid values: local_ssd, SSD, and cloud.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>local_ssd</para>
                    /// </summary>
                    [NameInMap("category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <para>The number of vCPUs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    /// <summary>
                    /// <para>The storage capacity. Unit: GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("disk")]
                    [Validation(Required=false)]
                    public int? Disk { get; set; }

                    /// <summary>
                    /// <para>The memory of the instance. Unit: GB.</para>
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
            /// <para>The status of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>INIT: being initialized</description></item>
            /// <item><description>WAIT_CONFIG: to be configured</description></item>
            /// <item><description>CONFIG_UPDATING: configuration taking effect</description></item>
            /// <item><description>READY: normal</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INIT</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags of the instance.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyResultTags> Tags { get; set; }
            public class GetInstanceResponseBodyResultTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>prod</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The time when the instance was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1634609702</para>
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
            /// <para>The version of the engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ha3_3.10.0</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
