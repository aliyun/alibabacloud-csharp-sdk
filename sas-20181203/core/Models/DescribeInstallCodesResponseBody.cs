// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeInstallCodesResponseBody : TeaModel {
        /// <summary>
        /// The information about the installation commands.
        /// </summary>
        [NameInMap("InstallCodes")]
        [Validation(Required=false)]
        public List<DescribeInstallCodesResponseBodyInstallCodes> InstallCodes { get; set; }
        public class DescribeInstallCodesResponseBodyInstallCodes : TeaModel {
            /// <summary>
            /// The verification code for you to manually install the Security Center agent.
            /// </summary>
            [NameInMap("CaptchaCode")]
            [Validation(Required=false)]
            public string CaptchaCode { get; set; }

            /// <summary>
            /// The timestamp generated when the commands used to install the Security Center agent expire. Unit: milliseconds.
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
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("OnlyImage")]
            [Validation(Required=false)]
            public bool? OnlyImage { get; set; }

            /// <summary>
            /// The operating system of the server. Valid values:
            /// 
            /// *   **linux**
            /// *   **windows**
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// The name of the proxy cluster.
            /// </summary>
            [NameInMap("ProxyCluster")]
            [Validation(Required=false)]
            public string ProxyCluster { get; set; }

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
