// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DebugPlaybookResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique ID for each request. Use this ID to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75E56B2C-C8FA-5A2F-AA08-8745E2AC33EF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The run UUID of the debugging task. Use this UUID to query information, such as the task result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6d412cfa-0905-4567-8a83-xxxxxx</para>
        /// </summary>
        [NameInMap("RequestUuid")]
        [Validation(Required=false)]
        public string RequestUuid { get; set; }

    }

}
