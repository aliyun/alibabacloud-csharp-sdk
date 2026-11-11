// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CmsV1MigrationCheck : TeaModel {
        /// <summary>
        /// <para>The check result code, where NAME_ indicates a naming issue and UNSUPPORTED_ indicates an unsupported resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NAME_INVALID</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The check result description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Target name must contain 1 to 256 characters</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
