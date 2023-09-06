// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ModifyClusterAttributesRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster that you want to modify.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The new cluster description.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The IDs of the images.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The new image type of the cluster. Valid values:
        /// 
        /// *   system: public image
        /// *   self: custom image
        /// *   others: shared image
        /// *   marketplace: Alibaba Cloud Marketplace image
        /// </summary>
        [NameInMap("ImageOwnerAlias")]
        [Validation(Required=false)]
        public string ImageOwnerAlias { get; set; }

        /// <summary>
        /// The new cluster name.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The type of the node to which you want to bind the RAM role.
        /// </summary>
        [NameInMap("RamNodeTypes")]
        [Validation(Required=false)]
        public List<string> RamNodeTypes { get; set; }

        /// <summary>
        /// The name of the instance RAM role.
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// The parameters that are used to connect to the Windows AD server.
        /// </summary>
        [NameInMap("WinAdPar")]
        [Validation(Required=false)]
        public ModifyClusterAttributesRequestWinAdPar WinAdPar { get; set; }
        public class ModifyClusterAttributesRequestWinAdPar : TeaModel {
            /// <summary>
            /// The domain name of the Windows AD server.
            /// </summary>
            [NameInMap("AdDc")]
            [Validation(Required=false)]
            public string AdDc { get; set; }

            /// <summary>
            /// The IP address of the Windows AD server.
            /// </summary>
            [NameInMap("AdIp")]
            [Validation(Required=false)]
            public string AdIp { get; set; }

            /// <summary>
            /// The Windows AD server administrator.
            /// </summary>
            [NameInMap("AdUser")]
            [Validation(Required=false)]
            public string AdUser { get; set; }

            /// <summary>
            /// The administrator password of the Windows AD server.
            /// </summary>
            [NameInMap("AdUserPasswd")]
            [Validation(Required=false)]
            public string AdUserPasswd { get; set; }

            /// <summary>
            /// The home directory of the Linux server.
            /// </summary>
            [NameInMap("FallbackHomeDir")]
            [Validation(Required=false)]
            public string FallbackHomeDir { get; set; }

        }

    }

}
