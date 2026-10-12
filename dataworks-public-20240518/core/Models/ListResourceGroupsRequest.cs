// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListResourceGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2kqofrgXXXXX</para>
        /// </summary>
        [NameInMap("AliyunResourceGroupId")]
        [Validation(Required=false)]
        public string AliyunResourceGroupId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud tags.</para>
        /// </summary>
        [NameInMap("AliyunResourceTags")]
        [Validation(Required=false)]
        public List<ListResourceGroupsRequestAliyunResourceTags> AliyunResourceTags { get; set; }
        public class ListResourceGroupsRequestAliyunResourceTags : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The name of the resource group for fuzzy match.</para>
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
        /// <para>The billing method of the resource group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PrePaid: Subscription.</description></item>
        /// <item><description>PostPaid: Pay-as-you-go.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the resource group belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The types of the resource groups to query. <b>If this parameter is left empty, general-purpose resource groups are queried by default.</b></para>
        /// </summary>
        [NameInMap("ResourceGroupTypes")]
        [Validation(Required=false)]
        public List<string> ResourceGroupTypes { get; set; }

        /// <summary>
        /// <para>The fields by which to sort the results. You can sort the results by fields such as scheduled time and start time. The format is \&quot;Sort field+Sort order (Desc/Asc)\&quot;. Asc can be omitted. Valid values for the sort field:</para>
        /// <list type="bullet">
        /// <item><description>Id (Desc/Asc): The ID of the resource group.</description></item>
        /// <item><description>Name (Desc/Asc): The name of the resource group.</description></item>
        /// <item><description>Remark (Desc/Asc): The description of the resource group.</description></item>
        /// <item><description>Type (Desc/Asc): The type of the resource group.</description></item>
        /// <item><description>Status (Desc/Asc): The status of the resource group.</description></item>
        /// <item><description>Spec (Desc/Asc): The specifications of the resource group.</description></item>
        /// <item><description>CreateUser (Desc/Asc): The creator of the resource group.</description></item>
        /// <item><description>CreateTime (Desc/Asc): The time when the resource group was created.</description></item>
        /// </list>
        /// <para>Default value: CreateTime Asc.</para>
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
        public List<string> Statuses { get; set; }

    }

}
