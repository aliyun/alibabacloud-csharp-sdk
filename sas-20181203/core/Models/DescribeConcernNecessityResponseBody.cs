// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeConcernNecessityResponseBody : TeaModel {
        /// <summary>
        /// <para>The priorities to fix the vulnerabilities. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>asap: high</description></item>
        /// <item><description>later: medium</description></item>
        /// <item><description>nntf: low</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ConcernNecessity")]
        [Validation(Required=false)]
        public List<string> ConcernNecessity { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECC6B3E3-D496-512D-B46D-E6996A6B63EE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
