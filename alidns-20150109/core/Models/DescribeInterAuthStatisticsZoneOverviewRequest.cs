// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeInterAuthStatisticsZoneOverviewRequest : TeaModel {
        /// <summary>
        /// <para>The statistical period. Valid values: DAY, WEEK, and MONTH.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DAY、WEEK、MONTH</para>
        /// </summary>
        [NameInMap("OverviewPeriod")]
        [Validation(Required=false)]
        public string OverviewPeriod { get; set; }

        /// <summary>
        /// <para>The region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DescribeInterAuthStatisticsZoneOverview</para>
        /// </summary>
        [NameInMap("ServerRegion")]
        [Validation(Required=false)]
        public string ServerRegion { get; set; }

        /// <summary>
        /// <para>The name of the zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cheng.suow.cc</para>
        /// </summary>
        [NameInMap("ZoneName")]
        [Validation(Required=false)]
        public string ZoneName { get; set; }

    }

}
