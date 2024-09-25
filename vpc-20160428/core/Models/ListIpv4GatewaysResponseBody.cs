// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListIpv4GatewaysResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of IPv4 gateways.</para>
        /// </summary>
        [NameInMap("Ipv4GatewayModels")]
        [Validation(Required=false)]
        public List<ListIpv4GatewaysResponseBodyIpv4GatewayModels> Ipv4GatewayModels { get; set; }
        public class ListIpv4GatewaysResponseBodyIpv4GatewayModels : TeaModel {
            /// <summary>
            /// <para>Indicates whether the IPv4 gateway is activated. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The time when the IPv4 gateway was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-02T07:07:35Z</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The description of the IPv4 gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Ipv4GatewayDescription")]
            [Validation(Required=false)]
            public string Ipv4GatewayDescription { get; set; }

            /// <summary>
            /// <para>The ID of the IPv4 gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ipv4gw-5tsnc6s4ogsedtp3k****</para>
            /// </summary>
            [NameInMap("Ipv4GatewayId")]
            [Validation(Required=false)]
            public string Ipv4GatewayId { get; set; }

            /// <summary>
            /// <para>The name of the IPv4 gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("Ipv4GatewayName")]
            [Validation(Required=false)]
            public string Ipv4GatewayName { get; set; }

            /// <summary>
            /// <para>The ID of the route table associated with the IPv4 gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vtb-5ts0ohchwkp3dydt2****</para>
            /// </summary>
            [NameInMap("Ipv4GatewayRouteTableId")]
            [Validation(Required=false)]
            public string Ipv4GatewayRouteTableId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the IPv4 gateway belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-bp67acfmxazb4ph****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The status of the IPv4 gateway. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Creating</b></description></item>
            /// <item><description><b>Created</b></description></item>
            /// <item><description><b>Modifying</b></description></item>
            /// <item><description><b>Deleting</b></description></item>
            /// <item><description><b>Deleted</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of tags that are added to the resource group.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListIpv4GatewaysResponseBodyIpv4GatewayModelsTags> Tags { get; set; }
            public class ListIpv4GatewaysResponseBodyIpv4GatewayModelsTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceJoshua</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the VPC with which the IPv4 gateways are associated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-5tsrxlw7dv074gci4****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The token that is used for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If no value is returned for <b>NextToken</b>, no next queries are sent.</description></item>
        /// <item><description>If a value of <b>NextToken</b> is returned, the value is the token that is used for the subsequent query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D265800-E306-529C-8418-84B0A1D201DB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
