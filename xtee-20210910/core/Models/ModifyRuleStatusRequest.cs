// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class ModifyRuleStatusRequest : TeaModel {
        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The UID of the user who initiated the approval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1519714049632764</para>
        /// </summary>
        [NameInMap("applyUserId")]
        [Validation(Required=false)]
        public string ApplyUserId { get; set; }

        /// <summary>
        /// <para>The name of the user who initiated the approval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("applyUserName")]
        [Validation(Required=false)]
        public string ApplyUserName { get; set; }

        /// <summary>
        /// <para>The remarks for the approval request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>申请发布上线</para>
        /// </summary>
        [NameInMap("auditRemark")]
        [Validation(Required=false)]
        public string AuditRemark { get; set; }

        /// <summary>
        /// <para>The UID of the approver.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1519714049632764</para>
        /// </summary>
        [NameInMap("auditUserId")]
        [Validation(Required=false)]
        public string AuditUserId { get; set; }

        /// <summary>
        /// <para>The name of the approver.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("auditUserName")]
        [Validation(Required=false)]
        public string AuditUserName { get; set; }

        /// <summary>
        /// <para>The primary key ID of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6843</para>
        /// </summary>
        [NameInMap("consoleRuleId")]
        [Validation(Required=false)]
        public long? ConsoleRuleId { get; set; }

        /// <summary>
        /// <para>The event type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MAIN</para>
        /// </summary>
        [NameInMap("eventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The region code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>The approval status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DRAFT_TO_RUNNING</para>
        /// </summary>
        [NameInMap("ruleAuditType")]
        [Validation(Required=false)]
        public string RuleAuditType { get; set; }

        /// <summary>
        /// <para>The policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101544</para>
        /// </summary>
        [NameInMap("ruleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The primary key ID of the policy version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11519</para>
        /// </summary>
        [NameInMap("ruleVersionId")]
        [Validation(Required=false)]
        public long? RuleVersionId { get; set; }

    }

}
