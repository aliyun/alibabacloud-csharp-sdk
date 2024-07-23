// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CalculateDBInstanceWeightResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of information about the system-assigned read weight.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public CalculateDBInstanceWeightResponseBodyItems Items { get; set; }
        public class CalculateDBInstanceWeightResponseBodyItems : TeaModel {
            [NameInMap("DBInstanceWeight")]
            [Validation(Required=false)]
            public List<CalculateDBInstanceWeightResponseBodyItemsDBInstanceWeight> DBInstanceWeight { get; set; }
            public class CalculateDBInstanceWeightResponseBodyItemsDBInstanceWeight : TeaModel {
                /// <summary>
                /// <para>The instance ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-uf6wjk5xxxxxxx</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <para>The type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Master</b>: primary instance</description></item>
                /// <item><description><b>Readonly</b>: read-only instance</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Master</para>
                /// </summary>
                [NameInMap("DBInstanceType")]
                [Validation(Required=false)]
                public string DBInstanceType { get; set; }

                /// <summary>
                /// <para>The latency at which the read-only instances replicate data. The read-only instances replicate data from the primary instance at the latency that is specified by the <b>ReadonlyInstanceSQLDelayedTime</b> parameter. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("ReadonlyInstanceSQLDelayedTime")]
                [Validation(Required=false)]
                public string ReadonlyInstanceSQLDelayedTime { get; set; }

                /// <summary>
                /// <para>The read weight that the system calculates in real time for the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public string Weight { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C816A4BF-A6EC-4722-95F9-2055859CCFD2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
