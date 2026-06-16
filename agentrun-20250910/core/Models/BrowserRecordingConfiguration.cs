// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class BrowserRecordingConfiguration : TeaModel {
        /// <summary>
        /// <para>Is recording enabled</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>OSS storage location</para>
        /// </summary>
        [NameInMap("ossLocation")]
        [Validation(Required=false)]
        public BrowserOssLocation OssLocation { get; set; }

    }

}
