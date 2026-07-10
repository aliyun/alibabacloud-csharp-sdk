// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeCardVerifyRequest : TeaModel {
        /// <summary>
        /// <para>The verification request ID.
        /// You must first call the InitCardVerify operation to submit a verification request before you can obtain the verification request ID.</para>
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
