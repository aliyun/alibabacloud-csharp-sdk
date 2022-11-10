// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class ListLiveFilesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListLiveFilesResponseBodyResult Result { get; set; }
        public class ListLiveFilesResponseBodyResult : TeaModel {
            [NameInMap("FileList")]
            [Validation(Required=false)]
            public List<ListLiveFilesResponseBodyResultFileList> FileList { get; set; }
            public class ListLiveFilesResponseBodyResultFileList : TeaModel {
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

    }

}
