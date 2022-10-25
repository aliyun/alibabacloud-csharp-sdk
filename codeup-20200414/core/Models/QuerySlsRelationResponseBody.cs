// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class QuerySlsRelationResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QuerySlsRelationResponseBodyResult> Result { get; set; }
        public class QuerySlsRelationResponseBodyResult : TeaModel {
            [NameInMap("aliyunUserId")]
            [Validation(Required=false)]
            public string AliyunUserId { get; set; }

            [NameInMap("codeupProjectId")]
            [Validation(Required=false)]
            public long? CodeupProjectId { get; set; }

            [NameInMap("defaultViewer")]
            [Validation(Required=false)]
            public bool? DefaultViewer { get; set; }

            [NameInMap("organizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            [NameInMap("slsLogStore")]
            [Validation(Required=false)]
            public string SlsLogStore { get; set; }

            [NameInMap("slsProject")]
            [Validation(Required=false)]
            public string SlsProject { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
