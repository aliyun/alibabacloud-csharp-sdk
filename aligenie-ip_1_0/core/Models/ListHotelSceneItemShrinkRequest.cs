// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ListHotelSceneItemShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public string PayloadShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public string UserInfoShrink { get; set; }

    }

}
