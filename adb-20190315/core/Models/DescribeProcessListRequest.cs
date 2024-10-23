// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeProcessListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp11q28kvl688****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The keyword in an SQL statement, which is used to filter queries. Set the value to <b>SELECT</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The order in which queries are sorted based on the specified fields. Specify this parameter as an ordered JSON array in the <c>[{&quot;Field&quot;:&quot;Time&quot;,&quot;Type&quot;:&quot;Desc&quot; },{ &quot;Field&quot;:&quot;User&quot;, &quot;Type&quot;:&quot;Asc&quot; }]</c> format.</para>
        /// <list type="bullet">
        /// <item><description><b>Field</b> specifies the field used to sort queries. Valid values: Time, User, Host, and DB.</description></item>
        /// <item><description><b>Type</b> specifies the sorting sequence. Valid values: <b>Desc</b> and <b>Asc</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[ { &quot;Field&quot;:&quot;Time&quot;,&quot;Type&quot;:&quot;Desc&quot; },  { &quot;Field&quot;:&quot;User&quot;, &quot;Type&quot;:&quot;Asc&quot; }]</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of the page to return. The value must be an integer that is greater than 0. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 30. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>30</b></description></item>
        /// <item><description><b>50</b></description></item>
        /// <item><description><b>100</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The execution duration used to filter queries. Queries that take a longer time than the specified execution duration are displayed. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("RunningTime")]
        [Validation(Required=false)]
        public int? RunningTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to show a complete SQL statement. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: shows a complete SQL statement.</description></item>
        /// <item><description><b>False</b>: shows only the first 100 characters of an SQL statement.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The default value is False.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("ShowFull")]
        [Validation(Required=false)]
        public bool? ShowFull { get; set; }

        /// <summary>
        /// <para>The name of the user used to filter queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
