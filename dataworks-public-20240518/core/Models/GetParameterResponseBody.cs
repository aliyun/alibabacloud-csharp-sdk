// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetParameterResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the parameter.</para>
        /// </summary>
        [NameInMap("Parameter")]
        [Validation(Required=false)]
        public GetParameterResponseBodyParameter Parameter { get; set; }
        public class GetParameterResponseBodyParameter : TeaModel {
            /// <summary>
            /// <para>The time when the parameter was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1640000000000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The creator of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

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
            /// <para>The ID of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The time when the parameter was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1640000000000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The modifier of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789</para>
            /// </summary>
            [NameInMap("ModifyUser")]
            [Validation(Required=false)]
            public string ModifyUser { get; set; }

            /// <summary>
            /// <para>The name of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>workspace.para</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The owner of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The ID of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The value configurations of the parameter.</para>
            /// </summary>
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public List<GetParameterResponseBodyParameterProperties> Properties { get; set; }
            public class GetParameterResponseBodyParameterProperties : TeaModel {
                /// <summary>
                /// <para>The project environment. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Prod</c>: production.</para>
                /// </description></item>
                /// <item><description><para><c>Dev</c>: development.</para>
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
                /// <para>The value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value123</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The scope of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Project</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>The type of the parameter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>PlainConstant</c>: a constant in plaintext.</para>
            /// </description></item>
            /// <item><description><para><c>SecretConstant</c>: a constant in ciphertext.</para>
            /// </description></item>
            /// <item><description><para><c>Variable</c>: a variable.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PlainConstant</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The version of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6A6CBE87-9F91-1323-B680-E7A7065XXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
