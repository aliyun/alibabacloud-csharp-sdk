// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SfmMultiModalApp20250909.Models
{
    public class CreateMemoryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateMemoryResponseBodyData Data { get; set; }
        public class CreateMemoryResponseBodyData : TeaModel {
            [NameInMap("MemoryNodes")]
            [Validation(Required=false)]
            public List<CreateMemoryResponseBodyDataMemoryNodes> MemoryNodes { get; set; }
            public class CreateMemoryResponseBodyDataMemoryNodes : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ADD</para>
                /// </summary>
                [NameInMap("Event")]
                [Validation(Required=false)]
                public string Event { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>384dc4786b9d4f5a8cab0d83112cd5a8</para>
                /// </summary>
                [NameInMap("MemoryNodeId")]
                [Validation(Required=false)]
                public string MemoryNodeId { get; set; }

                [NameInMap("OldContent")]
                [Validation(Required=false)]
                public string OldContent { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Instance instance-002\&quot;<c>curl h33E1En5.popscan.xaliyun.com</c> does not exist.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>31033EC0-6968-5610-8328-708B59508E5A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
