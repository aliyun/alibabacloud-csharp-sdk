// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class VariablesValue : TeaModel {
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
        /// The variable value.
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// The description of the variable.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The template value of the variable.
        /// </summary>
        [NameInMap("templateValue")]
        [Validation(Required=false)]
        public string TemplateValue { get; set; }

        /// <summary>
        /// The variable type. Valid values:
        /// 
        /// *   NORMAL: common variable
        /// *   FUNCTION: function variable
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The function variables.
        /// </summary>
        [NameInMap("funcValue")]
        [Validation(Required=false)]
        public VariablesValueFuncValue FuncValue { get; set; }
        public class VariablesValueFuncValue : TeaModel {
            /// <summary>
            /// The class name of the function variable.
            /// </summary>
            [NameInMap("funcClassName")]
            [Validation(Required=false)]
            public string FuncClassName { get; set; }

            /// <summary>
            /// The template of the function variable.
            /// </summary>
            [NameInMap("template")]
            [Validation(Required=false)]
            public string Template { get; set; }

        }

    }

}
