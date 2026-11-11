// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class UpdateCopilotSessionRequest : TeaModel {
        /// <summary>
        /// <para>The session title. The length is 1 to 255 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CPU load analysis record</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The session status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>archived</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
