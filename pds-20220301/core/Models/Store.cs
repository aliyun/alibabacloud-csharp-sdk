// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class Store : TeaModel {
        [NameInMap("base_path")]
        [Validation(Required=false)]
        public string BasePath { get; set; }

        [NameInMap("bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("ownership")]
        [Validation(Required=false)]
        public string Ownership { get; set; }

        [NameInMap("role_arn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        [NameInMap("store_id")]
        [Validation(Required=false)]
        public string StoreId { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
