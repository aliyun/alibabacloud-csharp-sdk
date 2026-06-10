// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetInstantScoreResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code  </para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, authorization succeeded.  </description></item>
        /// <item><description>Other status codes indicate authorization failed. When authorization fails, view the <c>message</c> field to obtain detailed error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetInstantScoreResponseBodyData Data { get; set; }
        public class GetInstantScoreResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Error score</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("error")]
            [Validation(Required=false)]
            public float? Error { get; set; }

            /// <summary>
            /// <para>Latency score</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("latency")]
            [Validation(Required=false)]
            public float? Latency { get; set; }

            /// <summary>
            /// <para>Load score</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("load")]
            [Validation(Required=false)]
            public float? Load { get; set; }

            /// <summary>
            /// <para>Saturation score</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("saturation")]
            [Validation(Required=false)]
            public float? Saturation { get; set; }

            /// <summary>
            /// <para>Total score</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public float? Total { get; set; }

        }

        /// <summary>
        /// <para>Error message  </para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, this field is empty.  </description></item>
        /// <item><description>Otherwise, this field contains the request error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Query no data</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D693121-C925-5154-8DF6-C09A8B369822</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
