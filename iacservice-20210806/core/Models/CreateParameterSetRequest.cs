// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CreateParameterSetRequest : TeaModel {
        /// <summary>
        /// <para>The idempotency token. Format: [0-9a-zA-Z-]{1,64}. Use a UUID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a65451293e64979ba7a4b573950217fe</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the parameter set. Maximum length: 1024 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is parameterSet</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the parameter set. Maximum length: 128 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The list of parameters.</para>
        /// </summary>
        [NameInMap("parameters")]
        [Validation(Required=false)]
        public List<CreateParameterSetRequestParameters> Parameters { get; set; }
        public class CreateParameterSetRequestParameters : TeaModel {
            /// <summary>
            /// <para>The parameter name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>region</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("secret")]
            [Validation(Required=false)]
            public bool? Secret { get; set; }

            /// <summary>
            /// <para>The parameter set status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>HAS_VALUE (default): Defines a specific value.</description></item>
            /// <item><description>EXPLICIT_NULL: Explicitly sets the value to null.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HAS_VALUE</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The parameter type. Valid values: string, number, bool, map(string), and list(string).</para>
            /// 
            /// <b>Example:</b>
            /// <para>string</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The parameter value. Use JSON for complex types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
