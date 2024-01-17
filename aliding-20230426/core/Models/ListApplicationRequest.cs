// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class ListApplicationRequest : TeaModel {
        [NameInMap("AppFilter")]
        [Validation(Required=false)]
        public string AppFilter { get; set; }

        [NameInMap("AppNameSearchKeyword")]
        [Validation(Required=false)]
        public string AppNameSearchKeyword { get; set; }

        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
