// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeConcernNecessityResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of vulnerability fix necessity levels. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>asap: high.</para>
        /// </description></item>
        /// <item><description><para>later: medium.</para>
        /// </description></item>
        /// <item><description><para>nntf: low.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ConcernNecessity")]
        [Validation(Required=false)]
        public List<string> ConcernNecessity { get; set; }

        /// <summary>
        /// <para>The ID of the request. The ID is a unique identifier that Alibaba Cloud generates for the request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECC6B3E3-D496-512D-B46D-E6996A6B63EE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
