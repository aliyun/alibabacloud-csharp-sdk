// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateEditingProjectRequest : TeaModel {
        [NameInMap("BusinessConfig")]
        [Validation(Required=false)]
        public string BusinessConfig { get; set; }

        [NameInMap("ClipsParam")]
        [Validation(Required=false)]
        public string ClipsParam { get; set; }

        [NameInMap("CoverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("MaterialMaps")]
        [Validation(Required=false)]
        public string MaterialMaps { get; set; }

        [NameInMap("ProjectType")]
        [Validation(Required=false)]
        public string ProjectType { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        [NameInMap("Timeline")]
        [Validation(Required=false)]
        public string Timeline { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
