// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class TransferCallToSkillGroupRequest : TeaModel {
        /// <summary>
        /// <para>The agent account name, which is the phone number or mailbox entered during account registration. It is unique within the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:username@example.com">username@example.com</a></para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>Hotline session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7719786</para>
        /// </summary>
        [NameInMap("CallId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        /// <summary>
        /// <para>Unique ID for the customer request. Used for idempotency validation. You can generate it using UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46c1341e-2648-447a-9b11-70b6a298d94d</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The connId in the WebSocket after an inbound call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7719788</para>
        /// </summary>
        [NameInMap("ConnectionId")]
        [Validation(Required=false)]
        public string ConnectionId { get; set; }

        /// <summary>
        /// <para>The holdConnId in the WebSocket after an inbound call (required only for two-step transfer).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HoldConnectionId")]
        [Validation(Required=false)]
        public string HoldConnectionId { get; set; }

        /// <summary>
        /// <para>Artificial Intelligence Cloud Call Service (AICCS) instance ID.
        /// You can obtain it from <b>Instance Management</b> in the left-side navigation pane of the <a href="https://aiccs.console.aliyun.com/overview">Artificial Intelligence Cloud Call Service console</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre-cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Default value: <b>true</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Single-step transfer.</description></item>
        /// <item><description><b>false</b>: Two-step transfer.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSingleTransfer")]
        [Validation(Required=false)]
        public bool? IsSingleTransfer { get; set; }

        /// <summary>
        /// <para>The jobId in the WebSocket after an inbound call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7719787</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>Skill group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>356543</para>
        /// </summary>
        [NameInMap("SkillGroupId")]
        [Validation(Required=false)]
        public long? SkillGroupId { get; set; }

        /// <summary>
        /// <para>Default value: <b>1</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Single-step transfer.</description></item>
        /// <item><description><b>2</b>: Two-step transfer.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
