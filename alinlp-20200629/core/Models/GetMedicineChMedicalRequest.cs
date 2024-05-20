// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alinlp20200629.Models
{
    public class GetMedicineChMedicalRequest : TeaModel {
        [NameInMap("Factory")]
        [Validation(Required=false)]
        public string Factory { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        [NameInMap("Specification")]
        [Validation(Required=false)]
        public string Specification { get; set; }

        [NameInMap("Unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

    }

}
