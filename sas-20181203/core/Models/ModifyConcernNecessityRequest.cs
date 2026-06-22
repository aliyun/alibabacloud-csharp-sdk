// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyConcernNecessityRequest : TeaModel {
        /// <summary>
        /// <para>The list of vulnerability fix necessity levels.</para>
        /// <list type="bullet">
        /// <item><description><para>asap: High</para>
        /// </description></item>
        /// <item><description><para>later: Medium</para>
        /// </description></item>
        /// <item><description><para>nntf: Low</para>
        /// </description></item>
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
