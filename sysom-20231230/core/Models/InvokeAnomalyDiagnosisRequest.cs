// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class InvokeAnomalyDiagnosisRequest : TeaModel {
        /// <summary>
        /// <para>UUID corresponding to the anomalous activity</para>
        /// 
        /// <b>Example:</b>
        /// <para>8047d763-5465-4a8c-b1cd-23f5a8ba2594</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
