// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentMemberStruct : TeaModel {
        /// <summary>
        /// <para>确认信息结构体。</para>
        /// </summary>
        [NameInMap("acknowledge")]
        [Validation(Required=false)]
        public IncidentMemberStructAcknowledge Acknowledge { get; set; }
        public class IncidentMemberStructAcknowledge : TeaModel {
            /// <summary>
            /// <para>确认级别。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("breakLevel")]
            [Validation(Required=false)]
            public string BreakLevel { get; set; }

            /// <summary>
            /// <para>验证时间。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1741234567890</para>
            /// </summary>
            [NameInMap("verifyTime")]
            [Validation(Required=false)]
            public long? VerifyTime { get; set; }

        }

        /// <summary>
        /// <para>联系人ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>user-12345</para>
        /// </summary>
        [NameInMap("contactId")]
        [Validation(Required=false)]
        public string ContactId { get; set; }

        /// <summary>
        /// <para>联系人列表。</para>
        /// </summary>
        [NameInMap("contacts")]
        [Validation(Required=false)]
        public List<IncidentMemberStructContacts> Contacts { get; set; }
        public class IncidentMemberStructContacts : TeaModel {
            /// <summary>
            /// <para>通道。</para>
            /// 
            /// <b>Example:</b>
            /// <para>dingtalk</para>
            /// </summary>
            [NameInMap("channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }

            /// <summary>
            /// <para>联系人 ID（脱敏）</para>
            /// 
            /// <b>Example:</b>
            /// <para>user-12345</para>
            /// </summary>
            [NameInMap("contactMask")]
            [Validation(Required=false)]
            public string ContactMask { get; set; }

        }

        /// <summary>
        /// <para>升级阶段信息。</para>
        /// </summary>
        [NameInMap("escalation")]
        [Validation(Required=false)]
        public IncidentMemberStructEscalation Escalation { get; set; }
        public class IncidentMemberStructEscalation : TeaModel {
            /// <summary>
            /// <para>描述。</para>
            /// 
            /// <b>Example:</b>
            /// <para>通知运维团队</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>事件升级ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>escalation-001</para>
            /// </summary>
            [NameInMap("incidentEscalationId")]
            [Validation(Required=false)]
            public string IncidentEscalationId { get; set; }

            /// <summary>
            /// <para>名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>第一阶段</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>升级阶段索引。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("stageIndex")]
            [Validation(Required=false)]
            public string StageIndex { get; set; }

            /// <summary>
            /// <para>标题。</para>
            /// 
            /// <b>Example:</b>
            /// <para>告警升级至运维团队</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>事件ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>incident-001</para>
        /// </summary>
        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public string IncidentId { get; set; }

        /// <summary>
        /// <para>事件成员ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>member-001</para>
        /// </summary>
        [NameInMap("incidentMemberId")]
        [Validation(Required=false)]
        public string IncidentMemberId { get; set; }

        /// <summary>
        /// <para>调度组。</para>
        /// </summary>
        [NameInMap("scheduleGroup")]
        [Validation(Required=false)]
        public IncidentMemberStructScheduleGroup ScheduleGroup { get; set; }
        public class IncidentMemberStructScheduleGroup : TeaModel {
            /// <summary>
            /// <para>联系人ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>group-001</para>
            /// </summary>
            [NameInMap("contactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }

            /// <summary>
            /// <para>名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>夜间值班组</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>时间。</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-10-08 10:18:58</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

        /// <summary>
        /// <para>用户ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>4123456</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
