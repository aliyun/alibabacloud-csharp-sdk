// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class SetSparkAppLogRootPathRequest : TeaModel {
        /// <summary>
        /// The database ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The Object Storage Service (OSS) log path.
        /// </summary>
        [NameInMap("OssLogPath")]
        [Validation(Required=false)]
        public string OssLogPath { get; set; }

        /// <summary>
        /// Specifies whether to use the default OSS log path.
        /// </summary>
        [NameInMap("UseDefaultOss")]
        [Validation(Required=false)]
        public bool? UseDefaultOss { get; set; }

    }

}
