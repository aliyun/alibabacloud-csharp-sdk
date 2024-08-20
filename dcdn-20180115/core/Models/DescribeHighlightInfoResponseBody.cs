// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeHighlightInfoResponseBody : TeaModel {
        /// <summary>
        /// The data model of the highlighted data.
        /// </summary>
        [NameInMap("DataModule")]
        [Validation(Required=false)]
        public List<DescribeHighlightInfoResponseBodyDataModule> DataModule { get; set; }
        public class DescribeHighlightInfoResponseBodyDataModule : TeaModel {
            /// <summary>
            /// The highlighted data.
            /// </summary>
            [NameInMap("Hit")]
            [Validation(Required=false)]
            public string Hit { get; set; }

            /// <summary>
            /// The type of the highlighted data.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The complete data.
            /// </summary>
            [NameInMap("Raw")]
            [Validation(Required=false)]
            public string Raw { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
