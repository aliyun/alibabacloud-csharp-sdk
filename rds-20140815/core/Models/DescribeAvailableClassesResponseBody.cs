// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAvailableClassesResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the instance types available for the instance.
        /// </summary>
        [NameInMap("DBInstanceClasses")]
        [Validation(Required=false)]
        public List<DescribeAvailableClassesResponseBodyDBInstanceClasses> DBInstanceClasses { get; set; }
        public class DescribeAvailableClassesResponseBodyDBInstanceClasses : TeaModel {
            /// <summary>
            /// The instance type of the instance.
            /// </summary>
            [NameInMap("DBInstanceClass")]
            [Validation(Required=false)]
            public string DBInstanceClass { get; set; }

            /// <summary>
            /// The storage capacity range that is supported for the instance.
            /// </summary>
            [NameInMap("DBInstanceStorageRange")]
            [Validation(Required=false)]
            public DescribeAvailableClassesResponseBodyDBInstanceClassesDBInstanceStorageRange DBInstanceStorageRange { get; set; }
            public class DescribeAvailableClassesResponseBodyDBInstanceClassesDBInstanceStorageRange : TeaModel {
                /// <summary>
                /// The maximum storage capacity that is supported for the instance. Unit: GB.
                /// </summary>
                [NameInMap("MaxValue")]
                [Validation(Required=false)]
                public int? MaxValue { get; set; }

                /// <summary>
                /// The minimum storage capacity that is supported for the instance. Unit: GB.
                /// </summary>
                [NameInMap("MinValue")]
                [Validation(Required=false)]
                public int? MinValue { get; set; }

                /// <summary>
                /// The minimum step size at which you can adjust the storage capacity of the instance. The minimum step size is 5 GB.
                /// </summary>
                [NameInMap("Step")]
                [Validation(Required=false)]
                public int? Step { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
