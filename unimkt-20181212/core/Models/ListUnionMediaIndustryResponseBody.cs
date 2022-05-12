// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class ListUnionMediaIndustryResponseBody : TeaModel {
        /// <summary>
        /// code
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListUnionMediaIndustryResponseBodyData> Data { get; set; }
        public class ListUnionMediaIndustryResponseBodyData : TeaModel {
            [NameInMap("IndustryCode")]
            [Validation(Required=false)]
            public string IndustryCode { get; set; }

            [NameInMap("IndustryName")]
            [Validation(Required=false)]
            public string IndustryName { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("ParentIndustryCode")]
            [Validation(Required=false)]
            public string ParentIndustryCode { get; set; }

            [NameInMap("UsedFlag")]
            [Validation(Required=false)]
            public bool? UsedFlag { get; set; }

        }

        /// <summary>
        /// errorMsg
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
