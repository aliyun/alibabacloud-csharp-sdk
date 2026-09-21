// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class PublicTemplateStatusReason : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>拉取源镜像失败：认证信息无效</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>build-context</para>
        /// </summary>
        [NameInMap("step")]
        [Validation(Required=false)]
        public string Step { get; set; }

    }

}
