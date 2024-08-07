// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListUserProdLogsRequest : TeaModel {
        /// <summary>
        /// The region in which the data management center of the threat analysis feature resides. Specify this parameter based on the regions in which your assets reside. Valid values:
        /// 
        /// *   cn-hangzhou: Your assets reside in regions in China.
        /// *   ap-southeast-1: Your assets reside in regions outside China.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// 管理员切换成其他成员视角的用户ID。
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// 视图类型。
        /// 
        /// - 0：当前阿里云账号视图。
        /// - 1：企业下所有账号的视图。
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

        /// <summary>
        /// The log code.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceLogCode")]
        [Validation(Required=false)]
        public string SourceLogCode { get; set; }

        /// <summary>
        /// The code of the cloud service.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceProdCode")]
        [Validation(Required=false)]
        public string SourceProdCode { get; set; }

    }

}
