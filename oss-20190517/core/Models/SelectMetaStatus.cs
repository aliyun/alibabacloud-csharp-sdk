// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class SelectMetaStatus : TeaModel {
        /// <summary>
        /// description
        /// </summary>
        [NameInMap("ColsCount")]
        [Validation(Required=false)]
        public long? ColsCount { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("RowsCount")]
        [Validation(Required=false)]
        public long? RowsCount { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("SplitsCount")]
        [Validation(Required=false)]
        public long? SplitsCount { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("TotalScannedBytes")]
        [Validation(Required=false)]
        public long? TotalScannedBytes { get; set; }

    }

}
