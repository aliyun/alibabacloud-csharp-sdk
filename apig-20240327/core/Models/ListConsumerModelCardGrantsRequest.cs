// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListConsumerModelCardGrantsRequest : TeaModel {
        /// <summary>
        /// <para>Filters by model card ID for reverse lookup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>msc-d00000000000000000000</para>
        /// </summary>
        [NameInMap("modelCardId")]
        [Validation(Required=false)]
        public string ModelCardId { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Filters by principal ID. This parameter must be used together with principalType.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs-d00000000000000000000</para>
        /// </summary>
        [NameInMap("principalId")]
        [Validation(Required=false)]
        public string PrincipalId { get; set; }

        /// <summary>
        /// <para>Filters by principal type. Valid values: Consumer and ConsumerGroup. This parameter must be used together with principalId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Consumer</para>
        /// </summary>
        [NameInMap("principalType")]
        [Validation(Required=false)]
        public string PrincipalType { get; set; }

    }

}
