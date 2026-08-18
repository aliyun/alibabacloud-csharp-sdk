// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListRoutesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the network resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public long? NetworkId { get; set; }

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
        /// <para>The unique identifier of the general quota.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Serverless_res_group_524257424564736_6831777003XXXXX</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of sort fields. Fields such as scheduled time and start time are supported. The format is &quot;sort field + sort order (Desc/Asc)&quot; (Asc is the default if omitted). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Id (Desc/Asc): route ID</description></item>
        /// <item><description>DestinationCidr (Desc/Asc): destination CIDR</description></item>
        /// <item><description>CreateTime (Desc/Asc): creation time</description></item>
        /// </list>
        /// <para>Default value: CreateTime Asc.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime Asc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

    }

}
