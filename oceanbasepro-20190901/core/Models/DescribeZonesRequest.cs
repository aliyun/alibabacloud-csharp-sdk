// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeZonesRequest : TeaModel {
        /// <summary>
        /// The deployment type of the cluster. Valid values:   
        /// - multiple: multi-IDC deployment   
        /// - single: single-IDC deployment   
        /// - dual: dual-IDC deployment
        /// </summary>
        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public string DeployType { get; set; }

        /// <summary>
        /// The series of the OceanBase cluster. Valid values:   
        /// NORMAL: the high availability version. This is the default value.
        /// </summary>
        [NameInMap("Series")]
        [Validation(Required=false)]
        public string Series { get; set; }

    }

}
