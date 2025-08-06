// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetPersonalStorageListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StorageInfoList")]
        [Validation(Required=false)]
        public GetPersonalStorageListResponseBodyStorageInfoList StorageInfoList { get; set; }
        public class GetPersonalStorageListResponseBodyStorageInfoList : TeaModel {
            [NameInMap("StorageInfo")]
            [Validation(Required=false)]
            public List<GetPersonalStorageListResponseBodyStorageInfoListStorageInfo> StorageInfo { get; set; }
            public class GetPersonalStorageListResponseBodyStorageInfoListStorageInfo : TeaModel {
                [NameInMap("ExtranetEndpoint")]
                [Validation(Required=false)]
                public string ExtranetEndpoint { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("IntranetEndpoint")]
                [Validation(Required=false)]
                public string IntranetEndpoint { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                [NameInMap("StorageACL")]
                [Validation(Required=false)]
                public string StorageACL { get; set; }

                [NameInMap("StorageClass")]
                [Validation(Required=false)]
                public string StorageClass { get; set; }

            }

        }

    }

}
