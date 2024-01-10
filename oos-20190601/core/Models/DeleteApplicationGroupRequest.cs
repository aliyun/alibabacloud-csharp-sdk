// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class DeleteApplicationGroupRequest : TeaModel {
        /// <summary>
        /// The name of the application.
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// The name of the application group.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the region. Set the value to cn-hangzhou.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to retain resources created by application manager when deleting the application. Valid values:
        /// - true
        /// - false
        /// </summary>
        [NameInMap("RetainResource")]
        [Validation(Required=false)]
        public bool? RetainResource { get; set; }

    }

}
