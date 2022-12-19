// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeInstallCodesResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the information about the installation command.
        /// </summary>
        [NameInMap("InstallCodes")]
        [Validation(Required=false)]
        public List<DescribeInstallCodesResponseBodyInstallCodes> InstallCodes { get; set; }
        public class DescribeInstallCodesResponseBodyInstallCodes : TeaModel {
            /// <summary>
            /// The installation verification code for you to manually install the Security Center agent.
            /// </summary>
            [NameInMap("CaptchaCode")]
            [Validation(Required=false)]
            public string CaptchaCode { get; set; }

            /// <summary>
            /// The timestamp when the installation command expires. Unit: milliseconds.
            /// </summary>
            [NameInMap("ExpiredDate")]
            [Validation(Required=false)]
            public long? ExpiredDate { get; set; }

            /// <summary>
            /// The ID of the server group to which the server belongs.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// The name of the server group to which the server belongs.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// Indicates whether an image is used to install the Security Center agent. Valid values:
            /// 
            /// *   **true**: An image is used to install the Security Center agent.
            /// *   **false**: An image is not used to install the Security Center agent.
            /// </summary>
            [NameInMap("OnlyImage")]
            [Validation(Required=false)]
            public bool? OnlyImage { get; set; }

            /// <summary>
            /// The operating system of the server. Valid values:
            /// *   **linux**: Linux.
            /// *   **windows**: Windows.
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// The name of the server provider.
            /// </summary>
            [NameInMap("VendorName")]
            [Validation(Required=false)]
            public string VendorName { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
