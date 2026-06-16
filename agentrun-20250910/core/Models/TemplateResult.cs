// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class TemplateResult : TeaModel {
        /// <summary>
        /// <para>SUCCESS indicates success. In case of failure, the corresponding Error Type is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Detailed information about the template</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public Template Data { get; set; }

        /// <summary>
        /// <para>Unique request ID used for troubleshooting</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8A0F5F3-0C3E-4C82-9D4F-5E4B6A7C8D9E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
