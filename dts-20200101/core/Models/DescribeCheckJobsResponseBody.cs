// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeCheckJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the data validation tasks.</para>
        /// </summary>
        [NameInMap("CheckJobs")]
        [Validation(Required=false)]
        public List<DescribeCheckJobsResponseBodyCheckJobs> CheckJobs { get; set; }
        public class DescribeCheckJobsResponseBodyCheckJobs : TeaModel {
            /// <summary>
            /// <para>The billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>POSTPAY</b>: pay-as-you-go.</description></item>
            /// <item><description><b>PREPAY</b>: subscription.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>POSTPAY</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The checkpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1111****</para>
            /// </summary>
            [NameInMap("CheckPoint")]
            [Validation(Required=false)]
            public long? CheckPoint { get; set; }

            /// <summary>
            /// <para>The data validation method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: full data validation.</description></item>
            /// <item><description><b>2</b>: incremental data validation.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CheckType")]
            [Validation(Required=false)]
            public int? CheckType { get; set; }

            /// <summary>
            /// <para>The number of rows with data inconsistency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DiffCount")]
            [Validation(Required=false)]
            public long? DiffCount { get; set; }

            /// <summary>
            /// <para>The progress of initial synchronization, in percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DiffSum")]
            [Validation(Required=false)]
            public long? DiffSum { get; set; }

            /// <summary>
            /// <para>The ID of the data migration, data synchronization, or change tracking instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtsz8tc99sy2158b36</para>
            /// </summary>
            [NameInMap("DtsInstanceID")]
            [Validation(Required=false)]
            public string DtsInstanceID { get; set; }

            /// <summary>
            /// <para>The ID of the data migration, data synchronization, or change tracking task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n08o6si4q338b1x</para>
            /// </summary>
            [NameInMap("DtsJobId")]
            [Validation(Required=false)]
            public string DtsJobId { get; set; }

            /// <summary>
            /// <para>The number of rows that have been validated in the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15094</para>
            /// </summary>
            [NameInMap("FinishCount")]
            [Validation(Required=false)]
            public long? FinishCount { get; set; }

            /// <summary>
            /// <para>The DTS task ID. &gt; In most cases, you do not need to specify this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c3d12dii27t632g</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The instance specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SMALL</para>
            /// </summary>
            [NameInMap("InstanceClass")]
            [Validation(Required=false)]
            public string InstanceClass { get; set; }

            /// <summary>
            /// <para>The name of the data validation task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstest</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
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
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The validation result. Valid values: - <b>0</b>: passed. - <b>1</b>: failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The total number of rows to be validated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>159</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The dynamic error code. This parameter will be deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>403</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message used to replace the <b>%s</b> variable in the <b>ErrMessage</b> parameter. &gt; If <b>ErrMessage</b> returns <b>The value of input parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>[1,2,3]</b>, the request parameter <b>DtsJobId</b> is invalid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>present environment is not support,so skip.</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error code returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request processing has failed due to some unknown error.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC1D920B-AB89-52A9-AA5F-AA724C4205E8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
