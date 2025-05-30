// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListResourceGroupsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Alibaba Cloud Resource Group ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2kqofrgXXXXX</para>
        /// </summary>
        [NameInMap("AliyunResourceGroupId")]
        [Validation(Required=false)]
        public string AliyunResourceGroupId { get; set; }

        /// <summary>
        /// <para>Alibaba Cloud tag list</para>
        /// </summary>
        [NameInMap("AliyunResourceTags")]
        [Validation(Required=false)]
        public string AliyunResourceTagsShrink { get; set; }

        /// <summary>
        /// <para>The name of a resource group, which is used for fuzzy match.</para>
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
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The billing method of resource groups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PrePaid</description></item>
        /// <item><description>PostPaid</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The types of resource groups to query. If you do not configure this parameter, only serverless resource groups are returned by default.</para>
        /// </summary>
        [NameInMap("ResourceGroupTypes")]
        [Validation(Required=false)]
        public string ResourceGroupTypesShrink { get; set; }

        /// <summary>
        /// <para>The fields used for sorting. Fields such as TriggerTime and StartedTime are supported. The value of this parameter is in the Sort field + Sort by (Desc/Asc) format. By default, results are sorted in ascending order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Id (Desc/Asc): the resource group ID</description></item>
        /// <item><description>Name (Desc/Asc): the name of the resource group</description></item>
        /// <item><description>Remark (Desc/Asc): the remarks of the resource group</description></item>
        /// <item><description>Type (Desc/Asc): the type of the resource group</description></item>
        /// <item><description>Status (Desc/Asc): the status of the resource group</description></item>
        /// <item><description>Spec (Desc/Asc): the specifications of the resource group</description></item>
        /// <item><description>CreateUser (Desc/Asc): the creator of the resource group</description></item>
        /// <item><description>CreateTime (Desc/Asc): the time when the resource group is created</description></item>
        /// </list>
        /// <para>Default value: CreateTime Asc</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime Asc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The statuses of resource groups.</para>
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public string StatusesShrink { get; set; }

    }

}
