// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeHybridMonitorSLSGroupResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeHybridMonitorSLSGroupResponseBodyList> List { get; set; }
        public class DescribeHybridMonitorSLSGroupResponseBodyList : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("SLSGroupConfig")]
            [Validation(Required=false)]
            public List<DescribeHybridMonitorSLSGroupResponseBodyListSLSGroupConfig> SLSGroupConfig { get; set; }
            public class DescribeHybridMonitorSLSGroupResponseBodyListSLSGroupConfig : TeaModel {
                [NameInMap("SLSLogstore")]
                [Validation(Required=false)]
                public string SLSLogstore { get; set; }

                [NameInMap("SLSProject")]
                [Validation(Required=false)]
                public string SLSProject { get; set; }

                [NameInMap("SLSRegion")]
                [Validation(Required=false)]
                public string SLSRegion { get; set; }

                [NameInMap("SLSUserId")]
                [Validation(Required=false)]
                public string SLSUserId { get; set; }

            }

            [NameInMap("SLSGroupDescription")]
            [Validation(Required=false)]
            public string SLSGroupDescription { get; set; }

            [NameInMap("SLSGroupName")]
            [Validation(Required=false)]
            public long? SLSGroupName { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
