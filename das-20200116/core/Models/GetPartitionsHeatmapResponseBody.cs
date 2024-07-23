// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetPartitionsHeatmapResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The hot data of the PolarDB-X 2.0 instance. The data is returned in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;boundAxis&quot;: [
        ///         {
        ///             &quot;bound&quot;: &quot;A,B,C,D&quot;,
        ///             &quot;labels&quot;: [
        ///                 &quot;L1&quot;,
        ///                 &quot;L2&quot;,
        ///                 &quot;L3&quot;,
        ///                 &quot;L4&quot;
        ///             ],
        ///             &quot;rows&quot;: 3171
        ///         },
        ///         {
        ///             &quot;bound&quot;: &quot;A,B,C,D&quot;,
        ///             &quot;labels&quot;: [
        ///                 &quot;L1&quot;,
        ///                 &quot;L2&quot;,
        ///                 &quot;L3&quot;,
        ///                 &quot;L4&quot;
        ///             ],
        ///             &quot;rows&quot;: 277128
        ///         }
        ///     ],
        ///     &quot;dataMap&quot;: {
        ///         &quot;READ_WRITTEN_ROWS&quot;: [
        ///             [
        ///                 0,
        ///                 0,
        ///                 0
        ///             ],
        ///             [
        ///                 0,
        ///                 0,
        ///                 0
        ///             ]
        ///         ]
        ///     },
        ///     &quot;timeAxis&quot;: [
        ///         1671701056070,
        ///         1671701116551,
        ///         1671701177020
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para> If the request was successful, <b>Successful</b> is returned. If the request failed, an error message that contains information such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D00DB161-FEF6-5428-B37A-8D29A4C2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
