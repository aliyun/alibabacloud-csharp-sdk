// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class RegisterMediaInfoRequest : TeaModel {
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("CoverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InputURL")]
        [Validation(Required=false)]
        public string InputURL { get; set; }

        [NameInMap("MediaTags")]
        [Validation(Required=false)]
        public string MediaTags { get; set; }

        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        [NameInMap("Overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

        [NameInMap("ReferenceId")]
        [Validation(Required=false)]
        public string ReferenceId { get; set; }

        [NameInMap("RegisterConfig")]
        [Validation(Required=false)]
        public string RegisterConfig { get; set; }

        [NameInMap("SmartTagTemplateId")]
        [Validation(Required=false)]
        public string SmartTagTemplateId { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

    }

}
