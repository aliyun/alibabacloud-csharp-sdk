// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ListEcsSpecsRequest : TeaModel {
        /// <summary>
        /// <para>Filter by accelerator type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CPU</description></item>
        /// <item><description>GPU</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GPU</para>
        /// </summary>
        [NameInMap("AcceleratorType")]
        [Validation(Required=false)]
        public string AcceleratorType { get; set; }

        /// <summary>
        /// <para>The instance types to query. Separate the types with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.large,ecs.g6.xlarge</para>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public string InstanceTypes { get; set; }

        /// <summary>
        /// <para>The sorting order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>desc: descending order.</description></item>
        /// <item><description>asc: ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The number of the page to query. The start value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The type of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ECS</description></item>
        /// <item><description>Lingjun</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The field based on which the results are sorted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CPU</description></item>
        /// <item><description>GPU</description></item>
        /// <item><description>Memory</description></item>
        /// <item><description>GmtCreateTime</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Gpu</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

    }

}
