// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveGrtnDurationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. Separate multiple application IDs with commas (,). You can specify up to 30 application IDs. By default, the aggregated data of all applications is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4346289a-a790-4869-9e23-22766d5e****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the billable region. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CN: Chinese mainland</description></item>
        /// <item><description>OverSeas: countries and regions outside the Chinese mainland</description></item>
        /// <item><description>AP1: Asia Pacific 1, including Hong Kong (China), Macao (China), Taiwan (China), Japan, and other Southeast Asia countries and regions except Vietnam and Indonesia</description></item>
        /// <item><description>AP2: Asia Pacific 2, including Indonesia, South Korea, and Vietnam</description></item>
        /// <item><description>AP3: Asia Pacific 3, including Australia and New Zealand</description></item>
        /// <item><description>NA: North America, including US and Canada</description></item>
        /// <item><description>SA: South America, specifically meaning Brazil</description></item>
        /// <item><description>EU: Europe, including Ukraine, UK, France, Netherlands, Spain, Italy, Sweden, and Germany</description></item>
        /// <item><description>MEAA: Middle East and Africa, including South Africa, Oman, UAE, and Kuwait</description></item>
        /// </list>
        /// <para>If you do not specify this parameter, data of all regions is aggregated and returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. The end time must be later than the start time. The time range that can be specified is greater than or equal to 5 minutes and less than or equal to 31 days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity of the query. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>300</description></item>
        /// <item><description>3600</description></item>
        /// <item><description>86400</description></item>
        /// </list>
        /// <para>If you specify an invalid value or do not specify this parameter, the default value 3600 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
