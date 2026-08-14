// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ListDedicatedClusterRequest : TeaModel {
        /// <summary>
        /// <para>The sort column when the response contains multiple DTS dedicated cluster instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>gmtCreated</b>: creation time.</description></item>
        /// <item><description><b>orderCount</b>: number of nodes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>gmtCreated</para>
        /// </summary>
        [NameInMap("OrderColumn")]
        [Validation(Required=false)]
        public string OrderColumn { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>asc</b>: ascending order. This is the default value.</description></item>
        /// <item><description><b>desc</b>: descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("OrderDirection")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be a positive integer that does not exceed the maximum value of the Integer data type. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of clusters to display per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The specific content of the query condition.</para>
        /// <remarks>
        /// <para>You must first specify the <b>Type</b> parameter to define the query key.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dtspk3f13r731m****</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>The region ID. This parameter is used as a query condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfntftbiobqyky</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The cluster status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>init</b>: initializing.</description></item>
        /// <item><description><b>schedule</b>: pending scheduling.</description></item>
        /// <item><description><b>running</b>: running.</description></item>
        /// <item><description><b>upgrade</b>: upgrading.</description></item>
        /// <item><description><b>downgrade</b>: downgrading.</description></item>
        /// <item><description><b>locked</b>: locked.</description></item>
        /// <item><description><b>releasing</b>: being released.</description></item>
        /// <item><description><b>released</b>: released.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>init</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The query key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NAME</b>: cluster name.</description></item>
        /// <item><description><b>INSTANCE</b>: cluster instance ID.</description></item>
        /// <item><description><b>DEDICATEDCLUSTERID</b>: dedicated cluster ID.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You must also specify the <b>Params</b> parameter to provide the specific content of the query condition.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>NAME</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
