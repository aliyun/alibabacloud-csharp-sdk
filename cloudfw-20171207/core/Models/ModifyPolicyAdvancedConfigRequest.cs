// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyPolicyAdvancedConfigRequest : TeaModel {
        /// <summary>
        /// <para>The IP addresses. The versions of the IP addresses must be the same. You can specify a maximum of 100 IP addresses.</para>
        /// </summary>
        [NameInMap("Eips")]
        [Validation(Required=false)]
        public List<string> Eips { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the strict mode for the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enables the strict mode.</description></item>
        /// <item><description><b>off</b>: disables the strict mode.</description></item>
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
        /// <para>The natural language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese (default)</description></item>
        /// <item><description><b>en</b>: English</description></item>
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
        /// <para>The source IP address of the request.</para>
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
