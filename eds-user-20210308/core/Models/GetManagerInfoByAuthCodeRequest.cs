// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class GetManagerInfoByAuthCodeRequest : TeaModel {
        /// <summary>
        /// The authorization code.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AuthCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

    }

}
