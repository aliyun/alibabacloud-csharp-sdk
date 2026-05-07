// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class DeleteJobTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>本次请求的 ID，用于诊断和答疑。</para>
        /// 
        /// <b>Example:</b>
        /// <para>78F6FCE2-278F-4C4A-A6B7-DD8ECEA****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>tplwk80096dw****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
