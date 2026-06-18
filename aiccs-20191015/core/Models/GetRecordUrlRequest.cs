// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetRecordUrlRequest : TeaModel {
        /// <summary>
        /// <para>The session ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001067****</para>
        /// </summary>
        [NameInMap("Acid")]
        [Validation(Required=false)]
        public string Acid { get; set; }

        /// <summary>
        /// <para>The Artificial Intelligence Cloud Call Service (AICCS) instance ID. You can obtain it in the <a href="https://aiccs.console.aliyun.com/overview">Artificial Intelligence Cloud Call Service console</a> &gt; Instance Management.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre-cn-****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The call type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DUP_CALL</b>: Incoming and outgoing calls.</description></item>
        /// <item><description><b>IVR_CALL</b>: IVR outbound call.</description></item>
        /// <item><description><b>SMART_CALL</b>: Intelligent outbound call.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DUP_CALL</para>
        /// </summary>
        [NameInMap("RecordType")]
        [Validation(Required=false)]
        public string RecordType { get; set; }

    }

}
