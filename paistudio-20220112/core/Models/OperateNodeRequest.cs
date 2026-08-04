// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class OperateNodeRequest : TeaModel {
        /// <summary>
        /// <para>The operation to perform.</para>
        /// <list type="bullet">
        /// <item><description><para>Cordon: Disables scheduling on the node.</para>
        /// </description></item>
        /// <item><description><para>Uncordon: Enables scheduling on the node.</para>
        /// </description></item>
        /// <item><description><para>Drain: Evicts pods from the node.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cordon</para>
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// <para>The parameter settings for the node operation.</para>
        /// </summary>
        [NameInMap("OperationParameters")]
        [Validation(Required=false)]
        public NodeOperationParameters OperationParameters { get; set; }

        /// <summary>
        /// <para>The ID of the resource group that contains the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rgaekzbrflewn6jjq</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
