// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeInstallCodesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("InstallCodes")]
        [Validation(Required=false)]
        public List<DescribeInstallCodesResponseBodyInstallCodes> InstallCodes { get; set; }
        public class DescribeInstallCodesResponseBodyInstallCodes : TeaModel {
            /// <summary>
            /// DescribeInstallCodes
            /// </summary>
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

            /// <summary>
            /// Queries the commands that are used to manually install the Security Center Agent.
            /// </summary>
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

        /// <summary>
        /// The installation verification code for you to manually install the Security Center agent.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
