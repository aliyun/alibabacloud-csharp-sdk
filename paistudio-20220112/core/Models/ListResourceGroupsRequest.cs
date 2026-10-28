// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListResourceGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The compute resource type of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ecs</para>
        /// </summary>
        [NameInMap("ComputingResourceProvider")]
        [Validation(Required=false)]
        public string ComputingResourceProvider { get; set; }

        /// <summary>
        /// <para>Specifies whether the resource group contains resources.</para>
        /// </summary>
        [NameInMap("HasResource")]
        [Validation(Required=false)]
        public bool? HasResource { get; set; }

        /// <summary>
        /// <para>The name of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rgf0zhfqn1d4ity2</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
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
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The list of resource group IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg123,rg456</para>
        /// </summary>
        [NameInMap("ResourceGroupIDs")]
        [Validation(Required=false)]
        public string ResourceGroupIDs { get; set; }

        /// <summary>
        /// <para>The list of resource types. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ECS: general compute resources.</description></item>
        /// <item><description>Lingjun: Lingjun AI compute resources.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Lingjun</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>Specifies whether to return all results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ShowAll")]
        [Validation(Required=false)]
        public bool? ShowAll { get; set; }

        /// <summary>
        /// <para>The name of the field used for sorting. Valid values: DisplayName, GmtCreated, GmtModified, RegionID, Duration, PricingCycle, and PayType.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DisplayName</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The status of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Creating</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The version to search for.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("Versions")]
        [Validation(Required=false)]
        public string Versions { get; set; }

    }

}
