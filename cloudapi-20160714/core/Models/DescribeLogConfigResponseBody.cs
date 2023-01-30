// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeLogConfigResponseBody : TeaModel {
        /// <summary>
        /// The log data.
        /// </summary>
        [NameInMap("LogInfos")]
        [Validation(Required=false)]
        public DescribeLogConfigResponseBodyLogInfos LogInfos { get; set; }
        public class DescribeLogConfigResponseBodyLogInfos : TeaModel {
            [NameInMap("LogInfo")]
            [Validation(Required=false)]
            public List<DescribeLogConfigResponseBodyLogInfosLogInfo> LogInfo { get; set; }
            public class DescribeLogConfigResponseBodyLogInfosLogInfo : TeaModel {
                /// <summary>
                /// The log type.
                /// </summary>
                [NameInMap("LogType")]
                [Validation(Required=false)]
                public string LogType { get; set; }

                /// <summary>
                /// The region ID of Log Service.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The log store value of Log Service (SLS).
                /// </summary>
                [NameInMap("SlsLogStore")]
                [Validation(Required=false)]
                public string SlsLogStore { get; set; }

                /// <summary>
                /// The SLS project.
                /// </summary>
                [NameInMap("SlsProject")]
                [Validation(Required=false)]
                public string SlsProject { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
