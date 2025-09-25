// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeCardVerifyRequest : TeaModel {
        /// <summary>
        /// <para>Authentication request ID.
        /// You must first call the initialization interface InitCardVerify to submit an authentication request in order to get the authentication request ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91707dc296d469ad38e4c5efa6a0xxxx</para>
        /// </summary>
        [NameInMap("CertifyId")]
        [Validation(Required=false)]
        public string CertifyId { get; set; }

    }

}
