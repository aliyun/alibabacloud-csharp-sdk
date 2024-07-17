// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ConfigValueFilesConfigVariablesValue : TeaModel {
        /// <summary>
        /// The description of the variable.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether the variable is not allowed to be modified.
        /// </summary>
        [NameInMap("disableModify")]
        [Validation(Required=false)]
        public bool? DisableModify { get; set; }

        /// <summary>
        /// Specifies whether the variable is modified.
        /// </summary>
        [NameInMap("isModify")]
        [Validation(Required=false)]
        public bool? IsModify { get; set; }

        /// <summary>
        /// The variable type. Valid values: NORMAL: common variable. FUNCTION: function variable.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The variable value.
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
