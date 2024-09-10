// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetRdTreeResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRdTreeResponseBodyData Data { get; set; }
        public class GetRdTreeResponseBodyData : TeaModel {
            [NameInMap("Children")]
            [Validation(Required=false)]
            public List<object> Children { get; set; }

            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

            [NameInMap("FolderName")]
            [Validation(Required=false)]
            public string FolderName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
