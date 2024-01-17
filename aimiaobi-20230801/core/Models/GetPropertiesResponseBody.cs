// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetPropertiesResponseBody : TeaModel {
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
                        [NameInMap("Select")]
                        [Validation(Required=false)]
                        public bool? Select { get; set; }

                        [NameInMap("Stared")]
                        [Validation(Required=false)]
                        public bool? Stared { get; set; }

                        [NameInMap("Title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                    [NameInMap("Prompt")]
                    [Validation(Required=false)]
                    public string Prompt { get; set; }

                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

                [NameInMap("SearchSources")]
                [Validation(Required=false)]
                public List<GetPropertiesResponseBodyDataIntelligentSearchConfigSearchSources> SearchSources { get; set; }
                public class GetPropertiesResponseBodyDataIntelligentSearchConfigSearchSources : TeaModel {
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

            }

            [NameInMap("SearchSources")]
            [Validation(Required=false)]
            public List<GetPropertiesResponseBodyDataSearchSources> SearchSources { get; set; }
            public class GetPropertiesResponseBodyDataSearchSources : TeaModel {
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("SlrAuthorized")]
            [Validation(Required=false)]
            public bool? SlrAuthorized { get; set; }

            [NameInMap("UserInfo")]
            [Validation(Required=false)]
            public GetPropertiesResponseBodyDataUserInfo UserInfo { get; set; }
            public class GetPropertiesResponseBodyDataUserInfo : TeaModel {
                [NameInMap("AgentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            [NameInMap("WanxiangImageSizeConfig")]
            [Validation(Required=false)]
            public List<GetPropertiesResponseBodyDataWanxiangImageSizeConfig> WanxiangImageSizeConfig { get; set; }
            public class GetPropertiesResponseBodyDataWanxiangImageSizeConfig : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

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

                [NameInMap("Pic")]
                [Validation(Required=false)]
                public string Pic { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
