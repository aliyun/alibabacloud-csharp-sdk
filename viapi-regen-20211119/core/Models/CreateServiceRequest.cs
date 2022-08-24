// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_regen20211119.Models
{
    public class CreateServiceRequest : TeaModel {
        [NameInMap("AuthorizationType")]
        [Validation(Required=false)]
        public string AuthorizationType { get; set; }

        [NameInMap("AuthorizedAccount")]
        [Validation(Required=false)]
        public string AuthorizedAccount { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("TrainTaskId")]
        [Validation(Required=false)]
        public long? TrainTaskId { get; set; }

    }

}
