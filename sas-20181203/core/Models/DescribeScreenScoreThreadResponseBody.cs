// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeScreenScoreThreadResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeScreenScoreThreadResponseBodyData Data { get; set; }
        public class DescribeScreenScoreThreadResponseBodyData : TeaModel {
            /// <summary>
            /// The trends of the scores on the security dashboard.
            /// </summary>
            [NameInMap("SocreThread")]
            [Validation(Required=false)]
            public List<string> SocreThread { get; set; }

            /// <summary>
            /// The dates of the scores on the security dashboard.
            /// </summary>
            [NameInMap("SocreThreadDate")]
            [Validation(Required=false)]
            public List<string> SocreThreadDate { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
