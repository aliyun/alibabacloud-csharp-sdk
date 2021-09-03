// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class RefreshWebofficeTokenShrinkRequest : TeaModel {
        /// <summary>
        /// 项目名称
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// access token
        /// </summary>
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// refresh token
        /// </summary>
        [NameInMap("RefreshToken")]
        [Validation(Required=false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// 链式授权
        /// </summary>
        [NameInMap("AssumeRoleChain")]
        [Validation(Required=false)]
        public string AssumeRoleChainShrink { get; set; }

    }

}
