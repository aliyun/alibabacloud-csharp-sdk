// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeAppLiveStreamStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the switch. enable indicates that the feature is enabled. disable indicates that the feature is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>disable</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

    }

}
