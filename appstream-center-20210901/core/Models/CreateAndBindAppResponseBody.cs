// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateAndBindAppResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. This field is returned when the request fails. A successful response may not contain this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business data returned by the operation.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateAndBindAppResponseBodyData Data { get; set; }
        public class CreateAndBindAppResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The application ID, which is used to query the application or dissociate the image later.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-bp1example****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The application version ID, which is used to locate a specified version of the application. This field is not the image version ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apv-bp1example****</para>
            /// </summary>
            [NameInMap("AppVersionId")]
            [Validation(Required=false)]
            public string AppVersionId { get; set; }

            /// <summary>
            /// <para>The image ID, which is used to query or modify the image later.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imgc-bp1example****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The image version ID, which is used to query or manage a specified version of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iv-bp1example****</para>
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

        }

        /// <summary>
        /// <para>The error or result message. This field describes the cause when the request fails. A successful response may not contain this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Internal error.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request. Provide this value when you troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A1A962-5503-107B-AC8F-EBA85DF905AC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is processed successfully. A value of true indicates that the request is processed successfully. To determine whether an asynchronous task is completed, query the task status separately.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
