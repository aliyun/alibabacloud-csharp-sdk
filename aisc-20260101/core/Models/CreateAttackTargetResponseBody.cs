// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AISC20260101.Models
{
    public class CreateAttackTargetResponseBody : TeaModel {
        /// <summary>
        /// <para>The operation result. Upon successful creation, the TargetId of the new scan target is returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateAttackTargetResponseBodyData Data { get; set; }
        public class CreateAttackTargetResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The unique identifier of the created scan target. You can use this value as the TargetId parameter in subsequent calls such as TestConnectivity and scan task creation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>target-abc123def4567</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

        }

        /// <summary>
        /// <para>The request ID, used for troubleshooting and log tracing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1EBD0C05-6C1F-4C95-9C63-B7AB7B5A9C8E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
