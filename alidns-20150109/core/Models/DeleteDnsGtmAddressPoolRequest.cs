// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DeleteDnsGtmAddressPoolRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the address pool. To obtain the ID, call <a href="https://www.alibabacloud.com/help/en/dns/latest/api-alidns-2015-01-09-describednsgtminstanceaddresspools">DescribeDnsGtmInstanceAddressPools</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testp******</para>
        /// </summary>
        [NameInMap("AddrPoolId")]
        [Validation(Required=false)]
        public string AddrPoolId { get; set; }

        /// <summary>
        /// <para>The language for some returned parameters. Default: en. Valid values: en, zh, and ja.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
