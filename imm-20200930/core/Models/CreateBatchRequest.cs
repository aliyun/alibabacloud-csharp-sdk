// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateBatchRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Actions")]
        [Validation(Required=false)]
        public List<CreateBatchRequestActions> Actions { get; set; }
        public class CreateBatchRequestActions : TeaModel {
            [NameInMap("FastFailPolicy")]
            [Validation(Required=false)]
            public FastFailPolicy FastFailPolicy { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<string> Parameters { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public Input Input { get; set; }

        [NameInMap("Notification")]
        [Validation(Required=false)]
        public CreateBatchRequestNotification Notification { get; set; }
        public class CreateBatchRequestNotification : TeaModel {
            [NameInMap("MNS")]
            [Validation(Required=false)]
            public MNS MNS { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServiceRole")]
        [Validation(Required=false)]
        public string ServiceRole { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

    }

}
