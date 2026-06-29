// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class VerifyCustomHostnameResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the verification is passed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Passed")]
        [Validation(Required=false)]
        public bool? Passed { get; set; }

        /// <summary>
        /// <para>The request ID. A unique identifier that Alibaba Cloud generates for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0AEDAF20-4DDF-4165-8750-47FF9C1929C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
