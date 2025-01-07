// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateImageEventOperationRequest : TeaModel {
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public string Conditions { get; set; }

        /// <summary>
        /// <para>The ID of the alert handling rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>814163</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        /// <summary>
        /// <para>The application scope of the rule. The value is in the JSON format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>type</b></description></item>
        /// <item><description><b>value</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;type\&quot;: \&quot;repo\&quot;, \&quot;value\&quot;: \&quot;test-aaa/shenzhen-repo-01\&quot;}</para>
        /// </summary>
        [NameInMap("Scenarios")]
        [Validation(Required=false)]
        public string Scenarios { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
