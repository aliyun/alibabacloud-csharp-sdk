// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListEtlMetaRequest : TeaModel {
        [NameInMap("etlMetaKey")]
        [Validation(Required=false)]
        public string EtlMetaKey { get; set; }

        [NameInMap("etlMetaName")]
        [Validation(Required=false)]
        public string EtlMetaName { get; set; }

        [NameInMap("etlMetaTag")]
        [Validation(Required=false)]
        public string EtlMetaTag { get; set; }

        /// <summary>
        /// 默认值 0。
        /// </summary>
        [NameInMap("offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// 默认值 200.
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
