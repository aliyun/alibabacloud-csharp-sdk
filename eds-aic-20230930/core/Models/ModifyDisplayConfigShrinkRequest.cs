// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ModifyDisplayConfigShrinkRequest : TeaModel {
        /// <summary>
        /// <para>A list of instance IDs.</para>
        /// </summary>
        [NameInMap("AndroidInstanceIds")]
        [Validation(Required=false)]
        public List<string> AndroidInstanceIds { get; set; }

        /// <summary>
        /// <para>The display settings.</para>
        /// </summary>
        [NameInMap("DisplayConfig")]
        [Validation(Required=false)]
        public string DisplayConfigShrink { get; set; }

    }

}
