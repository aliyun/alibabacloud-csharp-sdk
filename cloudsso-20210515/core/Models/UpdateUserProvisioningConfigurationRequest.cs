// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UpdateUserProvisioningConfigurationRequest : TeaModel {
        /// <summary>
        /// The ID of the resource directory.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// The new default URL for a CloudSSO user who logs on to the Alibaba Cloud Management Console.
        /// 
        /// Default value: https://homenew.console.aliyun.com.
        /// </summary>
        [NameInMap("NewDefaultLandingPage")]
        [Validation(Required=false)]
        public string NewDefaultLandingPage { get; set; }

        /// <summary>
        /// The new duration of the logon session.
        /// 
        /// Unit: hours.
        /// 
        /// Valid values: 1 to 24.
        /// 
        /// Default value: 6.
        /// </summary>
        [NameInMap("NewSessionDuration")]
        [Validation(Required=false)]
        public int? NewSessionDuration { get; set; }

    }

}
