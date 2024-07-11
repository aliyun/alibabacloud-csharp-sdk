// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class ModifyBackupPlanConfigRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("FullBackupCycle")]
        [Validation(Required=false)]
        public string FullBackupCycle { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("MinHFileBackupCount")]
        [Validation(Required=false)]
        public string MinHFileBackupCount { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("NextFullBackupDate")]
        [Validation(Required=false)]
        public string NextFullBackupDate { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Tables")]
        [Validation(Required=false)]
        public string Tables { get; set; }

    }

}
