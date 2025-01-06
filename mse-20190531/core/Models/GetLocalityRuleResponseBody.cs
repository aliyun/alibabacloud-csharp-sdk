// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetLocalityRuleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;pageNumber&quot;:0,
        ///   &quot;namespaceId&quot;:&quot;cn-hangzhou&quot;,
        ///   &quot;enable&quot;:false,
        ///   &quot;appId&quot;:&quot;hkhon1po62@3aa3582********&quot;,
        ///   &quot;pageSize&quot;:0,
        ///   &quot;region&quot;:&quot;cn-hangzhou&quot;,
        ///   &quot;routeRules&quot;:[
        ///     {
        ///       &quot;threshold&quot;:0.2,
        ///       &quot;tags&quot;:[]
        ///     }
        ///   ]
        /// }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D3971C60-3F07-58B0-8EA0-A194********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
