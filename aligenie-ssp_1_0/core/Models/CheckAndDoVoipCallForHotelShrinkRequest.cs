// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class CheckAndDoVoipCallForHotelShrinkRequest : TeaModel {
        [NameInMap("BizData")]
        [Validation(Required=false)]
        public string BizData { get; set; }

        [NameInMap("CalleeNick")]
        [Validation(Required=false)]
        public string CalleeNick { get; set; }

        [NameInMap("CalleePhoneNum")]
        [Validation(Required=false)]
        public string CalleePhoneNum { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public string DeviceInfoShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public string UserInfoShrink { get; set; }

    }

}
