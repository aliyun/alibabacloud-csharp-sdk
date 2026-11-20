// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class ReleaseExpiredPrepaidInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para><b>[Deprecated]</b> The host ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>deprecated</para>
        /// </summary>
        [NameInMap("Class")]
        [Validation(Required=false)]
        public string Class { get; set; }

        /// <summary>
        /// <para>The error code returned when the call fails. For more information, see Error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ReleaseExpiredPrepaidInstanceResponseBodyData Data { get; set; }
        public class ReleaseExpiredPrepaidInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para><b>[Deprecated]</b> The host ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deprecated</para>
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// <para>The list of instance results.</para>
            /// </summary>
            [NameInMap("InstanceResults")]
            [Validation(Required=false)]
            public List<ReleaseExpiredPrepaidInstanceResponseBodyDataInstanceResults> InstanceResults { get; set; }
            public class ReleaseExpiredPrepaidInstanceResponseBodyDataInstanceResults : TeaModel {
                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-1</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Indicates whether the operation was successful.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the release operation was successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ReleaseResult")]
            [Validation(Required=false)]
            public bool? ReleaseResult { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DF58589C-A06C-4224-8615-7797E6474FA3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
