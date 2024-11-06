// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserVipsByDomainRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to query the virtual IP addresses of only healthy POPs. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: queries healthy VIPs.</description></item>
        /// <item><description><b>off</b>: queries all VIPs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Available")]
        [Validation(Required=false)]
        public string Available { get; set; }

        /// <summary>
        /// <para>The accelerated domain name. You can specify only one domain name.</para>
        /// <para>Enumeration values: example.com</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

    }

}
