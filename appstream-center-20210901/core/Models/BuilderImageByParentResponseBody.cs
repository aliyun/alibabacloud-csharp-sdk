// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class BuilderImageByParentResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. This parameter is returned when the request fails. A successful response may not contain this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ExceedBuilderQuota</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business data returned by this operation.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BuilderImageByParentResponseBodyData Data { get; set; }
        public class BuilderImageByParentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The image ID, which is used for subsequent queries or modifications of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imgc-bp1example****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The task ID, which can be used to call GetTask to query the task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tid-bp1example****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The image version ID, which is used to query or manage the specified version of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iv-bp1example****</para>
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

        }

        /// <summary>
        /// <para>The error or result message. This parameter describes the cause when the request fails. A successful response may not contain this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The maximum number of builders is reached.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request. You can provide this value for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A1A962-5503-107B-AC8F-EBA85DF905AC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is processed successfully. A value of true indicates that the request is processed successfully. To check whether the asynchronous task is completed, you must query the task status separately.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
