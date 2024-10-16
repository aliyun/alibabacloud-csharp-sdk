// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class GetTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;mode&quot;: &quot;overwrite&quot;,
        ///     &quot;partitions&quot;: {
        ///         &quot;dt&quot;: &quot;20230820&quot;
        ///     },
        ///     &quot;event_time&quot;: &quot;&quot;,
        ///     &quot;config&quot;: {},
        ///     &quot;offline_to_online&quot;: true
        /// }</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-07-04T11:26:09.036+08:00</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-07-04T11:26:09.036+08:00</para>
        /// </summary>
        [NameInMap("GmtExecutedTime")]
        [Validation(Required=false)]
        public string GmtExecutedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-07-04T11:26:09.036+08:00</para>
        /// </summary>
        [NameInMap("GmtFinishedTime")]
        [Validation(Required=false)]
        public string GmtFinishedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-07-04T11:26:09.036+08:00</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ModelFeature</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>project_1</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>37D19490-AB69-567D-A852-407C94E510E9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DROP TABLE IF EXISTS public.fsxxx</para>
        /// </summary>
        [NameInMap("RunningConfig")]
        [Validation(Required=false)]
        public string RunningConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OfflineToOnline</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
