// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ContactCenterAI20240603.Models
{
    public class AnalyzeAudioSyncRequest : TeaModel {
        [NameInMap("categoryTags")]
        [Validation(Required=false)]
        public List<AnalyzeAudioSyncRequestCategoryTags> CategoryTags { get; set; }
        public class AnalyzeAudioSyncRequestCategoryTags : TeaModel {
            [NameInMap("tagDesc")]
            [Validation(Required=false)]
            public string TagDesc { get; set; }

            [NameInMap("tagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

        }

        [NameInMap("customPrompt")]
        [Validation(Required=false)]
        public string CustomPrompt { get; set; }

        [NameInMap("fields")]
        [Validation(Required=false)]
        public List<AnalyzeAudioSyncRequestFields> Fields { get; set; }
        public class AnalyzeAudioSyncRequestFields : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>phoneNumber</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("enumValues")]
            [Validation(Required=false)]
            public List<AnalyzeAudioSyncRequestFieldsEnumValues> EnumValues { get; set; }
            public class AnalyzeAudioSyncRequestFieldsEnumValues : TeaModel {
                [NameInMap("desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                [NameInMap("enumValue")]
                [Validation(Required=false)]
                public string EnumValue { get; set; }

            }

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
        /// <b>Example:</b>
        /// <para>jsonObject</para>
        /// </summary>
        [NameInMap("responseFormatType")]
        [Validation(Required=false)]
        public string ResponseFormatType { get; set; }

        [NameInMap("resultTypes")]
        [Validation(Required=false)]
        public List<string> ResultTypes { get; set; }

        [NameInMap("serviceInspection")]
        [Validation(Required=false)]
        public AnalyzeAudioSyncRequestServiceInspection ServiceInspection { get; set; }
        public class AnalyzeAudioSyncRequestServiceInspection : TeaModel {
            [NameInMap("inspectionContents")]
            [Validation(Required=false)]
            public List<AnalyzeAudioSyncRequestServiceInspectionInspectionContents> InspectionContents { get; set; }
            public class AnalyzeAudioSyncRequestServiceInspectionInspectionContents : TeaModel {
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("inspectionIntroduction")]
            [Validation(Required=false)]
            public string InspectionIntroduction { get; set; }

            [NameInMap("sceneIntroduction")]
            [Validation(Required=false)]
            public string SceneIntroduction { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        [NameInMap("templateIds")]
        [Validation(Required=false)]
        public List<string> TemplateIds { get; set; }

        [NameInMap("transcription")]
        [Validation(Required=false)]
        public AnalyzeAudioSyncRequestTranscription Transcription { get; set; }
        public class AnalyzeAudioSyncRequestTranscription : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>nls</para>
            /// </summary>
            [NameInMap("asrModelCode")]
            [Validation(Required=false)]
            public string AsrModelCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("autoSplit")]
            [Validation(Required=false)]
            public int? AutoSplit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("clientChannel")]
            [Validation(Required=false)]
            public int? ClientChannel { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sss.mp3</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>low</para>
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("serviceChannel")]
            [Validation(Required=false)]
            public int? ServiceChannel { get; set; }

            [NameInMap("serviceChannelKeywords")]
            [Validation(Required=false)]
            public List<string> ServiceChannelKeywords { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>esnvknv*****skdnvjksd</para>
            /// </summary>
            [NameInMap("vocabularyId")]
            [Validation(Required=false)]
            public string VocabularyId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://1111.com/sss.mp3">http://1111.com/sss.mp3</a></para>
            /// </summary>
            [NameInMap("voiceFileUrl")]
            [Validation(Required=false)]
            public string VoiceFileUrl { get; set; }

        }

        [NameInMap("variables")]
        [Validation(Required=false)]
        public List<AnalyzeAudioSyncRequestVariables> Variables { get; set; }
        public class AnalyzeAudioSyncRequestVariables : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("variableCode")]
            [Validation(Required=false)]
            public string VariableCode { get; set; }

            [NameInMap("variableValue")]
            [Validation(Required=false)]
            public string VariableValue { get; set; }

        }

    }

}
