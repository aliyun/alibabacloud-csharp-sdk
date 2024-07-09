// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeRegionsRequest : TeaModel {
        /// <summary>
        /// The supported language. Valid values:
        /// 
        /// *   zh-CN: Chinese
        /// *   en-US: English
        /// *   ja: Japanese
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account to which the permissions on the resources are granted.
        /// </summary>
        [NameInMap("AuthorizedUserId")]
        [Validation(Required=false)]
        public long? AuthorizedUserId { get; set; }

        /// <summary>
        /// The language.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The scenario. Valid values:
        /// 
        /// *   AUTH: the built-in authoritative module
        /// *   FWD: the forward module
        /// *   RA: the traffic analysis module
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// The IP address of the client.
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        /// <summary>
        /// The type of the virtual private cloud (VPC). Valid values:
        /// 
        /// *   STANDARD: standard VPC
        /// *   EDS: Elastic Desktop Service (EDS) workspace VPC
        /// </summary>
        [NameInMap("VpcType")]
        [Validation(Required=false)]
        public string VpcType { get; set; }

    }

}
