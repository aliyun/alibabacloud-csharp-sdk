// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyConcernNecessityRequest : TeaModel {
        /// <summary>
        /// <para>The priorities to fix the vulnerabilities. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>asap: high</description></item>
        /// <item><description>later: medium</description></item>
        /// <item><description>nntf: low</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asap,nntf</para>
        /// </summary>
        [NameInMap("ConcernNecessity")]
        [Validation(Required=false)]
        public string ConcernNecessity { get; set; }

    }

}
