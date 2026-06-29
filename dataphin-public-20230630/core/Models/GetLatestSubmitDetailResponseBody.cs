// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetLatestSubmitDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of OK indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The pending submit details.</para>
        /// </summary>
        [NameInMap("SubmitDetailResult")]
        [Validation(Required=false)]
        public GetLatestSubmitDetailResponseBodySubmitDetailResult SubmitDetailResult { get; set; }
        public class GetLatestSubmitDetailResponseBodySubmitDetailResult : TeaModel {
            /// <summary>
            /// <para>The submit record ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The publish status. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>NOT_VERIFIED: not verified.</description></item>
            /// <item><description>APPROVING: approval in progress.</description></item>
            /// <item><description>APPROVE_FAILED: approval failed.</description></item>
            /// <item><description>APPROVE_SUCCESS: approval succeeded.</description></item>
            /// <item><description>APPROVE_REVOKED: approval revoked.</description></item>
            /// <item><description>CHECKING: publish verification in progress.</description></item>
            /// <item><description>CHECK_FAILED: publish verification failed.</description></item>
            /// <item><description>CHECK_SUCCESS: publish verification succeeded.</description></item>
            /// <item><description>PUBLISHING: publishing in progress.</description></item>
            /// <item><description>FAILED: publish failed.</description></item>
            /// <item><description>SUCCESS: publish succeeded.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("PublishStatus")]
            [Validation(Required=false)]
            public string PublishStatus { get; set; }

            /// <summary>
            /// <para>The pending submit record object.</para>
            /// </summary>
            [NameInMap("ReleaseObject")]
            [Validation(Required=false)]
            public GetLatestSubmitDetailResponseBodySubmitDetailResultReleaseObject ReleaseObject { get; set; }
            public class GetLatestSubmitDetailResponseBodySubmitDetailResultReleaseObject : TeaModel {
                /// <summary>
                /// <para>The change type. Valid values: CREATE, UPDATE, and DELETE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DELETE</para>
                /// </summary>
                [NameInMap("ChangeType")]
                [Validation(Required=false)]
                public string ChangeType { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n_1234</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The object version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ObjectVersion")]
                [Validation(Required=false)]
                public string ObjectVersion { get; set; }

                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The submit comment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>提交说明</para>
                /// </summary>
                [NameInMap("SubmitComment")]
                [Validation(Required=false)]
                public string SubmitComment { get; set; }

                /// <summary>
                /// <para>The submit object.</para>
                /// </summary>
                [NameInMap("SubmitObject")]
                [Validation(Required=false)]
                public GetLatestSubmitDetailResponseBodySubmitDetailResultReleaseObjectSubmitObject SubmitObject { get; set; }
                public class GetLatestSubmitDetailResponseBodySubmitDetailResultReleaseObjectSubmitObject : TeaModel {
                    /// <summary>
                    /// <para>The object ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234</para>
                    /// </summary>
                    [NameInMap("ObjectId")]
                    [Validation(Required=false)]
                    public string ObjectId { get; set; }

                    /// <summary>
                    /// <para>The object name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>abc</para>
                    /// </summary>
                    [NameInMap("ObjectName")]
                    [Validation(Required=false)]
                    public string ObjectName { get; set; }

                    /// <summary>
                    /// <para>The object type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MAX_COMPUTE_SQL</para>
                    /// </summary>
                    [NameInMap("ObjectType")]
                    [Validation(Required=false)]
                    public string ObjectType { get; set; }

                }

            }

            /// <summary>
            /// <para>The submit status. Valid values: </para>
            /// <list type="bullet">
            /// <item><description><para>TO_BE_PUBLISHED: pending.</para>
            /// </description></item>
            /// <item><description><para>PUBLISHED: published.</para>
            /// </description></item>
            /// <item><description><para>PUBLISHING: publishing.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TO_BE_PUBLISHED</para>
            /// </summary>
            [NameInMap("SubmitStatus")]
            [Validation(Required=false)]
            public string SubmitStatus { get; set; }

            /// <summary>
            /// <para>The record tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
