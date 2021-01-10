// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeBahamutArchdomainsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ErrorMsgParamsMap")]
        [Validation(Required=false)]
        public string ErrorMsgParamsMap { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryLinkeBahamutArchdomainsResponseBodyResult> Result { get; set; }
        public class QueryLinkeBahamutArchdomainsResponseBodyResult : TeaModel {
            [NameInMap("BakOwner")]
            [Validation(Required=false)]
            public string BakOwner { get; set; }

            [NameInMap("BakTestOwner")]
            [Validation(Required=false)]
            public string BakTestOwner { get; set; }

            [NameInMap("Created")]
            [Validation(Required=false)]
            public long? Created { get; set; }

            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ExternalId")]
            [Validation(Required=false)]
            public string ExternalId { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public long? LastModified { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            [NameInMap("TestOwner")]
            [Validation(Required=false)]
            public string TestOwner { get; set; }

            [NameInMap("AppMetaIds")]
            [Validation(Required=false)]
            public List<string> AppMetaIds { get; set; }

            [NameInMap("LinkcGroups")]
            [Validation(Required=false)]
            public List<string> LinkcGroups { get; set; }

        }

    }

}
