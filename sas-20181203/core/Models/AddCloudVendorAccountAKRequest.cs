// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddCloudVendorAccountAKRequest : TeaModel {
        /// <summary>
        /// The type of the account to which the AccessKey pair belongs. Valid values:
        /// 
        /// *   **primary**: a primary account
        /// *   **sub**: a sub-account
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AkType")]
        [Validation(Required=false)]
        public string AkType { get; set; }

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
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<string> Regions { get; set; }

        /// <summary>
        /// The AccessKey ID. Valid values:
        /// 
        /// 1\\. If AkType is set to primary, specify this parameter based on the following description:
        /// 
        /// *   **Tencent**: Enter the AccessKey ID of a primary account on Tencent Cloud.
        /// *   **HUAWEICLOUD**: Enter the AccessKey ID of a primary account on Huawei Cloud.
        /// *   **Azure**: Enter the AccessKey ID of a primary account on Microsoft Azure.
        /// *   **AWS**: Enter the AccessKey ID of a primary account on AWS.
        /// 
        /// 2\\. If AkType is set to sub, specify this parameter based on the following description:
        /// 
        /// *   **Tencent**: Enter the AccessKey ID of a sub-account on Tencent Cloud.
        /// *   **HUAWEICLOUD**: Enter the AccessKey ID of a sub-account on Huawei Cloud.
        /// *   **Azure**: Enter the AccessKey ID of a sub-account on Microsoft Azure.
        /// *   **AWS**: Enter the AccessKey ID of a sub-account on AWS.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SecretId")]
        [Validation(Required=false)]
        public string SecretId { get; set; }

        /// <summary>
        /// The AccessKey secret. Valid values:
        /// 
        /// 1\\. If AkType is set to primary, specify this parameter based on the following description:
        /// 
        /// *   **Tencent**: Enter the AccessKey secret of a primary account on Tencent Cloud.
        /// *   **HUAWEICLOUD**: Enter the AccessKey secret of a primary account on Huawei Cloud.
        /// *   **Azure**: Enter the AccessKey secret of a primary account on Microsoft Azure.
        /// *   **AWS**: Enter the AccessKey secret of a primary account on AWS.
        /// 
        /// 2\\. If AkType is set to sub, specify this parameter based on the following description:
        /// 
        /// *   **Tencent**: Enter the AccessKey secret of a sub-account on Tencent Cloud.
        /// *   **HUAWEICLOUD**: Enter the AccessKey secret of a sub-account on Huawei Cloud.
        /// *   **Azure**: Enter the AccessKey secret of a sub-account on Microsoft Azure.
        /// *   **AWS**: Enter the AccessKey secret of a sub-account on AWS.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SecretKey")]
        [Validation(Required=false)]
        public string SecretKey { get; set; }

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

        /// <summary>
        /// The cloud service provider. Valid values:
        /// 
        /// *   **Tencent**: Tencent Cloud
        /// *   **HUAWEICLOUD**: Huawei Cloud
        /// *   **Azure**: Microsoft Azure
        /// *   **AWS**: Amazon Web Services (AWS)
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

    }

}
