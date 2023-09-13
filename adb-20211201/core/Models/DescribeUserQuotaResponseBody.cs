// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeUserQuotaResponseBody : TeaModel {
        [NameInMap("ElasticACU")]
        [Validation(Required=false)]
        public string ElasticACU { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ReserverdCompteACU")]
        [Validation(Required=false)]
        public string ReserverdCompteACU { get; set; }

        [NameInMap("ReserverdStorageACU")]
        [Validation(Required=false)]
        public string ReserverdStorageACU { get; set; }

        [NameInMap("ResourceGroupCount")]
        [Validation(Required=false)]
        public string ResourceGroupCount { get; set; }

    }

}
