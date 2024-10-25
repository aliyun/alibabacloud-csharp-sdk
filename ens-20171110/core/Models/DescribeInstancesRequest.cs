// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeInstancesRequest : TeaModel {
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
        /// <para>The IDs of the regions. The value is a JSON array that consists of up to 100 IDs. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cn-suzhou-telecom&quot;,&quot;cn-chengdu-telecom&quot;]</para>
        /// </summary>
        [NameInMap("EnsRegionIds")]
        [Validation(Required=false)]
        public string EnsRegionIds { get; set; }

        /// <summary>
        /// <para>The ID of the edge service. You can use the ID to query information about the instances that are created in the edge service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ens-20190730202316s****</para>
        /// </summary>
        [NameInMap("EnsServiceId")]
        [Validation(Required=false)]
        public string EnsServiceId { get; set; }

        /// <summary>
        /// <para>The ID of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>centos_6_08_64_20G_alibase_****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-5iqczfxps7csjrxeca****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The IDs of the instances. The value is a JSON array that consists of up to 100 IDs. Separate IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;i-5iqczfxps7csjrxeca07****&quot;, &quot;i-5iqczfxps7csjrxeca07****&quot;]]</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestName</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The condition that you want to use to filter instances by category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EnsInstance: ENS instances that you purchase.</description></item>
        /// <item><description>EnsService: ENS instances that belong to edge services.</description></item>
        /// <item><description>BuildMachine: ENS instances that are configured with image builders.</description></item>
        /// <item><description>EnsPostPaidInstance: Pay-as-you-go ENS instances that you purchase.</description></item>
        /// </list>
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
        /// <para>The internal IP address of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.100.XX.XX</para>
        /// </summary>
        [NameInMap("IntranetIp")]
        [Validation(Required=false)]
        public string IntranetIp { get; set; }

        /// <summary>
        /// <para>The ID of the network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>n-2zeuphj08tt7q3brd****</para>
        /// </summary>
        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public string NetworkId { get; set; }

        /// <summary>
        /// <para>The method that you want to use to sort instances. The value of this parameter is in the JSON format.</para>
        /// <para>You can sort instances by name, expiration time, node ID, or creation time. You can specify one or more methods.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;InstanceNameSort&quot;:&quot;asc&quot;,&quot;ExpireTimeSort&quot;:&quot;asc&quot;,&quot;CreationTimeSort&quot;:&quot;desc&quot;}}</para>
        /// </summary>
        [NameInMap("OrderByParams")]
        [Validation(Required=false)]
        public string OrderByParams { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page <b>1</b>.</para>
        /// <para>Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. The maximum value is <b>100</b>.</para>
        /// <para>Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The keyword that you use to query the logs of the service. You can specify the values of parameters such as <b>ip</b>, <b>InstanceName</b>, and <b>InstanceId</b> as the keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Joshua</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// <para>The ID of the security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-5kyicq2kfcapxrdds6tar7jqb</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The status of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Running</description></item>
        /// <item><description>Stopped</description></item>
        /// <item><description>Expired</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags that are added to the resource. This operation does not return tag information. You can call this operation in combination with the tag-related operations.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeInstancesRequestTags> Tags { get; set; }
        public class DescribeInstancesRequestTags : TeaModel {
            /// <summary>
            /// <para>The key of the tag that are to add to the instance. Valid values: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the instance. Valid values: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2zeh0r1pabwtg6wcs****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
