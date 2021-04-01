// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribleLayer7InstanceRelationsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Layer7InstanceRelations")]
        [Validation(Required=true)]
        public List<DescribleLayer7InstanceRelationsResponseLayer7InstanceRelations> Layer7InstanceRelations { get; set; }
        public class DescribleLayer7InstanceRelationsResponseLayer7InstanceRelations : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=true)]
            public string Domain { get; set; }

            [NameInMap("InstanceDetails")]
            [Validation(Required=true)]
            public List<DescribleLayer7InstanceRelationsResponseLayer7InstanceRelationsInstanceDetails> InstanceDetails { get; set; }
            public class DescribleLayer7InstanceRelationsResponseLayer7InstanceRelationsInstanceDetails : TeaModel {
                [NameInMap("InstanceId")]
                [Validation(Required=true)]
                public string InstanceId { get; set; }

                [NameInMap("FunctionVersion")]
                [Validation(Required=true)]
                public string FunctionVersion { get; set; }

                [NameInMap("EipList")]
                [Validation(Required=true)]
                public List<string> EipList { get; set; }

            }

        }

    }

}
