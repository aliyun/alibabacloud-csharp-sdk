// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20180528.Models
{
    public class AddMediaRequest : TeaModel {
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

        [NameInMap("CoverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileURL")]
        [Validation(Required=false)]
        public string FileURL { get; set; }

        [NameInMap("InputUnbind")]
        [Validation(Required=false)]
        public bool? InputUnbind { get; set; }

        [NameInMap("MediaWorkflowId")]
        [Validation(Required=false)]
        public string MediaWorkflowId { get; set; }

        [NameInMap("MediaWorkflowUserData")]
        [Validation(Required=false)]
        public string MediaWorkflowUserData { get; set; }

        [NameInMap("OverrideParams")]
        [Validation(Required=false)]
        public string OverrideParams { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
