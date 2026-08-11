// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateDomainMetaResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the newly created list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ladl-6f1exxxxx6ab59</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C37AE32-A5C0-5E0F-9EC3-399B83102ED1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
