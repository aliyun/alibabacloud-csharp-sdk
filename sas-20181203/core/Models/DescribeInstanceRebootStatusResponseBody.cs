// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeInstanceRebootStatusResponseBody : TeaModel {
        [NameInMap("RebootStatuses")]
        [Validation(Required=false)]
        public List<DescribeInstanceRebootStatusResponseBodyRebootStatuses> RebootStatuses { get; set; }
        public class DescribeInstanceRebootStatusResponseBodyRebootStatuses : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

            [NameInMap("RebootStatus")]
            [Validation(Required=false)]
            public int? RebootStatus { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// DescribeInstanceRebootStatus
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
