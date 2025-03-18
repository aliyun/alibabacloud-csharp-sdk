// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20210114.Models
{
    public class DescribeScreenScoreThreadResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeScreenScoreThreadResponseBodyData Data { get; set; }
        public class DescribeScreenScoreThreadResponseBodyData : TeaModel {
            [NameInMap("SocreThread")]
            [Validation(Required=false)]
            public List<string> SocreThread { get; set; }

            [NameInMap("SocreThreadDate")]
            [Validation(Required=false)]
            public List<string> SocreThreadDate { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D03DD0FD-6041-5107-AC00-383E28F1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
