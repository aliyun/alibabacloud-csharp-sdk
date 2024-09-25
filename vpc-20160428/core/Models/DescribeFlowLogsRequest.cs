// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeFlowLogsRequest : TeaModel {
        /// <summary>
        /// <para>The description of the flow log.</para>
        /// <para>The description must be 1 to 256 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is my Flowlog.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the flow log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fl-bp1f6qqhsrc2c12ta****</para>
        /// </summary>
        [NameInMap("FlowLogId")]
        [Validation(Required=false)]
        public string FlowLogId { get; set; }

        /// <summary>
        /// <para>The name of the flow log.</para>
        /// <para>The name must be 1 to 128 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myFlowlog</para>
        /// </summary>
        [NameInMap("FlowLogName")]
        [Validation(Required=false)]
        public string FlowLogName { get; set; }

        /// <summary>
        /// <para>The Logstore that stores the captured traffic data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FlowLogStore</para>
        /// </summary>
        [NameInMap("LogStoreName")]
        [Validation(Required=false)]
        public string LogStoreName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: <b>50</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The project that manages the captured traffic data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FlowLogProject</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The region ID of the flow log.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the flow log belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the resource from which traffic is captured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-askldfas****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The type of resource from which traffic is captured. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NetworkInterface</b>: elastic network interface (ENI)</description></item>
        /// <item><description><b>VSwitch</b>: all ENIs in a vSwitch</description></item>
        /// <item><description><b>VPC</b>: all ENIs in a virtual private cloud (VPC)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NetworkInterface</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The status of the flow log. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Active</b></description></item>
        /// <item><description><b>Activating</b></description></item>
        /// <item><description><b>Inactive</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeFlowLogsRequestTags> Tags { get; set; }
        public class DescribeFlowLogsRequestTags : TeaModel {
            /// <summary>
            /// <para>The key of tag N to add to the resource. You can specify at most 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be at most 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N to add to the resource. You can specify at most 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. The tag value cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The type of traffic that is captured. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>All</b>: all traffic</description></item>
        /// <item><description><b>Allow</b>: traffic that is allowed by access control</description></item>
        /// <item><description><b>Drop</b>: traffic that is denied by access control</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("TrafficType")]
        [Validation(Required=false)]
        public string TrafficType { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the flow log belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1nwd16gvo1wgs****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
