// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class RepeatNotifySetting : TeaModel {
        /// <summary>
        /// <para>The state that ends the management event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;Resolved&quot;</para>
        /// </summary>
        [NameInMap("endIncidentState")]
        [Validation(Required=false)]
        public string EndIncidentState { get; set; }

        /// <summary>
        /// <para>The interval between repeated notifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("repeatInterval")]
        [Validation(Required=false)]
        public string RepeatInterval { get; set; }

    }

}
