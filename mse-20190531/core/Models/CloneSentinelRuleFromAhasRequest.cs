// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CloneSentinelRuleFromAhasRequest : TeaModel {
        /// <summary>
        /// The language in which you want to display the results. Valid values: zh and en. zh indicates Chinese, which is the default value. en indicates English.
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The namespace (environment) of Application High Availability Service (AHAS).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AhasNamespace")]
        [Validation(Required=false)]
        public string AhasNamespace { get; set; }

        /// <summary>
        /// The application name.
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// Specifies whether AHAS is deployed in the Internet region.
        /// </summary>
        [NameInMap("IsAHASPublicRegion")]
        [Validation(Required=false)]
        public bool? IsAHASPublicRegion { get; set; }

        /// <summary>
        /// The namespace.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

    }

}
