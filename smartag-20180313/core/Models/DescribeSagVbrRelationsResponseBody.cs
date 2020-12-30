// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagVbrRelationsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SagVbrRelations")]
        [Validation(Required=false)]
        public List<DescribeSagVbrRelationsResponseBodySagVbrRelations> SagVbrRelations { get; set; }
        public class DescribeSagVbrRelationsResponseBodySagVbrRelations : TeaModel {
            [NameInMap("VbrInstanceId")]
            [Validation(Required=false)]
            public string VbrInstanceId { get; set; }

            [NameInMap("SagUid")]
            [Validation(Required=false)]
            public string SagUid { get; set; }

            [NameInMap("SagInstanceId")]
            [Validation(Required=false)]
            public string SagInstanceId { get; set; }

        }

    }

}
