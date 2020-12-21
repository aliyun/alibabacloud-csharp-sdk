// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Openanalytics_open20180619.Models
{
    public class DeleteAccountRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("AccountName")]
        [Validation(Required=true)]
        public string AccountName { get; set; }

        [NameInMap("IsShort")]
        [Validation(Required=false)]
        public bool? IsShort { get; set; }

        [NameInMap("IsServiceUser")]
        [Validation(Required=false)]
        public bool? IsServiceUser { get; set; }

    }

}
