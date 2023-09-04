// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UpdateAccessConfigurationRequest : TeaModel {
        /// <summary>
        /// The ID of the access configuration.
        /// </summary>
        [NameInMap("AccessConfigurationId")]
        [Validation(Required=false)]
        public string AccessConfigurationId { get; set; }

        /// <summary>
        /// The ID of the directory.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// The new description of the access configuration.
        /// 
        /// The description can be up to 1,024 characters in length.
        /// </summary>
        [NameInMap("NewDescription")]
        [Validation(Required=false)]
        public string NewDescription { get; set; }

        /// <summary>
        /// The new initial web page that is displayed after a CloudSSO user accesses an account in your resource directory by using the access configuration.
        /// 
        /// The web page must be a page of the Alibaba Cloud Management Console.
        /// </summary>
        [NameInMap("NewRelayState")]
        [Validation(Required=false)]
        public string NewRelayState { get; set; }

        /// <summary>
        /// The new duration of a session in which a CloudSSO user accesses an account in your resource directory by using the access configuration.
        /// 
        /// Unit: seconds.
        /// 
        /// Valid values: 900 to 43200. The value 900 indicates 15 minutes. The value 43200 indicates 12 hours.
        /// </summary>
        [NameInMap("NewSessionDuration")]
        [Validation(Required=false)]
        public int? NewSessionDuration { get; set; }

    }

}
