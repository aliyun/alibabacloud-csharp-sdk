// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetLatestSubmitDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubmitDetailResult")]
        [Validation(Required=false)]
        public GetLatestSubmitDetailResponseBodySubmitDetailResult SubmitDetailResult { get; set; }
        public class GetLatestSubmitDetailResponseBodySubmitDetailResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("PublishStatus")]
            [Validation(Required=false)]
            public string PublishStatus { get; set; }

            [NameInMap("ReleaseObject")]
            [Validation(Required=false)]
            public GetLatestSubmitDetailResponseBodySubmitDetailResultReleaseObject ReleaseObject { get; set; }
            public class GetLatestSubmitDetailResponseBodySubmitDetailResultReleaseObject : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>DELETE</para>
                /// </summary>
                [NameInMap("ChangeType")]
                [Validation(Required=false)]
                public string ChangeType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>n_1234</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ObjectVersion")]
                [Validation(Required=false)]
                public string ObjectVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>提交说明</para>
                /// </summary>
                [NameInMap("SubmitComment")]
                [Validation(Required=false)]
                public string SubmitComment { get; set; }

                [NameInMap("SubmitObject")]
                [Validation(Required=false)]
                public GetLatestSubmitDetailResponseBodySubmitDetailResultReleaseObjectSubmitObject SubmitObject { get; set; }
                public class GetLatestSubmitDetailResponseBodySubmitDetailResultReleaseObjectSubmitObject : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1234</para>
                    /// </summary>
                    [NameInMap("ObjectId")]
                    [Validation(Required=false)]
                    public string ObjectId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>abc</para>
                    /// </summary>
                    [NameInMap("ObjectName")]
                    [Validation(Required=false)]
                    public string ObjectName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MAX_COMPUTE_SQL</para>
                    /// </summary>
                    [NameInMap("ObjectType")]
                    [Validation(Required=false)]
                    public string ObjectType { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TO_BE_PUBLISHED</para>
            /// </summary>
            [NameInMap("SubmitStatus")]
            [Validation(Required=false)]
            public string SubmitStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tag</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
