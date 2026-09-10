// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class ExecDataCheckReRunRequest : TeaModel {
        /// <summary>
        /// <para>The batch ID returned by the ExecDataCheckSaveTask operation.</para>
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
