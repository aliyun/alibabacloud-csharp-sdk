// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class CreateRenderingDataPackageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dp-9f8c57355d224ad7beaf95e145f22111</para>
        /// </summary>
        [NameInMap("DataPackageId")]
        [Validation(Required=false)]
        public string DataPackageId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
