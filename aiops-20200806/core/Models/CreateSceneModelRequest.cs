// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class CreateSceneModelRequest : TeaModel {
        [NameInMap("FcFunctionName")]
        [Validation(Required=false)]
        public string FcFunctionName { get; set; }

        [NameInMap("FcHandler")]
        [Validation(Required=false)]
        public string FcHandler { get; set; }

        [NameInMap("FcInitializer")]
        [Validation(Required=false)]
        public string FcInitializer { get; set; }

        [NameInMap("FcRegionNo")]
        [Validation(Required=false)]
        public string FcRegionNo { get; set; }

        [NameInMap("FcServiceName")]
        [Validation(Required=false)]
        public string FcServiceName { get; set; }

        [NameInMap("ModelDesc")]
        [Validation(Required=false)]
        public string ModelDesc { get; set; }

        [NameInMap("ModelLanguage")]
        [Validation(Required=false)]
        public int? ModelLanguage { get; set; }

        [NameInMap("ModelMemo")]
        [Validation(Required=false)]
        public string ModelMemo { get; set; }

        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        [NameInMap("ModelType")]
        [Validation(Required=false)]
        public int? ModelType { get; set; }

        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

        [NameInMap("RootCauseDesc")]
        [Validation(Required=false)]
        public string RootCauseDesc { get; set; }

        [NameInMap("RootCauseSolution")]
        [Validation(Required=false)]
        public string RootCauseSolution { get; set; }

    }

}
