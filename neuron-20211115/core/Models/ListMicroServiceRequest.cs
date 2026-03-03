// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class ListMicroServiceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>gmtCreated</para>
        /// </summary>
        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("orderDirection")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pbcId")]
        [Validation(Required=false)]
        public long? PbcId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("serviceIds")]
        [Validation(Required=false)]
        public string ServiceIds { get; set; }

    }

}
