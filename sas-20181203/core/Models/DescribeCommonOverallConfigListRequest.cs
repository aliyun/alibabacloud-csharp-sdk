// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCommonOverallConfigListRequest : TeaModel {
        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The types of the configuration items.
        /// 
        /// >  You can query up to 50 types at a time.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TypeList")]
        [Validation(Required=false)]
        public List<string> TypeList { get; set; }

    }

}
