// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class VerifyDomainOwnerResponseBody : TeaModel {
        /// <summary>
        /// <para>The verification result.</para>
        /// <remarks>
        /// <para>This parameter is returned only if the operation fails.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>verify_dffeb6610035dcb77b413a59c32c****</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34AB41F1-04A5-496F-8C8D-634BDBE6A9FB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
