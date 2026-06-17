// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeBatchTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the batch task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pcb-xxx</para>
        /// </summary>
        [NameInMap("BatchId")]
        [Validation(Required=false)]
        public string BatchId { get; set; }

    }

}
