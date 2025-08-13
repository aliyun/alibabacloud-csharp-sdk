// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class ModifyRuleStatusRequest : TeaModel {
        /// <summary>
        /// <para>Set the language type for requests and received messages, default value is <b>zh</b>. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>UID of the applicant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1519714049632764</para>
        /// </summary>
        [NameInMap("applyUserId")]
        [Validation(Required=false)]
        public string ApplyUserId { get; set; }

        /// <summary>
        /// <para>Name of the applicant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("applyUserName")]
        [Validation(Required=false)]
        public string ApplyUserName { get; set; }

        /// <summary>
        /// <para>Approval remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>申请发布上线</para>
        /// </summary>
        [NameInMap("auditRemark")]
        [Validation(Required=false)]
        public string AuditRemark { get; set; }

        /// <summary>
        /// <para>UID of the auditor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1519714049632764</para>
        /// </summary>
        [NameInMap("auditUserId")]
        [Validation(Required=false)]
        public string AuditUserId { get; set; }

        /// <summary>
        /// <para>Name of the auditor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("auditUserName")]
        [Validation(Required=false)]
        public string AuditUserName { get; set; }

        /// <summary>
        /// <para>Primary key ID of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6843</para>
        /// </summary>
        [NameInMap("consoleRuleId")]
        [Validation(Required=false)]
        public long? ConsoleRuleId { get; set; }

        /// <summary>
        /// <para>Event type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MAIN</para>
        /// </summary>
        [NameInMap("eventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>Region code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>Audit status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DRAFT_TO_RUNNING</para>
        /// </summary>
        [NameInMap("ruleAuditType")]
        [Validation(Required=false)]
        public string RuleAuditType { get; set; }

        /// <summary>
        /// <para>Policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101544</para>
        /// </summary>
        [NameInMap("ruleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>Primary key ID of the policy version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11519</para>
        /// </summary>
        [NameInMap("ruleVersionId")]
        [Validation(Required=false)]
        public long? RuleVersionId { get; set; }

    }

}
