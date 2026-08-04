// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListNodeTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>A collection of node types.</para>
        /// </summary>
        [NameInMap("NodeTypes")]
        [Validation(Required=false)]
        public List<NodeType> NodeTypes { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Statistics for the node types that match the filter criteria.</para>
        /// </summary>
        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public List<NodeTypeStatistic> Statistics { get; set; }

    }

}
