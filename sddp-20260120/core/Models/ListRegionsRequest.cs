// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListRegionsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to filter regions by assets with auditing enabled. Valid values: true: Enabled. false: Disabled. If you do not specify this parameter, this filter condition is not applied.</para>
        /// </summary>
        [NameInMap("Audited")]
        [Validation(Required=false)]
        public bool? Audited { get; set; }

        /// <summary>
        /// <para>Specifies whether to filter regions by assets with detection enabled. Valid values: true: Enabled. false: Disabled. If you do not specify this parameter, this filter condition is not applied.</para>
        /// </summary>
        [NameInMap("Identified")]
        [Validation(Required=false)]
        public bool? Identified { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values: zh: Chinese. en: English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Specifies whether to retrieve all regions.</para>
        /// </summary>
        [NameInMap("LoadAll")]
        [Validation(Required=false)]
        public bool? LoadAll { get; set; }

    }

}
