// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeInstanceOpsRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the queried O\&amp;M tasks.</para>
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<DescribeInstanceOpsRecordsResponseBodyRecords> Records { get; set; }
        public class DescribeInstanceOpsRecordsResponseBodyRecords : TeaModel {
            /// <summary>
            /// <para>The time when the O\&amp;M task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-29T15:00:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the O\&amp;M task expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2099-12-29T15:00:00Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The status of the O\&amp;M task.</para>
            /// <list type="bullet">
            /// <item><description>Ready</description></item>
            /// <item><description>Failed</description></item>
            /// <item><description>Expired</description></item>
            /// <item><description>Closed</description></item>
            /// <item><description>Success</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Ready</para>
            /// </summary>
            [NameInMap("OpsStatus")]
            [Validation(Required=false)]
            public string OpsStatus { get; set; }

            /// <summary>
            /// <para>The type of the O\&amp;M task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>coredump</para>
            /// </summary>
            [NameInMap("OpsType")]
            [Validation(Required=false)]
            public string OpsType { get; set; }

            /// <summary>
            /// <para>The content of the O\&amp;M result. The value is the download URL of the files that are generated for the O\&amp;M task. This parameter is returned only when the value of the OpsStatus parameter is Success.</para>
            /// 
            /// <b>Example:</b>
            /// <para>https://******</para>
            /// </summary>
            [NameInMap("ResultContent")]
            [Validation(Required=false)]
            public string ResultContent { get; set; }

            /// <summary>
            /// <para>The type of the O\&amp;M result. This parameter is returned only when the value of the OpsStatus parameter is Success.\
            /// The only value of the parameter is Oss. The value indicates that the files generated for the O\&amp;M task are saved to Object Storage Service (OSS) buckets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("ResultType")]
            [Validation(Required=false)]
            public string ResultType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89945DD3-9072-47D0-A318-353284CFC7B3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
