// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetRayDashboardResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the dashboard has integrated CloudMonitor to display Ray metrics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("metricsEnabled")]
        [Validation(Required=false)]
        public string MetricsEnabled { get; set; }

        /// <summary>
        /// <para>The URL of the Ray Dashboard.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://pre-pai-dlc-proxy-cn-hangzhou.aliyun.com/ray/dashboard/dlc1k7426goc7bvy">https://pre-pai-dlc-proxy-cn-hangzhou.aliyun.com/ray/dashboard/dlc1k7426goc7bvy</a></para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
