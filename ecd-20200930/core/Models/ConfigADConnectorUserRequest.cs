// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ConfigADConnectorUserRequest : TeaModel {
        /// <summary>
        /// The password of the AD user that has the permissions to join computers to domains.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainPassword")]
        [Validation(Required=false)]
        public string DomainPassword { get; set; }

        /// <summary>
        /// The username of the AD user that has the permissions to join computers to domains.
        /// 
        /// After the username is configured, the cloud desktops in the same AD workspace are joined to the specified OU.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainUserName")]
        [Validation(Required=false)]
        public string DomainUserName { get; set; }

        /// <summary>
        /// The name of the OU in the AD domain. You can call the [ListUserAdOrganizationUnits](https://help.aliyun.com/document_detail/311259.html) to obtain the OU name.
        /// </summary>
        [NameInMap("OUName")]
        [Validation(Required=false)]
        public string OUName { get; set; }

        /// <summary>
        /// The ID of the AD workspace.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// The ID of the region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
