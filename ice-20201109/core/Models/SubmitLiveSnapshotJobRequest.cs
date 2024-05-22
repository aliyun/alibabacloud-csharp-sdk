// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitLiveSnapshotJobRequest : TeaModel {
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SnapshotOutput")]
        [Validation(Required=false)]
        public SubmitLiveSnapshotJobRequestSnapshotOutput SnapshotOutput { get; set; }
        public class SubmitLiveSnapshotJobRequestSnapshotOutput : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("StreamInput")]
        [Validation(Required=false)]
        public SubmitLiveSnapshotJobRequestStreamInput StreamInput { get; set; }
        public class SubmitLiveSnapshotJobRequestStreamInput : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
