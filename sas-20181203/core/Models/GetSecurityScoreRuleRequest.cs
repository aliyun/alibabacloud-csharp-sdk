// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetSecurityScoreRuleRequest : TeaModel {
        /// <summary>
        /// <para>The old or new version of the security score rule. If you set this parameter to <b>home_security_score</b>, the new version of the security score rule is returned. Otherwise, the old version of the security score rule is returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>home_security_score</para>
        /// </summary>
        [NameInMap("CalType")]
        [Validation(Required=false)]
        public string CalType { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
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
