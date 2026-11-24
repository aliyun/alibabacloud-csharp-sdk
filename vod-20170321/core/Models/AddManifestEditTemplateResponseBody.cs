// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddManifestEditTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para><b>The request ID.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>req-001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para><b>The ID of the new template.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>met-abc123</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
