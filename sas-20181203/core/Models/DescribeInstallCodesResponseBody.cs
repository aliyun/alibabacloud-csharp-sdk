// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeInstallCodesResponseBody : TeaModel {
        [NameInMap("InstallCodes")]
        [Validation(Required=false)]
        public List<DescribeInstallCodesResponseBodyInstallCodes> InstallCodes { get; set; }
        public class DescribeInstallCodesResponseBodyInstallCodes : TeaModel {
            [NameInMap("CaptchaCode")]
            [Validation(Required=false)]
            public string CaptchaCode { get; set; }

            [NameInMap("ExpiredDate")]
            [Validation(Required=false)]
            public long? ExpiredDate { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("OnlyImage")]
            [Validation(Required=false)]
            public bool? OnlyImage { get; set; }

            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            [NameInMap("VendorName")]
            [Validation(Required=false)]
            public string VendorName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
