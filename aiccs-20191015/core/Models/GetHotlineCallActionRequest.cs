// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetHotlineCallActionRequest : TeaModel {
        /// <summary>
        /// <para>Hotline Custom Parameter in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;time&quot;:1}</para>
        /// </summary>
        [NameInMap("Acc")]
        [Validation(Required=false)]
        public string Acc { get; set; }

        /// <summary>
        /// <para>Agent account name, which is the phone number or mailbox specified during account registration. It is unique within the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:username@example.com">username@example.com</a></para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>Operation Type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Hotline.</description></item>
        /// <item><description><b>2</b>: Online.</description></item>
        /// <item><description><b>3</b>: Ticket.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Act")]
        [Validation(Required=false)]
        public int? Act { get; set; }

        /// <summary>
        /// <para>Business Custom Parameter in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:123}</para>
        /// </summary>
        [NameInMap("Biz")]
        [Validation(Required=false)]
        public string Biz { get; set; }

        /// <summary>
        /// <para>Unique ID of the customer request. Used for idempotency validation. You can generate it by using a UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46c1341e-2648-447a-9b11-70b6a298d9****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Source type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>hotlinebs_out</b>: Hotline.</description></item>
        /// <item><description><b>ticket_out</b>: Ticket.</description></item>
        /// <item><description><b>other_system_out</b>: Other system.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hotlinebs_out</para>
        /// </summary>
        [NameInMap("FromSource")]
        [Validation(Required=false)]
        public string FromSource { get; set; }

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

    }

}
