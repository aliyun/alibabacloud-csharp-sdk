// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetTaskCopiesRequest : TeaModel {
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        [NameInMap("CreateFromTimeGMT")]
        [Validation(Required=false)]
        public long? CreateFromTimeGMT { get; set; }

        [NameInMap("CreateToTimeGMT")]
        [Validation(Required=false)]
        public long? CreateToTimeGMT { get; set; }

        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProcessCodes")]
        [Validation(Required=false)]
        public string ProcessCodes { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SystemToken")]
        [Validation(Required=false)]
        public string SystemToken { get; set; }

    }

}
