// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListLayersOutput : TeaModel {
        /// <summary>
        /// <para>The layers.</para>
        /// </summary>
        [NameInMap("layers")]
        [Validation(Required=false)]
        public List<Layer> Layers { get; set; }

        /// <summary>
        /// <para>The name of the start layer for the next query, which is also the token used to obtain more results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>next-layer-name</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
