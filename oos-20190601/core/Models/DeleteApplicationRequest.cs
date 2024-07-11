// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class DeleteApplicationRequest : TeaModel {
        /// <summary>
        /// Specifies whether to forcibly delete the application. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// The application name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The region ID. Set the value to cn-hangzhou.
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
