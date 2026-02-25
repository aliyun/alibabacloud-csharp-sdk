// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class WebWAFConfig : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable Web Application Firewall (WAF). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables WAF.</description></item>
        /// <item><description><b>false</b>: disables WAF.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableWAF")]
        [Validation(Required=false)]
        public bool? EnableWAF { get; set; }

    }

}
