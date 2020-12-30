// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribleLayer7InstanceRelationsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Layer7InstanceRelations")]
        [Validation(Required=false)]
        public List<DescribleLayer7InstanceRelationsResponseBodyLayer7InstanceRelations> Layer7InstanceRelations { get; set; }
        public class DescribleLayer7InstanceRelationsResponseBodyLayer7InstanceRelations : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("InstanceDetails")]
            [Validation(Required=false)]
            public List<DescribleLayer7InstanceRelationsResponseBodyLayer7InstanceRelationsInstanceDetails> InstanceDetails { get; set; }
            public class DescribleLayer7InstanceRelationsResponseBodyLayer7InstanceRelationsInstanceDetails : TeaModel {
                [NameInMap("EipList")]
                [Validation(Required=false)]
                public List<string> EipList { get; set; }

                [NameInMap("FunctionVersion")]
                [Validation(Required=false)]
                public string FunctionVersion { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

        }

    }

}
