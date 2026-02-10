// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListTrafficStatisticsShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>zh。</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("LogUserIds")]
        [Validation(Required=false)]
        public string LogUserIdsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>alibaba_cloud_sas。</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou。</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1。</para>
        /// </summary>
        [NameInMap("RegionTag")]
        [Validation(Required=false)]
        public int? RegionTag { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>173326*******。</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30。</para>
        /// </summary>
        [NameInMap("TrafficStatisticPeriod")]
        [Validation(Required=false)]
        public string TrafficStatisticPeriod { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>day。</para>
        /// </summary>
        [NameInMap("TrafficStatisticPeriodType")]
        [Validation(Required=false)]
        public string TrafficStatisticPeriodType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Region。</para>
        /// </summary>
        [NameInMap("TrafficStatisticType")]
        [Validation(Required=false)]
        public string TrafficStatisticType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>agentAnalysisLogTraffic</para>
        /// </summary>
        [NameInMap("TrafficType")]
        [Validation(Required=false)]
        public string TrafficType { get; set; }

    }

}
