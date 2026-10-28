// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetABMetricGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of the ABTest metrics, separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2</para>
        /// </summary>
        [NameInMap("ABMetricIds")]
        [Validation(Required=false)]
        public string ABMetricIds { get; set; }

        /// <summary>
        /// <para>The names of the ABTest metrics, separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pv,uv</para>
        /// </summary>
        [NameInMap("ABMetricNames")]
        [Validation(Required=false)]
        public string ABMetricNames { get; set; }

        /// <summary>
        /// <para>The description of the metric group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Traffic-related metrics</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the metric group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>visits</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2799614***</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>Indicates whether the metric group is real-time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Realtime")]
        [Validation(Required=false)]
        public bool? Realtime { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01D22D08-BA20-5F35-8302-99115F288220</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the scene. You can obtain the ID by calling the <a href="https://icms.alibaba-inc.com/content/learn/pai?l=1&m=16768&n=4298955">ListScenes</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

    }

}
