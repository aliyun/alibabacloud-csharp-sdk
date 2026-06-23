// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateParameterRequest : TeaModel {
        /// <summary>
        /// <para>The description of the parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a test parameter.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The parameter name. It must be unique within the workspace, be prefixed with <c>workspace.</c>, and not exceed 255 characters. The part of the name after the prefix must start with a letter and can contain only letters, digits, and underscores (_).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace.para</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The account ID of the owner.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The workspace ID. This parameter is required when <c>Scope</c> is set to <c>Project</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The value configurations for the parameter. A configuration for the production environment is required. If you provide duplicate configurations for an environment, only the first one is used.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public List<CreateParameterRequestProperties> Properties { get; set; }
        public class CreateParameterRequestProperties : TeaModel {
            /// <summary>
            /// <para>The environment.</para>
            /// <list type="bullet">
            /// <item><description><para><c>Prod</c>: production environment</para>
            /// </description></item>
            /// <item><description><para><c>Dev</c>: development environment</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Prod</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>The value of the parameter. The value can contain Chinese characters, letters, digits, and the following special characters: /, :, ., [, ], ,, \, \&quot;, &quot;, _, =, ?, space, carriage return, line feed, +, -, \*, %, &amp;, @, !, $, #, {, and }.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value123</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The scope of the parameter. The default value is <c>Project</c>. No other values are currently supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Project</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The type of the parameter.</para>
        /// <list type="bullet">
        /// <item><description><para><c>PlainConstant</c>: plaintext constant.</para>
        /// </description></item>
        /// <item><description><para><c>SecretConstant</c>: secret constant.</para>
        /// </description></item>
        /// <item><description><para><c>Variable</c>: variable.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PlainConstant</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
