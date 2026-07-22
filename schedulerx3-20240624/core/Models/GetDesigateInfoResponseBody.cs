// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class GetDesigateInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDesigateInfoResponseBodyData Data { get; set; }
        public class GetDesigateInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The type of the specified machine. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: worker.</description></item>
            /// <item><description>2: label.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("DesignateType")]
            [Validation(Required=false)]
            public int? DesignateType { get; set; }

            /// <summary>
            /// <para>Indicates whether failover is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Transferable")]
            [Validation(Required=false)]
            public bool? Transferable { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Parameter check error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each API request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1DF6732E-15D8-5E1F-95E3-C10077F556B5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful.</description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
