// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListParameterVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListParameterVersionsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListParameterVersionsResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The list of parameter versions.</para>
            /// </summary>
            [NameInMap("ParameterVersion")]
            [Validation(Required=false)]
            public List<ListParameterVersionsResponseBodyPagingInfoParameterVersion> ParameterVersion { get; set; }
            public class ListParameterVersionsResponseBodyPagingInfoParameterVersion : TeaModel {
                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1640000000000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456789</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <para>The parameter description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is a test parameter.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The parameter ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1640000000000</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>The ID of the modifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456789</para>
                /// </summary>
                [NameInMap("ModifyUser")]
                [Validation(Required=false)]
                public string ModifyUser { get; set; }

                /// <summary>
                /// <para>The parameter name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>workspace.para</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456789</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The environment-specific configurations of the parameter value.</para>
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public List<ListParameterVersionsResponseBodyPagingInfoParameterVersionProperties> Properties { get; set; }
                public class ListParameterVersionsResponseBodyPagingInfoParameterVersionProperties : TeaModel {
                    /// <summary>
                    /// <para>The environment type. Valid values:</para>
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
                    /// <para>The parameter value.</para>
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
                /// <item><description><para><c>PlainConstant</c>: a plaintext constant.</para>
                /// </description></item>
                /// <item><description><para><c>SecretConstant</c>: a secret constant.</para>
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
                /// <para>The version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

            }

            /// <summary>
            /// <para>The total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

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
