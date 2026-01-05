// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListComputeResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The environment type of the computing resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Dev</description></item>
        /// <item><description>Prod</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Dev</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>The name of the computing resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>category name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The sort direction of the computing resource list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Desc: descending order.</description></item>
        /// <item><description>Asc: ascending order.</description></item>
        /// </list>
        /// <para>Default value: Desc</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number to query. The default value is 1, which indicates the first page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The default value is 10, and the maximum value is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21229</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The field to sort the computing resource list by. Supported fields include name, creation time, and computing resource ID.</para>
        /// <list type="bullet">
        /// <item><description>CreateTime: Sorts by creation time</description></item>
        /// <item><description>Id: Sorts by computing resource ID</description></item>
        /// <item><description>Name: Sorts by computing resource name.</description></item>
        /// <item><description>CreateTimeWithDefaultFirst: Sorts based on whether it is the default resource and by creation time, with the default computing resource listed first.</description></item>
        /// </list>
        /// <para>Default value: CreateTime</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTimeWithDefaultFirst</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The filter for computing resource types. You can configure multiple types for filtering.</para>
        /// </summary>
        [NameInMap("Types")]
        [Validation(Required=false)]
        public List<string> Types { get; set; }

    }

}
