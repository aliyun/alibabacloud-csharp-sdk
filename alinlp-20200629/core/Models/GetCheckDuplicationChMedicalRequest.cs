// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alinlp20200629.Models
{
    public class GetCheckDuplicationChMedicalRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OriginQ")]
        [Validation(Required=false)]
        public string OriginQ { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OriginT")]
        [Validation(Required=false)]
        public string OriginT { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

    }

}
