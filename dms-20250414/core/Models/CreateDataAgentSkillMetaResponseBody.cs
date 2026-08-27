// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class CreateDataAgentSkillMetaResponseBody : TeaModel {
        /// <summary>
        /// <para>The response struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateDataAgentSkillMetaResponseBodyData Data { get; set; }
        public class CreateDataAgentSkillMetaResponseBodyData : TeaModel {
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
            /// <para>The creator name.</para>
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
            /// <para>The skill parsing error message.</para>
            /// <list type="bullet">
            /// <item><description>When the skill status is INVALID, the parsing error message is returned.</description></item>
            /// </list>
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
            /// <para>The skill source.</para>
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
            /// <item><description>INIT: Not ready.</description></item>
            /// <item><description>ACTIVE: Active.</description></item>
            /// <item><description>INVALID: Invalid.</description></item>
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
            /// <para>11if52e44**********edbv6</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidTid</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned when a system-level request failure occurs.</para>
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
