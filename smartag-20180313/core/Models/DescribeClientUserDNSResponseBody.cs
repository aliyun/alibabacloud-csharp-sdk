// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeClientUserDNSResponseBody : TeaModel {
        /// <summary>
        /// <para>The active and standby DNS servers that the SAG app instance uses when it connects to private networks.</para>
        /// </summary>
        [NameInMap("AppDNS")]
        [Validation(Required=false)]
        public List<string> AppDNS { get; set; }

        /// <summary>
        /// <para>The active and standby DNS servers that the SAG app instance uses when it disconnects from private networks.</para>
        /// </summary>
        [NameInMap("RecoveredDNS")]
        [Validation(Required=false)]
        public List<string> RecoveredDNS { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>894AA8BD-0627-45B1-AA18-9CE1D50DA9D0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
