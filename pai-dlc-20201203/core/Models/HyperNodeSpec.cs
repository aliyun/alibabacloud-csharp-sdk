// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class HyperNodeSpec : TeaModel {
        /// <summary>
        /// <para>The name of the HyperNode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mg1234567</para>
        /// </summary>
        [NameInMap("HyperNodeName")]
        [Validation(Required=false)]
        public string HyperNodeName { get; set; }

        /// <summary>
        /// <para>The comma-separated names of the specified nodes in the HyperNode. If you leave this parameter empty, all nodes in the HyperNode are specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lingjxxxxxxxx</para>
        /// </summary>
        [NameInMap("NodeNames")]
        [Validation(Required=false)]
        public string NodeNames { get; set; }

    }

}
