// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeUserVipsByDomainRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to query the virtual IP addresses of only healthy CDN POPs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: healthy CDN edge nodes.</description></item>
        /// <item><description><b>off</b>: all CDN edge nodes.</description></item>
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
