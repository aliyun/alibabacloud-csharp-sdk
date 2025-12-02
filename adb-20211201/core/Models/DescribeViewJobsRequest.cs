// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeViewJobsRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp1ub9grke1****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The owner of the view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("FilterOwner")]
        [Validation(Required=false)]
        public string FilterOwner { get; set; }

        /// <summary>
        /// <para>The name of the view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_mv</para>
        /// </summary>
        [NameInMap("FilterViewName")]
        [Validation(Required=false)]
        public string FilterViewName { get; set; }

        /// <summary>
        /// <para>The type of the view.</para>
        /// <para>Valid values:</para>
        /// <para>\-VIRTUAL_VIEW</para>
        /// <para>\-MATERIALIZED_VIEW</para>
        /// <para>This parameter is empty by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MATERIALIZED_VIEW</para>
        /// </summary>
        [NameInMap("FilterViewType")]
        [Validation(Required=false)]
        public string FilterViewType { get; set; }

        /// <summary>
        /// <para>The field used for sorting. Valid values for Type:</para>
        /// <list type="bullet">
        /// <item><description>Asc.</description></item>
        /// <item><description>Desc.</description></item>
        /// </list>
        /// <para>Valid values for Field:</para>
        /// <list type="bullet">
        /// <item><description>StartTime.</description></item>
        /// <item><description>EndTime;</description></item>
        /// <item><description>ScheduledStartTime;</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;Field\&quot;:\&quot;StartTime\&quot;,\&quot;Type\&quot;:\&quot;Desc\&quot;}</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo_db</para>
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

    }

}
