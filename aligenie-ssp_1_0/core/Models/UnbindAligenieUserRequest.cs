// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class UnbindAligenieUserRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99ce8a70c23a94f8569e1a525bef6e85</para>
        /// </summary>
        [NameInMap("LoginStateAccessToken")]
        [Validation(Required=false)]
        public string LoginStateAccessToken { get; set; }

    }

}
