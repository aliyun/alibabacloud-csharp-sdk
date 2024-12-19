// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeLogConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Info of the log config.</para>
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
                /// <para>The log type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PROVIDER</para>
                /// </summary>
                [NameInMap("LogType")]
                [Validation(Required=false)]
                public string LogType { get; set; }

                /// <summary>
                /// <para>The region ID of the Logstore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The name of the Logstore in Log Service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>slsstore</para>
                /// </summary>
                [NameInMap("SlsLogStore")]
                [Validation(Required=false)]
                public string SlsLogStore { get; set; }

                /// <summary>
                /// <para>The name of the Log Service project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>slsproject</para>
                /// </summary>
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
