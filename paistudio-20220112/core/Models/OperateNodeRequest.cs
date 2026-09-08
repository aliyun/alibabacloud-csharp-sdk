// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class OperateNodeRequest : TeaModel {
        /// <summary>
        /// <para>The operation. Valid values:	</para>
        /// <list type="bullet">
        /// <item><description>Cordon: disables scheduling</description></item>
        /// <item><description>Uncordon: enables scheduling</description></item>
        /// <item><description>Drain: evicts pods</description></item>
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
        /// <para>The node operation parameter settings.</para>
        /// </summary>
        [NameInMap("OperationParameters")]
        [Validation(Required=false)]
        public NodeOperationParameters OperationParameters { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the resource node belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rgaekzbrflewn6jjq</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
