// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class GetCodeEnhanceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Activation Channel, such as WeChat mini program or third-party app.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ChannelInfo")]
        [Validation(Required=false)]
        public string ChannelInfoShrink { get; set; }

        /// <summary>
        /// <para>List of User Identifier information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public string UserInfoShrink { get; set; }

    }

}
