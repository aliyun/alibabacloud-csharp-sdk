// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DeleteFaceVerifyResultRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>shae18209d29ce4e8ba252caae98ab15</para>
        /// </summary>
        [NameInMap("CertifyId")]
        [Validation(Required=false)]
        public string CertifyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("DeleteAfterQuery")]
        [Validation(Required=false)]
        public string DeleteAfterQuery { get; set; }

    }

}
