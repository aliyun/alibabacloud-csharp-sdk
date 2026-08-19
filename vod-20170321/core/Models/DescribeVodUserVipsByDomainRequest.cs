// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodUserVipsByDomainRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to query healthy VIPs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: Healthy VIPs.</description></item>
        /// <item><description><b>off</b>: All VIPs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Available")]
        [Validation(Required=false)]
        public string Available { get; set; }

        /// <summary>
        /// <para>The accelerated domain name for ApsaraVideo VOD. Only a single domain name can be queried.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

    }

}
