// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ScanCodeBindShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Input parameters for QR code scanning binding</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BindReq")]
        [Validation(Required=false)]
        public string BindReqShrink { get; set; }

        /// <summary>
        /// <para>User identity information</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public string UserInfoShrink { get; set; }

    }

}
