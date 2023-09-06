// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetRangeResponseBody : TeaModel {
        [NameInMap("backgroundColors")]
        [Validation(Required=false)]
        public List<List<GetRangeResponseBodyBackgroundColors>> BackgroundColors { get; set; }
        public class GetRangeResponseBodyBackgroundColors : TeaModel {
            /// <summary>
            /// red
            /// </summary>
            [NameInMap("Red")]
            [Validation(Required=false)]
            public int? Red { get; set; }

            /// <summary>
            /// green
            /// </summary>
            [NameInMap("Green")]
            [Validation(Required=false)]
            public int? Green { get; set; }

            /// <summary>
            /// blue
            /// </summary>
            [NameInMap("Blue")]
            [Validation(Required=false)]
            public int? Blue { get; set; }

            /// <summary>
            /// hexString
            /// </summary>
            [NameInMap("HexString")]
            [Validation(Required=false)]
            public string HexString { get; set; }

        }

        [NameInMap("displayValues")]
        [Validation(Required=false)]
        public List<List<string>> DisplayValues { get; set; }

        [NameInMap("formulas")]
        [Validation(Required=false)]
        public List<List<string>> Formulas { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("values")]
        [Validation(Required=false)]
        public List<List<object>> Values { get; set; }

    }

}
