// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The list of EIP addresses used to filter instances.</para>
        /// </summary>
        [NameInMap("EipAddresses")]
        [Validation(Required=false)]
        public List<string> EipAddresses { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-cmcc</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The list of edge zone IDs. This parameter is a formatted JSON array that contains up to 100 IDs separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cn-suzhou-telecom&quot;,&quot;cn-chengdu-telecom&quot;]</para>
        /// </summary>
        [NameInMap("EnsRegionIds")]
        [Validation(Required=false)]
        public string EnsRegionIds { get; set; }

        /// <summary>
        /// <para>The Edge Node Service ID. You can use this ID to query the instances created under the edge service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ens-20190730202316s****</para>
        /// </summary>
        [NameInMap("EnsServiceId")]
        [Validation(Required=false)]
        public string EnsServiceId { get; set; }

        /// <summary>
        /// <para>The image ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>centos_6_08_64_20G_alibase_****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-5iqczfxps7csjrxeca****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The list of instance IDs. This parameter is a formatted JSON array that contains up to 100 IDs separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;i-5iqczfxps7csjrxeca07****&quot;, &quot;i-5iqczfxps7csjrxeca07****&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestName</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The filter type. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>EnsService</para>
        /// </summary>
        [NameInMap("InstanceResourceType")]
        [Validation(Required=false)]
        public string InstanceResourceType { get; set; }

        /// <summary>
        /// <para>The instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ens.se1.tiny</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The internal IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.100.XX.XX</para>
        /// </summary>
        [NameInMap("IntranetIp")]
        [Validation(Required=false)]
        public string IntranetIp { get; set; }

        /// <summary>
        /// <para>The network ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>n-2zeuphj08tt7q3brd****</para>
        /// </summary>
        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public string NetworkId { get; set; }

        /// <summary>
        /// <para>The sorting parameter in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;InstanceNameSort&quot;: &quot;asc&quot;,
        ///     &quot;ExpireTimeSort&quot;: &quot;asc&quot;,
        ///     &quot;CreationTimeSort&quot;: &quot;desc&quot;,
        ///     &quot;EnsRegionId&quot;: &quot;desc&quot;
        /// }</para>
        /// </summary>
        [NameInMap("OrderByParams")]
        [Validation(Required=false)]
        public string OrderByParams { get; set; }

        /// <summary>
        /// <para>The page number of the instance status list. The value starts from <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query. Maximum value: <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The search keyword. Supports parameters such as <b>ip</b>, <b>InstanceName</b>, and <b>InstanceId</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Joshua</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// <para>The security group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-5kyicq2kfcapxrdds6tar7jqb</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The business status of the instance, which does not represent the actual running status of the instance.</para>
        /// </summary>
        [NameInMap("ServiceStatus")]
        [Validation(Required=false)]
        public List<string> ServiceStatus { get; set; }

        /// <summary>
        /// <para>The instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Running: Running.</description></item>
        /// <item><description>Stopped: Stopped.</description></item>
        /// <item><description>Expired: Expired.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The resource tags. This operation does not return tag information. Use this parameter in combination with the APIs in the tag category.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeInstancesRequestTags> Tags { get; set; }
        public class DescribeInstancesRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the instance. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the instance. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2zeh0r1pabwtg6wcs****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The VPD network ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpd-5s7xxxxxxx</para>
        /// </summary>
        [NameInMap("VpdId")]
        [Validation(Required=false)]
        public string VpdId { get; set; }

        /// <summary>
        /// <para>The VPD vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-5s7xxxxxxx</para>
        /// </summary>
        [NameInMap("VpdVSwitchId")]
        [Validation(Required=false)]
        public string VpdVSwitchId { get; set; }

    }

}
