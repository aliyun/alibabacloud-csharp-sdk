// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateFacesSearchingTaskRequest : TeaModel {
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        [NameInMap("MaxResult")]
        [Validation(Required=false)]
        public long? MaxResult { get; set; }

        [NameInMap("Notification")]
        [Validation(Required=false)]
        public Notification Notification { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("Sources")]
        [Validation(Required=false)]
        public List<CreateFacesSearchingTaskRequestSources> Sources { get; set; }
        public class CreateFacesSearchingTaskRequestSources : TeaModel {
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
