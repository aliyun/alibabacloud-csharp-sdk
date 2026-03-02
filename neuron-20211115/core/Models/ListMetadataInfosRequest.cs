// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class ListMetadataInfosRequest : TeaModel {
        [NameInMap("env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        [NameInMap("namespace_id")]
        [Validation(Required=false)]
        public long? NamespaceId { get; set; }

        [NameInMap("namespace_name")]
        [Validation(Required=false)]
        public string NamespaceName { get; set; }

        [NameInMap("order_by")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("order_direction")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        [NameInMap("org_id")]
        [Validation(Required=false)]
        public int? OrgId { get; set; }

        [NameInMap("page_number")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("pbc_id")]
        [Validation(Required=false)]
        public long? PbcId { get; set; }

    }

}
