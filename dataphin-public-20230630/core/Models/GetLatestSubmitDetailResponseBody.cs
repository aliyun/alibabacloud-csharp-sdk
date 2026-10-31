// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetLatestSubmitDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of OK indicates that the request is successful.</para>
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
        /// <para>The details of the pending release.</para>
        /// </summary>
        [NameInMap("SubmitDetailResult")]
        [Validation(Required=false)]
        public GetLatestSubmitDetailResponseBodySubmitDetailResult SubmitDetailResult { get; set; }
        public class GetLatestSubmitDetailResponseBodySubmitDetailResult : TeaModel {
            /// <summary>
            /// <para>The ID of the commit record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The status of the publish record. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>NOT_VERIFIED: Not verified.</description></item>
            /// <item><description>APPROVING: Approving.</description></item>
            /// <item><description>APPROVE_FAILED: Approval failed.</description></item>
            /// <item><description>APPROVE_SUCCESS: Approval succeeded.</description></item>
            /// <item><description>APPROVE_REVOKED: Approval revoked.</description></item>
            /// <item><description>CHECKING: Checking.</description></item>
            /// <item><description>CHECK_FAILED: Check failed.</description></item>
            /// <item><description>CHECK_SUCCESS: Check succeeded.</description></item>
            /// <item><description>PUBLISHING: Publishing.</description></item>
            /// <item><description>FAILED: Failed.</description></item>
            /// <item><description>SUCCESS: Succeeded.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("PublishStatus")]
            [Validation(Required=false)]
            public string PublishStatus { get; set; }

            /// <summary>
            /// <para>The object of the pending release record.</para>
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
                /// <para>The ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n_1234</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The version of the object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ObjectVersion")]
                [Validation(Required=false)]
                public string ObjectVersion { get; set; }

                /// <summary>
                /// <para>The ID of the project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The commit description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Commit description</para>
                /// </summary>
                [NameInMap("SubmitComment")]
                [Validation(Required=false)]
                public string SubmitComment { get; set; }

                /// <summary>
                /// <para>The object to be published.</para>
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
                    /// <para>The name of the object.</para>
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
            /// <para>The status of the pending release record. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TO_BE_PUBLISHED: Pending release.</description></item>
            /// <item><description>PUBLISHED: Published.</description></item>
            /// <item><description>PUBLISHING: Publishing.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TO_BE_PUBLISHED</para>
            /// </summary>
            [NameInMap("SubmitStatus")]
            [Validation(Required=false)]
            public string SubmitStatus { get; set; }

            /// <summary>
            /// <para>The tag of the record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
