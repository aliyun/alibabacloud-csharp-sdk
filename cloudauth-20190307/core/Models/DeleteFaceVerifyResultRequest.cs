// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DeleteFaceVerifyResultRequest : TeaModel {
        /// <summary>
        /// <para>Unique identifier for real-person authentication.</para>
        /// 
        /// <b>Example:</b>
        /// <para>shae18209d29ce4e8ba252caae98ab15</para>
        /// </summary>
        [NameInMap("CertifyId")]
        [Validation(Required=false)]
        public string CertifyId { get; set; }

        /// <summary>
        /// <para>Whether deletion depends on having already obtained relevant data from the corresponding authentication process.</para>
        /// <list type="bullet">
        /// <item><description>Y: Required. To successfully delete the related data, you must have obtained the processing result through the DescribeFaceVerify interface.</description></item>
        /// <item><description>N: Not required (default). For pure server-side API integration, you can directly pass N.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("DeleteAfterQuery")]
        [Validation(Required=false)]
        public string DeleteAfterQuery { get; set; }

    }

}
