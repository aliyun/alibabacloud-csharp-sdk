// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateServiceRolloutRequest : TeaModel {
        [NameInMap("Batch")]
        [Validation(Required=false)]
        public UpdateServiceRolloutRequestBatch Batch { get; set; }
        public class UpdateServiceRolloutRequestBatch : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>25%</para>
            /// </summary>
            [NameInMap("BatchSize")]
            [Validation(Required=false)]
            public string BatchSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>60s</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public string Interval { get; set; }

        }

        [NameInMap("Partition")]
        [Validation(Required=false)]
        public UpdateServiceRolloutRequestPartition Partition { get; set; }
        public class UpdateServiceRolloutRequestPartition : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>30%</para>
            /// </summary>
            [NameInMap("Partition")]
            [Validation(Required=false)]
            public string Partition { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Paused")]
        [Validation(Required=false)]
        public bool? Paused { get; set; }

    }

}
