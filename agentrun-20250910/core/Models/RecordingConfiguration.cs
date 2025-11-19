// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class RecordingConfiguration : TeaModel {
        /// <summary>
        /// <para>是否启用录制</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        [NameInMap("ossLocation")]
        [Validation(Required=false)]
        public OssConfiguration OssLocation { get; set; }

    }

}
