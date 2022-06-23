// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qssj20220112.Models
{
    public class GetStyleTopRequest : TeaModel {
        /// <summary>
        /// A short description of struct
        /// </summary>
        [NameInMap("CateIds")]
        [Validation(Required=false)]
        public string CateIds { get; set; }

        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public long? SortOrder { get; set; }

        [NameInMap("TimeDisplay")]
        [Validation(Required=false)]
        public long? TimeDisplay { get; set; }

    }

}
