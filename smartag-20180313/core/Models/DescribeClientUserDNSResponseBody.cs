// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeClientUserDNSResponseBody : TeaModel {
        /// <summary>
        /// <para>The primary and secondary DNS configurations used when the client of the Smart Access Gateway app instance connects to a private network.</para>
        /// </summary>
        [NameInMap("AppDNS")]
        [Validation(Required=false)]
        public List<string> AppDNS { get; set; }

        /// <summary>
        /// <para>The primary and secondary DNS configurations used when the client of the Smart Access Gateway app instance disconnects from a private network.</para>
        /// </summary>
        [NameInMap("RecoveredDNS")]
        [Validation(Required=false)]
        public List<string> RecoveredDNS { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>894AA8BD-0627-45B1-AA18-9CE1D50DA9D0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
