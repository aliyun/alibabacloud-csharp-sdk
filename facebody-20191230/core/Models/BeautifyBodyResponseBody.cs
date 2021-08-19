// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class BeautifyBodyResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BeautifyBodyResponseBodyData Data { get; set; }
        public class BeautifyBodyResponseBodyData : TeaModel {
            [NameInMap("XFlowURL")]
            [Validation(Required=false)]
            public string XFlowURL { get; set; }
            [NameInMap("YFlowURL")]
            [Validation(Required=false)]
            public string YFlowURL { get; set; }
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
