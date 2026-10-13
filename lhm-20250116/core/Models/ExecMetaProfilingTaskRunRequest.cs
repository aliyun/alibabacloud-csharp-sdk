// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class ExecMetaProfilingTaskRunRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1/0</para>
        /// </summary>
        [NameInMap("batchNo")]
        [Validation(Required=false)]
        public string BatchNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("componentId")]
        [Validation(Required=false)]
        public long? ComponentId { get; set; }

    }

}
