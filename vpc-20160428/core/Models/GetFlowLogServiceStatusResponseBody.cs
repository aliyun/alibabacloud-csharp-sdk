// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetFlowLogServiceStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the flow log feature is activated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: activated.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: not activated. You can call the <a href="https://help.aliyun.com/document_detail/449637.html">OpenFlowLogService</a> operation to activate the flow log feature.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54B48E3D-DF70-471B-AA93-06F83A1B457</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
