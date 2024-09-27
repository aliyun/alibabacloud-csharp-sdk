// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class GetExecuteOperationResultRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>op_xxxxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("OperationId")]
        [Validation(Required=false)]
        public string OperationId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. This parameter is specified to verify the permissions on the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testResourceId</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
