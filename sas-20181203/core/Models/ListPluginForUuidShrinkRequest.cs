// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListPluginForUuidShrinkRequest : TeaModel {
        /// <summary>
        /// The plug-in types.
        /// </summary>
        [NameInMap("Types")]
        [Validation(Required=false)]
        public string TypesShrink { get; set; }

        /// <summary>
        /// The UUID of the server.
        /// 
        /// >  You can call the [DescribeCloudCenterInstances](~~DescribeCloudCenterInstances~~) operation to query the UUIDs of servers.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
