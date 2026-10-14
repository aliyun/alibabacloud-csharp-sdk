// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListRegionsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to filter regions by assets that have audit enabled. A value of true indicates that audit is enabled. A value of false indicates that audit is not enabled. If you do not specify this parameter, this filter condition is not applied.</para>
        /// </summary>
        [NameInMap("Audited")]
        [Validation(Required=false)]
        public bool? Audited { get; set; }

        /// <summary>
        /// <para>Specifies whether to filter regions by assets that have detection enabled. A value of true indicates that detection is enabled. A value of false indicates that detection is not enabled. If you do not specify this parameter, this filter condition is not applied.</para>
        /// </summary>
        [NameInMap("Identified")]
        [Validation(Required=false)]
        public bool? Identified { get; set; }

        /// <summary>
        /// <para>The language of the response description. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese.</description></item>
        /// <item><description>en: English.</description></item>
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
