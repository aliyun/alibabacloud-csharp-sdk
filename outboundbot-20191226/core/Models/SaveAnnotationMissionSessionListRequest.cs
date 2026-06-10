// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SaveAnnotationMissionSessionListRequest : TeaModel {
        /// <summary>
        /// <para>The agent ID.</para>
        /// <remarks>
        /// <para>Obtain this by calling the DescribeInstance operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1198938</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The key of the workspace. If you do not specify this parameter, the default workspace is accessed. Obtain the key on the Business Management page of your Alibaba Cloud account.</para>
        /// <remarks>
        /// <para>Obtain this by calling the DescribeInstance operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>9137ab9c27044921860030adf8590ec4_p_outbound_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The source of the annotation data. Valid values: 1: Outbound call. 2: Navigation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AnnotationMissionDataSourceType")]
        [Validation(Required=false)]
        public long? AnnotationMissionDataSourceType { get; set; }

        /// <summary>
        /// <para>The list of sessions.</para>
        /// <remarks>
        /// <para>This parameter has the same function as AnnotationMissionSessionListJsonString. Specify either of them.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AnnotationMissionSessionList")]
        [Validation(Required=false)]
        public List<SaveAnnotationMissionSessionListRequestAnnotationMissionSessionList> AnnotationMissionSessionList { get; set; }
        public class SaveAnnotationMissionSessionListRequestAnnotationMissionSessionList : TeaModel {
            /// <summary>
            /// <para>The list of chats.</para>
            /// </summary>
            [NameInMap("AnnotationMissionChatList")]
            [Validation(Required=false)]
            public List<SaveAnnotationMissionSessionListRequestAnnotationMissionSessionListAnnotationMissionChatList> AnnotationMissionChatList { get; set; }
            public class SaveAnnotationMissionSessionListRequestAnnotationMissionSessionListAnnotationMissionChatList : TeaModel {
                /// <summary>
                /// <para>The result of manual ASR annotation. This is used to calculate the character accuracy rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("AnnotationAsrResult")]
                [Validation(Required=false)]
                public string AnnotationAsrResult { get; set; }

                /// <summary>
                /// <para>The language model annotation information for the annotation task chat.</para>
                /// </summary>
                [NameInMap("AnnotationMissionChatCustomizationDataInfoList")]
                [Validation(Required=false)]
                public List<SaveAnnotationMissionSessionListRequestAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatCustomizationDataInfoList> AnnotationMissionChatCustomizationDataInfoList { get; set; }
                public class SaveAnnotationMissionSessionListRequestAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatCustomizationDataInfoList : TeaModel {
                    /// <summary>
                    /// <para>The ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>b598a47a-7c03-45fb-af6b-343950dd9512</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionChatCustomizationDataInfoId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionChatCustomizationDataInfoId { get; set; }

                    /// <summary>
                    /// <para>The chat ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>977a45dc-b636-4407-9e98-9f572c709ada</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionChatId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionChatId { get; set; }

                    /// <summary>
                    /// <para>The ID of the annotation task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>03f56192-fa8a-40dc-9558-39b357f0618f</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionId { get; set; }

                    /// <summary>
                    /// <para>The session ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>977a45dc-b636-4407-9e98-9f572c709ada</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionSessionId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionSessionId { get; set; }

                    /// <summary>
                    /// <para>The content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>现在呢主动邀请到您，机会非常难得，而且额度放着不用，也是不收费的，可以当作咱们的备用金，最快5分钟就能到账，建议您可以先把额度免费领取下来呢。</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>Create</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Create")]
                    [Validation(Required=false)]
                    public bool? Create { get; set; }

                    /// <summary>
                    /// <para>The time when the item was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1682316909210</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <para>The description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>默认数据描述</para>
                    /// </summary>
                    [NameInMap("CustomizationDataDescription")]
                    [Validation(Required=false)]
                    public string CustomizationDataDescription { get; set; }

                    /// <summary>
                    /// <para>The ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>977a45dc-b636-4407-9e98-9f572c709ada</para>
                    /// </summary>
                    [NameInMap("CustomizationDataId")]
                    [Validation(Required=false)]
                    public string CustomizationDataId { get; set; }

                    /// <summary>
                    /// <para>The name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>默认数据</para>
                    /// </summary>
                    [NameInMap("CustomizationDataName")]
                    [Validation(Required=false)]
                    public string CustomizationDataName { get; set; }

                    /// <summary>
                    /// <para>The weight of the language model data.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("CustomizationDataWeight")]
                    [Validation(Required=false)]
                    public int? CustomizationDataWeight { get; set; }

                    /// <summary>
                    /// <para>Delete</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Delete")]
                    [Validation(Required=false)]
                    public bool? Delete { get; set; }

                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>b598a47a-7c03-45fb-af6b-343950dd9512</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The time when the item was last modified.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1673438100000</para>
                    /// </summary>
                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public long? ModifiedTime { get; set; }

                }

                /// <summary>
                /// <para>The chat ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ddce607f-f537-4ebd-9914-cf45671defb9</para>
                /// </summary>
                [NameInMap("AnnotationMissionChatId")]
                [Validation(Required=false)]
                public string AnnotationMissionChatId { get; set; }

                /// <summary>
                /// <para>The list.</para>
                /// </summary>
                [NameInMap("AnnotationMissionChatIntentUserSayInfoList")]
                [Validation(Required=false)]
                public List<SaveAnnotationMissionSessionListRequestAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatIntentUserSayInfoList> AnnotationMissionChatIntentUserSayInfoList { get; set; }
                public class SaveAnnotationMissionSessionListRequestAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatIntentUserSayInfoList : TeaModel {
                    /// <summary>
                    /// <para>The chat ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ddce607f-f537-4ebd-9914-cf45671defb9</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionChatId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionChatId { get; set; }

                    /// <summary>
                    /// <para>The ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ddce607f-f537-4ebd-9914-cf45671defb9</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionChatIntentUserSayInfoId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionChatIntentUserSayInfoId { get; set; }

                    /// <summary>
                    /// <para>The ID of the annotation task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ddce607f-f537-4ebd-9914-cf45671defb9</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionId { get; set; }

                    /// <summary>
                    /// <para>The session ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ddce607f-f537-4ebd-9914-cf45671defb9</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionSessionId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionSessionId { get; set; }

                    /// <summary>
                    /// <para>The bot ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ddce607f-f537-4ebd-9914-cf45671defb9</para>
                    /// </summary>
                    [NameInMap("BotId")]
                    [Validation(Required=false)]
                    public string BotId { get; set; }

                    /// <summary>
                    /// <para>The content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[]</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>Create</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Create")]
                    [Validation(Required=false)]
                    public bool? Create { get; set; }

                    /// <summary>
                    /// <para>The time when the item was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1683858248778</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <para>Delete this item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Delete")]
                    [Validation(Required=false)]
                    public bool? Delete { get; set; }

                    /// <summary>
                    /// <para>The dialog ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2991201</para>
                    /// </summary>
                    [NameInMap("DialogId")]
                    [Validation(Required=false)]
                    public long? DialogId { get; set; }

                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ddce607f-f537-4ebd-9914-cf45671defb9</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The intent ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>119839</para>
                    /// </summary>
                    [NameInMap("IntentId")]
                    [Validation(Required=false)]
                    public long? IntentId { get; set; }

                    /// <summary>
                    /// <para>The time when the item was last modified.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1683858248778</para>
                    /// </summary>
                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public long? ModifiedTime { get; set; }

                }

                /// <summary>
                /// <para>The list of mappings between annotation information chats and attached tags.</para>
                /// </summary>
                [NameInMap("AnnotationMissionChatTagInfoList")]
                [Validation(Required=false)]
                public List<SaveAnnotationMissionSessionListRequestAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatTagInfoList> AnnotationMissionChatTagInfoList { get; set; }
                public class SaveAnnotationMissionSessionListRequestAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatTagInfoList : TeaModel {
                    /// <summary>
                    /// <para>The chat ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>977a45dc-b636-4407-9e98-9f572c709ada</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionChatId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionChatId { get; set; }

                    /// <summary>
                    /// <para>The ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>id</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionChatTagInfoId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionChatTagInfoId { get; set; }

                    /// <summary>
                    /// <para>The task ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>977a45dc-b636-4407-9e98-9f572c709ada</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionId { get; set; }

                    /// <summary>
                    /// <para>The session ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>977a45dc-b636-4407-9e98-9f572c709ada</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionSessionId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionSessionId { get; set; }

                    /// <summary>
                    /// <para>The tag ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>977a45dc-b636-4407-9e98-9f572c709ada</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionTagInfoId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionTagInfoId { get; set; }

                    /// <summary>
                    /// <para>The tag name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("AnnotationMissionTagInfoName")]
                    [Validation(Required=false)]
                    public string AnnotationMissionTagInfoName { get; set; }

                    /// <summary>
                    /// <para>Create</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Create")]
                    [Validation(Required=false)]
                    public bool? Create { get; set; }

                    /// <summary>
                    /// <para>End time of the annotation mission group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1679710866060</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <para>Delete</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Delete")]
                    [Validation(Required=false)]
                    public bool? Delete { get; set; }

                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>32be9d94-1346-4c4a-a4d0-ccd379f87013</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>Modified time</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1679710866060</para>
                    /// </summary>
                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public long? ModifiedTime { get; set; }

                }

                /// <summary>
                /// <para>The hotword annotation information for the annotation task chat.</para>
                /// </summary>
                [NameInMap("AnnotationMissionChatVocabularyInfoList")]
                [Validation(Required=false)]
                public List<SaveAnnotationMissionSessionListRequestAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatVocabularyInfoList> AnnotationMissionChatVocabularyInfoList { get; set; }
                public class SaveAnnotationMissionSessionListRequestAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatVocabularyInfoList : TeaModel {
                    /// <summary>
                    /// <para>The chat ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>77343553-cbc2-4487-a35c-869f1e86c573</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionChatId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionChatId { get; set; }

                    /// <summary>
                    /// <para>The ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>77343553-cbc2-4487-a35c-869f1e86c573</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionChatVocabularyInfoId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionChatVocabularyInfoId { get; set; }

                    /// <summary>
                    /// <para>The ID of the annotation task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>977a45dc-b636-4407-9e98-9f572c709ada</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionId { get; set; }

                    /// <summary>
                    /// <para>The session ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>77343553-cbc2-4487-a35c-869f1e86c573</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionSessionId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionSessionId { get; set; }

                    /// <summary>
                    /// <para>Create</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Create")]
                    [Validation(Required=false)]
                    public bool? Create { get; set; }

                    /// <summary>
                    /// <para>The time when the item was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1677552860720</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <para>Delete</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Delete")]
                    [Validation(Required=false)]
                    public bool? Delete { get; set; }

                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>77343553-cbc2-4487-a35c-869f1e86c573</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The time when the item was last modified.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1679283408230</para>
                    /// </summary>
                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public long? ModifiedTime { get; set; }

                    /// <summary>
                    /// <para>The content of the hotword annotation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[]</para>
                    /// </summary>
                    [NameInMap("Vocabulary")]
                    [Validation(Required=false)]
                    public string Vocabulary { get; set; }

                    /// <summary>
                    /// <para>The description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>售后咨询</para>
                    /// </summary>
                    [NameInMap("VocabularyDescription")]
                    [Validation(Required=false)]
                    public string VocabularyDescription { get; set; }

                    /// <summary>
                    /// <para>The hotword ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>77343553-cbc2-4487-a35c-869f1e86c573</para>
                    /// </summary>
                    [NameInMap("VocabularyId")]
                    [Validation(Required=false)]
                    public string VocabularyId { get; set; }

                    /// <summary>
                    /// <para>The name of the processing scenario.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>咨询</para>
                    /// </summary>
                    [NameInMap("VocabularyName")]
                    [Validation(Required=false)]
                    public string VocabularyName { get; set; }

                    /// <summary>
                    /// <para>The weight of the hotword. The value ranges from -6 to 5.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("VocabularyWeight")]
                    [Validation(Required=false)]
                    public int? VocabularyWeight { get; set; }

                }

                /// <summary>
                /// <para>The ID of the annotation task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ddce607f-f537-4ebd-9914-cf45671defb9</para>
                /// </summary>
                [NameInMap("AnnotationMissionId")]
                [Validation(Required=false)]
                public string AnnotationMissionId { get; set; }

                /// <summary>
                /// <para>The session ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c88cc004-de69-4eee-aa5f-2efed533a54e</para>
                /// </summary>
                [NameInMap("AnnotationMissionSessionId")]
                [Validation(Required=false)]
                public string AnnotationMissionSessionId { get; set; }

                /// <summary>
                /// <para>The annotation status.</para>
                /// <list type="bullet">
                /// <item><description><para>0: UNDO</para>
                /// </description></item>
                /// <item><description><para>1: DOING</para>
                /// </description></item>
                /// <item><description><para>2: DONE</para>
                /// </description></item>
                /// <item><description><para>3: CLOSED</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AnnotationStatus")]
                [Validation(Required=false)]
                public int? AnnotationStatus { get; set; }

                /// <summary>
                /// <para>The content of the robot\&quot;s response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;Answer\&quot;: u\&quot;\u53c2\u8003\u6587\u6863\uff1a<a href="https://help.aliyun.com/document_detail/181325.html%5C%5C">https://help.aliyun.com/document_detail/181325.html\\</a>&quot;, \&quot;QuestionId\&quot;: 372858, \&quot;Uuid\&quot;: \&quot;ac14000516762684770197536d0044\&quot;}</para>
                /// </summary>
                [NameInMap("Answer")]
                [Validation(Required=false)]
                public string Answer { get; set; }

                /// <summary>
                /// <para>The Automatic Speech Recognition (ASR) annotation status.</para>
                /// <list type="bullet">
                /// <item><description><para>0: UNDO</para>
                /// </description></item>
                /// <item><description><para>1: DOING</para>
                /// </description></item>
                /// <item><description><para>2: DONE</para>
                /// </description></item>
                /// <item><description><para>3: CLOSED</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AsrAnnotationStatus")]
                [Validation(Required=false)]
                public int? AsrAnnotationStatus { get; set; }

                /// <summary>
                /// <para>The time when the chat was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1679629770336</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5ec263fa-c8de-46f4-b844-6fb8275bb645</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The semantic tagging status.</para>
                /// <list type="bullet">
                /// <item><description><para>0: UNDO</para>
                /// </description></item>
                /// <item><description><para>1: DOING</para>
                /// </description></item>
                /// <item><description><para>2: DONE</para>
                /// </description></item>
                /// <item><description><para>3: CLOSED</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IntentAnnotationStatus")]
                [Validation(Required=false)]
                public int? IntentAnnotationStatus { get; set; }

                /// <summary>
                /// <para>The time when the chat was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1629360780000</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public long? ModifiedTime { get; set; }

                /// <summary>
                /// <para>The time when the chat was triggered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1682493047418</para>
                /// </summary>
                [NameInMap("OccurTime")]
                [Validation(Required=false)]
                public long? OccurTime { get; set; }

                /// <summary>
                /// <para>The ASR result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("OriginalAsrResult")]
                [Validation(Required=false)]
                public string OriginalAsrResult { get; set; }

                /// <summary>
                /// <para>The serial number of the current session interaction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1475140522</para>
                /// </summary>
                [NameInMap("SequenceId")]
                [Validation(Required=false)]
                public string SequenceId { get; set; }

                /// <summary>
                /// <para>The annotation action. Valid values: 1: Correct. 20: Matching error (not optimized). 21: Matching error (optimized). 3: Not covered. 4: Invalid.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SubStatus")]
                [Validation(Required=false)]
                public int? SubStatus { get; set; }

                /// <summary>
                /// <para>The tag annotation status.</para>
                /// <list type="bullet">
                /// <item><description><para>0: UNDO</para>
                /// </description></item>
                /// <item><description><para>1: DOING</para>
                /// </description></item>
                /// <item><description><para>2: DONE</para>
                /// </description></item>
                /// <item><description><para>3: CLOSED</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TagAnnotationStatus")]
                [Validation(Required=false)]
                public int? TagAnnotationStatus { get; set; }

                /// <summary>
                /// <para>The transcription error flag.</para>
                /// <list type="bullet">
                /// <item><description><para>0: No</para>
                /// </description></item>
                /// <item><description><para>1: Yes</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TranslationError")]
                [Validation(Required=false)]
                public int? TranslationError { get; set; }

            }

            /// <summary>
            /// <para>The ID of the annotation task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c88cc004-de69-4eee-aa5f-2efed533a54e</para>
            /// </summary>
            [NameInMap("AnnotationMissionId")]
            [Validation(Required=false)]
            public string AnnotationMissionId { get; set; }

            /// <summary>
            /// <para>The session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c88cc004-de69-4eee-aa5f-2efed533a54e</para>
            /// </summary>
            [NameInMap("AnnotationMissionSessionId")]
            [Validation(Required=false)]
            public string AnnotationMissionSessionId { get; set; }

            /// <summary>
            /// <para>The annotation status.</para>
            /// <list type="bullet">
            /// <item><description><para>0: UNDO</para>
            /// </description></item>
            /// <item><description><para>1: DOING</para>
            /// </description></item>
            /// <item><description><para>2: DONE</para>
            /// </description></item>
            /// <item><description><para>3: CLOSED</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AnnotationStatus")]
            [Validation(Required=false)]
            public int? AnnotationStatus { get; set; }

            /// <summary>
            /// <para>The time when the session was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-14T02:01:23Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>77343553-cbc2-4487-a35c-869f1e86c573</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The task group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>29e669bd-a9d1-4529-98cd-c2b0549bcf53</para>
            /// </summary>
            [NameInMap("JobGroupId")]
            [Validation(Required=false)]
            public string JobGroupId { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>593aaf5e-1275-4add-9990-22696385dc6e</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The time when the session was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683858248778</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            /// <summary>
            /// <para>The scenario ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e4f32632-2e56-4399-9fec-47bdbaeefdf6</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <para>For an outbound call, this is the task ID. For navigation, this is the conversation ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e6271044-b4b2-4ad8-ade4-c720be023538</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        /// <summary>
        /// <para>The list of sessions in JSON format.</para>
        /// <remarks>
        /// <para>This parameter has the same function as the AnnotationMissionSessionList parameter. You can specify either of them. The JSON field is a parameter of AnnotationMissionSessionList.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;jobGroupId&quot;:&quot;4093e364-57dc-4a89-83e0-a88454642596&quot;,&quot;modifiedTime&quot;:1744971010000,&quot;instanceId&quot;:&quot;00b37342-e759-4fe5-b296-aef775933af0&quot;,&quot;version&quot;:0,&quot;annotationMissionId&quot;:&quot;3d4bfd93-0d16-4873-9d77-e4fb1771e5cf&quot;,&quot;createTime&quot;:1744971010000,&quot;annotationMissionSessionId&quot;:&quot;42032063-8ef2-48e1-bc99-587b51581742&quot;,&quot;scriptId&quot;:&quot;bc50d543-6d52-4df8-8fb0-50f31ee9c1ff&quot;,&quot;sessionId&quot;:&quot;641a2c43-5e2a-4535-8a4d-c66d4b4258d6&quot;,&quot;jobId&quot;:&quot;fa54c5bb-d8a7-40ae-a32e-9a4a0c734ce5&quot;,&quot;annotationStatus&quot;:2,&quot;debugConversation&quot;:false}]</para>
        /// </summary>
        [NameInMap("AnnotationMissionSessionListJsonString")]
        [Validation(Required=false)]
        public string AnnotationMissionSessionListJsonString { get; set; }

        /// <summary>
        /// <para>The environment.</para>
        /// <list type="bullet">
        /// <item><description><para>0: NONE</para>
        /// </description></item>
        /// <item><description><para>1: Private cloud</para>
        /// </description></item>
        /// <item><description><para>2: Public cloud</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Environment")]
        [Validation(Required=false)]
        public long? Environment { get; set; }

        /// <summary>
        /// <para>The user\&quot;s nickname.</para>
        /// 
        /// <b>Example:</b>
        /// <para>用户</para>
        /// </summary>
        [NameInMap("UserNick")]
        [Validation(Required=false)]
        public string UserNick { get; set; }

    }

}
