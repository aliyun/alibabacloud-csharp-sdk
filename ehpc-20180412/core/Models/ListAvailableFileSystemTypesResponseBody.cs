// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListAvailableFileSystemTypesResponseBody : TeaModel {
        [NameInMap("FileSystemTypeList")]
        [Validation(Required=false)]
        public List<ListAvailableFileSystemTypesResponseBodyFileSystemTypeList> FileSystemTypeList { get; set; }
        public class ListAvailableFileSystemTypesResponseBodyFileSystemTypeList : TeaModel {
            [NameInMap("FileSystemType")]
            [Validation(Required=false)]
            public string FileSystemType { get; set; }

            [NameInMap("Available")]
            [Validation(Required=false)]
            public bool? Available { get; set; }

            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            [NameInMap("StorageTypes")]
            [Validation(Required=false)]
            public List<string> StorageTypes { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
