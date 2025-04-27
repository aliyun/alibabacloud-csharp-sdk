// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateSnapshotSettingResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The return results.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdateSnapshotSettingResponseBodyResult Result { get; set; }
        public class UpdateSnapshotSettingResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable automatic backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The start time of automatic backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 01 ? * * *</para>
            /// </summary>
            [NameInMap("quartzRegex")]
            [Validation(Required=false)]
            public string QuartzRegex { get; set; }

        }

    }

}
