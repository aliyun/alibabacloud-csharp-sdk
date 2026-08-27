// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListDataAgentSkillMetaResponseBody : TeaModel {
        /// <summary>
        /// <para>The response struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDataAgentSkillMetaResponseBodyData Data { get; set; }
        public class ListDataAgentSkillMetaResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of data content.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<ListDataAgentSkillMetaResponseBodyDataContent> Content { get; set; }
            public class ListDataAgentSkillMetaResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud account ID of the parent account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16738266********</para>
                /// </summary>
                [NameInMap("AliyunParentUid")]
                [Validation(Required=false)]
                public string AliyunParentUid { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud account ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20372822********</para>
                /// </summary>
                [NameInMap("AliyunUid")]
                [Validation(Required=false)]
                public string AliyunUid { get; set; }

                /// <summary>
                /// <para>The name of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HaoY*****</para>
                /// </summary>
                [NameInMap("CreatorUserName")]
                [Validation(Required=false)]
                public string CreatorUserName { get; set; }

                /// <summary>
                /// <para>The skill description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is a demo skill description.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether the skill is available. Valid values: true and false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public int? Enabled { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-12-11T14:04:32.000+00:00</para>
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-12-11T14:04:32.000+00:00</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The skill parsing error message. This parameter is returned when the skill status is INVALID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SKILL.md file not exist.</para>
                /// </summary>
                [NameInMap("ParseError")]
                [Validation(Required=false)]
                public string ParseError { get; set; }

                /// <summary>
                /// <para>The region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The source of the skill. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>User: a skill uploaded by the user.</description></item>
                /// <item><description>Agent: a skill derived from Agent analysis.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>User</para>
                /// </summary>
                [NameInMap("SkillFrom")]
                [Validation(Required=false)]
                public string SkillFrom { get; set; }

                /// <summary>
                /// <para>The skill ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ski-04pomiln*************j0</para>
                /// </summary>
                [NameInMap("SkillId")]
                [Validation(Required=false)]
                public string SkillId { get; set; }

                /// <summary>
                /// <para>The skill name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>data-query-skill</para>
                /// </summary>
                [NameInMap("SkillName")]
                [Validation(Required=false)]
                public string SkillName { get; set; }

                /// <summary>
                /// <para>The skill status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>INIT: not ready.</description></item>
                /// <item><description>ACTIVE: active.</description></item>
                /// <item><description>INVALID: invalid.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ACTIVE</para>
                /// </summary>
                [NameInMap("SkillStatus")]
                [Validation(Required=false)]
                public string SkillStatus { get; set; }

                /// <summary>
                /// <para>The workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>56kv1pvl9uvt9**********bb</para>
                /// </summary>
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of records per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TotalElements")]
            [Validation(Required=false)]
            public long? TotalElements { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public long? TotalPages { get; set; }

        }

        /// <summary>
        /// <para>The error code returned when the request is abnormal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidTid</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Specified parameter Tid is not valid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>E0D21075-CD3E-4D98-8264-FD8AD04A63B6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.                                 </description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
