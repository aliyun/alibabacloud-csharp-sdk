// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListApplicationsForSwimmingLaneResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListApplicationsForSwimmingLaneResponseBodyData> Data { get; set; }
        public class ListApplicationsForSwimmingLaneResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0099b7be-5f5b-4512-a7fc-56049ef1****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>demo-app</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8c573618-8d72-4407-baf4-f7b64b******</para>
            /// </summary>
            [NameInMap("BaseAppId")]
            [Validation(Required=false)]
            public string BaseAppId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("BaseAppName")]
            [Validation(Required=false)]
            public string BaseAppName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mse-cn-hvm47******</para>
            /// </summary>
            [NameInMap("MseAppId")]
            [Validation(Required=false)]
            public string MseAppId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("MseAppName")]
            [Validation(Required=false)]
            public string MseAppName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sae-test</para>
            /// </summary>
            [NameInMap("MseNamespaceId")]
            [Validation(Required=false)]
            public string MseNamespaceId { get; set; }

            [NameInMap("ServiceTags")]
            [Validation(Required=false)]
            public Dictionary<string, string> ServiceTags { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
