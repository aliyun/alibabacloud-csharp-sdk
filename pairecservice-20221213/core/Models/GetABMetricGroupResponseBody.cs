// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetABMetricGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>A comma-separated list of A/B testing metric IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2</para>
        /// </summary>
        [NameInMap("ABMetricIds")]
        [Validation(Required=false)]
        public string ABMetricIds { get; set; }

        /// <summary>
        /// <para>A comma-separated list of A/B testing metric names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pv,uv</para>
        /// </summary>
        [NameInMap("ABMetricNames")]
        [Validation(Required=false)]
        public string ABMetricNames { get; set; }

        /// <summary>
        /// <para>The metric group description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>访问量相关指标</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The metric group name.</para>
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
        /// <para>Whether the metric group is a real-time metric group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Realtime")]
        [Validation(Required=false)]
        public bool? Realtime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01D22D08-BA20-5F35-8302-99115F288220</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The scene ID. You can get this ID by calling the <a href="https://icms.alibaba-inc.com/content/learn/pai?l=1%5C&m=16768%5C&n=4298955">ListScenes</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

    }

}
