// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class UpdateAlertStrategyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///             &quot;uid&quot;: &quot;uid-1&quot;,
        ///             &quot;name&quot;: &quot;test-name&quot;,
        ///             &quot;strategy&quot;: {
        ///                 &quot;clusters&quot;: [&quot;test-cluster-1&quot;,&quot;test-cluster-2&quot;],
        ///                 &quot;items&quot;: [&quot;test-item1&quot;,&quot;test-item2&quot;]
        ///             },
        ///             &quot;enabled&quot;: True
        /// }</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public object Data { get; set; }

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
