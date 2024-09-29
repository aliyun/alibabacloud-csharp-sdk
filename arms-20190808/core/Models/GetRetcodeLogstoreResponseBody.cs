// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetRetcodeLogstoreResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRetcodeLogstoreResponseBodyData Data { get; set; }
        public class GetRetcodeLogstoreResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The content of the log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>retcode app or task can not be found!</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The information about Log Service.</para>
            /// </summary>
            [NameInMap("RetcodeSLSConfig")]
            [Validation(Required=false)]
            public GetRetcodeLogstoreResponseBodyDataRetcodeSLSConfig RetcodeSLSConfig { get; set; }
            public class GetRetcodeLogstoreResponseBodyDataRetcodeSLSConfig : TeaModel {
                /// <summary>
                /// <para>The Log Service Logstore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>log-test-220431</para>
                /// </summary>
                [NameInMap("Logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                /// <summary>
                /// <para>The Log Service project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-project</para>
                /// </summary>
                [NameInMap("Project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The ID of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// <para>The status of the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A9C645C-C83F-4C9D-8CCB-29BEC9E1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
