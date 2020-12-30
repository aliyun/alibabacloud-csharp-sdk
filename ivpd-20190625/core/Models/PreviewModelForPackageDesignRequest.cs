// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ivpd20190625.Models
{
    public class PreviewModelForPackageDesignRequest : TeaModel {
        [NameInMap("DataId")]
        [Validation(Required=false)]
        public string DataId { get; set; }

        [NameInMap("ModelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        [NameInMap("MaterialType")]
        [Validation(Required=false)]
        public string MaterialType { get; set; }

        [NameInMap("MaterialName")]
        [Validation(Required=false)]
        public string MaterialName { get; set; }

        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("ElementList")]
        [Validation(Required=false)]
        public List<PreviewModelForPackageDesignRequestElementList> ElementList { get; set; }
        public class PreviewModelForPackageDesignRequestElementList : TeaModel {
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            [NameInMap("SideName")]
            [Validation(Required=false)]
            public string SideName { get; set; }

        }

    }

}
