// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSnatTableEntriesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Network Address Translation (NAT) gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nat-5tawjw5j7sgd2deujxuk0****</para>
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
        /// <para>The number of entries per page. The maximum value is <b>100</b>.</para>
        /// <para>Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the SNAT entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>snat-5tfjp36fsrb36zs36faj0****</para>
        /// </summary>
        [NameInMap("SnatEntryId")]
        [Validation(Required=false)]
        public string SnatEntryId { get; set; }

        /// <summary>
        /// <para>The name of the SNAT entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test0</para>
        /// </summary>
        [NameInMap("SnatEntryName")]
        [Validation(Required=false)]
        public string SnatEntryName { get; set; }

        /// <summary>
        /// <para>The elastic IP address (EIP) specified in the SNAT entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58.XXXX.XXX.29</para>
        /// </summary>
        [NameInMap("SnatIp")]
        [Validation(Required=false)]
        public string SnatIp { get; set; }

        /// <summary>
        /// <para>The information about the EIP specified in the SNAT entry.</para>
        /// </summary>
        [NameInMap("SnatIps")]
        [Validation(Required=false)]
        public List<string> SnatIps { get; set; }

        /// <summary>
        /// <para>The source CIDR block specified in the SNAT entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.1.0.50/32</para>
        /// </summary>
        [NameInMap("SourceCIDR")]
        [Validation(Required=false)]
        public string SourceCIDR { get; set; }

    }

}
