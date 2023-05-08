// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddInstallCodeRequest : TeaModel {
        /// <summary>
        /// 6134
        /// </summary>
        [NameInMap("ExpiredDate")]
        [Validation(Required=false)]
        public long? ExpiredDate { get; set; }

        /// <summary>
        /// Specifies whether to create an image. Default value: **false**. Valid values:
        /// 
        /// *   **false**: does not create an image.
        /// *   **true**: creates an image.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// The operating system of the instance. Default value: **linux**. Valid values:
        /// 
        /// *   **linux**
        /// *   **windows**
        /// *   **windows-2003**
        /// </summary>
        [NameInMap("OnlyImage")]
        [Validation(Required=false)]
        public bool? OnlyImage { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("Os")]
        [Validation(Required=false)]
        public string Os { get; set; }

        /// <summary>
        /// The ID of the asset group to which the you want to add the asset.
        /// 
        /// >  You can call the [DescribeAllGroups](~~describeallgroups~~) operation to query the IDs of asset groups.
        /// </summary>
        [NameInMap("VendorName")]
        [Validation(Required=false)]
        public string VendorName { get; set; }

    }

}
