// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetAccountResponseBody : TeaModel {
        [NameInMap("Account")]
        [Validation(Required=false)]
        public GetAccountResponseBodyAccount Account { get; set; }
        public class GetAccountResponseBodyAccount : TeaModel {
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("EmailStatus")]
            [Validation(Required=false)]
            public string EmailStatus { get; set; }

            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

            [NameInMap("IdentityInformation")]
            [Validation(Required=false)]
            public string IdentityInformation { get; set; }

            [NameInMap("JoinMethod")]
            [Validation(Required=false)]
            public string JoinMethod { get; set; }

            [NameInMap("JoinTime")]
            [Validation(Required=false)]
            public string JoinTime { get; set; }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("ResourceDirectoryId")]
            [Validation(Required=false)]
            public string ResourceDirectoryId { get; set; }

            [NameInMap("ResourceDirectoryPath")]
            [Validation(Required=false)]
            public string ResourceDirectoryPath { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetAccountResponseBodyAccountTags> Tags { get; set; }
            public class GetAccountResponseBodyAccountTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
