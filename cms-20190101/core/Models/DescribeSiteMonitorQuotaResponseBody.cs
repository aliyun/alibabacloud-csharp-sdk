// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para>The value 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The quota information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSiteMonitorQuotaResponseBodyData Data { get; set; }
        public class DescribeSiteMonitorQuotaResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether second-level monitoring is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: enabled.</para>
            /// </description></item>
            /// <item><description><para>false: disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SecondMonitor")]
            [Validation(Required=false)]
            public bool? SecondMonitor { get; set; }

            /// <summary>
            /// <para>The quota of Alibaba detection points. The free quota is 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("SiteMonitorIdcQuota")]
            [Validation(Required=false)]
            public int? SiteMonitorIdcQuota { get; set; }

            /// <summary>
            /// <para>The quota of non-Alibaba detection points. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SiteMonitorOperatorQuotaQuota")]
            [Validation(Required=false)]
            public int? SiteMonitorOperatorQuotaQuota { get; set; }

            /// <summary>
            /// <para>The number of used site monitoring detection task quotas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("SiteMonitorQuotaTaskUsed")]
            [Validation(Required=false)]
            public int? SiteMonitorQuotaTaskUsed { get; set; }

            /// <summary>
            /// <para>The quota of site monitoring detection tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SiteMonitorTaskQuota")]
            [Validation(Required=false)]
            public int? SiteMonitorTaskQuota { get; set; }

            /// <summary>
            /// <para>The version of site monitoring. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>V1: the old version.</para>
            /// </description></item>
            /// <item><description><para>V2: the new version.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>V1</para>
            /// </summary>
            [NameInMap("SiteMonitorVersion")]
            [Validation(Required=false)]
            public string SiteMonitorVersion { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Request succeeded.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>26860260-76C6-404E-AB7A-EB98D36A6885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The operation was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The operation failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
