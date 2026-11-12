// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateServiceRolloutRequest : TeaModel {
        /// <summary>
        /// <para>The configuration for automatic batching.</para>
        /// </summary>
        [NameInMap("Batch")]
        [Validation(Required=false)]
        public CreateServiceRolloutRequestBatch Batch { get; set; }
        public class CreateServiceRolloutRequestBatch : TeaModel {
            /// <summary>
            /// <para>The number of instances to update in each batch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BatchSize")]
            [Validation(Required=false)]
            public string BatchSize { get; set; }

            /// <summary>
            /// <para>The wait interval after each batch update is completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5m</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public string Interval { get; set; }

        }

        /// <summary>
        /// <para>The configuration for manual batching.</para>
        /// </summary>
        [NameInMap("Partition")]
        [Validation(Required=false)]
        public CreateServiceRolloutRequestPartition Partition { get; set; }
        public class CreateServiceRolloutRequestPartition : TeaModel {
            /// <summary>
            /// <para>The number of instances to update to the new version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Partition")]
            [Validation(Required=false)]
            public string Partition { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to pause the update.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("Paused")]
        [Validation(Required=false)]
        public bool? Paused { get; set; }

    }

}
