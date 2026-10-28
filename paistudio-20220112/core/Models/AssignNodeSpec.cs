// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class AssignNodeSpec : TeaModel {
        /// <summary>
        /// <para>The anti-affinity node names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>node3</para>
        /// </summary>
        [NameInMap("AntiAffinityNodeNames")]
        [Validation(Required=false)]
        public string AntiAffinityNodeNames { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the specified node.</para>
        /// </summary>
        [NameInMap("EnableAssignNode")]
        [Validation(Required=false)]
        public bool? EnableAssignNode { get; set; }

        /// <summary>
        /// <para>The node names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lingjxxxx</para>
        /// </summary>
        [NameInMap("NodeNames")]
        [Validation(Required=false)]
        public string NodeNames { get; set; }

    }

}
