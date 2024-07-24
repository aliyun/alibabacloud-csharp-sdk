// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListUserKubeConfigStatesRequest : TeaModel {
        /// <summary>
        /// The page number.
        /// 
        /// *   Valid values: ≥ 1.
        /// *   Default value: 1.
        /// </summary>
        [NameInMap("page_number")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// *   Value values: 1 to 100.
        /// *   Default value: 50.
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
