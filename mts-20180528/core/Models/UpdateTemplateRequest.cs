// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20180528.Models
{
    public class UpdateTemplateRequest : TeaModel {
        [NameInMap("Audio")]
        [Validation(Required=false)]
        public string Audio { get; set; }

        [NameInMap("Container")]
        [Validation(Required=false)]
        public string Container { get; set; }

        [NameInMap("MuxConfig")]
        [Validation(Required=false)]
        public string MuxConfig { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("TransConfig")]
        [Validation(Required=false)]
        public string TransConfig { get; set; }

        [NameInMap("Video")]
        [Validation(Required=false)]
        public string Video { get; set; }

    }

}
