// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class PAL7ConfigReplaceRule : TeaModel {
        /// <summary>
        /// <para>The original content to be replaced.</para>
        /// 
        /// <b>Example:</b>
        /// <para>before</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The target content for replacement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>after</para>
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public string To { get; set; }

    }

}
