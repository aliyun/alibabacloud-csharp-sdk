// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAvailableClassesResponseBody : TeaModel {
        /// <summary>
        /// <para>The available instance types for the instance.</para>
        /// </summary>
        [NameInMap("DBInstanceClasses")]
        [Validation(Required=false)]
        public List<DescribeAvailableClassesResponseBodyDBInstanceClasses> DBInstanceClasses { get; set; }
        public class DescribeAvailableClassesResponseBodyDBInstanceClasses : TeaModel {
            /// <summary>
            /// <para>The instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds.mysql.c1.large</para>
            /// </summary>
            [NameInMap("DBInstanceClass")]
            [Validation(Required=false)]
            public string DBInstanceClass { get; set; }

            /// <summary>
            /// <para>The instance storage capacity range.</para>
            /// </summary>
            [NameInMap("DBInstanceStorageRange")]
            [Validation(Required=false)]
            public DescribeAvailableClassesResponseBodyDBInstanceClassesDBInstanceStorageRange DBInstanceStorageRange { get; set; }
            public class DescribeAvailableClassesResponseBodyDBInstanceClassesDBInstanceStorageRange : TeaModel {
                /// <summary>
                /// <para>The maximum storage capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("MaxValue")]
                [Validation(Required=false)]
                public int? MaxValue { get; set; }

                /// <summary>
                /// <para>The minimum storage capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("MinValue")]
                [Validation(Required=false)]
                public int? MinValue { get; set; }

                /// <summary>
                /// <para>The minimum granularity for storage capacity adjustment. The value is fixed at 5 GB increments.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Step")]
                [Validation(Required=false)]
                public int? Step { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E4448A6-9FE6-4474-A0C1-AA7CFC772CAC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
