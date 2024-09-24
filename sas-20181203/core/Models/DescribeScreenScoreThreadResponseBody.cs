// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeScreenScoreThreadResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeScreenScoreThreadResponseBodyData Data { get; set; }
        public class DescribeScreenScoreThreadResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The trends of the scores on the security dashboard.</para>
            /// </summary>
            [NameInMap("SocreThread")]
            [Validation(Required=false)]
            public List<string> SocreThread { get; set; }

            /// <summary>
            /// <para>The dates of the scores on the security dashboard.</para>
            /// </summary>
            [NameInMap("SocreThreadDate")]
            [Validation(Required=false)]
            public List<string> SocreThreadDate { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D03DD0FD-6041-5107-AC00-383E28F1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
