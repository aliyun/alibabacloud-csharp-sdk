// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeHaVipsRequest : TeaModel {
        /// <summary>
        /// <para>The details of the filter conditions.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeHaVipsRequestFilter> Filter { get; set; }
        public class DescribeHaVipsRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter condition. You can specify up to 5 filter conditions. Valid values of <b>N</b>: <b>1</b> to <b>5</b>.
            /// Supported filter conditions:</para>
            /// <list type="bullet">
            /// <item><description><para><b>VpcId</b>: The ID of the virtual private cloud (VPC). </para>
            /// </description></item>
            /// <item><description><para><b>VSwitchId</b>: The vSwitch ID. </para>
            /// </description></item>
            /// <item><description><para><b>Status</b>: The status of the HaVip. </para>
            /// </description></item>
            /// <item><description><para><b>HaVipId</b>: The HaVip ID. </para>
            /// </description></item>
            /// <item><description><para><b>HaVipAddress</b>: The IP address of the HaVip.</para>
            /// </description></item>
            /// </list>
            /// <para>You can specify multiple values for each filter condition. The values are evaluated by using the OR operator. A resource is considered to match the filter condition of the parameter if it matches at least one of the values.</para>
            /// <para>Multiple filter conditions are evaluated by using the AND operator. A resource is returned only if it matches the filter conditions of all parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HaVipId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the specified filter condition. Valid values of <b>N</b>: <b>1</b> to <b>5</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>havip-bp19o63nequs01i8d****</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

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
        /// <para>The region ID of the HaVip.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to obtain the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the HaVip belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4ph****</para>
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
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeHaVipsRequestTags> Tags { get; set; }
        public class DescribeHaVipsRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys. If you specify this parameter, you cannot enter an empty string.</para>
            /// <para>A tag key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values. If you specify this parameter, you can enter an empty string.</para>
            /// <para>A tag value can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
