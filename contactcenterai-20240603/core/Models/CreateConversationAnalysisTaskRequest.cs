// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ContactCenterAI20240603.Models
{
    public class CreateConversationAnalysisTaskRequest : TeaModel {
        [NameInMap("autoSplit")]
        [Validation(Required=false)]
        public int? AutoSplit { get; set; }

        [NameInMap("clientChannel")]
        [Validation(Required=false)]
        public int? ClientChannel { get; set; }

        [NameInMap("examples")]
        [Validation(Required=false)]
        public CreateConversationAnalysisTaskRequestExamples Examples { get; set; }
        public class CreateConversationAnalysisTaskRequestExamples : TeaModel {
            [NameInMap("output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("sentences")]
            [Validation(Required=false)]
            public List<CreateConversationAnalysisTaskRequestExamplesSentences> Sentences { get; set; }
            public class CreateConversationAnalysisTaskRequestExamplesSentences : TeaModel {
                [NameInMap("chatId")]
                [Validation(Required=false)]
                public string ChatId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

        }

        [NameInMap("fields")]
        [Validation(Required=false)]
        public List<CreateConversationAnalysisTaskRequestFields> Fields { get; set; }
        public class CreateConversationAnalysisTaskRequestFields : TeaModel {
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("enumValues")]
            [Validation(Required=false)]
            public List<CreateConversationAnalysisTaskRequestFieldsEnumValues> EnumValues { get; set; }
            public class CreateConversationAnalysisTaskRequestFieldsEnumValues : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("enumValue")]
                [Validation(Required=false)]
                public string EnumValue { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("modelCode")]
        [Validation(Required=false)]
        public string ModelCode { get; set; }

        [NameInMap("resultTypes")]
        [Validation(Required=false)]
        public List<string> ResultTypes { get; set; }

        [NameInMap("sceneName")]
        [Validation(Required=false)]
        public string SceneName { get; set; }

        [NameInMap("serviceChannel")]
        [Validation(Required=false)]
        public int? ServiceChannel { get; set; }

        [NameInMap("serviceChannelKeywords")]
        [Validation(Required=false)]
        public List<string> ServiceChannelKeywords { get; set; }

        [NameInMap("serviceInspection")]
        [Validation(Required=false)]
        public CreateConversationAnalysisTaskRequestServiceInspection ServiceInspection { get; set; }
        public class CreateConversationAnalysisTaskRequestServiceInspection : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("inspectionContents")]
            [Validation(Required=false)]
            public List<CreateConversationAnalysisTaskRequestServiceInspectionInspectionContents> InspectionContents { get; set; }
            public class CreateConversationAnalysisTaskRequestServiceInspectionInspectionContents : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("inspectionIntroduction")]
            [Validation(Required=false)]
            public string InspectionIntroduction { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("sceneIntroduction")]
            [Validation(Required=false)]
            public string SceneIntroduction { get; set; }

        }

        [NameInMap("templateIds")]
        [Validation(Required=false)]
        public List<string> TemplateIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("voiceFileUrl")]
        [Validation(Required=false)]
        public string VoiceFileUrl { get; set; }

    }

}
