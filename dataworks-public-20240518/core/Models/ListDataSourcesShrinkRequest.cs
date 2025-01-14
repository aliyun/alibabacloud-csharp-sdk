// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataSourcesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The environment in which the data sources are used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Dev: development environment</description></item>
        /// <item><description>Prod: production environment</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prod</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>The name of the data source. Fuzzy match by data source name is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The order in which you want to sort the data sources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Desc: descending order</description></item>
        /// <item><description>Asc: ascending order</description></item>
        /// </list>
        /// <para>Default value: Asc</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to query the ID.</para>
        /// <para>You must configure this parameter to specify the DataWorks workspace to which the API operation is applied.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17820</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The field that you want to use to sort the data sources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CreateTime</description></item>
        /// <item><description>Id</description></item>
        /// <item><description>Name</description></item>
        /// </list>
        /// <para>Default value: Id</para>
        /// 
        /// <b>Example:</b>
        /// <para>Id</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The tag of the data source. This parameter specifies a filter condition.</para>
        /// <list type="bullet">
        /// <item><description>You can specify multiple tags, which are in the logical AND relation. For example, you can query the data sources that contain the following tags: <c>[&quot;tag1&quot;, &quot;tag2&quot;, &quot;tag3&quot;]</c>.</description></item>
        /// <item><description>If you do not configure this parameter, tag-based filtering is not performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;tag1&quot;, &quot;tag2&quot;, &quot;tag3&quot;]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The data source types. This parameter specifies a filter condition. You can specify multiple data source types.</para>
        /// </summary>
        [NameInMap("Types")]
        [Validation(Required=false)]
        public string TypesShrink { get; set; }

    }

}
