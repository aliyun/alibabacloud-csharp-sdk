// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SaveAnnotationMissionSessionListRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1198938</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9137ab9c27044921860030adf8590ec4_p_outbound_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AnnotationMissionDataSourceType")]
        [Validation(Required=false)]
        public long? AnnotationMissionDataSourceType { get; set; }

        [NameInMap("AnnotationMissionSessionList")]
        [Validation(Required=false)]
        public List<SaveAnnotationMissionSessionListRequestAnnotationMissionSessionList> AnnotationMissionSessionList { get; set; }
        public class SaveAnnotationMissionSessionListRequestAnnotationMissionSessionList : TeaModel {
            [NameInMap("AnnotationMissionChatList")]
            [Validation(Required=false)]
            public List<SaveAnnotationMissionSessionListRequestAnnotationMissionSessionListAnnotationMissionChatList> AnnotationMissionChatList { get; set; }
            public class SaveAnnotationMissionSessionListRequestAnnotationMissionSessionListAnnotationMissionChatList : TeaModel {
                [NameInMap("AnnotationAsrResult")]
                [Validation(Required=false)]
                public string AnnotationAsrResult { get; set; }

                [NameInMap("AnnotationMissionChatCustomizationDataInfoList")]
                [Validation(Required=false)]
                public List<SaveAnnotationMissionSessionListRequestAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatCustomizationDataInfoList> AnnotationMissionChatCustomizationDataInfoList { get; set; }
                public class SaveAnnotationMissionSessionListRequestAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatCustomizationDataInfoList : TeaModel {
                    /// <summary>
                    /// <para>id</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionChatCustomizationDataInfoId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionChatCustomizationDataInfoId { get; set; }

                    /// <summary>
                    /// <para>chat id</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>977a45dc-b636-4407-9e98-9f572c709ada</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionChatId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionChatId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>03f56192-fa8a-40dc-9558-39b357f0618f</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>977a45dc-b636-4407-9e98-9f572c709ada</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionSessionId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionSessionId { get; set; }

                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Create")]
                    [Validation(Required=false)]
                    public bool? Create { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1682316909210</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    [NameInMap("CustomizationDataDescription")]
                    [Validation(Required=false)]
                    public string CustomizationDataDescription { get; set; }

                    /// <summary>
                    /// <para>id</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>977a45dc-b636-4407-9e98-9f572c709ada</para>
                    /// </summary>
                    [NameInMap("CustomizationDataId")]
                    [Validation(Required=false)]
                    public string CustomizationDataId { get; set; }

                    [NameInMap("CustomizationDataName")]
                    [Validation(Required=false)]
                    public string CustomizationDataName { get; set; }

                    [NameInMap("CustomizationDataWeight")]
                    [Validation(Required=false)]
                    public int? CustomizationDataWeight { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Delete")]
                    [Validation(Required=false)]
                    public bool? Delete { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>b598a47a-7c03-45fb-af6b-343950dd9512</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1673438100000</para>
                    /// </summary>
                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public long? ModifiedTime { get; set; }

                }

                /// <summary>
                /// <para>chat id</para>
                /// </summary>
                [NameInMap("AnnotationMissionChatId")]
                [Validation(Required=false)]
                public string AnnotationMissionChatId { get; set; }

                [NameInMap("AnnotationMissionChatIntentUserSayInfoList")]
                [Validation(Required=false)]
                public List<SaveAnnotationMissionSessionListRequestAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatIntentUserSayInfoList> AnnotationMissionChatIntentUserSayInfoList { get; set; }
                public class SaveAnnotationMissionSessionListRequestAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatIntentUserSayInfoList : TeaModel {
                    [NameInMap("AnnotationMissionChatId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionChatId { get; set; }

                    [NameInMap("AnnotationMissionChatIntentUserSayInfoId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionChatIntentUserSayInfoId { get; set; }

                    [NameInMap("AnnotationMissionId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionId { get; set; }

                    [NameInMap("AnnotationMissionSessionId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionSessionId { get; set; }

                    [NameInMap("BotId")]
                    [Validation(Required=false)]
                    public string BotId { get; set; }

                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("Create")]
                    [Validation(Required=false)]
                    public bool? Create { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    [NameInMap("Delete")]
                    [Validation(Required=false)]
                    public bool? Delete { get; set; }

                    [NameInMap("DialogId")]
                    [Validation(Required=false)]
                    public long? DialogId { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("IntentId")]
                    [Validation(Required=false)]
                    public long? IntentId { get; set; }

                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public long? ModifiedTime { get; set; }

                }

                [NameInMap("AnnotationMissionChatTagInfoList")]
                [Validation(Required=false)]
                public List<SaveAnnotationMissionSessionListRequestAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatTagInfoList> AnnotationMissionChatTagInfoList { get; set; }
                public class SaveAnnotationMissionSessionListRequestAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatTagInfoList : TeaModel {
                    /// <summary>
                    /// <para>chat id</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>977a45dc-b636-4407-9e98-9f572c709ada</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionChatId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionChatId { get; set; }

                    /// <summary>
                    /// <para>id</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionChatTagInfoId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionChatTagInfoId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>977a45dc-b636-4407-9e98-9f572c709ada</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>977a45dc-b636-4407-9e98-9f572c709ada</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionSessionId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionSessionId { get; set; }

                    /// <summary>
                    /// <para>tag id</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>977a45dc-b636-4407-9e98-9f572c709ada</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionTagInfoId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionTagInfoId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("AnnotationMissionTagInfoName")]
                    [Validation(Required=false)]
                    public string AnnotationMissionTagInfoName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Create")]
                    [Validation(Required=false)]
                    public bool? Create { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1679710866060</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Delete")]
                    [Validation(Required=false)]
                    public bool? Delete { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>32be9d94-1346-4c4a-a4d0-ccd379f87013</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1679710866060</para>
                    /// </summary>
                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public long? ModifiedTime { get; set; }

                }

                [NameInMap("AnnotationMissionChatVocabularyInfoList")]
                [Validation(Required=false)]
                public List<SaveAnnotationMissionSessionListRequestAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatVocabularyInfoList> AnnotationMissionChatVocabularyInfoList { get; set; }
                public class SaveAnnotationMissionSessionListRequestAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatVocabularyInfoList : TeaModel {
                    /// <summary>
                    /// <para>chat id</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionChatId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionChatId { get; set; }

                    /// <summary>
                    /// <para>id</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionChatVocabularyInfoId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionChatVocabularyInfoId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>977a45dc-b636-4407-9e98-9f572c709ada</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionId { get; set; }

                    [NameInMap("AnnotationMissionSessionId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionSessionId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Create")]
                    [Validation(Required=false)]
                    public bool? Create { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1677552860720</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Delete")]
                    [Validation(Required=false)]
                    public bool? Delete { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>77343553-cbc2-4487-a35c-869f1e86c573</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1679283408230</para>
                    /// </summary>
                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public long? ModifiedTime { get; set; }

                    [NameInMap("Vocabulary")]
                    [Validation(Required=false)]
                    public string Vocabulary { get; set; }

                    [NameInMap("VocabularyDescription")]
                    [Validation(Required=false)]
                    public string VocabularyDescription { get; set; }

                    [NameInMap("VocabularyId")]
                    [Validation(Required=false)]
                    public string VocabularyId { get; set; }

                    [NameInMap("VocabularyName")]
                    [Validation(Required=false)]
                    public string VocabularyName { get; set; }

                    [NameInMap("VocabularyWeight")]
                    [Validation(Required=false)]
                    public int? VocabularyWeight { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ddce607f-f537-4ebd-9914-cf45671defb9</para>
                /// </summary>
                [NameInMap("AnnotationMissionId")]
                [Validation(Required=false)]
                public string AnnotationMissionId { get; set; }

                [NameInMap("AnnotationMissionSessionId")]
                [Validation(Required=false)]
                public string AnnotationMissionSessionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AnnotationStatus")]
                [Validation(Required=false)]
                public int? AnnotationStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{\&quot;Answer\&quot;: u\&quot;\u53c2\u8003\u6587\u6863\uff1a<a href="https://help.aliyun.com/document_detail/181325.html%5C%5C">https://help.aliyun.com/document_detail/181325.html\\</a>&quot;, \&quot;QuestionId\&quot;: 372858, \&quot;Uuid\&quot;: \&quot;ac14000516762684770197536d0044\&quot;}</para>
                /// </summary>
                [NameInMap("Answer")]
                [Validation(Required=false)]
                public string Answer { get; set; }

                [NameInMap("AsrAnnotationStatus")]
                [Validation(Required=false)]
                public int? AsrAnnotationStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1679629770336</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5ec263fa-c8de-46f4-b844-6fb8275bb645</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("IntentAnnotationStatus")]
                [Validation(Required=false)]
                public int? IntentAnnotationStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1629360780000</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public long? ModifiedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1682493047418</para>
                /// </summary>
                [NameInMap("OccurTime")]
                [Validation(Required=false)]
                public long? OccurTime { get; set; }

                [NameInMap("OriginalAsrResult")]
                [Validation(Required=false)]
                public string OriginalAsrResult { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1475140522</para>
                /// </summary>
                [NameInMap("SequenceId")]
                [Validation(Required=false)]
                public string SequenceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SubStatus")]
                [Validation(Required=false)]
                public int? SubStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TagAnnotationStatus")]
                [Validation(Required=false)]
                public int? TagAnnotationStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TranslationError")]
                [Validation(Required=false)]
                public int? TranslationError { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>c88cc004-de69-4eee-aa5f-2efed533a54e</para>
            /// </summary>
            [NameInMap("AnnotationMissionId")]
            [Validation(Required=false)]
            public string AnnotationMissionId { get; set; }

            [NameInMap("AnnotationMissionSessionId")]
            [Validation(Required=false)]
            public string AnnotationMissionSessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AnnotationStatus")]
            [Validation(Required=false)]
            public int? AnnotationStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-04-14T02:01:23Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>77343553-cbc2-4487-a35c-869f1e86c573</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>29e669bd-a9d1-4529-98cd-c2b0549bcf53</para>
            /// </summary>
            [NameInMap("JobGroupId")]
            [Validation(Required=false)]
            public string JobGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>593aaf5e-1275-4add-9990-22696385dc6e</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1683858248778</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>e4f32632-2e56-4399-9fec-47bdbaeefdf6</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>e6271044-b4b2-4ad8-ade4-c720be023538</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("AnnotationMissionSessionListJsonString")]
        [Validation(Required=false)]
        public string AnnotationMissionSessionListJsonString { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Environment")]
        [Validation(Required=false)]
        public long? Environment { get; set; }

        [NameInMap("UserNick")]
        [Validation(Required=false)]
        public string UserNick { get; set; }

    }

}
