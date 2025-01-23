// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDataServiceApiTestResponseBody : TeaModel {
        /// <summary>
        /// <para>Return object</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataServiceApiTestResponseBodyData Data { get; set; }
        public class GetDataServiceApiTestResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Test API Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>12343</para>
            /// </summary>
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public long? ApiId { get; set; }

            /// <summary>
            /// <para>Time consuming</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("CostTime")]
            [Validation(Required=false)]
            public string CostTime { get; set; }

            /// <summary>
            /// <para>Debug information</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&lt;span style=\&quot;color: #92D581;\&quot;&gt;INFO</span>] [16:15:13.240] resource group is 498774069027041[&lt;span style=\&quot;color: #92D581;\&quot;&gt;INFO</span>]</para>
            /// </summary>
            [NameInMap("DebugInfo")]
            [Validation(Required=false)]
            public string DebugInfo { get; set; }

            /// <summary>
            /// <para>Node Debug information</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&lt;span style=\&quot;color: #92D581;\&quot;&gt;INFO</span>] [16:15:13.240] resource group is 498774069027041[&lt;span style=\&quot;color: #92D581;\&quot;&gt;INFO</span>]</para>
            /// </summary>
            [NameInMap("NodesDebugInfo")]
            [Validation(Required=false)]
            public string NodesDebugInfo { get; set; }

            /// <summary>
            /// <para>Test API request parameters</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;name&quot;:&quot;test&quot;}</para>
            /// </summary>
            [NameInMap("ParamMap")]
            [Validation(Required=false)]
            public string ParamMap { get; set; }

            /// <summary>
            /// <para>The test API returns the code. If it is not completed, the data is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RetCode")]
            [Validation(Required=false)]
            public long? RetCode { get; set; }

            /// <summary>
            /// <para>Return data</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;id&quot;:2}</para>
            /// </summary>
            [NameInMap("RetResult")]
            [Validation(Required=false)]
            public string RetResult { get; set; }

            /// <summary>
            /// <para>Whether the task has been completed, including: RUNNING,FINISHED</para>
            /// 
            /// <b>Example:</b>
            /// <para>FINISHED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adssdsewe</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
