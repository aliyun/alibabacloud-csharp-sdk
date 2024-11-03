// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnUserBillPredictionRequest : TeaModel {
        /// <summary>
        /// <para>The billable region. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CN</b>: the Chinese mainland</description></item>
        /// <item><description><b>OverSeas</b>: outside the Chinese mainland</description></item>
        /// <item><description><b>AP1</b>: Asia Pacific 1</description></item>
        /// <item><description><b>AP2</b>: Asia Pacific 2</description></item>
        /// <item><description><b>AP3</b>: Asia Pacific 3</description></item>
        /// <item><description><b>NA</b>: North America</description></item>
        /// <item><description><b>SA</b>: South America</description></item>
        /// <item><description><b>EU</b>: Europe</description></item>
        /// <item><description><b>MEAA</b>: Middle East and Africa</description></item>
        /// </list>
        /// <para>By default, the value of this parameter is determined by the metering method that is currently used. Regions inside and outside the Chinese mainland are classified into the <b>CN</b> and <b>OverSeas</b> billable regions. Billable regions inside the Chinese mainland include <b>CN</b>. Billable regions outside the Chinese mainland include <b>AP1</b>, <b>AP2</b>, <b>AP3</b>, <b>NA</b>, <b>SA</b>, <b>EU</b>, and <b>MEAA</b>.</para>
        /// <remarks>
        /// <para>For more information about billable regions, see <a href="https://help.aliyun.com/document_detail/142221.html">Billable regions</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CN,OverSeas</para>
        /// </summary>
        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

        /// <summary>
        /// <para>The billable item. A value of flow specifies bandwidth.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flow</para>
        /// </summary>
        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public string Dimension { get; set; }

        /// <summary>
        /// <para>The end time of the estimation. The default value is the current time. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2018-10-25T10:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The start time of the estimation. The default value is 00:00 on the first day of the current month. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-09-30T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
