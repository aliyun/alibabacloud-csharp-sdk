// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryArtExtensionResponseBody : TeaModel {
        [NameInMap("DateOrPeriod")]
        [Validation(Required=false)]
        public string DateOrPeriod { get; set; }

        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public string Dimensions { get; set; }

        [NameInMap("Features")]
        [Validation(Required=false)]
        public string Features { get; set; }

        [NameInMap("InscriptionsAndMarkings")]
        [Validation(Required=false)]
        public string InscriptionsAndMarkings { get; set; }

        [NameInMap("Maker")]
        [Validation(Required=false)]
        public string Maker { get; set; }

        [NameInMap("MaterialsAndTechniques")]
        [Validation(Required=false)]
        public string MaterialsAndTechniques { get; set; }

        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        [NameInMap("Reference")]
        [Validation(Required=false)]
        public string Reference { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
