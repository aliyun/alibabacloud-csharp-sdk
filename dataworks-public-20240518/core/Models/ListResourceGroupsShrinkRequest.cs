// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListResourceGroupsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2kqofrgXXXXX</para>
        /// </summary>
        [NameInMap("AliyunResourceGroupId")]
        [Validation(Required=false)]
        public string AliyunResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of Alibaba Cloud tags.</para>
        /// </summary>
        [NameInMap("AliyunResourceTags")]
        [Validation(Required=false)]
        public string AliyunResourceTagsShrink { get; set; }

        /// <summary>
        /// <para>The name of the resource group. Fuzzy search is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Resource</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The billing method of the resource group. Valid values include:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PrePaid</c>: subscription.</para>
        /// </description></item>
        /// <item><description><para><c>PostPaid</c>: pay-as-you-go.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The ID of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The types of the resource groups to query. <b>If this parameter is not specified, general-purpose resource groups are queried by default.</b></para>
        /// </summary>
        [NameInMap("ResourceGroupTypes")]
        [Validation(Required=false)]
        public string ResourceGroupTypesShrink { get; set; }

        /// <summary>
        /// <para>The sorting criterion for the results. The format is <c>FieldName SortOrder</c>. <c>SortOrder</c> can be <c>Asc</c> (ascending) or <c>Desc</c> (descending). If you do not specify <c>SortOrder</c>, the default is <c>Asc</c>. The following fields are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Id</c>: Resource group ID</para>
        /// </description></item>
        /// <item><description><para><c>Name</c>: Resource group name</para>
        /// </description></item>
        /// <item><description><para><c>Remark</c>: Resource group remarks</para>
        /// </description></item>
        /// <item><description><para><c>Type</c>: Resource group type</para>
        /// </description></item>
        /// <item><description><para><c>Status</c>: Resource group status</para>
        /// </description></item>
        /// <item><description><para><c>Spec</c>: Resource group specifications</para>
        /// </description></item>
        /// <item><description><para><c>CreateUser</c>: The user who created the resource group</para>
        /// </description></item>
        /// <item><description><para><c>CreateTime</c>: The time when the resource group was created</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>CreateTime Asc</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime Asc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The statuses of the resource groups to query.</para>
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public string StatusesShrink { get; set; }

    }

}
