// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudQueryAgentSkillResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CloudQueryAgentSkillResponseBodyData Data { get; set; }
        public class CloudQueryAgentSkillResponseBodyData : TeaModel {
            /// <summary>
            /// <para>座席技能列表</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<CloudQueryAgentSkillResponseBodyDataList> List { get; set; }
            public class CloudQueryAgentSkillResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>座席id</para>
                /// 
                /// <b>Example:</b>
                /// <para>64</para>
                /// </summary>
                [NameInMap("AgentId")]
                [Validation(Required=false)]
                public long? AgentId { get; set; }

                /// <summary>
                /// <para>创建时间，格式: yyyy-MM-dd HH:mm:ss</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-04-20 10:00:00</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>企业编号</para>
                /// 
                /// <b>Example:</b>
                /// <para>7000002</para>
                /// </summary>
                [NameInMap("EnterpriseId")]
                [Validation(Required=false)]
                public long? EnterpriseId { get; set; }

                /// <summary>
                /// <para>queueSkill关系表中id</para>
                /// 
                /// <b>Example:</b>
                /// <para>99</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>skill的id</para>
                /// 
                /// <b>Example:</b>
                /// <para>79</para>
                /// </summary>
                [NameInMap("SkillId")]
                [Validation(Required=false)]
                public long? SkillId { get; set; }

                /// <summary>
                /// <para>技能值</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("SkillLevel")]
                [Validation(Required=false)]
                public long? SkillLevel { get; set; }

                /// <summary>
                /// <para>技能名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>skillname</para>
                /// </summary>
                [NameInMap("SkillName")]
                [Validation(Required=false)]
                public string SkillName { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5B0F201F-DCDA-45C2-AA92-1AE177F94991</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
