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
                [NameInMap("LogType")]
                [Validation(Required=false)]
                public string LogType { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("SlsLogStore")]
                [Validation(Required=false)]
                public string SlsLogStore { get; set; }

                [NameInMap("SlsProject")]
                [Validation(Required=false)]
                public string SlsProject { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E3BC2706-ABDB-5B64-A12F-08DFD9E3F339</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
