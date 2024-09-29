// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdateEnvPodMonitorResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateEnvPodMonitorResponseBodyData Data { get; set; }
        public class UpdateEnvPodMonitorResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether targets are matched.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Match successful.</para>
            /// </summary>
            [NameInMap("MatchedMsg")]
            [Validation(Required=false)]
            public string MatchedMsg { get; set; }

            /// <summary>
            /// <para>The number of matched targets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MatchedTargetCount")]
            [Validation(Required=false)]
            public string MatchedTargetCount { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C21AB7CF-B7AF-410F-BD61-82D1567F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
