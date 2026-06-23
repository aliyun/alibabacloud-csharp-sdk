// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpdateK8sClusterUserConfigExpireRequest : TeaModel {
        /// <summary>
        /// <para>The custom expiration time. Unit: hours.</para>
        /// <para>Valid values: [1, 876000]. The maximum value is equivalent to 100 years.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>720</para>
        /// </summary>
        [NameInMap("expire_hour")]
        [Validation(Required=false)]
        public long? ExpireHour { get; set; }

        /// <summary>
        /// <para>The Resource Access Management (RAM) user ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>206945240368******</para>
        /// </summary>
        [NameInMap("user")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
