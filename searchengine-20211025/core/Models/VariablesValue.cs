// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class VariablesValue : TeaModel {
        /// <summary>
        /// <para>Specifies whether modification is not allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("disableModify")]
        [Validation(Required=false)]
        public bool? DisableModify { get; set; }

        /// <summary>
        /// <para>Indicates whether the variable has been modified.</para>
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
        /// <para>qrs_connection_timeout</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>超时时间</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The template value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("templateValue")]
        [Validation(Required=false)]
        public string TemplateValue { get; set; }

        /// <summary>
        /// <para>The type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NORMAL: normal variable</description></item>
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
        /// <para>The function variable.</para>
        /// </summary>
        [NameInMap("funcValue")]
        [Validation(Required=false)]
        public VariablesValueFuncValue FuncValue { get; set; }
        public class VariablesValueFuncValue : TeaModel {
            /// <summary>
            /// <para>The method class name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ModifyFile</para>
            /// </summary>
            [NameInMap("funcClassName")]
            [Validation(Required=false)]
            public string FuncClassName { get; set; }

            /// <summary>
            /// <para>The template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-template</para>
            /// </summary>
            [NameInMap("template")]
            [Validation(Required=false)]
            public string Template { get; set; }

        }

    }

}
