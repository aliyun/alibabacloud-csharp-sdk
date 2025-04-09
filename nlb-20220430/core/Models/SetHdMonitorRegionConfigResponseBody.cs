// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class SetHdMonitorRegionConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the Log Service project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hdmonitor-cn-hangzhou-223794579283657556</para>
        /// </summary>
        [NameInMap("LogProject")]
        [Validation(Required=false)]
        public string LogProject { get; set; }

        /// <summary>
        /// <para>The name of the MetricStore in Simple Log Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hdmonitor-cn-hangzhou-metricStore-1</para>
        /// </summary>
        [NameInMap("MetricStore")]
        [Validation(Required=false)]
        public string MetricStore { get; set; }

        /// <summary>
        /// <para>The region ID of the NLB instance.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2399192.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BA984</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
