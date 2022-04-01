// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class NASConfig : TeaModel {
        /// <summary>
        /// groupID
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public int? GroupId { get; set; }

        /// <summary>
        /// 挂载点
        /// </summary>
        [NameInMap("mountPoints")]
        [Validation(Required=false)]
        public List<NASConfigMountPoints> MountPoints { get; set; }
        public class NASConfigMountPoints : TeaModel {
            /// <summary>
            /// 本地挂载目录
            /// </summary>
            [NameInMap("mountDir")]
            [Validation(Required=false)]
            public string MountDir { get; set; }

            /// <summary>
            /// NAS服务器地址
            /// </summary>
            [NameInMap("serverAddr")]
            [Validation(Required=false)]
            public string ServerAddr { get; set; }

        }

        /// <summary>
        /// userID
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public int? UserId { get; set; }

    }

}
