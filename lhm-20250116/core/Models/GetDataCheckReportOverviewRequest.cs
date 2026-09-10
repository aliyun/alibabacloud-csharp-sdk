// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class GetDataCheckReportOverviewRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the validation job (batch).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20001</para>
        /// </summary>
        [NameInMap("batchId")]
        [Validation(Required=false)]
        public long? BatchId { get; set; }

    }

}
