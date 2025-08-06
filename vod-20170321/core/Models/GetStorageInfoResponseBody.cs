// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetStorageInfoResponseBody : TeaModel {
        [NameInMap("DomainInfoList")]
        [Validation(Required=false)]
        public GetStorageInfoResponseBodyDomainInfoList DomainInfoList { get; set; }
        public class GetStorageInfoResponseBodyDomainInfoList : TeaModel {
            [NameInMap("DomainInfo")]
            [Validation(Required=false)]
            public List<GetStorageInfoResponseBodyDomainInfoListDomainInfo> DomainInfo { get; set; }
            public class GetStorageInfoResponseBodyDomainInfoListDomainInfo : TeaModel {
                [NameInMap("DefaultPlay")]
                [Validation(Required=false)]
                public bool? DefaultPlay { get; set; }

                [NameInMap("DomainCname")]
                [Validation(Required=false)]
                public string DomainCname { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("DomainStatus")]
                [Validation(Required=false)]
                public string DomainStatus { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Storage")]
        [Validation(Required=false)]
        public GetStorageInfoResponseBodyStorage Storage { get; set; }
        public class GetStorageInfoResponseBodyStorage : TeaModel {
            [NameInMap("DefaultUpload")]
            [Validation(Required=false)]
            public bool? DefaultUpload { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("StorageUsage")]
            [Validation(Required=false)]
            public int? StorageUsage { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        [NameInMap("StorageACL")]
        [Validation(Required=false)]
        public string StorageACL { get; set; }

    }

}
