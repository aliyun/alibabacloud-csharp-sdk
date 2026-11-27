// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeDiagnosticResultRequest : TeaModel {
        /// <summary>
        /// <para>The diagnostic ID. This parameter is required. If you do not specify this parameter, the API returns an error. You can obtain the ID from the response of the CreateDiagnosticTask operation when you create a diagnostic task, or by calling the ListDiagnosticResults operation to query existing diagnostic tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>diag-i151942361720577788844</para>
        /// </summary>
        [NameInMap("DiagnosticId")]
        [Validation(Required=false)]
        public string DiagnosticId { get; set; }

    }

}
