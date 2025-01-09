// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class UpdateSnapshotSettingResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>A7B03723-AA73-5A5F-B71C-270792614DD8</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;quartzRegex&quot;: &quot;0 0 01 ? * * *&quot;,
        ///     &quot;enable&quot;: true
        ///   }</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public Dictionary<string, object> Result { get; set; }

    }

}
