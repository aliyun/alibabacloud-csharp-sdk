// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetMetricsRequest : TeaModel {
        /// <summary>
        /// <para>(Required) The request parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;jobId\&quot;:\&quot;dlcdpfpc96mh63mg\&quot;,\&quot;pod\&quot;:\&quot;dlcdpfpc96mh63mg-worker-748\&quot;,\&quot;regionId\&quot;:\&quot;cn-wulanchabu\&quot;,\&quot;userId\&quot;:\&quot;1458867964644701\&quot;}]</para>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public string Dimensions { get; set; }

        /// <summary>
        /// <para>The end time of the query. Default value: the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-09T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlckjd5hm84tmjec</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The number of entries per query. This parameter is used for paged query with paging. Default value: 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public string Length { get; set; }

        /// <summary>
        /// <para>The metric name. Not populated. Not in use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JOB_MEMORY_FREE</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The data namespace of the cloud service. For information about the data namespaces of cloud services, see cloud service monitoring items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs_pai_dlc</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The pagination token. If you do not set this parameter, data on the first page is returned. If a value is returned for this parameter, more pages are available. You can set NextToken to the returned value to retrieve the next page. Repeat this process until a null value is returned, which indicates that all data has been retrieved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2c6b65b6f9d625d4716568ca19b2064be0b5e8707e68181f</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The statistical period of the monitoring data. Unit: seconds. Valid values: 15, 60, 900, and 3600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The start time (UTC) of the time range for querying monitoring data. Default value: one hour before the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The temporary token used for authentication.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyXXXX-XXXX.XXXXX</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
