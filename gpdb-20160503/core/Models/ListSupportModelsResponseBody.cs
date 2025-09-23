// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListSupportModelsResponseBody : TeaModel {
        [NameInMap("ModelNames")]
        [Validation(Required=false)]
        public ListSupportModelsResponseBodyModelNames ModelNames { get; set; }
        public class ListSupportModelsResponseBodyModelNames : TeaModel {
            [NameInMap("modelNames")]
            [Validation(Required=false)]
            public List<string> ModelNames { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
