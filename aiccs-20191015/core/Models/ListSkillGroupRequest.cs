// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ListSkillGroupRequest : TeaModel {
        /// <summary>
        /// <para>The skill group channel type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Returns all skill groups.</description></item>
        /// <item><description><b>1</b>: Voice skill group.</description></item>
        /// <item><description><b>2</b>: Chat skill group.</description></item>
        /// <item><description><b>3</b>: Chat and voice skill group.</description></item>
        /// <item><description><b>4</b>: Ticket skill group.</description></item>
        /// <item><description><b>5</b>: Voice and ticket skill group.</description></item>
        /// <item><description><b>6</b>: Chat and ticket skill group.</description></item>
        /// <item><description><b>7</b>: Chat, voice, and ticket skill group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public int? ChannelType { get; set; }

        /// <summary>
        /// <para>Unique ID of the customer request. Used for idempotency validation. You can generate it using UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46c1341e-2648-447a-****-70b6a298d94d</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Artificial Intelligence Cloud Call Service (AICCS) instance ID.<br>You can obtain it from <b>Instance Management</b> in the left-side navigation pane of the <a href="https://aiccs.console.aliyun.com/overview">Artificial Intelligence Cloud Call Service console</a>.</para>
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
