// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListEnhanhcedNatGatewayAvailableZonesRequest : TeaModel {
        /// <summary>
        /// <para>The language to display the results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh-CN</b> (default): Chinese</description></item>
        /// <item><description><b>en-US</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The filter information. You can specify a filter key and a filter value.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListEnhanhcedNatGatewayAvailableZonesRequestFilter> Filter { get; set; }
        public class ListEnhanhcedNatGatewayAvailableZonesRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter key. Only <b>PrivateLinkEnabled</b> is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PrivateLinkEnabled</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the filter key.</para>
            /// <remarks>
            /// <para> If the filter key is set to <b>PrivateLinkEnabled</b>, you must specify a filter value. Valid values: <b>true</b> and <b>false</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region that you want to query.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>In this example, zones that support NAT gateways in the UAE (Dubai) region are queried.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>me-east-1</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
