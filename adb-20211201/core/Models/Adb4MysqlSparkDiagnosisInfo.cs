/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class Adb4MysqlSparkDiagnosisInfo : TeaModel {
        [NameInMap("DiagnosisCode")]
        [Validation(Required=false)]
        public string DiagnosisCode { get; set; }

        [NameInMap("DiagnosisCodeLabel")]
        [Validation(Required=false)]
        public string DiagnosisCodeLabel { get; set; }

        [NameInMap("DiagnosisMsg")]
        [Validation(Required=false)]
        public string DiagnosisMsg { get; set; }

        [NameInMap("DiagnosisType")]
        [Validation(Required=false)]
        public string DiagnosisType { get; set; }

    }

}
