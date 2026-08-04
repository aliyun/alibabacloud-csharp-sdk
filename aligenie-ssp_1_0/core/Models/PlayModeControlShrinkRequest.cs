// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class PlayModeControlShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Device identity information</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public string DeviceInfoShrink { get; set; }

        /// <summary>
        /// <para>Business parameters</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OpenPlayModeControlRequest")]
        [Validation(Required=false)]
        public string OpenPlayModeControlRequestShrink { get; set; }

        /// <summary>
        /// <para>User Identifier information</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public string UserInfoShrink { get; set; }

    }

}
