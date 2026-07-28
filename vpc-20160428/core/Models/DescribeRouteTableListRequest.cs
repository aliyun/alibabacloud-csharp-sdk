// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeRouteTableListRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paging query. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the VPC to which the route table belongs.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-southeast-6</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the route table belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph****</para>
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
        /// <para>The ID of the route table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-bp145q7glnuzdvzu2****</para>
        /// </summary>
        [NameInMap("RouteTableId")]
        [Validation(Required=false)]
        public string RouteTableId { get; set; }

        /// <summary>
        /// <para>The name of the route table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>doctest</para>
        /// </summary>
        [NameInMap("RouteTableName")]
        [Validation(Required=false)]
        public string RouteTableName { get; set; }

        /// <summary>
        /// <para>The type of the route table. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>System</b>: system route table.</para>
        /// </description></item>
        /// <item><description><para><b>Custom</b>: custom route table.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>System</para>
        /// </summary>
        [NameInMap("RouteTableType")]
        [Validation(Required=false)]
        public string RouteTableType { get; set; }

        /// <summary>
        /// <para>The ID of the router to which the route table belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vrt-bp1lhl0taikrteen8****</para>
        /// </summary>
        [NameInMap("RouterId")]
        [Validation(Required=false)]
        public string RouterId { get; set; }

        /// <summary>
        /// <para>The type of the router to which the route table belongs. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para><b>VRouter</b> (default): vRouter.</para>
        /// </description></item>
        /// <item><description><para><b>VBR</b>: Virtual Border Router.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VRouter</para>
        /// </summary>
        [NameInMap("RouterType")]
        [Validation(Required=false)]
        public string RouterType { get; set; }

        /// <summary>
        /// <para>The tags of the resource.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeRouteTableListRequestTag> Tag { get; set; }
        public class DescribeRouteTableListRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>A tag key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the VPC to which the route table belongs.</para>
        /// <para>If you specify this parameter, the value of <b>RouterType</b> is automatically set to <b>VRouter</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp15zckdt37pq72****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
