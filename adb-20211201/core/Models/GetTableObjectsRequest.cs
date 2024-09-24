// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetTableObjectsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp1565u55p32****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The description of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("FilterDescription")]
        [Validation(Required=false)]
        public string FilterDescription { get; set; }

        /// <summary>
        /// <para>The owner of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("FilterOwner")]
        [Validation(Required=false)]
        public string FilterOwner { get; set; }

        /// <summary>
        /// <para>The name of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_tbl</para>
        /// </summary>
        [NameInMap("FilterTblName")]
        [Validation(Required=false)]
        public string FilterTblName { get; set; }

        /// <summary>
        /// <para>The type of the table.</para>
        /// <para>Valid values:</para>
        /// <para>DIMENSION_TABLE</para>
        /// <para>FACT_TABLE</para>
        /// <para>EXTERNAL_TABLE</para>
        /// <para>Default value: null.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FACT_TABLE</para>
        /// </summary>
        [NameInMap("FilterTblType")]
        [Validation(Required=false)]
        public string FilterTblType { get; set; }

        /// <summary>
        /// <para>The order in which the fields to be returned are sorted.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Asc</description></item>
        /// <item><description>Desc</description></item>
        /// </list>
        /// <para>Values for fields:</para>
        /// <para>TableName</para>
        /// <para>TableSize</para>
        /// <para>CreateTime</para>
        /// <para>UpdateTime</para>
        /// <para>Default value: {&quot;Type&quot;: &quot;Desc&quot;,&quot;Field&quot;: &quot;TableName&quot;};</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Type&quot;: &quot;Desc&quot;,&quot;Field&quot;: &quot;TableName&quot;}</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The number of the page to return. The value is an integer that is greater than 0. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values:</para>
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
        /// <para>The ID of the region in which the cluster resides.</para>
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
