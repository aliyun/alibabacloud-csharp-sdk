// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class VerifyMigrationTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public VerifyMigrationTaskResponseBodyData Data { get; set; }
        public class VerifyMigrationTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isSupported")]
            [Validation(Required=false)]
            public bool? IsSupported { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>all routes supported</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            [NameInMap("unSupportedRouteRules")]
            [Validation(Required=false)]
            public List<VerifyMigrationTaskResponseBodyDataUnSupportedRouteRules> UnSupportedRouteRules { get; set; }
            public class VerifyMigrationTaskResponseBodyDataUnSupportedRouteRules : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>default/my-ingress</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/api/v1/pets -&gt; pet-service</para>
                /// </summary>
                [NameInMap("rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                [NameInMap("unSupportedAnnotations")]
                [Validation(Required=false)]
                public List<string> UnSupportedAnnotations { get; set; }

            }

        }

        /// <summary>
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
