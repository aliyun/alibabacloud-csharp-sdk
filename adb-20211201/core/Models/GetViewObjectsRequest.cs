// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetViewObjectsRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp1xxxxxxxx47</para>
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
        /// <para>test_filter</para>
        /// </summary>
        [NameInMap("FilterViewName")]
        [Validation(Required=false)]
        public string FilterViewName { get; set; }

        /// <summary>
        /// <para>The type of the view.</para>
        /// <para>Valid values:</para>
        /// <para>\-VIRTUAL_VIEW</para>
        /// <para>\-MATERIALIZED_VIEW</para>
        /// <para>Default value: null.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VIRTUAL_VIEW</para>
        /// </summary>
        [NameInMap("FilterViewType")]
        [Validation(Required=false)]
        public string FilterViewType { get; set; }

        /// <summary>
        /// <para>The order in which you want to sort the query results. Valid values for Type:</para>
        /// <list type="bullet">
        /// <item><description>Asc</description></item>
        /// <item><description>Desc</description></item>
        /// </list>
        /// <para>Valid values for Field: -ViewName</para>
        /// <para>\-CreateTime</para>
        /// <para>\-UpdateTime</para>
        /// <para>Default value: {&quot;Type&quot;: &quot;Desc&quot;,&quot;Field&quot;: &quot;ViewName&quot;}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Type&quot;: &quot;Desc&quot;,&quot;Field&quot;: &quot;ViewName&quot;}</para>
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
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>30</b> (default)</description></item>
        /// <item><description><b>50</b></description></item>
        /// <item><description><b>100</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the cluster.</para>
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

        [NameInMap("ShowMvBaseTable")]
        [Validation(Required=false)]
        public bool? ShowMvBaseTable { get; set; }

    }

}
