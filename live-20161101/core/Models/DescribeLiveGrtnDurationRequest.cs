// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveGrtnDurationRequest : TeaModel {
        /// <summary>
        /// <para>Application ID. You can query multiple application IDs separated by commas (half-width). A maximum of 30 IDs can be queried. By default, aggregated data for all applications is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4346289a-a790-4869-9e23-22766d5e****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The area code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CN: Chinese mainland.</description></item>
        /// <item><description>OverSeas: Overseas regions.</description></item>
        /// <item><description>AP1: Asia Pacific 1, including Hong Kong (China), Macao (China), Taiwan (China), Japan, and Southeast Asian countries except Vietnam and Indonesia.</description></item>
        /// <item><description>AP2: Asia Pacific 2, including Indonesia, South Korea, and Vietnam.</description></item>
        /// <item><description>AP3: Asia Pacific 3, including Australia and New Zealand.</description></item>
        /// <item><description>NA: North America, including the United States and Canada.</description></item>
        /// <item><description>SA: South America, specifically Brazil.</description></item>
        /// <item><description>EU: Europe, including Ukraine, the United Kingdom, France, the Netherlands, Spain, Italy, Sweden, and Germany.</description></item>
        /// <item><description>MEAA: Middle East and Africa, including South Africa, Oman, the United Arab Emirates, and Kuwait.</description></item>
        /// </list>
        /// <para>If not specified, aggregated data for all areas is returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

        /// <summary>
        /// <para>The end time must be later than the start time. The query granularity must be ≥ 5 minutes and ≤ 31 days. The date format follows the ISO 8601 notation and uses UTC time in the format: YYYY-MM-DDThh:mm:ssZ.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity for querying data. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>300</description></item>
        /// <item><description>3600</description></item>
        /// <item><description>86400</description></item>
        /// </list>
        /// <para>If not specified or an unsupported value is passed, the default value of 3600 seconds is used.</para>
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

        /// <summary>
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start time for data retrieval. The date format follows the ISO 8601 notation and uses UTC time in the format: YYYY-MM-DDThh:mm:ssZ.</para>
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
