// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20171016.Models
{
    public class ModifyFullTableScanRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("FullTableScan")]
        [Validation(Required=false)]
        public bool? FullTableScan { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TableNames")]
        [Validation(Required=false)]
        public string TableNames { get; set; }

    }

}
