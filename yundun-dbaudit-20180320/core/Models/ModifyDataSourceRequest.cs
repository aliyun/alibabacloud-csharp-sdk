// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class ModifyDataSourceRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("DbId")]
        [Validation(Required=false)]
        public int? DbId { get; set; }

        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("DbVersion")]
        [Validation(Required=false)]
        public int? DbVersion { get; set; }

        [NameInMap("DbCertificate")]
        [Validation(Required=false)]
        public string DbCertificate { get; set; }

        [NameInMap("DbUsername")]
        [Validation(Required=false)]
        public string DbUsername { get; set; }

        [NameInMap("DbPassword")]
        [Validation(Required=false)]
        public string DbPassword { get; set; }

        [NameInMap("DbInstanceId")]
        [Validation(Required=false)]
        public string DbInstanceId { get; set; }

        [NameInMap("DbAddresses")]
        [Validation(Required=false)]
        public List<string> DbAddresses { get; set; }

    }

}
