// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateServiceRolloutRequest : TeaModel {
        [NameInMap("Batch")]
        [Validation(Required=false)]
        public CreateServiceRolloutRequestBatch Batch { get; set; }
        public class CreateServiceRolloutRequestBatch : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BatchSize")]
            [Validation(Required=false)]
            public string BatchSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5m</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public string Interval { get; set; }

        }

        [NameInMap("Partition")]
        [Validation(Required=false)]
        public CreateServiceRolloutRequestPartition Partition { get; set; }
        public class CreateServiceRolloutRequestPartition : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Partition")]
            [Validation(Required=false)]
            public string Partition { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("Paused")]
        [Validation(Required=false)]
        public bool? Paused { get; set; }

    }

}
