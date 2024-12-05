// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class VariablesValue : TeaModel {
        /// <summary>
        /// <para>Specifies whether the variable is not allowed to be modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("disableModify")]
        [Validation(Required=false)]
        public bool? DisableModify { get; set; }

        /// <summary>
        /// <para>Specifies whether the variable is modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("isModify")]
        [Validation(Required=false)]
        public bool? IsModify { get; set; }

        /// <summary>
        /// <para>The variable value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// <para>The description of the variable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The template value of the variable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("templateValue")]
        [Validation(Required=false)]
        public string TemplateValue { get; set; }

        /// <summary>
        /// <para>The variable type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NORMAL: common variable</description></item>
        /// <item><description>FUNCTION: function variable</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The function variables.</para>
        /// </summary>
        [NameInMap("funcValue")]
        [Validation(Required=false)]
        public VariablesValueFuncValue FuncValue { get; set; }
        public class VariablesValueFuncValue : TeaModel {
            /// <summary>
            /// <para>The class name of the function variable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("funcClassName")]
            [Validation(Required=false)]
            public string FuncClassName { get; set; }

            /// <summary>
            /// <para>The template of the function variable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("template")]
            [Validation(Required=false)]
            public string Template { get; set; }

        }

    }

}
