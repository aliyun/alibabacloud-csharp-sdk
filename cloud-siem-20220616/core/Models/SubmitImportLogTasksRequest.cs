// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class SubmitImportLogTasksRequest : TeaModel {
        /// <summary>
        /// The accounts that you want to add. The value is a JSON array. Valid values:
        /// 
        /// *   AccountId: the IDs of the accounts.
        /// 
        /// *   Imported: specifies whether to add the accounts. Valid values:
        /// 
        ///     *   0: no
        ///     *   1: yes
        /// </summary>
        [NameInMap("Accounts")]
        [Validation(Required=false)]
        public string Accounts { get; set; }

        /// <summary>
        /// Specifies whether to automatically add the account for which the logging feature is configured. Valid values:
        /// 
        /// *   1: yes
        /// *   0: no
        /// </summary>
        [NameInMap("AutoImported")]
        [Validation(Required=false)]
        public int? AutoImported { get; set; }

        /// <summary>
        /// The code that is used for multi-cloud environments. Valid values:
        /// 
        /// *   qcloud: Tencent Cloud
        /// *   aliyun: Alibaba Cloud
        /// *   hcloud: Huawei Cloud
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CloudCode")]
        [Validation(Required=false)]
        public string CloudCode { get; set; }

        /// <summary>
        /// The logs that you want to collect. The value is a JSON array.
        /// </summary>
        [NameInMap("LogCodes")]
        [Validation(Required=false)]
        public string LogCodes { get; set; }

        /// <summary>
        /// The code of the service.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        /// <summary>
        /// The data management center of the threat analysis feature. Specify this parameter based on the region where your assets reside. Valid values:
        /// 
        /// *   cn-hangzhou: Your assets reside in regions inside China.
        /// *   ap-southeast-1: Your assets reside in regions outside China.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the account that you switch from the management account.
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// The type of the view. Valid values:
        /// - 0: the current Alibaba Cloud account
        /// - 1: the global account
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

    }

}
