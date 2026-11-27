// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class InsertTaskDetailRequest : TeaModel {
        /// <summary>
        /// <para>The outbound call information.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;dnis&quot;:&quot;1&quot;,&quot;memberId&quot;:1133,&quot;memberName&quot;:&quot;Test member&quot;,&quot;priority&quot;:10}]</para>
        /// </summary>
        [NameInMap("CallInfos")]
        [Validation(Required=false)]
        public string CallInfos { get; set; }

        /// <summary>
        /// <para>Instance ID of the AICCS instance. You can obtain instance ID from the Artificial Intelligence Cloud Call Service console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the outbound task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120001</para>
        /// </summary>
        [NameInMap("OutboundTaskId")]
        [Validation(Required=false)]
        public long? OutboundTaskId { get; set; }

    }

}
