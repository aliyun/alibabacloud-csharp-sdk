// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class MetricDefinition : TeaModel {
        /// <summary>
        /// <para>The description of the metric.</para>
        /// 
        /// <b>Example:</b>
        /// <para>训练损失函数。</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the metric.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>loss</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The regular expression to collect metrics from logs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>.<em>train:loss=([-+]?[0-9]</em>\\.?[0-9]+(?:[eE][-+]?[0-9]+)?).*</para>
        /// </summary>
        [NameInMap("Regex")]
        [Validation(Required=false)]
        public string Regex { get; set; }

    }

}
