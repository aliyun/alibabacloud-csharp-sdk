// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetTableObjectsRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp1565u55p32****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("FilterDescription")]
        [Validation(Required=false)]
        public string FilterDescription { get; set; }

        /// <summary>
        /// <para>The owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("FilterOwner")]
        [Validation(Required=false)]
        public string FilterOwner { get; set; }

        /// <summary>
        /// <para>The table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_tbl</para>
        /// </summary>
        [NameInMap("FilterTblName")]
        [Validation(Required=false)]
        public string FilterTblName { get; set; }

        /// <summary>
        /// <para>The table type.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DIMENSION_TABLE</description></item>
        /// <item><description>FACT_TABLE</description></item>
        /// <item><description>EXTERNAL_TABLE</description></item>
        /// </list>
        /// <para>Default value: null.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FACT_TABLE</para>
        /// </summary>
        [NameInMap("FilterTblType")]
        [Validation(Required=false)]
        public string FilterTblType { get; set; }

        /// <summary>
        /// <para>The sorting field.</para>
        /// <para>Valid values for Type:</para>
        /// <list type="bullet">
        /// <item><description>Asc</description></item>
        /// <item><description>Desc</description></item>
        /// </list>
        /// <para>Valid values for Field:</para>
        /// <list type="bullet">
        /// <item><description>TableName</description></item>
        /// <item><description>TableSize</description></item>
        /// <item><description>CreateTime</description></item>
        /// <item><description>UpdateTime</description></item>
        /// </list>
        /// <para>Default value: {&quot;Type&quot;: &quot;Desc&quot;,&quot;Field&quot;: &quot;TableName&quot;}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Type&quot;: &quot;Desc&quot;,&quot;Field&quot;: &quot;TableName&quot;}</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page number. The value must be a positive integer that does not exceed the maximum value of the Integer data type. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>30</description></item>
        /// <item><description>50</description></item>
        /// <item><description>100</description></item>
        /// </list>
        /// <para>Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adb_demo</para>
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

    }

}
