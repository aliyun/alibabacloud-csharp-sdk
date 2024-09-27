// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmRecoveryPlansResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The details about the queried disaster recovery plans.</para>
        /// </summary>
        [NameInMap("RecoveryPlans")]
        [Validation(Required=false)]
        public DescribeGtmRecoveryPlansResponseBodyRecoveryPlans RecoveryPlans { get; set; }
        public class DescribeGtmRecoveryPlansResponseBodyRecoveryPlans : TeaModel {
            [NameInMap("RecoveryPlan")]
            [Validation(Required=false)]
            public List<DescribeGtmRecoveryPlansResponseBodyRecoveryPlansRecoveryPlan> RecoveryPlan { get; set; }
            public class DescribeGtmRecoveryPlansResponseBodyRecoveryPlansRecoveryPlan : TeaModel {
                /// <summary>
                /// <para>The time when the disaster recovery plan was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-08-11T06:45Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The UNIX timestamp that indicates when the disaster recovery plan was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1565499867000</para>
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <para>The number of faulty address pools.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FaultAddrPoolNum")]
                [Validation(Required=false)]
                public int? FaultAddrPoolNum { get; set; }

                /// <summary>
                /// <para>The last time when the disaster recovery plan was executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-08-11T06:44Z</para>
                /// </summary>
                [NameInMap("LastExecuteTime")]
                [Validation(Required=false)]
                public string LastExecuteTime { get; set; }

                /// <summary>
                /// <para>The UNIX timestamp that indicates the last time when the disaster recovery plan was executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1565505898000</para>
                /// </summary>
                [NameInMap("LastExecuteTimestamp")]
                [Validation(Required=false)]
                public long? LastExecuteTimestamp { get; set; }

                /// <summary>
                /// <para>The last time when the disaster recovery plan was rolled back.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-08-11T06:45Z</para>
                /// </summary>
                [NameInMap("LastRollbackTime")]
                [Validation(Required=false)]
                public string LastRollbackTime { get; set; }

                /// <summary>
                /// <para>The UNIX timestamp that indicates the last time when the disaster recovery plan was rolled back.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1565505919000</para>
                /// </summary>
                [NameInMap("LastRollbackTimestamp")]
                [Validation(Required=false)]
                public long? LastRollbackTimestamp { get; set; }

                /// <summary>
                /// <para>The name of the disaster recovery plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name-example</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the disaster recovery plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>55</para>
                /// </summary>
                [NameInMap("RecoveryPlanId")]
                [Validation(Required=false)]
                public long? RecoveryPlanId { get; set; }

                /// <summary>
                /// <para>The remarks about the disaster recovery plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>remark-example</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The status of the disaster recovery plan. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>UNEXECUTED</b>: The plan is not executed.</description></item>
                /// <item><description><b>EXECUTED</b>: The plan is executed.</description></item>
                /// <item><description><b>ROLLED_BACK</b>: The plan is rolled back.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>UNEXECUTED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The last time when the disaster recovery plan was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-08-11T06:45Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The UNIX timestamp that indicates the last time when the disaster recovery plan was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1565505919000</para>
                /// </summary>
                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2BA072CF-CA21-4A34-B6C2-227BE2C58079</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>The total number of pages returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
