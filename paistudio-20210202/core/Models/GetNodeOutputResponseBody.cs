// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class GetNodeOutputResponseBody : TeaModel {
        [NameInMap("AlgoName")]
        [Validation(Required=false)]
        public string AlgoName { get; set; }

        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MaxComputeTable</para>
        /// </summary>
        [NameInMap("LocationType")]
        [Validation(Required=false)]
        public string LocationType { get; set; }

        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>601FD8B1-78EB-5220-844C-92AC2EDAF7E1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Model</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;name&quot;: &quot;model_flow_wayrh3k605s7i51wey_node_7n3tstbuhr36t0ukiz_model&quot;,
        ///   &quot;modelType&quot;: &quot;OfflineModel&quot;,
        ///   &quot;labelCol&quot;: &quot;_c2&quot;,
        ///   &quot;features&quot;: &quot;pm10,so2,co,no2&quot;,
        ///   &quot;gmtCreateTime&quot;: &quot;2021-01-21T17:12:35.232Z&quot;,
        ///   &quot;gmtModifiedTime&quot;: &quot;2021-01-21T17:12:35.232Z&quot;,
        ///   &quot;parameters&quot;: {
        ///     &quot;epsilon&quot;: &quot;0.000001&quot;,
        ///     &quot;enableSparse&quot;: &quot;false&quot;,
        ///     &quot;regularizedLevel&quot;: &quot;1&quot;,
        ///     &quot;roleArn&quot;: &quot;true&quot;,
        ///     &quot;maxIter&quot;: &quot;100&quot;,
        ///     &quot;regularizedType&quot;: &quot;None&quot;,
        ///     &quot;generatePmml&quot;: &quot;true&quot;
        ///   }
        /// }</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public Dictionary<string, object> Value { get; set; }

    }

}
