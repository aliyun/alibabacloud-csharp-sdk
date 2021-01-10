// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryMsSgServiceSubKeysResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("StartIndex")]
        [Validation(Required=false)]
        public long? StartIndex { get; set; }

        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public long? TotalSize { get; set; }

        [NameInMap("SimpleServiceInfos")]
        [Validation(Required=false)]
        public List<QueryMsSgServiceSubKeysResponseBodySimpleServiceInfos> SimpleServiceInfos { get; set; }
        public class QueryMsSgServiceSubKeysResponseBodySimpleServiceInfos : TeaModel {
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            [NameInMap("PubCount")]
            [Validation(Required=false)]
            public long? PubCount { get; set; }

            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            [NameInMap("SubCount")]
            [Validation(Required=false)]
            public long? SubCount { get; set; }

            [NameInMap("PubApp")]
            [Validation(Required=false)]
            public List<string> PubApp { get; set; }

            [NameInMap("AppInfos")]
            [Validation(Required=false)]
            public List<QueryMsSgServiceSubKeysResponseBodySimpleServiceInfosAppInfos> AppInfos { get; set; }
            public class QueryMsSgServiceSubKeysResponseBodySimpleServiceInfosAppInfos : TeaModel {
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

    }

}
