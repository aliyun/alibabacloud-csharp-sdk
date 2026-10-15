// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeSavingsPlansCoverageTotalShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource ownership account. The resource ownership account is the account that actually uses the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123745698925000</para>
        /// </summary>
        [NameInMap("BillOwnerId")]
        [Validation(Required=false)]
        public long? BillOwnerId { get; set; }

        /// <summary>
        /// <para>Format: yyyy-MM-dd HH:mm:ss. The query excludes this time. If this parameter is left empty, the query covers data up to the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-20 00:00:00</para>
        /// </summary>
        [NameInMap("EndPeriod")]
        [Validation(Required=false)]
        public string EndPeriod { get; set; }

        [NameInMap("FilterParam")]
        [Validation(Required=false)]
        public string FilterParamShrink { get; set; }

        /// <summary>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MONTH: month granularity.</description></item>
        /// <item><description>DAY: day granularity.</description></item>
        /// <item><description>HOUR: hour granularity.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HOUR</para>
        /// </summary>
        [NameInMap("PeriodType")]
        [Validation(Required=false)]
        public string PeriodType { get; set; }

        /// <summary>
        /// <para>Format: yyyy-MM-dd HH:mm:ss. The query includes this time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-15 00:00:00</para>
        /// </summary>
        [NameInMap("StartPeriod")]
        [Validation(Required=false)]
        public string StartPeriod { get; set; }

    }

}
