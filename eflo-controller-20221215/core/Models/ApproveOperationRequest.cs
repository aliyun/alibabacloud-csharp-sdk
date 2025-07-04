// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ApproveOperationRequest : TeaModel {
        /// <summary>
        /// <para>The node ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e01-cn-zvp2tgykr08</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The O\&amp;M operation type</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>RepairMachine</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RepairMachine</para>
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

    }

}
