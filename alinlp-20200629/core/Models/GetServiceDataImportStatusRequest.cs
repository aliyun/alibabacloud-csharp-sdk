// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alinlp20200629.Models
{
    public class GetServiceDataImportStatusRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DataImportIds")]
        [Validation(Required=false)]
        public List<long?> DataImportIds { get; set; }

    }

}
