// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeTairKVCacheInferInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The billing method of the simple application servers. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PrePaid</b>: subscription</description></item>
        /// <item><description><b>PostPaid</b>: pay-as-you-go</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance has expired. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The instance has expired.</description></item>
        /// <item><description><b>false</b>: The instance has not expired.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Expired")]
        [Validation(Required=false)]
        public string Expired { get; set; }

        /// <summary>
        /// <para>The instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kvcache.cu.g4c.2</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>The IDs of the instances that you want to query.</para>
        /// <remarks>
        /// <para> If you want to specify multiple instance IDs, separate the instance IDs with commas (,). You can specify a maximum of 30 instance IDs in a single request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>tk-2zefe7728c2c****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The state of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: The instance is normal.</description></item>
        /// <item><description><b>Creating</b>: The instance is being created.</description></item>
        /// </list>
        /// <remarks>
        /// <para> For more information about instance states, see <a href="https://help.aliyun.com/document_detail/200740.html">Instance states and impacts</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// <para>The network type of the instance. Default value: VPC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b> (default)</description></item>
        /// </list>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CLASSIC</description></item>
        /// <item><description>VPC</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number of the instance list. Start value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// <para>The ID of the region where the instance resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID. You can leave this parameter empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmyiu4ekp****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The keyword that you want to use for fuzzy match. The keyword can be a part of an instance name or an instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apitest</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>Details of the tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeTairKVCacheInferInstancesRequestTag> Tag { get; set; }
        public class DescribeTairKVCacheInferInstancesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <remarks>
            /// <para> A maximum of five key-value pairs can be specified at a time.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>key1_test</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N of the instance.</para>
            /// <remarks>
            /// <para> <b>N</b> specifies the value of the nth tag. For example, <b>Tag.1.Value</b> specifies the value of the first tag, and <b>Tag.2.Value</b> specifies the value of the second tag.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>testvalue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1e7clcw529l773d****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1nme44gek34slfc****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-e</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
