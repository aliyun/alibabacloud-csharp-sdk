// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateImageVulRequest : TeaModel {
        /// <summary>
        /// The information about the vulnerability. The value of this parameter is in the JSON format and contains the following fields:
        /// 
        /// *   namespace: the namespace of the image
        /// *   repoName: the name of the Container Registry repository
        /// *   regionId: the region ID
        /// *   instanceId: the ID of the Container Registry instance
        /// *   repoId: the name of the repository
        /// *   tag: the tad added to the image
        /// *   digest: the digest of the image
        /// *   newTag: the tag added to the image after the vulnerability is fixed
        /// *   uuid: the UUID of the image
        /// *   ids: the IDs of the vulnerability primary keys
        /// </summary>
        [NameInMap("Info")]
        [Validation(Required=false)]
        public string Info { get; set; }

        /// <summary>
        /// If you want to fix the vulnerability, set the value to vul_fix.
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// The type of the vulnerability. Set the value to cve.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
