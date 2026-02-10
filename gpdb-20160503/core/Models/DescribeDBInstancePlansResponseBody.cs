// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstancePlansResponseBody : TeaModel {
        /// <summary>
        /// <para>The error message.</para>
        /// <para>This parameter is returned only if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstancePlansResponseBodyItems Items { get; set; }
        public class DescribeDBInstancePlansResponseBodyItems : TeaModel {
            [NameInMap("PlanList")]
            [Validation(Required=false)]
            public List<DescribeDBInstancePlansResponseBodyItemsPlanList> PlanList { get; set; }
            public class DescribeDBInstancePlansResponseBodyItemsPlanList : TeaModel {
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                [NameInMap("PlanConfig")]
                [Validation(Required=false)]
                public string PlanConfig { get; set; }

                [NameInMap("PlanDesc")]
                [Validation(Required=false)]
                public string PlanDesc { get; set; }

                [NameInMap("PlanEndDate")]
                [Validation(Required=false)]
                public string PlanEndDate { get; set; }

                [NameInMap("PlanId")]
                [Validation(Required=false)]
                public string PlanId { get; set; }

                [NameInMap("PlanName")]
                [Validation(Required=false)]
                public string PlanName { get; set; }

                [NameInMap("PlanScheduleType")]
                [Validation(Required=false)]
                public string PlanScheduleType { get; set; }

                [NameInMap("PlanStartDate")]
                [Validation(Required=false)]
                public string PlanStartDate { get; set; }

                [NameInMap("PlanStatus")]
                [Validation(Required=false)]
                public string PlanStatus { get; set; }

                [NameInMap("PlanType")]
                [Validation(Required=false)]
                public string PlanType { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34b32a0a-08ef-4a87-b6be-cdd988888888</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// <para>If the request was successful, <b>success</b> is returned. If the request failed, this parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
