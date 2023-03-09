/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20200324.Models
{
    public class CreateBpmsRecordRequest : TeaModel {
        [NameInMap("BpmsParamJson")]
        [Validation(Required=false)]
        public string BpmsParamJson { get; set; }

        [NameInMap("BpmsType")]
        [Validation(Required=false)]
        public string BpmsType { get; set; }

        [NameInMap("PartnerId")]
        [Validation(Required=false)]
        public long? PartnerId { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
