// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class DeployRankingSystemRequest : TeaModel {
        /// <summary>
        /// <para>The schema of the response parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;meta&quot;: {
        ///     &quot;autoDeploy&quot;: true,
        ///     &quot;autoDeployAuc&quot;: &quot;0.9&quot;,
        ///     &quot;conf&quot;:&quot;&quot;,
        ///     &quot;predictEngineType&quot;: &quot;EAS&quot;,
        ///     &quot;predictEngine&quot;:{
        ///         &quot;resourceId&quot;: &quot;eas-oljkkdrggxhx7eizjd&quot;
        ///     }
        ///   }</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public Dictionary<string, object> Body { get; set; }

    }

}
