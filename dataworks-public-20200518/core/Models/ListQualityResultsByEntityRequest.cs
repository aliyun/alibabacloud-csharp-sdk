// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListQualityResultsByEntityRequest : TeaModel {
        /// <summary>
        /// The name of the compute engine instance or data source. You can obtain the name from data source configurations.
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 10. Maximum value: 100.
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public long? EntityId { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
