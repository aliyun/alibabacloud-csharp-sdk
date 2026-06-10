// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class InitialSysomRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to only check if the service role exists</para>
        /// </summary>
        [NameInMap("check_only")]
        [Validation(Required=false)]
        public bool? CheckOnly { get; set; }

        /// <summary>
        /// <para>Source, which is fixed as console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>console</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
