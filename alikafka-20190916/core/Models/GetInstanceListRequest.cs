// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetInstanceListRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka_post-cn-mp91gnw0p***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the order. You can obtain the order ID on the <a href="https://usercenter2-intl.aliyun.com/order/list?pageIndex=1%5C&pageSize=20%5C&spm=5176.12818093.top-nav.ditem-ord.36f016d0OQFmJa">Orders</a> page in Alibaba Cloud User Center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6072673****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. You can obtain this ID on the Resource Group page in the Resource Management console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ac***********7q</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The instance version. You can use instance versions to filter different versions of instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>v2</description></item>
        /// <item><description>v3</description></item>
        /// <item><description>confluent</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>v3</para>
        /// </summary>
        [NameInMap("Series")]
        [Validation(Required=false)]
        public string Series { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<GetInstanceListRequestTag> Tag { get; set; }
        public class GetInstanceListRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <list type="bullet">
            /// <item><description>If you leave this parameter empty, the keys of all tags are matched.</description></item>
            /// <item><description>The tag key can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain <c>http://</c> or <c>https://</c>.</description></item>
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
            /// <item><description>If you leave Key empty, you must also leave this parameter empty. If you leave this parameter empty, the values of all tags are matched.</description></item>
            /// <item><description>The tag value can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain <c>http://</c> or <c>https://</c>.</description></item>
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
