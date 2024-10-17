// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateMountTargetResponseBody : TeaModel {
        /// <summary>
        /// <para>The IPv4 domain name of the mount target.</para>
        /// 
        /// <b>Example:</b>
        /// <para>174494b666-x****.cn-hangzhou.nas.aliyuncs.com</para>
        /// </summary>
        [NameInMap("MountTargetDomain")]
        [Validation(Required=false)]
        public string MountTargetDomain { get; set; }

        /// <summary>
        /// <para>The information about the mount target.</para>
        /// </summary>
        [NameInMap("MountTargetExtra")]
        [Validation(Required=false)]
        public CreateMountTargetResponseBodyMountTargetExtra MountTargetExtra { get; set; }
        public class CreateMountTargetResponseBodyMountTargetExtra : TeaModel {
            /// <summary>
            /// <para>The dual-stack (IPv4 and IPv6) domain name of the mount target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>174494b666-x****.dualstack.cn-hangzhou.nas.aliyuncs.com</para>
            /// </summary>
            [NameInMap("DualStackMountTargetDomain")]
            [Validation(Required=false)]
            public string DualStackMountTargetDomain { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70EACC9C-D07A-4A34-ADA4-77506C42****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
