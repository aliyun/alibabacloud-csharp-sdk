// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class WarmPoolCurrentError : TeaModel {
        /// <summary>
        /// <para>The error code of the current error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SourceNotFound</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The description of the current error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Source template does not exist</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
