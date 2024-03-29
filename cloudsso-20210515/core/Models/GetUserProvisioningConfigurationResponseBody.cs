// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetUserProvisioningConfigurationResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The global configurations of the RAM user provisioning.
        /// </summary>
        [NameInMap("UserProvisioningConfiguration")]
        [Validation(Required=false)]
        public GetUserProvisioningConfigurationResponseBodyUserProvisioningConfiguration UserProvisioningConfiguration { get; set; }
        public class GetUserProvisioningConfigurationResponseBodyUserProvisioningConfiguration : TeaModel {
            /// <summary>
            /// The creation time.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The default URL for a CloudSSO user who logs on to the Alibaba Cloud Management Console.
            /// 
            /// Default value: https://homenew.console.aliyun.com.
            /// </summary>
            [NameInMap("DefaultLandingPage")]
            [Validation(Required=false)]
            public string DefaultLandingPage { get; set; }

            /// <summary>
            /// The ID of the resource directory.
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// The duration of the logon session.
            /// 
            /// Unit: hours.
            /// 
            /// Valid values: 1 to 24.
            /// 
            /// Default value: 6.
            /// </summary>
            [NameInMap("SessionDuration")]
            [Validation(Required=false)]
            public int? SessionDuration { get; set; }

            /// <summary>
            /// The modification time.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
