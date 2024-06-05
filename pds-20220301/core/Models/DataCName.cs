// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class DataCName : TeaModel {
        [NameInMap("cert_expire_time")]
        [Validation(Required=false)]
        public long? CertExpireTime { get; set; }

        [NameInMap("cert_name")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        [NameInMap("cname")]
        [Validation(Required=false)]
        public string Cname { get; set; }

        [NameInMap("cname_type")]
        [Validation(Required=false)]
        public string CnameType { get; set; }

        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("store_id")]
        [Validation(Required=false)]
        public string StoreId { get; set; }

    }

}
