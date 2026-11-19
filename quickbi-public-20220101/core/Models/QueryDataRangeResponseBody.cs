// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDataRangeResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The data scope object.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryDataRangeResponseBodyResult Result { get; set; }
        public class QueryDataRangeResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The array of data query resources.</para>
            /// </summary>
            [NameInMap("ApiCopilotLlmCubeModels")]
            [Validation(Required=false)]
            public List<QueryDataRangeResponseBodyResultApiCopilotLlmCubeModels> ApiCopilotLlmCubeModels { get; set; }
            public class QueryDataRangeResponseBodyResultApiCopilotLlmCubeModels : TeaModel {
                /// <summary>
                /// <para>The alias of the data query resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// <para>The nickname of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhuge</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <para>The ID of the data query resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sdasdafas23342342342</para>
                /// </summary>
                [NameInMap("LlmCubeId")]
                [Validation(Required=false)]
                public string LlmCubeId { get; set; }

            }

            /// <summary>
            /// <para>The array of analysis themes.</para>
            /// </summary>
            [NameInMap("ApiCopilotThemeModels")]
            [Validation(Required=false)]
            public List<QueryDataRangeResponseBodyResultApiCopilotThemeModels> ApiCopilotThemeModels { get; set; }
            public class QueryDataRangeResponseBodyResultApiCopilotThemeModels : TeaModel {
                /// <summary>
                /// <para>The array of data query resources.</para>
                /// </summary>
                [NameInMap("ApiCopilotLlmCubeModels")]
                [Validation(Required=false)]
                public List<QueryDataRangeResponseBodyResultApiCopilotThemeModelsApiCopilotLlmCubeModels> ApiCopilotLlmCubeModels { get; set; }
                public class QueryDataRangeResponseBodyResultApiCopilotThemeModelsApiCopilotLlmCubeModels : TeaModel {
                    /// <summary>
                    /// <para>The alias of the data query resource.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TestHa</para>
                    /// </summary>
                    [NameInMap("Alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    /// <summary>
                    /// <para>The nickname of the creator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Zhuge</para>
                    /// </summary>
                    [NameInMap("CreateUser")]
                    [Validation(Required=false)]
                    public string CreateUser { get; set; }

                    /// <summary>
                    /// <para>The ID of the data query resource.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1231242231asdasda</para>
                    /// </summary>
                    [NameInMap("LlmCubeId")]
                    [Validation(Required=false)]
                    public string LlmCubeId { get; set; }

                }

                /// <summary>
                /// <para>The nickname of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhuge</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <para>The ID of the analysis theme.</para>
                /// 
                /// <b>Example:</b>
                /// <para>36631232342312312</para>
                /// </summary>
                [NameInMap("ThemeId")]
                [Validation(Required=false)]
                public string ThemeId { get; set; }

                /// <summary>
                /// <para>The nickname of the analysis theme.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test theme</para>
                /// </summary>
                [NameInMap("ThemeName")]
                [Validation(Required=false)]
                public string ThemeName { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
