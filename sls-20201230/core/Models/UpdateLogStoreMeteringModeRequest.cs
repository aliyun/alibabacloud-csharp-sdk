// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateLogStoreMeteringModeRequest : TeaModel {
        /// <summary>
        /// The billing mode. Valid values: ChargeByFunction and ChargeByDataIngest. Default value: ChargeByFunction. The value ChargeByFunction specifies the pay-by-feature billing mode. The value ChargeByDataIngest specifies the pay-by-ingested-data billing mode.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("meteringMode")]
        [Validation(Required=false)]
        public string MeteringMode { get; set; }

    }

}
