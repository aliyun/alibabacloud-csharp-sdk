// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetMediaConnectFlowResponseBody : TeaModel {
        /// <summary>
        /// <para>The response body.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public GetMediaConnectFlowResponseBodyContent Content { get; set; }
        public class GetMediaConnectFlowResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The creation time of the MediaConnect Flow instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-18T01:29:24Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether Input Failover is enabled for the flow. Valid values: <c>yes</c> and <c>no</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yes</para>
            /// </summary>
            [NameInMap("FlowFailover")]
            [Validation(Required=false)]
            public string FlowFailover { get; set; }

            /// <summary>
            /// <para>The ID of the MediaConnect Flow instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>34900dc6-90ec-4968-af3c-fcd87f231a5f</para>
            /// </summary>
            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

            /// <summary>
            /// <para>The name of the MediaConnect Flow instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliTestFlow</para>
            /// </summary>
            [NameInMap("FlowName")]
            [Validation(Required=false)]
            public string FlowName { get; set; }

            [NameInMap("FlowRegion")]
            [Validation(Required=false)]
            public string FlowRegion { get; set; }

            /// <summary>
            /// <para>The status of the MediaConnect Flow instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("FlowStatus")]
            [Validation(Required=false)]
            public string FlowStatus { get; set; }

            /// <summary>
            /// <para>The start time of the MediaConnect Flow instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-18T01:39:24Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>The description of the API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>FB503AEF-118E-1516-89E2-7B227EA1AC20</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The return code. A value of 0 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Retcode")]
        [Validation(Required=false)]
        public int? Retcode { get; set; }

    }

}
