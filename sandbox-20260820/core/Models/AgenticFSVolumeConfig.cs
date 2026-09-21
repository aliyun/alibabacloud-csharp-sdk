// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class AgenticFSVolumeConfig : TeaModel {
        /// <summary>
        /// <para>The access point ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-xxxx</para>
        /// </summary>
        [NameInMap("accessPointID")]
        [Validation(Required=false)]
        public string AccessPointID { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agentic-xxxx</para>
        /// </summary>
        [NameInMap("agenticSpaceID")]
        [Validation(Required=false)]
        public string AgenticSpaceID { get; set; }

        /// <summary>
        /// <para>The file system ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>03204sl2qjiax4ocdt2</para>
        /// </summary>
        [NameInMap("fileSystemID")]
        [Validation(Required=false)]
        public string FileSystemID { get; set; }

        /// <summary>
        /// <para>The group ID for local mounting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("groupID")]
        [Validation(Required=false)]
        public int? GroupID { get; set; }

        /// <summary>
        /// <para>The AgenticFS access point address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-xxxx.03204sl2qjiax4ocdt2-ljs60.cn-shanghai.nas.aliyuncs.com</para>
        /// </summary>
        [NameInMap("serverAddr")]
        [Validation(Required=false)]
        public string ServerAddr { get; set; }

        /// <summary>
        /// <para>The user ID for local mounting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("userID")]
        [Validation(Required=false)]
        public int? UserID { get; set; }

    }

}
