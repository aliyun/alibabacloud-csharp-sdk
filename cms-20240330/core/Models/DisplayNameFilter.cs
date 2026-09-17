// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DisplayNameFilter : TeaModel {
        /// <summary>
        /// <para>The inclusion keyword for the display name. Only alert rules whose display names contain this keyword are returned. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CPU monitoring</para>
        /// </summary>
        [NameInMap("contains")]
        [Validation(Required=false)]
        public string Contains { get; set; }

        /// <summary>
        /// <para>The exclusion keyword for the display name. Alert rules whose display names contain this keyword are excluded. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ARM</para>
        /// </summary>
        [NameInMap("notContains")]
        [Validation(Required=false)]
        public string NotContains { get; set; }

    }

}
