// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyCloudVendorAccountAKRequest : TeaModel {
        /// <summary>
        /// The unique ID of the AccessKey pair.
        /// 
        /// >  You can call the [DescribeCloudVendorAccountAKList](~~DescribeCloudVendorAccountAKList~~) operation to query the unique ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AuthIds")]
        [Validation(Required=false)]
        public string AuthIds { get; set; }

        /// <summary>
        /// The modules that are associated with the AccessKey pair.
        /// </summary>
        [NameInMap("AuthModules")]
        [Validation(Required=false)]
        public List<string> AuthModules { get; set; }

        /// <summary>
        /// The Active Directory (AD) domain. This parameter takes effect only when Vendor is set to Azure. Valid values:
        /// 
        /// *   **china**
        /// *   **global**
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The regions that are examined during AccessKey pair authentication. This parameter takes effect only when Vendor is set to AWS.
        /// 
        /// >  You can call the [ListCloudVendorRegions](~~ListCloudVendorRegions~~) operation to query regions.
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<string> Regions { get; set; }

        /// <summary>
        /// The AccessKey ID.
        /// </summary>
        [NameInMap("SecretId")]
        [Validation(Required=false)]
        public string SecretId { get; set; }

        /// <summary>
        /// The AccessKey secret. Valid values:
        /// 
        /// 1\\. If AkType is set to primary, specify this parameter based on the following description:
        /// 
        /// *   **Tencent**: Specify the AccessKey secret of a primary account on Tencent Cloud.
        /// *   **HUAWEICLOUD**: Specify the AccessKey secret of a primary account on Huawei Cloud.
        /// *   **Azure**: Specify the AccessKey secret of a primary account on Microsoft Azure.
        /// *   **AWS**: Specifythe AccessKey secret of a primary account on Amazon Web Services (AWS).
        /// 
        /// 2\\. If AkType is set to sub, specify this parameter based on the following description:
        /// 
        /// *   **Tencent**: Specify the AccessKey secret of a sub-account on Tencent Cloud.
        /// *   **HUAWEICLOUD**: Specify the AccessKey secret of a sub-account on Huawei Cloud.
        /// *   **Azure**: Specify the AccessKey secret of a sub-account on Microsoft Azure.
        /// *   **AWS**: Specify the AccessKey secret of a sub-account on AWS.
        /// </summary>
        [NameInMap("SecretKey")]
        [Validation(Required=false)]
        public string SecretKey { get; set; }

        /// <summary>
        /// The status of the AccessKey pair. Valid values:
        /// 
        /// *   **0**: enabled.
        /// *   **1**: disabled.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// The subscription IDs. This parameter takes effect only when Vendor is set to Azure.
        /// </summary>
        [NameInMap("SubscriptionIds")]
        [Validation(Required=false)]
        public List<string> SubscriptionIds { get; set; }

        /// <summary>
        /// The tenant ID. This parameter takes effect only when Vendor is set to Azure.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
