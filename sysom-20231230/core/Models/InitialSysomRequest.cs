// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class InitialSysomRequest : TeaModel {
        [NameInMap("X-Debug-Id")]
        [Validation(Required=false)]
        public string XDebugId { get; set; }

        /// <summary>
        /// <para>Specifies whether to only check if the service-linked role exists.</para>
        /// </summary>
        [NameInMap("check_only")]
        [Validation(Required=false)]
        public bool? CheckOnly { get; set; }

        /// <summary>
        /// <para>The source. Set this parameter to console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>console</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("x-sysom-invoke-source")]
        [Validation(Required=false)]
        public string XSysomInvokeSource { get; set; }

    }

}
