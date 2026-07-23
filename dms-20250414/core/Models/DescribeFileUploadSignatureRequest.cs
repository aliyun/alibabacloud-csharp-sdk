// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DescribeFileUploadSignatureRequest : TeaModel {
        /// <summary>
        /// <para>The parameter used only by the frontend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>仅前端使用</para>
        /// </summary>
        [NameInMap("CallFrom")]
        [Validation(Required=false)]
        public string CallFrom { get; set; }

        /// <summary>
        /// <para>The current DMS unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DmsUnit")]
        [Validation(Required=false)]
        public string DmsUnit { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
