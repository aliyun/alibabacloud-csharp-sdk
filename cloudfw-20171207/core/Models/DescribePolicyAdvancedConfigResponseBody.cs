// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePolicyAdvancedConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of elastic IP addresses (EIPs) that take effect when strict mode is enabled. A maximum of 100 IP addresses can be returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;47.100.XX.XX&quot;,&quot;47.101.XX.XX&quot;]</para>
        /// </summary>
        [NameInMap("Eips")]
        [Validation(Required=false)]
        public List<string> Eips { get; set; }

        /// <summary>
        /// <para>The enabling status of the strict mode for access control policies. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: The strict mode is enabled.</description></item>
        /// <item><description><b>off</b>: The strict mode is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("InternetSwitch")]
        [Validation(Required=false)]
        public string InternetSwitch { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>850A84D6-0DE4-4797-A1E8-00090125EEB1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
