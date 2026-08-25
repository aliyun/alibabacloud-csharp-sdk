// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetSqlOptimizeAdviceRequest : TeaModel {
        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("ConsoleContext")]
        [Validation(Required=false)]
        public string ConsoleContext { get; set; }

        /// <summary>
        /// <para>The end date of the query. Format: <i>yyyyMMdd</i> (UTC).</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is left empty, the default value is the day before the current date.</description></item>
        /// <item><description>You can only query data from the day before the current date or earlier. The interval between the start date and the end date cannot exceed 30 days.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20210917</para>
        /// </summary>
        [NameInMap("EndDt")]
        [Validation(Required=false)]
        public string EndDt { get; set; }

        /// <summary>
        /// <para>The database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b>: RDS MySQL.</description></item>
        /// <item><description><b>PolarDBMySQL</b>: PolarDB for MySQL.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>Only RDS MySQL and PolarDB for MySQL instances are supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze1jdv45i7l6****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The region to which the instance belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-china</b>: the Chinese mainland.</description></item>
        /// <item><description><b>cn-hongkong</b>: Hong Kong (China).</description></item>
        /// <item><description><b>ap-southeast-1</b>: Singapore.</description></item>
        /// </list>
        /// <para>This parameter takes effect only when the <b>InstanceIds</b> request parameter is left empty. If <b>InstanceIds</b> is left empty, data is retrieved based on the region specified by the <b>Region</b> parameter. The default region is <b>cn-china</b>. If <b>InstanceIds</b> is not empty, data is retrieved based on the region of the first instance specified by <b>InstanceIds</b>, even if the <b>Region</b> parameter is set.</para>
        /// <remarks>
        /// <para>For instances created in regions within the Chinese mainland, set this parameter to <b>cn-china</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-china</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The start date of the query. Format: <i>yyyyMMdd</i> (UTC).</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is left empty, the default value is the day before the current date.</description></item>
        /// <item><description>You can only query data from the day before the current date or earlier.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20210916</para>
        /// </summary>
        [NameInMap("StartDt")]
        [Validation(Required=false)]
        public string StartDt { get; set; }

    }

}
