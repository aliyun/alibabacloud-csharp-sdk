// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_cnp20230828.Models
{
    public class GetWorkloadRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13</para>
        /// </summary>
        [NameInMap("WorkloadId")]
        [Validation(Required=false)]
        public long? WorkloadId { get; set; }

    }

}
