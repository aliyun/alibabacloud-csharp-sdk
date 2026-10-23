// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeManagedInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the activation code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4ECEEE12-56F1-4FBC-9AB1-890F7494****</para>
        /// </summary>
        [NameInMap("ActivationId")]
        [Validation(Required=false)]
        public string ActivationId { get; set; }

        /// <summary>
        /// <para>Specifies whether the managed instance is connected. Valid values:</para>
        /// <para>true: The managed instance is connected. You can use Cloud Assistant to manage the managed instance.</para>
        /// <para>false: The managed instance is not connected. The server may be stopped or the Cloud Assistant Agent is not properly installed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Connected")]
        [Validation(Required=false)]
        public string Connected { get; set; }

        /// <summary>
        /// <para>The ID of the managed instance. Valid values of N: 1 to 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mi-hz018jrc1o0****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// <para>The internal IP address or public IP address of the managed instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para><c>192.168.**.**</c></para>
        /// </summary>
        [NameInMap("InstanceIp")]
        [Validation(Required=false)]
        public string InstanceIp { get; set; }

        /// <summary>
        /// <para>The name of the managed instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-webapp-server</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The value of the MachineId parameter specified when the managed instance was registered. The value can be up to 36 characters in length.
        /// Sample registration script:</para>
        /// <pre><c>aliyun-service --register \\
        ///   --RegionId=cn-hangznou \\
        ///   --ActivationId=xxxxxxxxxxx \\
        ///   --ActivationCode=xxxxxxxxx \\
        ///   --MachineId=xxxxxx \\ # Optional parameter. The unique identifier of the machine.
        ///   --ForceResue                 
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>If the MachineId and ForceResult parameters are specified during registration, Cloud Assistant generates a fixed managed instance ID for the MachineId.</description></item>
        /// <item><description>If the MachineId parameter is not explicitly specified, Cloud Assistant automatically generates a MachineId value based on the hardware information of the machine.</description></item>
        /// <item><description>Recommended: Explicitly specify the MachineId and ForceResult parameters to mark the mapping between the managed instance and the on-premises machine.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GOG4X8312A0188</para>
        /// </summary>
        [NameInMap("MachineId")]
        [Validation(Required=false)]
        public string MachineId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return per page during paging.</para>
        /// <para>Maximum value: 50.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Set the value to the NextToken value returned from the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The operating system type of the managed instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>windows</description></item>
        /// <item><description>linux</description></item>
        /// <item><description>FreeBSD</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>windows</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter will be deprecated soon. We recommend that you use NextToken and MaxResults to perform a paged query.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter will be deprecated soon. We recommend that you use NextToken and MaxResults to perform a paged query.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID. Supported regions: China (Qingdao), China (Beijing), China (Zhangjiakou), China (Hohhot), China (Ulanqab), China (Hangzhou), China (Shanghai), China (Shenzhen), China (Heyuan), China (Guangzhou), China (Chengdu), Hong Kong (China), Singapore, Japan (Tokyo), US (Silicon Valley), and US (Virginia).</para>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query region IDs and other information.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the managed instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-123******</para>
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
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeManagedInstancesRequestTag> Tag { get; set; }
        public class DescribeManagedInstancesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the managed instance. Valid values of N: 1 to 20. The tag key cannot be an empty string.</para>
            /// <para>If you use a single tag to filter resources, the resource count for that tag cannot exceed 1,000. If you use multiple tags to filter resources, the resource count for resources attached to multiple tags cannot exceed 1,000. If the resource count exceeds 1,000, you must call the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation to query the resources.</para>
            /// <para>The tag key can be up to 64 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the managed instance. Valid values of N: 1 to 20. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
