// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class MetricDefinition : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>train dataset oob score</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>train:oob_score</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>.<em>train:oob_score=([-+]?[0-9]</em>\.?[0-9]+(?:[eE][-+]?[0-9]+)?).*</para>
        /// </summary>
        [NameInMap("Regex")]
        [Validation(Required=false)]
        public string Regex { get; set; }

    }

}
