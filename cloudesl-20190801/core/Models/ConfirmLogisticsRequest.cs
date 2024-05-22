// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20190801.Models
{
    public class ConfirmLogisticsRequest : TeaModel {
        [NameInMap("LogisticsDocuments")]
        [Validation(Required=false)]
        public string LogisticsDocuments { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("PoNumber")]
        [Validation(Required=false)]
        public string PoNumber { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("PrNumber")]
        [Validation(Required=false)]
        public string PrNumber { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
