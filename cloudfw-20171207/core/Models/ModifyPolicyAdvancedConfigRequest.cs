// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyPolicyAdvancedConfigRequest : TeaModel {
        /// <summary>
        /// <para>A list of IP addresses. The IP addresses must use the same protocol version. You can specify up to 100 IP addresses.</para>
        /// </summary>
        [NameInMap("Eips")]
        [Validation(Required=false)]
        public List<string> Eips { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable or disable the strict mode for access control policies. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: Enables strict mode.</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: Disables strict mode.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("InternetSwitch")]
        [Validation(Required=false)]
        public string InternetSwitch { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The source IP address of the visitor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceIp { get; set; }

    }

}
