// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateMemoryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateMemoryResponseBodyData Data { get; set; }
        public class CreateMemoryResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>default_workspace</para>
            /// </summary>
            [NameInMap("cmsWorkspaceName")]
            [Validation(Required=false)]
            public string CmsWorkspaceName { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FB1162C-D50B-5DA7-AD04-3417ABBF133A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
