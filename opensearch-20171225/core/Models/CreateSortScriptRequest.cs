// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateSortScriptRequest : TeaModel {
        /// <summary>
        /// The sort phase to which the script applies.
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// The script name.
        /// </summary>
        [NameInMap("scriptName")]
        [Validation(Required=false)]
        public string ScriptName { get; set; }

        /// <summary>
        /// The script type. Set the value to cava_script.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
