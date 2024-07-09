// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyUserToDesktopGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the cloud computer pool whose end users you want to change.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        /// <summary>
        /// The IDs of the end users that you want to add. You can configure 1 to 500 IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NewEndUserIds")]
        [Validation(Required=false)]
        public List<string> NewEndUserIds { get; set; }

        /// <summary>
        /// The IDs of the end users that you want to remove. You can configure 1 to 500 IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OldEndUserIds")]
        [Validation(Required=false)]
        public List<string> OldEndUserIds { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/196646.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
