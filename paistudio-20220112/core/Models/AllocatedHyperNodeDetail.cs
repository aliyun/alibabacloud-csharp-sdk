// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class AllocatedHyperNodeDetail : TeaModel {
        /// <summary>
        /// <para>The number of allocated nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AllocatedNodeNum")]
        [Validation(Required=false)]
        public long? AllocatedNodeNum { get; set; }

        /// <summary>
        /// <para>The number of idle nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("EmptyNodeNum")]
        [Validation(Required=false)]
        public long? EmptyNodeNum { get; set; }

        /// <summary>
        /// <para>The name of the hypernode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mg123456</para>
        /// </summary>
        [NameInMap("HyperNodeName")]
        [Validation(Required=false)]
        public string HyperNodeName { get; set; }

        /// <summary>
        /// <para>The total number of nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalNodeNum")]
        [Validation(Required=false)]
        public long? TotalNodeNum { get; set; }

    }

}
