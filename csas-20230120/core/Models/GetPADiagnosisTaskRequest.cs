// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetPADiagnosisTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>diag-58d0750e8786919a</para>
        /// </summary>
        [NameInMap("DiagnoseId")]
        [Validation(Required=false)]
        public string DiagnoseId { get; set; }

    }

}
