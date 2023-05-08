// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeLogstoreStorageResponseBody : TeaModel {
        /// <summary>
        /// WB01014029
        /// </summary>
        [NameInMap("Logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        [NameInMap("Preserve")]
        [Validation(Required=false)]
        public long? Preserve { get; set; }

        /// <summary>
        /// 谈佳伟
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// DescribeLogstoreStorage
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// Queries the purchased log storage capacity.
        /// </summary>
        [NameInMap("Used")]
        [Validation(Required=false)]
        public long? Used { get; set; }

        [NameInMap("UserProject")]
        [Validation(Required=false)]
        public string UserProject { get; set; }

    }

}
