// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ApproveOperationRequest : TeaModel {
        /// <summary>
        /// <para>Node ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>e01-cn-zvp2tgykr08</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>Operation Type</para>
        /// 
        /// <b>Example:</b>
        /// <para>RepairMachine</para>
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

    }

}
