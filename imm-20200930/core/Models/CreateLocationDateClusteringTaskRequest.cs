// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateLocationDateClusteringTaskRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DateOptions")]
        [Validation(Required=false)]
        public CreateLocationDateClusteringTaskRequestDateOptions DateOptions { get; set; }
        public class CreateLocationDateClusteringTaskRequestDateOptions : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("GapDays")]
            [Validation(Required=false)]
            public long? GapDays { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("MaxDays")]
            [Validation(Required=false)]
            public long? MaxDays { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("MinDays")]
            [Validation(Required=false)]
            public long? MinDays { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("LocationOptions")]
        [Validation(Required=false)]
        public CreateLocationDateClusteringTaskRequestLocationOptions LocationOptions { get; set; }
        public class CreateLocationDateClusteringTaskRequestLocationOptions : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("LocationDateClusterLevels")]
            [Validation(Required=false)]
            public List<string> LocationDateClusterLevels { get; set; }

        }

        [NameInMap("Notification")]
        [Validation(Required=false)]
        public Notification Notification { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
