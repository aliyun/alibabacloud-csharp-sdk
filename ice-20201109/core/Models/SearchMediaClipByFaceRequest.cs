// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SearchMediaClipByFaceRequest : TeaModel {
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        [NameInMap("FaceSearchToken")]
        [Validation(Required=false)]
        public string FaceSearchToken { get; set; }

        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SearchLibName")]
        [Validation(Required=false)]
        public string SearchLibName { get; set; }

    }

}
