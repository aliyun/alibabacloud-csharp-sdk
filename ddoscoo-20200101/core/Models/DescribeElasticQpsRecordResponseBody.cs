// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeElasticQpsRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The QPS information about the instance.</para>
        /// </summary>
        [NameInMap("ElasticQpsList")]
        [Validation(Required=false)]
        public List<DescribeElasticQpsRecordResponseBodyElasticQpsList> ElasticQpsList { get; set; }
        public class DescribeElasticQpsRecordResponseBodyElasticQpsList : TeaModel {
            /// <summary>
            /// <para>The timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1688140799999</para>
            /// </summary>
            [NameInMap("Date")]
            [Validation(Required=false)]
            public long? Date { get; set; }

            /// <summary>
            /// <para>The ID of the Anti-DDoS Proxy instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddoscoo-cn-7e225i41****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The IP address of the Anti-DDoS Proxy instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>203.<em><b>.</b></em>.199</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The burstable QPS value. A value of 0 indicates that the burstable QPS feature is not enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300000</para>
            /// </summary>
            [NameInMap("OpsElasticQps")]
            [Validation(Required=false)]
            public long? OpsElasticQps { get; set; }

            /// <summary>
            /// <para>The service QPS (active).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1345</para>
            /// </summary>
            [NameInMap("OpsQps")]
            [Validation(Required=false)]
            public long? OpsQps { get; set; }

            /// <summary>
            /// <para>The service QPS (purchased).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1345</para>
            /// </summary>
            [NameInMap("OriginQps")]
            [Validation(Required=false)]
            public long? OriginQps { get; set; }

            /// <summary>
            /// <para>The daily peak 95th percentile QPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4367</para>
            /// </summary>
            [NameInMap("Qps")]
            [Validation(Required=false)]
            public long? Qps { get; set; }

            /// <summary>
            /// <para>The daily peak traffic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>122</para>
            /// </summary>
            [NameInMap("QpsPeak")]
            [Validation(Required=false)]
            public long? QpsPeak { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance has expired or is released. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: The instance runs as expected.</description></item>
            /// <item><description><b>2</b>: The instance has expired.</description></item>
            /// <item><description><b>4</b>: The instance is released.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F68B34E2-570C-508D-95FD-DFB6611D518F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
