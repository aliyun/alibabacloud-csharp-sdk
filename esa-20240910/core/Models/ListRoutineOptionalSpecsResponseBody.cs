// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListRoutineOptionalSpecsResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Specs")]
        [Validation(Required=false)]
        public List<ListRoutineOptionalSpecsResponseBodySpecs> Specs { get; set; }
        public class ListRoutineOptionalSpecsResponseBodySpecs : TeaModel {
            [NameInMap("IsAvailable")]
            [Validation(Required=false)]
            public bool? IsAvailable { get; set; }

            [NameInMap("SpecName")]
            [Validation(Required=false)]
            public string SpecName { get; set; }

        }

    }

}
