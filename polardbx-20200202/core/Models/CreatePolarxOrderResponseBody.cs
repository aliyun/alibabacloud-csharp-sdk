// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class CreatePolarxOrderResponseBody : TeaModel {
        [NameInMap("OrderResultList")]
        [Validation(Required=false)]
        public List<CreatePolarxOrderResponseBodyOrderResultList> OrderResultList { get; set; }
        public class CreatePolarxOrderResponseBodyOrderResultList : TeaModel {
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
