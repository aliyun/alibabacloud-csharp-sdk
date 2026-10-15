// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class AgenticFSVolumeConfig : TeaModel {
        /// <summary>
        /// <para>The group ID (GID) for accessing the mounted directory in the sandbox.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("groupID")]
        [Validation(Required=false)]
        public int? GroupID { get; set; }

        /// <summary>
        /// <para>The service address of the AgenticFS access point.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-12345678.fs-12345678-abc.cn-hangzhou.nas.aliyuncs.com:/</para>
        /// </summary>
        [NameInMap("serverAddr")]
        [Validation(Required=false)]
        public string ServerAddr { get; set; }

        /// <summary>
        /// <para>The user ID (UID) for accessing the mounted directory in the sandbox.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("userID")]
        [Validation(Required=false)]
        public int? UserID { get; set; }

    }

}
