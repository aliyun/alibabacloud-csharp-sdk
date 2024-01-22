// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreatePublicIpAddressPoolRequest : TeaModel {
        /// <summary>
        /// The service type of the IP address pool. Valid values:
        /// 
        /// *   **CloudBox** Only cloud box users can select this type.
        /// *   **Default**: This is the default value.
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate a value, and you must make sure that each request has a unique token value. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the value of **RequestId** as the value of **ClientToken**. The value of **RequestId** for each API request is different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the IP address pool.
        /// 
        /// This parameter is optional. The description must be 2 to 256 characters in length, and cannot start with http:// or https://.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether to precheck only this request. Valid values:
        /// 
        /// *   **true**: prechecks the request without creating an IP address pool. The system checks the required parameters, request format, and service limits. If the request fails to pass the precheck, an error code is returned. If the request passes the precheck, the `DryRunOperation` error code is returned.
        /// *   **false**: sends the request. This is the default value. If the request passes the precheck, a 2xx HTTP status code is returned and the IP address pool is created.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The line type. Valid values:
        /// 
        /// *   **BGP** (default)
        /// *   **BGP_PRO**
        /// 
        /// For more information about BGP (Multi-ISP) lines and BGP (Multi-ISP) Pro lines, see the "Line types" section in the [What is EIP?](~~32321~~) topic.
        /// 
        /// *   If you are allowed to use single-ISP bandwidth, you can also use one of the following values:
        /// 
        ///     *   **ChinaTelecom**
        ///     *   **ChinaUnicom**
        ///     *   **ChinaMobile**
        ///     *   **ChinaTelecom_L2**
        ///     *   **ChinaUnicom_L2**
        ///     *   **ChinaMobile_L2**
        /// 
        /// *   If your services are deployed in China East 1 Finance, this parameter is required and you must set the value to **BGP_FinanceCloud**.
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// The name of the IP address pool.
        /// 
        /// This parameter is optional. The name must be 1 to 128 characters in length and can contain digits, periods (.), underscores (\_), and hyphens (-). The name must start with a letter but cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region where you want to create the IP address pool.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the IP address pool belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityProtectionTypes")]
        [Validation(Required=false)]
        public List<string> SecurityProtectionTypes { get; set; }

        /// <summary>
        /// The tag of the resource.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreatePublicIpAddressPoolRequestTag> Tag { get; set; }
        public class CreatePublicIpAddressPoolRequestTag : TeaModel {
            /// <summary>
            /// The tag key of the resource. You can specify up to 20 tag keys. The tag key cannot be an empty string.
            /// 
            /// A tag key can be up to 128 characters in length. It cannot start with `aliyun` or `acs:`, and cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value of the resource. You can specify up to 20 tag values. The tag value can be an empty string.
            /// 
            /// The tag value can be up to 128 characters in length. It cannot start with `aliyun` or `acs:`, and cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The zone of the IP address pool. If you set **BizType** to **CloudBox**, this parameter is required.
        /// </summary>
        [NameInMap("Zones")]
        [Validation(Required=false)]
        public List<string> Zones { get; set; }

    }

}
