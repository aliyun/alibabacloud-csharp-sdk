// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateOssBucketScanTaskRequest : TeaModel {
        [NameInMap("BucketNameList")]
        [Validation(Required=false)]
        public List<string> BucketNameList { get; set; }

        [NameInMap("ExcludeKeySuffixList")]
        [Validation(Required=false)]
        public List<string> ExcludeKeySuffixList { get; set; }

        [NameInMap("KeySuffixList")]
        [Validation(Required=false)]
        public List<string> KeySuffixList { get; set; }

        [NameInMap("ScanMode")]
        [Validation(Required=false)]
        public int? ScanMode { get; set; }

    }

}
