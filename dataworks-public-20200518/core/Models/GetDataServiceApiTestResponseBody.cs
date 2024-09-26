// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDataServiceApiTestResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataServiceApiTestResponseBodyData Data { get; set; }
        public class GetDataServiceApiTestResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>12343</para>
            /// </summary>
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public long? ApiId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("CostTime")]
            [Validation(Required=false)]
            public string CostTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&lt;span style=\&quot;color: #92D581;\&quot;&gt;INFO</span>] [16:15:13.240] resource group is 498774069027041[&lt;span style=\&quot;color: #92D581;\&quot;&gt;INFO</span>]</para>
            /// </summary>
            [NameInMap("DebugInfo")]
            [Validation(Required=false)]
            public string DebugInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&lt;span style=\&quot;color: #92D581;\&quot;&gt;INFO</span>] [16:15:13.240] resource group is 498774069027041[&lt;span style=\&quot;color: #92D581;\&quot;&gt;INFO</span>]</para>
            /// </summary>
            [NameInMap("NodesDebugInfo")]
            [Validation(Required=false)]
            public string NodesDebugInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;name&quot;:&quot;test&quot;}</para>
            /// </summary>
            [NameInMap("ParamMap")]
            [Validation(Required=false)]
            public string ParamMap { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RetCode")]
            [Validation(Required=false)]
            public long? RetCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;id&quot;:2}</para>
            /// </summary>
            [NameInMap("RetResult")]
            [Validation(Required=false)]
            public string RetResult { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FINISHED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>adssdsewe</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
