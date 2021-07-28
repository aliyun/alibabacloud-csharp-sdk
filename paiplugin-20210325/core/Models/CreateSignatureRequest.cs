/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20210325.Models
{
    public class CreateSignatureRequest : TeaModel {
        /// <summary>
        /// 签名归属方的三证合一，OSS地址，必须以https开头，使用前需要授权
        /// </summary>
        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public string Certificates { get; set; }

        /// <summary>
        /// 申请说明
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 签名名称
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 授权委托书(Power of attorney)， OSS地址，必须以https或oss开头，使用前需要授权，同上
        /// </summary>
        [NameInMap("PowerOfAttorney")]
        [Validation(Required=false)]
        public string PowerOfAttorney { get; set; }

        /// <summary>
        /// 无需填写
        /// </summary>
        [NameInMap("ProcessInstanceID")]
        [Validation(Required=false)]
        public string ProcessInstanceID { get; set; }

    }

}
