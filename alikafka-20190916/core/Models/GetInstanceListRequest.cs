// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetInstanceListRequest : TeaModel {
        /// <summary>
        /// <para>A list of instance IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka_post-cn-mp91gnw0p***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// <para>The order ID. You can find the order ID on the &lt;props=&quot;china&quot;&gt;<a href="https://usercenter2.aliyun.com/order/list?pageIndex=1%5C&pageSize=20">Orders</a> page in the Billing Management console.
        /// &lt;props=&quot;intl&quot;&gt;<a href="https://usercenter2-intl.aliyun.com/order/list?pageIndex=1%5C&pageSize=20%5C&spm=5176.12818093.top-nav.ditem-ord.36f016d0OQFmJa">Orders</a> page in the Billing Management console.</para>
        /// <remarks>
        /// <para>Notice: You cannot use an order ID to query Serverless instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>6072673****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance is located.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. You can view the resource group ID in the Resource Group console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ac***********7q</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The instance series. You can use this parameter to filter instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>v2</para>
        /// </description></item>
        /// <item><description><para>v3</para>
        /// </description></item>
        /// <item><description><para>confluent</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>v3</para>
        /// </summary>
        [NameInMap("Series")]
        [Validation(Required=false)]
        public string Series { get; set; }

        /// <summary>
        /// <para>A list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<GetInstanceListRequestTag> Tag { get; set; }
        public class GetInstanceListRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <list type="bullet">
            /// <item><description><para>If you do not specify this parameter, all tag keys are matched.</para>
            /// </description></item>
            /// <item><description><para>The tag key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// <list type="bullet">
            /// <item><description><para>If you do not specify the <c>Key</c> parameter, you do not need to specify this parameter. If you leave this parameter empty, all tag values are matched.</para>
            /// </description></item>
            /// <item><description><para>The tag value can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
