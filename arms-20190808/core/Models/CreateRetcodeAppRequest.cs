// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateRetcodeAppRequest : TeaModel {
        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group. You can obtain the resource group ID in the **Resource Management** console.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The name of the application that is monitored by Browser Monitoring.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RetcodeAppName")]
        [Validation(Required=false)]
        public string RetcodeAppName { get; set; }

        /// <summary>
        /// The site type.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RetcodeAppType")]
        [Validation(Required=false)]
        public string RetcodeAppType { get; set; }

        /// <summary>
        /// The list of tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateRetcodeAppRequestTags> Tags { get; set; }
        public class CreateRetcodeAppRequestTags : TeaModel {
            /// <summary>
            /// The tag key.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
