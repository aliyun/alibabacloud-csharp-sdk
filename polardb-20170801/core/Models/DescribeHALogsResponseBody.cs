// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeHALogsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>pc-a*************</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>polardb_mysql_rw</para>
        /// </summary>
        [NameInMap("DBInstanceType")]
        [Validation(Required=false)]
        public string DBInstanceType { get; set; }

        /// <summary>
        /// <para>The failover logs.</para>
        /// </summary>
        [NameInMap("HaLogItems")]
        [Validation(Required=false)]
        public List<DescribeHALogsResponseBodyHaLogItems> HaLogItems { get; set; }
        public class DescribeHALogsResponseBodyHaLogItems : TeaModel {
            /// <summary>
            /// <para>The reason code of the failover.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Platform.Ha.AuroraService.ManualOperations</para>
            /// </summary>
            [NameInMap("SwitchCauseCode")]
            [Validation(Required=false)]
            public string SwitchCauseCode { get; set; }

            /// <summary>
            /// <para>The reason of the failover.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Platform.Ha.ManuallyTriggered</para>
            /// </summary>
            [NameInMap("SwitchCauseDetail")]
            [Validation(Required=false)]
            public string SwitchCauseDetail { get; set; }

            /// <summary>
            /// <para>The time when the failover ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-20T03:09:56Z</para>
            /// </summary>
            [NameInMap("SwitchFinishTime")]
            [Validation(Required=false)]
            public string SwitchFinishTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>e571f897-9b3c-4012-9470-88333832dec4</para>
            /// </summary>
            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

            /// <summary>
            /// <para>The time when the failover started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-20T03:09:45Z</para>
            /// </summary>
            [NameInMap("SwitchStartTime")]
            [Validation(Required=false)]
            public string SwitchStartTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HaStatus")]
        [Validation(Required=false)]
        public int? HaStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ItemsNumbers")]
        [Validation(Required=false)]
        public int? ItemsNumbers { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6BD9CDE4-5E7B-4BF3-9BB8-83C73E******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>160</para>
        /// </summary>
        [NameInMap("TotalRecords")]
        [Validation(Required=false)]
        public int? TotalRecords { get; set; }

    }

}
