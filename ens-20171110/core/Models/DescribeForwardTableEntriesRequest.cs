// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeForwardTableEntriesRequest : TeaModel {
        /// <summary>
        /// <para>The EIP in the DNAT entry. The public IP address is used to access the Internet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36.XXX.XXX.72</para>
        /// </summary>
        [NameInMap("ExternalIp")]
        [Validation(Required=false)]
        public string ExternalIp { get; set; }

        /// <summary>
        /// <para>The ID of the DNAT entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fwd-5tfi6f0rutmd00xrhkag7****</para>
        /// </summary>
        [NameInMap("ForwardEntryId")]
        [Validation(Required=false)]
        public string ForwardEntryId { get; set; }

        /// <summary>
        /// <para>The name of the DNAT entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test0</para>
        /// </summary>
        [NameInMap("ForwardEntryName")]
        [Validation(Required=false)]
        public string ForwardEntryName { get; set; }

        /// <summary>
        /// <para>The private IP address of the instance that uses the DNAT entry for Internet communication.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.XXX.XXX.50</para>
        /// </summary>
        [NameInMap("InternalIp")]
        [Validation(Required=false)]
        public string InternalIp { get; set; }

        /// <summary>
        /// <para>The protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>TCP</b>: forwards TCP packets.</description></item>
        /// <item><description><b>UDP</b>: forwards UDP packets.</description></item>
        /// <item><description><b>Any</b>: forwards all packets.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// <para>The ID of the NAT gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nat-5t7nh1cfm6kxiszlttr38****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

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
        /// <para>The number of entries per page. Maximum value: <b>100</b>.</para>
        /// <para>Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
