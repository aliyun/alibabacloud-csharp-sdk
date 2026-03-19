// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTaskFlowEdgesByConditionResponseBody : TeaModel {
        [NameInMap("Edges")]
        [Validation(Required=false)]
        public ListTaskFlowEdgesByConditionResponseBodyEdges Edges { get; set; }
        public class ListTaskFlowEdgesByConditionResponseBodyEdges : TeaModel {
            [NameInMap("Edge")]
            [Validation(Required=false)]
            public List<ListTaskFlowEdgesByConditionResponseBodyEdgesEdge> Edge { get; set; }
            public class ListTaskFlowEdgesByConditionResponseBodyEdgesEdge : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("NodeEnd")]
                [Validation(Required=false)]
                public long? NodeEnd { get; set; }

                [NameInMap("NodeFrom")]
                [Validation(Required=false)]
                public long? NodeFrom { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request. You can use the ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D86249CD-422F-5ACF-85BA-9187C986AE0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
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
