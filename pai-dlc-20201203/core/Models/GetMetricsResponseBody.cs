// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetMetricsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The monitoring metric data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;Content\&quot;: \&quot;\&quot;, \&quot;OperationName\&quot;: \&quot;purchase\&quot;, \&quot;Success\&quot;: 1, \&quot;Id\&quot;: \&quot;217\&quot;, \&quot;LogDatetime\&quot;: 1687679582923}]</para>
        /// </summary>
        [NameInMap("DataPoints")]
        [Validation(Required=false)]
        public string DataPoints { get; set; }

        /// <summary>
        /// <para>Detailed result message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6lESTRpd5hnHNnmKOP/+w9F</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The statistical period for monitoring data. Valid values: 15, 60, 900, and 3600. Unit: seconds. If you do not specify a statistical period, the system uses the reporting period registered for the metric. Each cloud service metric (MetricName) may have a different statistical period. For more information, see cloud service monitoring metrics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation succeeded. Valid values: true (success) and false (failure).</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
