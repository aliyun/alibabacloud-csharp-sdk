// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetSecurityScoreRuleRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to query the new or legacy security score rules. If the value is <b>home_security_score</b>, the new security score rules are queried. Otherwise, the legacy security score rules are queried by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>home_security_score</para>
        /// </summary>
        [NameInMap("CalType")]
        [Validation(Required=false)]
        public string CalType { get; set; }

        /// <summary>
        /// <para>The language type for the request and response messages. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
