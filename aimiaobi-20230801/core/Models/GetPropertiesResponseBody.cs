// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetPropertiesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DataNotExists</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPropertiesResponseBodyData Data { get; set; }
        public class GetPropertiesResponseBodyData : TeaModel {
            [NameInMap("ChatConfig")]
            [Validation(Required=false)]
            public Dictionary<string, object> ChatConfig { get; set; }

            [NameInMap("ConsoleConfig")]
            [Validation(Required=false)]
            public GetPropertiesResponseBodyDataConsoleConfig ConsoleConfig { get; set; }
            public class GetPropertiesResponseBodyDataConsoleConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("TipContent")]
                [Validation(Required=false)]
                public string TipContent { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("GeneralConfigMap")]
            [Validation(Required=false)]
            public Dictionary<string, object> GeneralConfigMap { get; set; }

            [NameInMap("IntelligentSearchConfig")]
            [Validation(Required=false)]
            public GetPropertiesResponseBodyDataIntelligentSearchConfig IntelligentSearchConfig { get; set; }
            public class GetPropertiesResponseBodyDataIntelligentSearchConfig : TeaModel {
                [NameInMap("CopilotPreciseSearchSources")]
                [Validation(Required=false)]
                public List<GetPropertiesResponseBodyDataIntelligentSearchConfigCopilotPreciseSearchSources> CopilotPreciseSearchSources { get; set; }
                public class GetPropertiesResponseBodyDataIntelligentSearchConfigCopilotPreciseSearchSources : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>x</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>x</para>
                    /// </summary>
                    [NameInMap("DatasetName")]
                    [Validation(Required=false)]
                    public string DatasetName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>x</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("ProductDescription")]
                [Validation(Required=false)]
                public string ProductDescription { get; set; }

                [NameInMap("SearchSamples")]
                [Validation(Required=false)]
                public List<GetPropertiesResponseBodyDataIntelligentSearchConfigSearchSamples> SearchSamples { get; set; }
                public class GetPropertiesResponseBodyDataIntelligentSearchConfigSearchSamples : TeaModel {
                    [NameInMap("Articles")]
                    [Validation(Required=false)]
                    public List<GetPropertiesResponseBodyDataIntelligentSearchConfigSearchSamplesArticles> Articles { get; set; }
                    public class GetPropertiesResponseBodyDataIntelligentSearchConfigSearchSamplesArticles : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Select")]
                        [Validation(Required=false)]
                        public bool? Select { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Stared")]
                        [Validation(Required=false)]
                        public bool? Stared { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xx</para>
                        /// </summary>
                        [NameInMap("Title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="http://xxx.com">http://xxx.com</a></para>
                        /// </summary>
                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("Prompt")]
                    [Validation(Required=false)]
                    public string Prompt { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

                [NameInMap("SearchSources")]
                [Validation(Required=false)]
                public List<GetPropertiesResponseBodyDataIntelligentSearchConfigSearchSources> SearchSources { get; set; }
                public class GetPropertiesResponseBodyDataIntelligentSearchConfigSearchSources : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("DatasetName")]
                    [Validation(Required=false)]
                    public string DatasetName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            [NameInMap("MiaosouConfig")]
            [Validation(Required=false)]
            public GetPropertiesResponseBodyDataMiaosouConfig MiaosouConfig { get; set; }
            public class GetPropertiesResponseBodyDataMiaosouConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MaxDocSize")]
                [Validation(Required=false)]
                public long? MaxDocSize { get; set; }

                [NameInMap("ModelInfos")]
                [Validation(Required=false)]
                public List<GetPropertiesResponseBodyDataMiaosouConfigModelInfos> ModelInfos { get; set; }
                public class GetPropertiesResponseBodyDataMiaosouConfigModelInfos : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>quanmiao-max</para>
                    /// </summary>
                    [NameInMap("ModelId")]
                    [Validation(Required=false)]
                    public string ModelId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>全妙-Max</para>
                    /// </summary>
                    [NameInMap("ModelName")]
                    [Validation(Required=false)]
                    public string ModelName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UseDocSize")]
                [Validation(Required=false)]
                public long? UseDocSize { get; set; }

            }

            [NameInMap("SearchSourceList")]
            [Validation(Required=false)]
            public List<GetPropertiesResponseBodyDataSearchSourceList> SearchSourceList { get; set; }
            public class GetPropertiesResponseBodyDataSearchSourceList : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("DatasetName")]
                [Validation(Required=false)]
                public string DatasetName { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("SearchSources")]
            [Validation(Required=false)]
            public List<GetPropertiesResponseBodyDataSearchSources> SearchSources { get; set; }
            public class GetPropertiesResponseBodyDataSearchSources : TeaModel {
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SystemSearch</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SlrAuthorized")]
            [Validation(Required=false)]
            public bool? SlrAuthorized { get; set; }

            [NameInMap("UserInfo")]
            [Validation(Required=false)]
            public GetPropertiesResponseBodyDataUserInfo UserInfo { get; set; }
            public class GetPropertiesResponseBodyDataUserInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AgentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>admin</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            [NameInMap("WanxiangImageSizeConfig")]
            [Validation(Required=false)]
            public List<GetPropertiesResponseBodyDataWanxiangImageSizeConfig> WanxiangImageSizeConfig { get; set; }
            public class GetPropertiesResponseBodyDataWanxiangImageSizeConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1:1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1024*1024</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("WanxiangImageStyleConfig")]
            [Validation(Required=false)]
            public List<GetPropertiesResponseBodyDataWanxiangImageStyleConfig> WanxiangImageStyleConfig { get; set; }
            public class GetPropertiesResponseBodyDataWanxiangImageStyleConfig : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://img.alicdn.com/imgextra/i4/O1CN01RzKicz1W0YWzYkWcK_!!6000000002726-2-tps-132-104.png">https://img.alicdn.com/imgextra/i4/O1CN01RzKicz1W0YWzYkWcK_!!6000000002726-2-tps-132-104.png</a></para>
                /// </summary>
                [NameInMap("Pic")]
                [Validation(Required=false)]
                public string Pic { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <auto>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
