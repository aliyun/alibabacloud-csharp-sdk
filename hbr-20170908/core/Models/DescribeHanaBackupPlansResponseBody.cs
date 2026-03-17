// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeHanaBackupPlansResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HanaBackupPlans")]
        [Validation(Required=false)]
        public DescribeHanaBackupPlansResponseBodyHanaBackupPlans HanaBackupPlans { get; set; }
        public class DescribeHanaBackupPlansResponseBodyHanaBackupPlans : TeaModel {
            [NameInMap("HanaBackupPlan")]
            [Validation(Required=false)]
            public List<DescribeHanaBackupPlansResponseBodyHanaBackupPlansHanaBackupPlan> HanaBackupPlan { get; set; }
            public class DescribeHanaBackupPlansResponseBodyHanaBackupPlansHanaBackupPlan : TeaModel {
                [NameInMap("BackupPrefix")]
                [Validation(Required=false)]
                public string BackupPrefix { get; set; }

                [NameInMap("BackupType")]
                [Validation(Required=false)]
                public string BackupType { get; set; }

                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }

                [NameInMap("Disabled")]
                [Validation(Required=false)]
                public bool? Disabled { get; set; }

                [NameInMap("PlanId")]
                [Validation(Required=false)]
                public string PlanId { get; set; }

                [NameInMap("PlanName")]
                [Validation(Required=false)]
                public string PlanName { get; set; }

                [NameInMap("Schedule")]
                [Validation(Required=false)]
                public string Schedule { get; set; }

                [NameInMap("VaultId")]
                [Validation(Required=false)]
                public string VaultId { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message. If the request was successful, &quot;successful&quot; is returned. If the request failed, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 99. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F029C1C7-26B6-5ADD-A73E-D85CCD7C73A9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
