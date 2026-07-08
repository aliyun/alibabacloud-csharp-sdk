// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetPropertiesResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataNotExists</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Business data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPropertiesResponseBodyData Data { get; set; }
        public class GetPropertiesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Call configuration</para>
            /// </summary>
            [NameInMap("ChatConfig")]
            [Validation(Required=false)]
            public Dictionary<string, object> ChatConfig { get; set; }

            /// <summary>
            /// <para>Console configuration</para>
            /// </summary>
            [NameInMap("ConsoleConfig")]
            [Validation(Required=false)]
            public GetPropertiesResponseBodyDataConsoleConfig ConsoleConfig { get; set; }
            public class GetPropertiesResponseBodyDataConsoleConfig : TeaModel {
                /// <summary>
                /// <para>Prompt content</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("TipContent")]
                [Validation(Required=false)]
                public string TipContent { get; set; }

                /// <summary>
                /// <para>Title</para>
                /// 
                /// <b>Example:</b>
                /// <para>AI妙笔</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>General configurations map</para>
            /// </summary>
            [NameInMap("GeneralConfigMap")]
            [Validation(Required=false)]
            public Dictionary<string, object> GeneralConfigMap { get; set; }

            /// <summary>
            /// <para>Intelligent search configuration</para>
            /// </summary>
            [NameInMap("IntelligentSearchConfig")]
            [Validation(Required=false)]
            public GetPropertiesResponseBodyDataIntelligentSearchConfig IntelligentSearchConfig { get; set; }
            public class GetPropertiesResponseBodyDataIntelligentSearchConfig : TeaModel {
                /// <summary>
                /// <para>Miaosou: Search source configuration</para>
                /// </summary>
                [NameInMap("CopilotPreciseSearchSources")]
                [Validation(Required=false)]
                public List<GetPropertiesResponseBodyDataIntelligentSearchConfigCopilotPreciseSearchSources> CopilotPreciseSearchSources { get; set; }
                public class GetPropertiesResponseBodyDataIntelligentSearchConfigCopilotPreciseSearchSources : TeaModel {
                    /// <summary>
                    /// <para>Unique identifier for the dataset: code+datasetName</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>x</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>Unique identifier for the dataset: code+datasetName</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>x</para>
                    /// </summary>
                    [NameInMap("DatasetName")]
                    [Validation(Required=false)]
                    public string DatasetName { get; set; }

                    /// <summary>
                    /// <para>Search source name: Chinese</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>x</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>Homepage product description</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("ProductDescription")]
                [Validation(Required=false)]
                public string ProductDescription { get; set; }

                /// <summary>
                /// <para>Intelligent search recommendations</para>
                /// </summary>
                [NameInMap("SearchSamples")]
                [Validation(Required=false)]
                public List<GetPropertiesResponseBodyDataIntelligentSearchConfigSearchSamples> SearchSamples { get; set; }
                public class GetPropertiesResponseBodyDataIntelligentSearchConfigSearchSamples : TeaModel {
                    /// <summary>
                    /// <para>Article list</para>
                    /// </summary>
                    [NameInMap("Articles")]
                    [Validation(Required=false)]
                    public List<GetPropertiesResponseBodyDataIntelligentSearchConfigSearchSamplesArticles> Articles { get; set; }
                    public class GetPropertiesResponseBodyDataIntelligentSearchConfigSearchSamplesArticles : TeaModel {
                        /// <summary>
                        /// <para>Whether manually selected when passed from the frontend</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Select")]
                        [Validation(Required=false)]
                        public bool? Select { get; set; }

                        /// <summary>
                        /// <para>Whether it is a starred article</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Stared")]
                        [Validation(Required=false)]
                        public bool? Stared { get; set; }

                        /// <summary>
                        /// <para>Title</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xx</para>
                        /// </summary>
                        [NameInMap("Title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                        /// <summary>
                        /// <para>Article URL</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="http://xxx.com">http://xxx.com</a></para>
                        /// </summary>
                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                    /// <summary>
                    /// <para>Prompt</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("Prompt")]
                    [Validation(Required=false)]
                    public string Prompt { get; set; }

                    /// <summary>
                    /// <para>Generated content</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

                /// <summary>
                /// <para>Search source list</para>
                /// </summary>
                [NameInMap("SearchSources")]
                [Validation(Required=false)]
                public List<GetPropertiesResponseBodyDataIntelligentSearchConfigSearchSources> SearchSources { get; set; }
                public class GetPropertiesResponseBodyDataIntelligentSearchConfigSearchSources : TeaModel {
                    /// <summary>
                    /// <para>Unique identifier for the dataset: code+datasetName</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>Unique identifier for the dataset: code+datasetName</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("DatasetName")]
                    [Validation(Required=false)]
                    public string DatasetName { get; set; }

                    /// <summary>
                    /// <para>Search source name: Chinese</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// <para>Miaosou configuration</para>
            /// </summary>
            [NameInMap("MiaosouConfig")]
            [Validation(Required=false)]
            public GetPropertiesResponseBodyDataMiaosouConfig MiaosouConfig { get; set; }
            public class GetPropertiesResponseBodyDataMiaosouConfig : TeaModel {
                /// <summary>
                /// <para>The number of active documents in the dataset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MaxDocSize")]
                [Validation(Required=false)]
                public long? MaxDocSize { get; set; }

                /// <summary>
                /// <para>Model list supported by intelligent search</para>
                /// </summary>
                [NameInMap("ModelInfos")]
                [Validation(Required=false)]
                public List<GetPropertiesResponseBodyDataMiaosouConfigModelInfos> ModelInfos { get; set; }
                public class GetPropertiesResponseBodyDataMiaosouConfigModelInfos : TeaModel {
                    /// <summary>
                    /// <para>Model ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>quanmiao-max</para>
                    /// </summary>
                    [NameInMap("ModelId")]
                    [Validation(Required=false)]
                    public string ModelId { get; set; }

                    /// <summary>
                    /// <para>Model name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>全妙-Max</para>
                    /// </summary>
                    [NameInMap("ModelName")]
                    [Validation(Required=false)]
                    public string ModelName { get; set; }

                }

                /// <summary>
                /// <para>Number of documents used in the dataset</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UseDocSize")]
                [Validation(Required=false)]
                public long? UseDocSize { get; set; }

            }

            /// <summary>
            /// <para>Specified search source list</para>
            /// </summary>
            [NameInMap("SearchSourceList")]
            [Validation(Required=false)]
            public List<GetPropertiesResponseBodyDataSearchSourceList> SearchSourceList { get; set; }
            public class GetPropertiesResponseBodyDataSearchSourceList : TeaModel {
                /// <summary>
                /// <para>Search source type: corresponds to (SystemSearch: system-built-in search, CustomSemanticSearch: custom semantic index search, ThirdSearch: third-party API search)</para>
                /// 
                /// <b>Example:</b>
                /// <para>SystemSearch</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>Unique identifier for the data source</para>
                /// 
                /// <b>Example:</b>
                /// <para>QuarkCommonNews</para>
                /// </summary>
                [NameInMap("DatasetName")]
                [Validation(Required=false)]
                public string DatasetName { get; set; }

                /// <summary>
                /// <para>Search source description</para>
                /// 
                /// <b>Example:</b>
                /// <para>互联网检索</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>Search source dropdown list</para>
            /// </summary>
            [NameInMap("SearchSources")]
            [Validation(Required=false)]
            public List<GetPropertiesResponseBodyDataSearchSources> SearchSources { get; set; }
            public class GetPropertiesResponseBodyDataSearchSources : TeaModel {
                /// <summary>
                /// <para>Search source name</para>
                /// 
                /// <b>Example:</b>
                /// <para>夸克通用搜索</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>Search source code</para>
                /// 
                /// <b>Example:</b>
                /// <para>SystemSearch</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Whether SLR is authorized</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SlrAuthorized")]
            [Validation(Required=false)]
            public bool? SlrAuthorized { get; set; }

            /// <summary>
            /// <para>User configuration</para>
            /// </summary>
            [NameInMap("UserInfo")]
            [Validation(Required=false)]
            public GetPropertiesResponseBodyDataUserInfo UserInfo { get; set; }
            public class GetPropertiesResponseBodyDataUserInfo : TeaModel {
                /// <summary>
                /// <para>Unique identifier for the workspace</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AgentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                /// <summary>
                /// <para>Unique identifier for the tenant</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>User ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>Username</para>
                /// 
                /// <b>Example:</b>
                /// <para>admin</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <para>Wanxiang images</para>
            /// </summary>
            [NameInMap("WanxiangImageSizeConfig")]
            [Validation(Required=false)]
            public List<GetPropertiesResponseBodyDataWanxiangImageSizeConfig> WanxiangImageSizeConfig { get; set; }
            public class GetPropertiesResponseBodyDataWanxiangImageSizeConfig : TeaModel {
                /// <summary>
                /// <para>Image aspect ratio</para>
                /// 
                /// <b>Example:</b>
                /// <para>1:1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Image size in pixels</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024*1024</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Wanxiang image style configuration</para>
            /// </summary>
            [NameInMap("WanxiangImageStyleConfig")]
            [Validation(Required=false)]
            public List<GetPropertiesResponseBodyDataWanxiangImageStyleConfig> WanxiangImageStyleConfig { get; set; }
            public class GetPropertiesResponseBodyDataWanxiangImageStyleConfig : TeaModel {
                /// <summary>
                /// <para>Style name</para>
                /// 
                /// <b>Example:</b>
                /// <para>默认</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Style image URL</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://img.alicdn.com/imgextra/i4/O1CN01RzKicz1W0YWzYkWcK_!!6000000002726-2-tps-132-104.png">https://img.alicdn.com/imgextra/i4/O1CN01RzKicz1W0YWzYkWcK_!!6000000002726-2-tps-132-104.png</a></para>
                /// </summary>
                [NameInMap("Pic")]
                [Validation(Required=false)]
                public string Pic { get; set; }

                /// <summary>
                /// <para>Style code</para>
                /// 
                /// <b>Example:</b>
                /// <auto>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error description</para>
        /// 
        /// <b>Example:</b>
        /// <para>数据不存在</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Unique request identifier</para>
        /// 
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether successful: true for success, false for failure</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
