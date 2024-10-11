// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class DescribeDbfsSpecificationsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MaxDbfsNumberPerEcs")]
        [Validation(Required=false)]
        public Dictionary<string, object> MaxDbfsNumberPerEcs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SupportedEcsInstanceTypeFamily")]
        [Validation(Required=false)]
        public List<string> SupportedEcsInstanceTypeFamily { get; set; }

    }

}
