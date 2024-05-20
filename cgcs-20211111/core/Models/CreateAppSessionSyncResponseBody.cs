// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CGCS20211111.Models
{
    public class CreateAppSessionSyncResponseBody : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        [NameInMap("BizInfo")]
        [Validation(Required=false)]
        public CreateAppSessionSyncResponseBodyBizInfo BizInfo { get; set; }
        public class CreateAppSessionSyncResponseBodyBizInfo : TeaModel {
            [NameInMap("Biz")]
            [Validation(Required=false)]
            public Dictionary<string, object> Biz { get; set; }

            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public List<CreateAppSessionSyncResponseBodyBizInfoEndpoints> Endpoints { get; set; }
            public class CreateAppSessionSyncResponseBodyBizInfoEndpoints : TeaModel {
                [NameInMap("AccessHost")]
                [Validation(Required=false)]
                public string AccessHost { get; set; }

                [NameInMap("AccessPort")]
                [Validation(Required=false)]
                public string AccessPort { get; set; }

                [NameInMap("DistrictId")]
                [Validation(Required=false)]
                public string DistrictId { get; set; }

                [NameInMap("Isp")]
                [Validation(Required=false)]
                public string Isp { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("CustomSessionId")]
        [Validation(Required=false)]
        public string CustomSessionId { get; set; }

        [NameInMap("PlatformSessionId")]
        [Validation(Required=false)]
        public string PlatformSessionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
