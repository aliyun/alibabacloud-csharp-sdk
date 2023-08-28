// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class VariablesValue : TeaModel {
        /// <summary>
        /// Specifies whether the variable cannot be modified.
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
        /// The value of the variable.
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// The description about the variable.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The value of the template.
        /// </summary>
        [NameInMap("templateValue")]
        [Validation(Required=false)]
        public string TemplateValue { get; set; }

        /// <summary>
        /// The type of the variable. Valid values:
        /// 
        /// *   NORMAL: a normal variable
        /// *   FUNCTION: a function variable
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The function variable.
        /// </summary>
        [NameInMap("funcValue")]
        [Validation(Required=false)]
        public VariablesValueFuncValue FuncValue { get; set; }
        public class VariablesValueFuncValue : TeaModel {
            /// <summary>
            /// The class name.
            /// </summary>
            [NameInMap("funcClassName")]
            [Validation(Required=false)]
            public string FuncClassName { get; set; }

            /// <summary>
            /// The template of the variable.
            /// </summary>
            [NameInMap("template")]
            [Validation(Required=false)]
            public string Template { get; set; }

        }

    }

}
