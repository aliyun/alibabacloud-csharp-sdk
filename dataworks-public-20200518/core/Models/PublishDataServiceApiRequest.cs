// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class PublishDataServiceApiRequest : TeaModel {
        /// <summary>
        /// The ID of the API. You can call the [ListDataServiceApis](~~174009~~) operation to obtain the ID.
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public long? ApiId { get; set; }

        /// <summary>
        /// The ID of the DataWorks workspace. You can log on to the DataWorks console and go to the Workspace Management page to obtain the workspace ID.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

    }

}
