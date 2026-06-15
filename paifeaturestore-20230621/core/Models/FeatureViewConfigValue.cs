// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class FeatureViewConfigValue : TeaModel {
        /// <summary>
        /// <para>The list of partitions.</para>
        /// </summary>
        [NameInMap("Partitions")]
        [Validation(Required=false)]
        public Dictionary<string, FeatureViewConfigValuePartitionsValue> Partitions { get; set; }

        /// <summary>
        /// <para>The event time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1721186536</para>
        /// </summary>
        [NameInMap("EventTime")]
        [Validation(Required=false)]
        public string EventTime { get; set; }

        /// <summary>
        /// <para>Specifies whether the feature\&quot;s timestamp must match the event time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("Equal")]
        [Validation(Required=false)]
        public bool? Equal { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a mock data table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("UseMock")]
        [Validation(Required=false)]
        public bool? UseMock { get; set; }

        /// <summary>
        /// <para>The snapshot configuration.</para>
        /// </summary>
        [NameInMap("Snapshot")]
        [Validation(Required=false)]
        public FeatureViewConfigValueSnapshot Snapshot { get; set; }
        public class FeatureViewConfigValueSnapshot : TeaModel {
            /// <summary>
            /// <para>The partition configuration for the snapshot.</para>
            /// </summary>
            [NameInMap("Partitions")]
            [Validation(Required=false)]
            public Dictionary<string, FeatureViewConfigValueSnapshotPartitionsValue> Partitions { get; set; }

            /// <summary>
            /// <para>The name of the snapshot table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table_name</para>
            /// </summary>
            [NameInMap("Table")]
            [Validation(Required=false)]
            public string Table { get; set; }

        }

        /// <summary>
        /// <para>The second join key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request_id</para>
        /// </summary>
        [NameInMap("SecondJoinKey")]
        [Validation(Required=false)]
        public string SecondJoinKey { get; set; }

        [NameInMap("JoinWithLabel")]
        [Validation(Required=false)]
        public bool? JoinWithLabel { get; set; }

    }

}
