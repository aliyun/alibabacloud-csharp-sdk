// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class PreviewLogicalModelUpdateResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public PreviewLogicalModelUpdateResponseBodyData Data { get; set; }
        public class PreviewLogicalModelUpdateResponseBodyData : TeaModel {
            [NameInMap("apis")]
            [Validation(Required=false)]
            public List<PreviewLogicalModelUpdateResponseBodyDataApis> Apis { get; set; }
            public class PreviewLogicalModelUpdateResponseBodyDataApis : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Draft</para>
                /// </summary>
                [NameInMap("configuration")]
                [Validation(Required=false)]
                public string Configuration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>env-d00000000000000000000</para>
                /// </summary>
                [NameInMap("environmentId")]
                [Validation(Required=false)]
                public string EnvironmentId { get; set; }

                [NameInMap("errors")]
                [Validation(Required=false)]
                public List<string> Errors { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>api-d00000000000000000000</para>
                /// </summary>
                [NameInMap("httpApiId")]
                [Validation(Required=false)]
                public string HttpApiId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>beta-chat</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("revision")]
                [Validation(Required=false)]
                public string Revision { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6b8e7d61b3a94c7285cf0d9ee1a72c836b8e7d61b3a94c7285cf0d9ee1a72c83</para>
            /// </summary>
            [NameInMap("confirmationToken")]
            [Validation(Required=false)]
            public string ConfirmationToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("revision")]
            [Validation(Required=false)]
            public long? Revision { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
