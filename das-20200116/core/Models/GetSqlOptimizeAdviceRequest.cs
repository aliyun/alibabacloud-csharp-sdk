// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetSqlOptimizeAdviceRequest : TeaModel {
        /// <summary>
        /// <para>The reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("ConsoleContext")]
        [Validation(Required=false)]
        public string ConsoleContext { get; set; }

        /// <summary>
        /// <para>The end date of the time range to query. Specify the date in the <em>yyyyMMdd</em> format. The time must be in UTC.</para>
        /// <list type="bullet">
        /// <item><description>The default value of this parameter is one day before the current day.</description></item>
        /// <item><description>The value must be earlier than the current day. The interval between the start date and the end date cannot exceed 30 days.</description></item>
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
        /// <item><description><b>MySQL</b>: ApsaraDB RDS for MySQL.</description></item>
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
        /// <para> You must specify the instance ID only if your database instance is an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze1jdv45i7l6****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The region in which the instance resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-china</b>: Chinese mainland.</description></item>
        /// <item><description><b>cn-hongkong</b>: China (Hong Kong).</description></item>
        /// <item><description><b>ap-southeast-1</b>: Singapore.</description></item>
        /// </list>
        /// <para>This parameter takes effect only if <b>InstanceIds</b> is left empty. If you leave <b>InstanceIds</b> empty, the system obtains data from the region specified by <b>Region</b>. By default, Region is set to <b>cn-china</b>. If you specify <b>InstanceIds</b>, <b>Region</b> does not take effect, and the system obtains data from the region in which the first specified instance resides.****</para>
        /// <remarks>
        /// <para> If your instances reside in the regions inside the Chinese mainland, set this parameter to <b>cn-china</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-china</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The start date of the time range to query. Specify the date in the <em>yyyyMMdd</em> format. The time must be in UTC.</para>
        /// <list type="bullet">
        /// <item><description>The default value of this parameter is one day before the current day.</description></item>
        /// <item><description>The value must be earlier than the current day.</description></item>
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
