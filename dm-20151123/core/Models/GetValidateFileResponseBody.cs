// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class GetValidateFileResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://xxxxxx/yyy">https://xxxxxx/yyy</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>yyyy-yyyy-yyyy-yyyy</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
