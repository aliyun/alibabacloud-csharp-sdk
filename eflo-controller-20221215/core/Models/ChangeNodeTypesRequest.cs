// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ChangeNodeTypesRequest : TeaModel {
        /// <summary>
        /// <para>A list of node IDs. You can specify a maximum of 10 nodes in a single request.</para>
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public List<string> NodeIds { get; set; }

        /// <summary>
        /// <para>The node specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpfs-enhanced</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

    }

}
