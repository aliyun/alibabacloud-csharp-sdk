// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class GetAlipayTransferStatusRequest : TeaModel {
        /// <summary>
        /// <para>The tipping code returned by the Alipay tipping link request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx-xxxx</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The Bailian workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-cxxxxxxb8d47ks</para>
        /// </summary>
        [NameInMap("workspace_id")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
