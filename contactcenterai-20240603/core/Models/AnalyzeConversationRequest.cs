/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ContactCenterAI20240603.Models
{
    public class AnalyzeConversationRequest : TeaModel {
        [NameInMap("categoryTags")]
        [Validation(Required=false)]
        public List<AnalyzeConversationRequestCategoryTags> CategoryTags { get; set; }
        public class AnalyzeConversationRequestCategoryTags : TeaModel {
            [NameInMap("tagDesc")]
            [Validation(Required=false)]
            public string TagDesc { get; set; }

            [NameInMap("tagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dialogue")]
        [Validation(Required=false)]
        public AnalyzeConversationRequestDialogue Dialogue { get; set; }
        public class AnalyzeConversationRequestDialogue : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("sentences")]
            [Validation(Required=false)]
            public List<AnalyzeConversationRequestDialogueSentences> Sentences { get; set; }
            public class AnalyzeConversationRequestDialogueSentences : TeaModel {
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

            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        [NameInMap("examples")]
        [Validation(Required=false)]
        public List<AnalyzeConversationRequestExamples> Examples { get; set; }
        public class AnalyzeConversationRequestExamples : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("sentences")]
            [Validation(Required=false)]
            public List<AnalyzeConversationRequestExamplesSentences> Sentences { get; set; }
            public class AnalyzeConversationRequestExamplesSentences : TeaModel {
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
        public List<AnalyzeConversationRequestFields> Fields { get; set; }
        public class AnalyzeConversationRequestFields : TeaModel {
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("enumValues")]
            [Validation(Required=false)]
            public List<AnalyzeConversationRequestFieldsEnumValues> EnumValues { get; set; }
            public class AnalyzeConversationRequestFieldsEnumValues : TeaModel {
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

        [NameInMap("modelCode")]
        [Validation(Required=false)]
        public string ModelCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("resultTypes")]
        [Validation(Required=false)]
        public List<string> ResultTypes { get; set; }

        [NameInMap("sceneName")]
        [Validation(Required=false)]
        public string SceneName { get; set; }

        [NameInMap("serviceInspection")]
        [Validation(Required=false)]
        public AnalyzeConversationRequestServiceInspection ServiceInspection { get; set; }
        public class AnalyzeConversationRequestServiceInspection : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("inspectionContents")]
            [Validation(Required=false)]
            public List<AnalyzeConversationRequestServiceInspectionInspectionContents> InspectionContents { get; set; }
            public class AnalyzeConversationRequestServiceInspectionInspectionContents : TeaModel {
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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        [NameInMap("userProfiles")]
        [Validation(Required=false)]
        public List<AnalyzeConversationRequestUserProfiles> UserProfiles { get; set; }
        public class AnalyzeConversationRequestUserProfiles : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
