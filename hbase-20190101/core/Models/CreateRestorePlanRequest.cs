// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class CreateRestorePlanRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RestoreAllTable")]
        [Validation(Required=false)]
        public bool? RestoreAllTable { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RestoreByCopy")]
        [Validation(Required=false)]
        public bool? RestoreByCopy { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RestoreToDate")]
        [Validation(Required=false)]
        public string RestoreToDate { get; set; }

        [NameInMap("Tables")]
        [Validation(Required=false)]
        public string Tables { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TargetClusterId")]
        [Validation(Required=false)]
        public string TargetClusterId { get; set; }

    }

}
