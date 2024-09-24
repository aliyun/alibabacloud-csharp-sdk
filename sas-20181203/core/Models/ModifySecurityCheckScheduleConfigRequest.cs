// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifySecurityCheckScheduleConfigRequest : TeaModel {
        /// <summary>
        /// <para>The days on which the automatic configuration check runs. You can specify multiple days. Separate multiple days with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Monday</description></item>
        /// <item><description><b>2</b>: Tuesday</description></item>
        /// <item><description><b>3</b>: Wednesday</description></item>
        /// <item><description><b>4</b>: Thursday</description></item>
        /// <item><description><b>5</b>: Friday</description></item>
        /// <item><description><b>6</b>: Saturday</description></item>
        /// <item><description><b>7</b>: Sunday</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4,5,6</para>
        /// </summary>
        [NameInMap("DaysOfWeek")]
        [Validation(Required=false)]
        public string DaysOfWeek { get; set; }

        /// <summary>
        /// <para>The time period during which the automatic configuration check ends. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: 00:00 to 06:00</description></item>
        /// <item><description><b>6</b>: 06:00 to 12:00</description></item>
        /// <item><description><b>12</b>: 12:00 to 18:00</description></item>
        /// <item><description><b>18</b>: 18:00 to 24:00</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The time period during which the automatic configuration check starts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: 00:00 to 06:00</description></item>
        /// <item><description><b>6</b>: 06:00 to 12:00</description></item>
        /// <item><description><b>12</b>: 12:00 to 18:00</description></item>
        /// <item><description><b>18</b>: 18:00 to 24:00</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

    }

}
