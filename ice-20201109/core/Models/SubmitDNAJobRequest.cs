// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitDNAJobRequest : TeaModel {
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBId")]
        [Validation(Required=false)]
        public string DBId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitDNAJobRequestInput Input { get; set; }
        public class SubmitDNAJobRequestInput : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("PrimaryKey")]
        [Validation(Required=false)]
        public string PrimaryKey { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
