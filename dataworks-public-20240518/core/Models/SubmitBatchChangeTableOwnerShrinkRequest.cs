// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class SubmitBatchChangeTableOwnerShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow transferring ownership to an owner in a different tenant. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableCrossTenant")]
        [Validation(Required=false)]
        public bool? EnableCrossTenant { get; set; }

        /// <summary>
        /// <para>The target owner after the transfer. Use the Alibaba Cloud UID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2xxxxx8146415628</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The list of MaxCompute table metadata entity IDs to transfer. A maximum of 100 tables are allowed per request. Duplicate values are not allowed.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TableMetaEntityIds")]
        [Validation(Required=false)]
        public string TableMetaEntityIdsShrink { get; set; }

    }

}
