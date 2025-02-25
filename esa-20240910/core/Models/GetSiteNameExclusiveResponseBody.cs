// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetSiteNameExclusiveResponseBody : TeaModel {
        /// <summary>
        /// <para>Feature switch. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public string Enable { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35C66C7B-671H-4297-9187-2C4477247A78</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
