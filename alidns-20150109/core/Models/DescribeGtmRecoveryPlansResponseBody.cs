// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmRecoveryPlansResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page. Pages start from <b>1</b>. The default value is <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page. The maximum value is <b>100</b>. The default value is <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RecoveryPlans")]
        [Validation(Required=false)]
        public DescribeGtmRecoveryPlansResponseBodyRecoveryPlans RecoveryPlans { get; set; }
        public class DescribeGtmRecoveryPlansResponseBodyRecoveryPlans : TeaModel {
            [NameInMap("RecoveryPlan")]
            [Validation(Required=false)]
            public List<DescribeGtmRecoveryPlansResponseBodyRecoveryPlansRecoveryPlan> RecoveryPlan { get; set; }
            public class DescribeGtmRecoveryPlansResponseBodyRecoveryPlansRecoveryPlan : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                [NameInMap("FaultAddrPoolNum")]
                [Validation(Required=false)]
                public int? FaultAddrPoolNum { get; set; }

                [NameInMap("LastExecuteTime")]
                [Validation(Required=false)]
                public string LastExecuteTime { get; set; }

                [NameInMap("LastExecuteTimestamp")]
                [Validation(Required=false)]
                public long? LastExecuteTimestamp { get; set; }

                [NameInMap("LastRollbackTime")]
                [Validation(Required=false)]
                public string LastRollbackTime { get; set; }

                [NameInMap("LastRollbackTimestamp")]
                [Validation(Required=false)]
                public long? LastRollbackTimestamp { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RecoveryPlanId")]
                [Validation(Required=false)]
                public long? RecoveryPlanId { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2BA072CF-CA21-4A34-B6C2-227BE2C58079</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
