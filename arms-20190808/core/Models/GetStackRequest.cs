// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetStackRequest : TeaModel {
        /// <summary>
        /// <para>The exit timestamp of the method call. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1653641800</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The process identifier (PID) of the application. For more information about how to obtain the PID, see <a href="https://www.alibabacloud.com/help/zh/doc-detail/186100.htm?spm=a2cdw.13409063.0.0.7a72281f0bkTfx#title-imy-7gj-qhr">Obtain the PID of an application</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eb4zdose6v@36bab313a******</para>
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the remote procedure call (RPC) mode. You can obtain the ID by calling the <b>GetTrace</b> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.1</para>
        /// </summary>
        [NameInMap("RpcID")]
        [Validation(Required=false)]
        public string RpcID { get; set; }

        /// <summary>
        /// <para>The span ID of the trace. It is displayed on the Trace Explorer page in the ARMS console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>88c32dfa4b******</para>
        /// </summary>
        [NameInMap("SpanID")]
        [Validation(Required=false)]
        public string SpanID { get; set; }

        /// <summary>
        /// <para>The entry timestamp of the method call. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1653555396</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The trace ID. It is displayed on the <b>Trace Explorer</b> page in the Application Real-Time Monitoring Service (ARMS) console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a5800611641470044457853******</para>
        /// </summary>
        [NameInMap("TraceID")]
        [Validation(Required=false)]
        public string TraceID { get; set; }

    }

}
