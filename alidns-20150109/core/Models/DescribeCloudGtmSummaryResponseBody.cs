// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeCloudGtmSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of instances within the current account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InstanceTotalCount")]
        [Validation(Required=false)]
        public int? InstanceTotalCount { get; set; }

        /// <summary>
        /// <para>The total number of configured health check tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MonitorTaskTotalCount")]
        [Validation(Required=false)]
        public int? MonitorTaskTotalCount { get; set; }

        /// <summary>
        /// <para>The quota on the number of health check tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("MonitorTaskTotalQuota")]
        [Validation(Required=false)]
        public int? MonitorTaskTotalQuota { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>199C3699-9A7B-41A1-BB5A-F1E862D3CB38</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
