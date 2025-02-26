// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class AttachKeyPairResponseBody : TeaModel {
        /// <summary>
        /// <para>The object that is returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AttachKeyPairResponseBodyData Data { get; set; }
        public class AttachKeyPairResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The IDs of the cloud phone instances to which the ADB key pair is successfully attached.</para>
            /// </summary>
            [NameInMap("AttachedInstanceIds")]
            [Validation(Required=false)]
            public List<string> AttachedInstanceIds { get; set; }

            /// <summary>
            /// <para>The number of the cloud phone instances to which the ADB key pair failed to be attached.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FailCount")]
            [Validation(Required=false)]
            public int? FailCount { get; set; }

            /// <summary>
            /// <para>The ID of the ADB key pair.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kp-6v2q33ae4tw3a****</para>
            /// </summary>
            [NameInMap("KeyPairId")]
            [Validation(Required=false)]
            public string KeyPairId { get; set; }

            /// <summary>
            /// <para>The total number of the cloud phone instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69BCBBE4-FCF2-59B8-AD9D-531EB422****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
