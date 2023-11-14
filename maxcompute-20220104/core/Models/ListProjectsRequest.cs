// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListProjectsRequest : TeaModel {
        [NameInMap("listSystemCatalog")]
        [Validation(Required=false)]
        public bool? ListSystemCatalog { get; set; }

        /// <summary>
        /// The maximum number of entries to return on each page.
        /// </summary>
        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// The maximum number of entries returned per page.
        /// </summary>
        [NameInMap("maxItem")]
        [Validation(Required=false)]
        public int? MaxItem { get; set; }

        /// <summary>
        /// Specifies the marker after which the returned list begins.
        /// </summary>
        [NameInMap("prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// The name of the quota. The value of this parameter is the identifier of the quota in MaxCompute, which differs from the quotaNickname parameter. You can configure the quotaNickname parameter. The system automatically generates a value for the quotaName parameter. This parameter is only used to describe the tunnel quota.
        /// </summary>
        [NameInMap("quotaName")]
        [Validation(Required=false)]
        public string QuotaName { get; set; }

        /// <summary>
        /// The name of the quota.
        /// </summary>
        [NameInMap("quotaNickName")]
        [Validation(Required=false)]
        public string QuotaNickName { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The identifier of an object in a MaxCompute quota. This identifier is the same as the identifier in the sales bill of Alibaba Cloud. This parameter is used for tags.
        /// </summary>
        [NameInMap("saleTags")]
        [Validation(Required=false)]
        public string SaleTags { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// The project type. Valid values: external and managed. The value external indicates an external project, which is used in the data lakehouse solution. The value managed indicates an internal project.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
