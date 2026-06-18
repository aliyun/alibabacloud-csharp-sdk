// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class GetAlipayUrlRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Bailian application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asfasdfxxasdf</para>
        /// </summary>
        [NameInMap("app_id")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the Bailian workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxllm-czb8d47ks</para>
        /// </summary>
        [NameInMap("workspace_id")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
