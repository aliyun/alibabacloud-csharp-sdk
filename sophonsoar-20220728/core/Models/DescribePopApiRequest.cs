// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePopApiRequest : TeaModel {
        /// <summary>
        /// The operation name of the Alibaba Cloud service.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        /// <summary>
        /// The version number of the API.
        /// 
        /// >  You can call the [DescribePopApiVersionList](~~DescribePopApiVersionList~~) operation to query the version number.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApiVersion")]
        [Validation(Required=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// The environment in which the API operation parameter is used. Set the value to online.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// The POP code of the Alibaba Cloud service.
        /// 
        /// >  You can call the [DescribeApiList](~~DescribeApiList~~) operation to query the POP code.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PopCode")]
        [Validation(Required=false)]
        public string PopCode { get; set; }

    }

}
