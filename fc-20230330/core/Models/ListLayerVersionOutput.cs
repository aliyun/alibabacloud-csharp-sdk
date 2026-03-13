// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListLayerVersionOutput : TeaModel {
        /// <summary>
        /// <para>The list of layer versions.</para>
        /// </summary>
        [NameInMap("layers")]
        [Validation(Required=false)]
        public List<Layer> Layers { get; set; }

        /// <summary>
        /// <para>The next version, which is used to return more results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("nextVersion")]
        [Validation(Required=false)]
        public int? NextVersion { get; set; }

    }

}
