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
        /// <item><description><para>The default value of this parameter is one day before the current day.</para>
        /// </description></item>
        /// <item><description><para>The value must be earlier than the current day. The interval between the start date and the end date cannot exceed 30 days.</para>
        /// </description></item>
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
        /// <item><description><para><b>MySQL</b>: ApsaraDB RDS for MySQL.</para>
        /// </description></item>
        /// <item><description><para><b>PolarDBMySQL</b>: PolarDB for MySQL.</para>
        /// </description></item>
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
        /// <para>You must specify the instance ID only if your database instance is an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster.</para>
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
        /// <item><description><para><b>cn-china</b>: Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>cn-hongkong</b>: China (Hong Kong).</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: Singapore.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter takes effect only if <b>InstanceIds</b> is left empty. If you leave <b>InstanceIds</b> empty, the system obtains data from the region specified by <b>Region</b>. By default, Region is set to <b>cn-china</b>. If you specify <b>InstanceIds</b>, <b>Region</b> does not take effect, and the system obtains data from the region in which the first specified instance resides.\<em>\</em>\<em>\</em></para>
        /// <remarks>
        /// <para>If your instances reside in the regions inside the Chinese mainland, set this parameter to <b>cn-china</b>.</para>
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
        /// <item><description><para>The default value of this parameter is one day before the current day.</para>
        /// </description></item>
        /// <item><description><para>The value must be earlier than the current day.</para>
        /// </description></item>
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
