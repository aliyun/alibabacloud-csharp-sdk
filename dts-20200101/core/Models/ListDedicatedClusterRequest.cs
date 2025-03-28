// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ListDedicatedClusterRequest : TeaModel {
        /// <summary>
        /// <para>The basis on which the retrieved entries are sorted if multiple DTS dedicated clusters are returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>gmtCreated</b>: the time when a cluster was created.</description></item>
        /// <item><description><b>orderCount</b>: the number of nodes in a cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>gmtCreated</para>
        /// </summary>
        [NameInMap("OrderColumn")]
        [Validation(Required=false)]
        public string OrderColumn { get; set; }

        /// <summary>
        /// <para>The order in which you want to sort the retrieved entries. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>asc: sorts the retrieved entries in ascending order. This is the default value.</description></item>
        /// <item><description>desc: sorts the retrieved entries in descending order.</description></item>
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
        /// <para>The number of the page to return. The value of this parameter must be an integer that is greater than 0. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of clusters to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The content of the query condition.</para>
        /// <remarks>
        /// <para> You must set the <b>Type parameter</b> to specify the type of the query condition.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dtspk3f13r731m****</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
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
        /// <para>The status of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>init</b>: The cluster is being initialized.</description></item>
        /// <item><description><b>schedule</b>: The cluster is pending scheduling.</description></item>
        /// <item><description><b>running</b>: The cluster is running.</description></item>
        /// <item><description><b>upgrade</b>: The cluster is being upgraded.</description></item>
        /// <item><description><b>downgrade</b>: The cluster is being downgraded.</description></item>
        /// <item><description><b>locked</b>: The cluster is locked.</description></item>
        /// <item><description><b>releasing</b>: The cluster is being released.</description></item>
        /// <item><description><b>released</b>: The cluster is released.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>init</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The type of the query condition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NAME</b>: the name of the cluster.</description></item>
        /// <item><description><b>INSTANCE</b>: the ID of a cluster instance.</description></item>
        /// <item><description><b>DEDICAETEDCLUSTERID</b>: the ID of a dedicated cluster.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You must specify the query condition by using the <b>Params</b> parameter.</para>
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
