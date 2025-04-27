// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeSnapshotSettingResponseBody : TeaModel {
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
        public DescribeSnapshotSettingResponseBodyResult Result { get; set; }
        public class DescribeSnapshotSettingResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Whether to enable automatic backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>Automatic backup time configuration, using Quartz Cron expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 01 ? * * *</para>
            /// </summary>
            [NameInMap("QuartzRegex")]
            [Validation(Required=false)]
            public string QuartzRegex { get; set; }

        }

    }

}
