// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeParametersRequest : TeaModel {
        /// <summary>
        /// It is an online CLI tool that allows you to quickly retrieve and debug APIs. It can dynamically generate executable SDK code samples.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public string Dimension { get; set; }

        /// <summary>
        /// Alibaba Cloud CLI
        /// </summary>
        [NameInMap("DimensionValue")]
        [Validation(Required=false)]
        public string DimensionValue { get; set; }

        /// <summary>
        /// 498529
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
