// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetDatabaseObjectsRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp1565u55p32****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The owner of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("FilterOwner")]
        [Validation(Required=false)]
        public string FilterOwner { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_db</para>
        /// </summary>
        [NameInMap("FilterSchemaName")]
        [Validation(Required=false)]
        public string FilterSchemaName { get; set; }

        /// <summary>
        /// <para>The order in which you want to sort the query results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Asc</description></item>
        /// <item><description>Desc</description></item>
        /// </list>
        /// <para>Valid values for Field: DatabaseName, CreateTime, and UpdateTime. -CreateTime; -UpdateTime;</para>
        /// <para>Default value: {&quot;Type&quot;: &quot;Desc&quot;,&quot;Field&quot;: &quot;DatabaseName&quot;}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Type&quot;: &quot;Desc&quot;,&quot;Field&quot;: &quot;DbName&quot;}</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: <b>1</b>.</para>
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
        /// <para>The region ID of the database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
