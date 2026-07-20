// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetCacheReserveResponseBody : TeaModel {
        /// <summary>
        /// <para>The cache reserve instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cr_hk_123456789</para>
        /// </summary>
        [NameInMap("CacheReserveInstanceId")]
        [Validation(Required=false)]
        public string CacheReserveInstanceId { get; set; }

        /// <summary>
        /// <para>The switch status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: Enabled.</description></item>
        /// <item><description><b>off</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public string Enable { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F61CDR30-E83C-4FDA-BF73-9A94CDD44229</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
