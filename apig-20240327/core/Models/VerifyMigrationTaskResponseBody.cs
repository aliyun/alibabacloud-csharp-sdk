// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class VerifyMigrationTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public VerifyMigrationTaskResponseBodyData Data { get; set; }
        public class VerifyMigrationTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether all routes are compatible and can be migrated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isSupported")]
            [Validation(Required=false)]
            public bool? IsSupported { get; set; }

            /// <summary>
            /// <para>The description of the check result, such as the failure reason or incompatibility summary. This value is from the Istio validation Reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>all routes supported</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Indicates whether the check is successful, which means whether the Istiod query link is working properly.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// <para>The list of incompatible routes.</para>
            /// </summary>
            [NameInMap("unSupportedRouteRules")]
            [Validation(Required=false)]
            public List<VerifyMigrationTaskResponseBodyDataUnSupportedRouteRules> UnSupportedRouteRules { get; set; }
            public class VerifyMigrationTaskResponseBodyDataUnSupportedRouteRules : TeaModel {
                /// <summary>
                /// <para>The namespaced name of the incompatible Ingress.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default/my-ingress</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The summary of the incompatible rule, in the format of request URI → destination service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/api/v1/pets -&gt; pet-service</para>
                /// </summary>
                [NameInMap("rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <para>The list of unsupported annotations on the Ingress.</para>
                /// </summary>
                [NameInMap("unSupportedAnnotations")]
                [Validation(Required=false)]
                public List<string> UnSupportedAnnotations { get; set; }

            }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB85272A-5F04-58D7-BDE1-8BB5EB390CE1</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
