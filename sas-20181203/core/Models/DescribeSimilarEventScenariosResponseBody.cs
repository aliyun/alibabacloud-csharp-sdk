// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSimilarEventScenariosResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>FDF7B8D9-8493-4B90-8D13-E0C1FFCE5F97</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Scenarios")]
        [Validation(Required=false)]
        public List<DescribeSimilarEventScenariosResponseBodyScenarios> Scenarios { get; set; }
        public class DescribeSimilarEventScenariosResponseBodyScenarios : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>same_url</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

        }

    }

}
