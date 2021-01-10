// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListDSTBizLogConfigsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("BizLogConfigs")]
        [Validation(Required=false)]
        public List<ListDSTBizLogConfigsResponseBodyBizLogConfigs> BizLogConfigs { get; set; }
        public class ListDSTBizLogConfigsResponseBodyBizLogConfigs : TeaModel {
            [NameInMap("AdvSetValid")]
            [Validation(Required=false)]
            public bool? AdvSetValid { get; set; }

            [NameInMap("App")]
            [Validation(Required=false)]
            public string App { get; set; }

            [NameInMap("CheckCondition")]
            [Validation(Required=false)]
            public string CheckCondition { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("LogBeginRegex")]
            [Validation(Required=false)]
            public string LogBeginRegex { get; set; }

            [NameInMap("LogPath")]
            [Validation(Required=false)]
            public string LogPath { get; set; }

            [NameInMap("LogSample")]
            [Validation(Required=false)]
            public string LogSample { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
