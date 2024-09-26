// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDataServiceApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the application.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataServiceApplicationResponseBodyData Data { get; set; }
        public class GetDataServiceApplicationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The AppCode for simple authentication. You can select simple authentication or signature authentication when you call an API operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CODE123</para>
            /// </summary>
            [NameInMap("ApplicationCode")]
            [Validation(Required=false)]
            public string ApplicationCode { get; set; }

            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public long? ApplicationId { get; set; }

            /// <summary>
            /// <para>The AppKey for signature authentication. You can select simple authentication or signature authentication when you call an API operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KEY123</para>
            /// </summary>
            [NameInMap("ApplicationKey")]
            [Validation(Required=false)]
            public string ApplicationKey { get; set; }

            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test application</para>
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// <para>The AppSecret for signature authentication. You can select simple authentication or signature authentication when you call an API operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SECRET123</para>
            /// </summary>
            [NameInMap("ApplicationSecret")]
            [Validation(Required=false)]
            public string ApplicationSecret { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
