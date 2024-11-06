// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnSLSRealtimeLogDeliveryResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration results of the domain name.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public DescribeDcdnSLSRealtimeLogDeliveryResponseBodyContent Content { get; set; }
        public class DescribeDcdnSLSRealtimeLogDeliveryResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The type of the collected logs. Default value: cdn_log_access_l1. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cdn_log_access_l1</b>: access logs of Dynamic Content Delivery Network (DCDN) points of presence (POPs)</description></item>
            /// <item><description><b>cdn_log_origin</b>: back-to-origin logs</description></item>
            /// <item><description><b>cdn_log_er</b>: EdgeRoutine logs</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cdn_log_access_l1</para>
            /// </summary>
            [NameInMap("BusinessType")]
            [Validation(Required=false)]
            public string BusinessType { get; set; }

            /// <summary>
            /// <para>The region from which logs were collected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("DataCenter")]
            [Validation(Required=false)]
            public string DataCenter { get; set; }

            /// <summary>
            /// <para>The domain names from which logs were collected. You can specify one or more domain names. Separate multiple domain names with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com,example.org</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The name of the field. For more information about fields in real-time log entries, see <a href="https://help.aliyun.com/document_detail/324199.html">Fields in a real-time log</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>field1,field2</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <para>The name of the project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The name of the Logstore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-cn</para>
            /// </summary>
            [NameInMap("SLSLogStore")]
            [Validation(Required=false)]
            public string SLSLogStore { get; set; }

            /// <summary>
            /// <para>The name of the log file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-cn</para>
            /// </summary>
            [NameInMap("SLSProject")]
            [Validation(Required=false)]
            public string SLSProject { get; set; }

            /// <summary>
            /// <para>The region to which logs were delivered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("SLSRegion")]
            [Validation(Required=false)]
            public string SLSRegion { get; set; }

            /// <summary>
            /// <para>The sampling rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("SamplingRate")]
            [Validation(Required=false)]
            public string SamplingRate { get; set; }

            /// <summary>
            /// <para>The status of real-time logs.</para>
            /// <list type="bullet">
            /// <item><description><b>success</b></description></item>
            /// <item><description><b>fail</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of log delivery. Only <b>SLS_POST</b> is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SLS_POST</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F32C57AA-7BF8-49AE-A2CC-9F42390F5A19</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
