// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateOrgHonorTemplateResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>21660610</para>
        /// </summary>
        [NameInMap("honorId")]
        [Validation(Required=false)]
        public string HonorId { get; set; }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
