// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkelinkflowLinkflowAppResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Current")]
        [Validation(Required=false)]
        public long? Current { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetLinkelinkflowLinkflowAppResponseBodyData Data { get; set; }
        public class GetLinkelinkflowLinkflowAppResponseBodyData : TeaModel {
            [NameInMap("CnName")]
            [Validation(Required=false)]
            public string CnName { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }
            [NameInMap("Members")]
            [Validation(Required=false)]
            public string Members { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("RepoUrl")]
            [Validation(Required=false)]
            public string RepoUrl { get; set; }
            [NameInMap("Tenant")]
            [Validation(Required=false)]
            public string Tenant { get; set; }
        };

    }

}
