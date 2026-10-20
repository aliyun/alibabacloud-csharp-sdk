// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpdateK8sClusterUserConfigExpireRequest : Darabonba.Model {
        /// <summary>
        /// <para>The custom expiration time specified by the user. Unit: hours.</para>
        /// <para>Valid values: [1, 876000], which indicates a maximum of 100 years.</para>
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

