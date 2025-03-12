// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeSlowSQLHistoryListRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the time range for querying the execution history of the slow SQL statement.<br>The value must be UTC time in the format of YYYY-MM-DDThh:mm:ssZ.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-14T08:34:49Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The number of the page to return.    </para>
        /// <list type="bullet">
        /// <item><description>Start value: 1   </description></item>
        /// <item><description>Default value: 1</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of rows to return on each page.  </para>
        /// <list type="bullet">
        /// <item><description>Maximum value: 100   </description></item>
        /// <item><description>Default value: 10</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The SQL ID, which uniquely identifies an SQL statement.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8D6E84735C0<b><b>1823D199E2CA1</b></b></para>
        /// </summary>
        [NameInMap("SQLId")]
        [Validation(Required=false)]
        public string SQLId { get; set; }

        /// <summary>
        /// <para>The start time of the time range for querying the execution history of the slow SQL statement.<br>The value must be UTC time in the format of YYYY-MM-DDThh:mm:ssZ.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-14T02:34:49Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t384tolsj****</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
