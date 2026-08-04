// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class BindingPolicy : TeaModel {
        /// <summary>
        /// <para>A list of node IDs to exclude from scheduling.</para>
        /// </summary>
        [NameInMap("ExcludeNodes")]
        [Validation(Required=false)]
        public List<string> ExcludeNodes { get; set; }

        /// <summary>
        /// <para>A list of node IDs to include in the scheduling.</para>
        /// </summary>
        [NameInMap("IncludeNodes")]
        [Validation(Required=false)]
        public List<string> IncludeNodes { get; set; }

        /// <summary>
        /// <para>The number of nodes to be selected by the scheduler.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("NodeSpecCount")]
        [Validation(Required=false)]
        public long? NodeSpecCount { get; set; }

    }

}
