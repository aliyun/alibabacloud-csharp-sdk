// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class CreateAccessConfigurationRequest : TeaModel {
        /// <summary>
        /// The name of the access configuration.
        /// 
        /// The name can contain letters, digits, and hyphens (-).
        /// 
        /// The name can be up to 32 characters in length.
        /// </summary>
        [NameInMap("AccessConfigurationName")]
        [Validation(Required=false)]
        public string AccessConfigurationName { get; set; }

        /// <summary>
        /// The description of the access configuration.
        /// 
        /// The description can be up to 1,024 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the directory.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// The initial web page that is displayed after a CloudSSO user accesses an account in your resource directory by using the access configuration.
        /// 
        /// The web page must be a page of the Alibaba Cloud Management Console. By default, this parameter is empty, which indicates that the initial web page is the homepage of the Alibaba Cloud Management Console.
        /// </summary>
        [NameInMap("RelayState")]
        [Validation(Required=false)]
        public string RelayState { get; set; }

        /// <summary>
        /// The duration of a session in which a CloudSSO user accesses an account in your resource directory by using the access configuration.
        /// 
        /// Unit: seconds.
        /// 
        /// Valid values: 900 to 43200. The value 900 indicates 15 minutes. The value 43200 indicates 12 hours.
        /// 
        /// Default value: 3600. The value indicates 1 hour.
        /// </summary>
        [NameInMap("SessionDuration")]
        [Validation(Required=false)]
        public int? SessionDuration { get; set; }

    }

}
