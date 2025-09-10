// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class UpdateAndPublishAgentRequest : TeaModel {
        [NameInMap("applicationConfig")]
        [Validation(Required=false)]
        public UpdateAndPublishAgentRequestApplicationConfig ApplicationConfig { get; set; }
        public class UpdateAndPublishAgentRequestApplicationConfig : TeaModel {
            [NameInMap("historyConfig")]
            [Validation(Required=false)]
            public UpdateAndPublishAgentRequestApplicationConfigHistoryConfig HistoryConfig { get; set; }
            public class UpdateAndPublishAgentRequestApplicationConfigHistoryConfig : TeaModel {
                [NameInMap("enableAdbRecord")]
                [Validation(Required=false)]
                public bool? EnableAdbRecord { get; set; }

                [NameInMap("enableRecord")]
                [Validation(Required=false)]
                public bool? EnableRecord { get; set; }

                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("storeCode")]
                [Validation(Required=false)]
                public string StoreCode { get; set; }

            }

            [NameInMap("longTermMemory")]
            [Validation(Required=false)]
            public UpdateAndPublishAgentRequestApplicationConfigLongTermMemory LongTermMemory { get; set; }
            public class UpdateAndPublishAgentRequestApplicationConfigLongTermMemory : TeaModel {
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

            }

            [NameInMap("parameters")]
            [Validation(Required=false)]
            public UpdateAndPublishAgentRequestApplicationConfigParameters Parameters { get; set; }
            public class UpdateAndPublishAgentRequestApplicationConfigParameters : TeaModel {
                [NameInMap("dialogRound")]
                [Validation(Required=false)]
                public int? DialogRound { get; set; }

                [NameInMap("enable_thinking")]
                [Validation(Required=false)]
                public bool? EnableThinking { get; set; }

                [NameInMap("maxTokens")]
                [Validation(Required=false)]
                public int? MaxTokens { get; set; }

                [NameInMap("temperature")]
                [Validation(Required=false)]
                public double? Temperature { get; set; }

            }

            [NameInMap("ragConfig")]
            [Validation(Required=false)]
            public UpdateAndPublishAgentRequestApplicationConfigRagConfig RagConfig { get; set; }
            public class UpdateAndPublishAgentRequestApplicationConfigRagConfig : TeaModel {
                [NameInMap("answerScope")]
                [Validation(Required=false)]
                public string AnswerScope { get; set; }

                [NameInMap("enableCitation")]
                [Validation(Required=false)]
                public bool? EnableCitation { get; set; }

                [NameInMap("enableSearch")]
                [Validation(Required=false)]
                public bool? EnableSearch { get; set; }

                [NameInMap("enableWebSearch")]
                [Validation(Required=false)]
                public bool? EnableWebSearch { get; set; }

                [NameInMap("fixedReplyDetail")]
                [Validation(Required=false)]
                public string FixedReplyDetail { get; set; }

                [NameInMap("knowledgeBaseCodeList")]
                [Validation(Required=false)]
                public List<string> KnowledgeBaseCodeList { get; set; }

                [NameInMap("promptStrategy")]
                [Validation(Required=false)]
                public string PromptStrategy { get; set; }

                [NameInMap("ragRejectType")]
                [Validation(Required=false)]
                public string RagRejectType { get; set; }

                [NameInMap("rejectFilterPrompt")]
                [Validation(Required=false)]
                public string RejectFilterPrompt { get; set; }

                [NameInMap("rejectFilterType")]
                [Validation(Required=false)]
                public string RejectFilterType { get; set; }

                [NameInMap("retrieveMaxLength")]
                [Validation(Required=false)]
                public int? RetrieveMaxLength { get; set; }

                [NameInMap("topK")]
                [Validation(Required=false)]
                public int? TopK { get; set; }

            }

            [NameInMap("security")]
            [Validation(Required=false)]
            public UpdateAndPublishAgentRequestApplicationConfigSecurity Security { get; set; }
            public class UpdateAndPublishAgentRequestApplicationConfigSecurity : TeaModel {
                [NameInMap("processingStrategy")]
                [Validation(Required=false)]
                public string ProcessingStrategy { get; set; }

            }

            [NameInMap("tools")]
            [Validation(Required=false)]
            public List<UpdateAndPublishAgentRequestApplicationConfigTools> Tools { get; set; }
            public class UpdateAndPublishAgentRequestApplicationConfigTools : TeaModel {
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("workFlows")]
            [Validation(Required=false)]
            public List<UpdateAndPublishAgentRequestApplicationConfigWorkFlows> WorkFlows { get; set; }
            public class UpdateAndPublishAgentRequestApplicationConfigWorkFlows : TeaModel {
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("instructions")]
        [Validation(Required=false)]
        public string Instructions { get; set; }

        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("sampleLibrary")]
        [Validation(Required=false)]
        public UpdateAndPublishAgentRequestSampleLibrary SampleLibrary { get; set; }
        public class UpdateAndPublishAgentRequestSampleLibrary : TeaModel {
            [NameInMap("enableSample")]
            [Validation(Required=false)]
            public bool? EnableSample { get; set; }

            [NameInMap("sampleLibraryIdList")]
            [Validation(Required=false)]
            public List<string> SampleLibraryIdList { get; set; }

            [NameInMap("topK")]
            [Validation(Required=false)]
            public int? TopK { get; set; }

        }

    }

}
