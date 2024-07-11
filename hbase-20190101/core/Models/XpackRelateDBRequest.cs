// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class XpackRelateDBRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DbClusterIds")]
        [Validation(Required=false)]
        public string DbClusterIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RelateDbType")]
        [Validation(Required=false)]
        public string RelateDbType { get; set; }

    }

}
