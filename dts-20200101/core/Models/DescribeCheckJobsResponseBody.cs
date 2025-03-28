// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeCheckJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>Item information check.</para>
        /// </summary>
        [NameInMap("CheckJobs")]
        [Validation(Required=false)]
        public List<DescribeCheckJobsResponseBodyCheckJobs> CheckJobs { get; set; }
        public class DescribeCheckJobsResponseBodyCheckJobs : TeaModel {
            /// <summary>
            /// <para>Billing type, return values: - <b>POSTPAY</b>: Pay-as-you-go (postpaid). - <b>PREPAY</b>: Subscription (prepaid).</para>
            /// 
            /// <b>Example:</b>
            /// <para>POSTPAY</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>checkpoint</para>
            /// 
            /// <b>Example:</b>
            /// <para>1111****</para>
            /// </summary>
            [NameInMap("CheckPoint")]
            [Validation(Required=false)]
            public long? CheckPoint { get; set; }

            /// <summary>
            /// <para>Data validation method, with values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Full validation. - <b>2</b>: Incremental validation.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CheckType")]
            [Validation(Required=false)]
            public int? CheckType { get; set; }

            /// <summary>
            /// <para>Number of rows with data inconsistency</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DiffCount")]
            [Validation(Required=false)]
            public long? DiffCount { get; set; }

            /// <summary>
            /// <para>Synchronization initialization progress, in percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DiffSum")]
            [Validation(Required=false)]
            public long? DiffSum { get; set; }

            /// <summary>
            /// <para>Migration, synchronization, or subscription instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtsz8tc99sy2158b36</para>
            /// </summary>
            [NameInMap("DtsInstanceID")]
            [Validation(Required=false)]
            public string DtsInstanceID { get; set; }

            /// <summary>
            /// <para>Migration, synchronization, or subscription task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n08o6si4q338b1x</para>
            /// </summary>
            [NameInMap("DtsJobId")]
            [Validation(Required=false)]
            public string DtsJobId { get; set; }

            /// <summary>
            /// <para>The number of data rows in the table that have completed validation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15094</para>
            /// </summary>
            [NameInMap("FinishCount")]
            [Validation(Required=false)]
            public long? FinishCount { get; set; }

            /// <summary>
            /// <para>DTS task ID. In most cases, there is no need to set this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c3d12dii27t632g</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>Instance specification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SMALL</para>
            /// </summary>
            [NameInMap("InstanceClass")]
            [Validation(Required=false)]
            public string InstanceClass { get; set; }

            /// <summary>
            /// <para>Check the name of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstest</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>Task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>as0e1ks426bq3z0</para>
            /// </summary>
            [NameInMap("JobStepId")]
            [Validation(Required=false)]
            public string JobStepId { get; set; }

            /// <summary>
            /// <para>This parameter will be deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("ParentJobType")]
            [Validation(Required=false)]
            public string ParentJobType { get; set; }

            /// <summary>
            /// <para>Region ID to which it belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Check result, return values: -<b>0</b>: Check passed -<b>1</b>: Check failed</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Verify the total number of rows in the data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>159</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Dynamic error code, this parameter will be deprecated soon.</para>
        /// 
        /// <b>Example:</b>
        /// <para>403</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>Dynamic error message, used to replace the <b>%s</b> in the <b>errmessage</b> return parameter. If <b>errmessage</b> returns <b>thevalueofinputparameter%sisnotvalid</b>, and <b>dynamicmessage</b> returns <em>[1,2,3]</em>, it indicates that the request parameter <b>dtsjobid</b> is invalid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>present environment is not support,so skip.</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>Error code returned when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>Error message returned when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request processing has failed due to some unknown error.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>Status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of records that can be displayed on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public long? PageRecordCount { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC1D920B-AB89-52A9-AA5F-AA724C4205E8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
