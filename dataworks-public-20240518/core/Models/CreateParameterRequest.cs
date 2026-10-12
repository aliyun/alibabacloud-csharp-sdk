// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateParameterRequest : TeaModel {
        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a test parameter</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the parameter. It must be unique within the workspace. It must start with &quot;workspace.&quot;. The subsequent content must start with a letter and can contain only letters, underscores, and digits. The total length of the name cannot exceed 255 characters.</para>
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
        /// <para>The workspace ID. This parameter is required when Scope is set to Project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The parameter value configurations. This parameter is required for the production environment. If duplicate environment configurations exist in the array, the subsequent configurations do not take effect.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public List<CreateParameterRequestProperties> Properties { get; set; }
        public class CreateParameterRequestProperties : TeaModel {
            /// <summary>
            /// <para>The project environment. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Prod: production.</description></item>
            /// <item><description>Dev: development.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Prod</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>The parameter value. Only Chinese characters, letters, digits, and specific special characters are allowed, such as /, :, ., [, ], ,, \, \&quot;, &quot;, _, =, ?, space, carriage return, line feed, +, -, *, %, &amp;, @, !, $, #, {, and }.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value123</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The scope of the parameter. Default value: Project. Other types are currently not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Project</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PlainConstant: plaintext constant.</description></item>
        /// <item><description>SecretConstant: ciphertext constant.</description></item>
        /// <item><description>Variable: variable.</description></item>
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
