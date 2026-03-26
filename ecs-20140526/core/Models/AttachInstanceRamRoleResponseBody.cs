// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class AttachInstanceRamRoleResponseBody : TeaModel {
        [NameInMap("AttachInstanceRamRoleResults")]
        [Validation(Required=false)]
        public AttachInstanceRamRoleResponseBodyAttachInstanceRamRoleResults AttachInstanceRamRoleResults { get; set; }
        public class AttachInstanceRamRoleResponseBodyAttachInstanceRamRoleResults : TeaModel {
            [NameInMap("AttachInstanceRamRoleResult")]
            [Validation(Required=false)]
            public List<AttachInstanceRamRoleResponseBodyAttachInstanceRamRoleResultsAttachInstanceRamRoleResult> AttachInstanceRamRoleResult { get; set; }
            public class AttachInstanceRamRoleResponseBodyAttachInstanceRamRoleResultsAttachInstanceRamRoleResult : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of instances to which the instance RAM role failed to be attached.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FailCount")]
        [Validation(Required=false)]
        public int? FailCount { get; set; }

        /// <summary>
        /// <para>The name of the instance RAM role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testRamRoleName</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9553E4C-6C3A-4D66-AE79-9835AF705639</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of instances to which you attempted to attach the instance RAM role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
