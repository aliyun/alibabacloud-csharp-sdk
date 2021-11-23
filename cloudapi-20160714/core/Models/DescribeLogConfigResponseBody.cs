// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeLogConfigResponseBody : TeaModel {
        [NameInMap("LogInfos")]
        [Validation(Required=false)]
        public DescribeLogConfigResponseBodyLogInfos LogInfos { get; set; }
        public class DescribeLogConfigResponseBodyLogInfos : TeaModel {
            [NameInMap("LogInfo")]
            [Validation(Required=false)]
            public List<DescribeLogConfigResponseBodyLogInfosLogInfo> LogInfo { get; set; }
            public class DescribeLogConfigResponseBodyLogInfosLogInfo : TeaModel {
                public string LogType { get; set; }
                public string RegionId { get; set; }
                public string SlsLogStore { get; set; }
                public string SlsProject { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
