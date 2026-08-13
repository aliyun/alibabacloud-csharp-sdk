// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeControlPolicyDomainResolveRequest : TeaModel {
        /// <summary>
        /// <para>The domain name. This parameter is required and must be specified when you call this operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The type of the cloud firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internet</para>
        /// </summary>
        [NameInMap("FirewallType")]
        [Validation(Required=false)]
        public string FirewallType { get; set; }

        /// <summary>
        /// <para>The IP address version. Valid values: <b>4</b> (IPv4) and <b>6</b> (IPv6).</para>
        /// <remarks>
        /// <para>This parameter is unconditionally required and has no dependency on RegionNo. If this parameter is not specified, the error MissingParameter.IpVersion is returned (-200157). If the value is invalid, the error ErrorParameterIpVersion is returned (-200135).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public int? IpVersion { get; set; }

        /// <summary>
        /// <para>The language type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The region ID. This parameter is required. If this parameter is not specified, the error MissingParameter.RegionNo is returned (-200155, The required parameter \&quot;RegionNo\&quot; is not provided.).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

    }

}
