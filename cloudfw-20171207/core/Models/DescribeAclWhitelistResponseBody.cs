// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAclWhitelistResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the whitelist is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Not enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DomainGroupUseDns")]
        [Validation(Required=false)]
        public bool? DomainGroupUseDns { get; set; }

        /// <summary>
        /// <para>Indicates whether domain name DNS is supported in NAT scenarios. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Supported.</description></item>
        /// <item><description><b>false</b>: Not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NatDomainGroupUseDns")]
        [Validation(Required=false)]
        public bool? NatDomainGroupUseDns { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7D45133B-DBC0-506B-9DF9-AB0735D3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the message type is supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Supported.</description></item>
        /// <item><description><b>false</b>: Not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SupportMessageType")]
        [Validation(Required=false)]
        public bool? SupportMessageType { get; set; }

        /// <summary>
        /// <para>Indicates whether domain name DNS is supported in VPC scenarios. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Supported.</description></item>
        /// <item><description><b>false</b>: Not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("VpcDomainGroupUseDns")]
        [Validation(Required=false)]
        public bool? VpcDomainGroupUseDns { get; set; }

    }

}
