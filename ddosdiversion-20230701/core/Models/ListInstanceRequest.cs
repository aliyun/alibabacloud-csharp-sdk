// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DdosDiversion20230701.Models
{
    public class ListInstanceRequest : TeaModel {
        /// <summary>
        /// The name of the instance.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 100.
        /// </summary>
        [NameInMap("Num")]
        [Validation(Required=false)]
        public long? Num { get; set; }

        /// <summary>
        /// The page number. Default value: 1
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// The ID of the anti-DDoS diversion instance.
        /// </summary>
        [NameInMap("SaleId")]
        [Validation(Required=false)]
        public string SaleId { get; set; }

        /// <summary>
        /// The status of the instance. Valid values:
        /// 
        /// - normal
        /// - expired
        /// - deleting
        /// - stopped
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
