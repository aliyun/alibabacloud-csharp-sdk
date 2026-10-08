// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class CheckProcessingServerLockApplyResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the domain name has a registry lock service request with the <b>Processing</b> status at the domain name registry. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: exists</description></item>
        /// <item><description>false: does not exist</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Exists")]
        [Validation(Required=false)]
        public bool? Exists { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9DFCF6F8-243C-****-8035-4B12FEFD7D48</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
