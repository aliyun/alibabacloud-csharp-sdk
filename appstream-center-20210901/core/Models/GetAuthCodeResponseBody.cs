// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetAuthCodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. It is returned when the request fails. A success response may not contain this field.</para>
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
        public GetAuthCodeResponseBodyData Data { get; set; }
        public class GetAuthCodeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The network access type supported by the connection resource.</para>
            /// <list type="bullet">
            /// <item><description><b>INTERNET</b>: Supports Internet access.</description></item>
            /// <item><description><b>VPC</b>: Supports virtual private cloud (VPC) access.</description></item>
            /// <item><description><b>ANY</b>: Supports both Internet and VPC access.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INTERNET</para>
            /// </summary>
            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            /// <summary>
            /// <para>The application ID, which is used for subsequent application queries or unbinding the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-bp1example****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The delivery group ID of the creation or validation resource. It is used together with the user and application information in this response during connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-bp1example****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The application version ID, which is used to locate a specific version of the application. This field is not the image version ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apv-bp1example****</para>
            /// </summary>
            [NameInMap("AppVersionId")]
            [Validation(Required=false)]
            public string AppVersionId { get; set; }

            /// <summary>
            /// <para>The authorization code used to connect to the creation or validation resource. <b>The validity period is 180 seconds (3 minutes) from the time of issuance. Use it promptly after obtaining it.</b> Use it together with the user, delivery group, and application information in the same response, and keep it confidential as a connection credential.</para>
            /// <para>Do not reuse the authorization code after it is redeemed. If it has been used or expired, call this operation again to obtain a new one.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e4e169bea1cc48e8afac53**********</para>
            /// </summary>
            [NameInMap("AuthCode")]
            [Validation(Required=false)]
            public string AuthCode { get; set; }

            /// <summary>
            /// <para>The purpose type of the connection resource.</para>
            /// <list type="bullet">
            /// <item><description><b>ImageBuilder</b>: Image or application creation resource.</description></item>
            /// <item><description><b>ImageValidate</b>: Image or application validation resource.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ImageBuilder</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The region ID in this response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The user ID used when connecting to the creation or validation environment. Use the value returned in this response.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b>vhd_builder</b></para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The error or result message. It describes the cause when the request fails. A success response may not contain this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Internal error.</para>
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
        /// <para>Indicates whether the request was processed successfully. A value of true indicates that the request was processed successfully. To check whether an asynchronous task is completed, you must query the task status separately.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
