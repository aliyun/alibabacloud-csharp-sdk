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
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dialogue")]
        [Validation(Required=false)]
        public AnalyzeConversationRequestDialogue Dialogue { get; set; }
        public class AnalyzeConversationRequestDialogue : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("sentences")]
            [Validation(Required=false)]
            public List<AnalyzeConversationRequestDialogueSentences> Sentences { get; set; }
            public class AnalyzeConversationRequestDialogueSentences : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>session-01</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        [NameInMap("examples")]
        [Validation(Required=false)]
        public List<AnalyzeConversationRequestExamples> Examples { get; set; }
        public class AnalyzeConversationRequestExamples : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("sentences")]
            [Validation(Required=false)]
            public List<AnalyzeConversationRequestExamplesSentences> Sentences { get; set; }
            public class AnalyzeConversationRequestExamplesSentences : TeaModel {
                [NameInMap("chatId")]
                [Validation(Required=false)]
                public string ChatId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
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
            /// <summary>
            /// <b>Example:</b>
            /// <para>phoneNumber</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("enumValues")]
            [Validation(Required=false)]
            public List<AnalyzeConversationRequestFieldsEnumValues> EnumValues { get; set; }
            public class AnalyzeConversationRequestFieldsEnumValues : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("enumValue")]
                [Validation(Required=false)]
                public string EnumValue { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>tyxmTurbo</para>
        /// </summary>
        [NameInMap("modelCode")]
        [Validation(Required=false)]
        public string ModelCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
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
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("inspectionContents")]
            [Validation(Required=false)]
            public List<AnalyzeConversationRequestServiceInspectionInspectionContents> InspectionContents { get; set; }
            public class AnalyzeConversationRequestServiceInspectionInspectionContents : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("inspectionIntroduction")]
            [Validation(Required=false)]
            public string InspectionIntroduction { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("sceneIntroduction")]
            [Validation(Required=false)]
            public string SceneIntroduction { get; set; }

        }

        [NameInMap("sourceCallerUid")]
        [Validation(Required=false)]
        public string SourceCallerUid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        [NameInMap("timeConstraintList")]
        [Validation(Required=false)]
        public List<string> TimeConstraintList { get; set; }

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
