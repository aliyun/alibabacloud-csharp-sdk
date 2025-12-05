// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class GetJMeterLogsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies that the operational logs of the stress tester identified as number 0 are returned if the agent index is invalid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AgentIndex")]
        [Validation(Required=false)]
        public int? AgentIndex { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1637115306000</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1637115309000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The log level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ERROR</description></item>
        /// <item><description>WARN</description></item>
        /// <item><description>INFO (default)</description></item>
        /// <item><description>DEBUG</description></item>
        /// <item><description>TRACE</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>INFO</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The report ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KS2YE3J2</para>
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

        /// <summary>
        /// <para>The thread name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>main</para>
        /// </summary>
        [NameInMap("Thread")]
        [Validation(Required=false)]
        public string Thread { get; set; }

    }

}
