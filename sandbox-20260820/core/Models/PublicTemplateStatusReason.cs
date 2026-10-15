// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class PublicTemplateStatusReason : TeaModel {
        /// <summary>
        /// <para>The details of the failure reason.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Failed to pull the source image: invalid authentication information</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The identity of the failed step.</para>
        /// 
        /// <b>Example:</b>
        /// <para>build-context</para>
        /// </summary>
        [NameInMap("step")]
        [Validation(Required=false)]
        public string Step { get; set; }

    }

}
