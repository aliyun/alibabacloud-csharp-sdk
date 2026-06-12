// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateAzureBlobIngestionRequest : TeaModel {
        /// <summary>
        /// <para>The updated configuration for the Azure Blob ingestion task.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public AzureBlobIngestionConfiguration Configuration { get; set; }

        /// <summary>
        /// <para>The updated description for the Azure Blob ingestion task.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The updated display name for the Azure Blob ingestion task.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The updated ingestion schedule.</para>
        /// </summary>
        [NameInMap("schedule")]
        [Validation(Required=false)]
        public Schedule Schedule { get; set; }

    }

}
