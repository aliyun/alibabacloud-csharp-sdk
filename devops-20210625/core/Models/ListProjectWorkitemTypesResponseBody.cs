// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListProjectWorkitemTypesResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("workitemTypes")]
        [Validation(Required=false)]
        public List<ListProjectWorkitemTypesResponseBodyWorkitemTypes> WorkitemTypes { get; set; }
        public class ListProjectWorkitemTypesResponseBodyWorkitemTypes : TeaModel {
            [NameInMap("addUser")]
            [Validation(Required=false)]
            public string AddUser { get; set; }

            [NameInMap("categoryIdentifier")]
            [Validation(Required=false)]
            public string CategoryIdentifier { get; set; }

            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("defaultType")]
            [Validation(Required=false)]
            public bool? DefaultType { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            [NameInMap("gmtAdd")]
            [Validation(Required=false)]
            public long? GmtAdd { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("nameEn")]
            [Validation(Required=false)]
            public string NameEn { get; set; }

            [NameInMap("systemDefault")]
            [Validation(Required=false)]
            public bool? SystemDefault { get; set; }

        }

    }

}
