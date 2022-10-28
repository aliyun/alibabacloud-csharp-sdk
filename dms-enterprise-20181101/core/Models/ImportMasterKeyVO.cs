// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ImportMasterKeyVO : TeaModel {
        [NameInMap("EncryptMekDataBase64")]
        [Validation(Required=false)]
        public string EncryptMekDataBase64 { get; set; }

        [NameInMap("MekId")]
        [Validation(Required=false)]
        public long? MekId { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public List<long?> ProjectId { get; set; }

    }

}
