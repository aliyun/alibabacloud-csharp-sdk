// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeDataCheckTableDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of tables that contain inconsistent data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DiffTableCount")]
        [Validation(Required=false)]
        public long? DiffTableCount { get; set; }

        /// <summary>
        /// <para>The dynamic error code. This parameter will be discontinued in the future.</para>
        /// 
        /// <b>Example:</b>
        /// <para>403</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic part in the error message. This parameter is used to replace the \<em>\</em>%s\<em>\</em> variable in the <b>ErrMessage</b> parameter.</para>
        /// <remarks>
        /// <para>For example, if the returned value of the <b>ErrMessage</b> parameter is <b>The Value of Input Parameter %s is not valid</b> and the return value of the <b>DynamicMessage</b> parameter is <b>Type</b>, the specified <b>Type</b> parameter is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Type</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Value of Input Parameter %s is not valid.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The total number of data rows that were failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FailedTableCount")]
        [Validation(Required=false)]
        public long? FailedTableCount { get; set; }

        /// <summary>
        /// <para>The total number of data rows that were verified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("FinishedCount")]
        [Validation(Required=false)]
        public long? FinishedCount { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>621BB4F8-3016-4FAA-8D5A-5D3163CC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The details of data verification results.</para>
        /// </summary>
        [NameInMap("TableDetails")]
        [Validation(Required=false)]
        public List<DescribeDataCheckTableDetailsResponseBodyTableDetails> TableDetails { get; set; }
        public class DescribeDataCheckTableDetailsResponseBodyTableDetails : TeaModel {
            /// <summary>
            /// <para>The time when data verification was performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-18 11:26:59</para>
            /// </summary>
            [NameInMap("BootTime")]
            [Validation(Required=false)]
            public string BootTime { get; set; }

            /// <summary>
            /// <para>The number of data rows that contain inconsistent data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DiffCount")]
            [Validation(Required=false)]
            public long? DiffCount { get; set; }

            /// <summary>
            /// <para>The error code returned if the data verification task failed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: The number of tables that do not contain primary keys exceeds the limit.</description></item>
            /// <item><description><b>2</b>: The number of data rows that contain inconsistent data exceeds 300.</description></item>
            /// <item><description><b>3</b>: One or more tables to be verified do not exist.</description></item>
            /// <item><description><b>4</b>: The SQL statements used for verifying data contain a syntax error.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public int? ErrorCode { get; set; }

            /// <summary>
            /// <para>The number of data rows that were verified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("FinishCount")]
            [Validation(Required=false)]
            public long? FinishCount { get; set; }

            /// <summary>
            /// <para>The auto-increment primary key that is used to identify the data in a verification result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>167401241974****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the source database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testdb</para>
            /// </summary>
            [NameInMap("SourceDbName")]
            [Validation(Required=false)]
            public string SourceDbName { get; set; }

            /// <summary>
            /// <para>The name of the source table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>student</para>
            /// </summary>
            [NameInMap("SourceTbName")]
            [Validation(Required=false)]
            public string SourceTbName { get; set; }

            /// <summary>
            /// <para>The status of data verification results. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The data verification task was complete.</description></item>
            /// <item><description><b>2</b>: The data verification task was being initialized.</description></item>
            /// <item><description><b>3</b>: The data verification task was in progress.</description></item>
            /// <item><description><b>5</b>: The data verification task failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The name of the destination database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testdb</para>
            /// </summary>
            [NameInMap("TargetDbName")]
            [Validation(Required=false)]
            public string TargetDbName { get; set; }

            /// <summary>
            /// <para>The name of the destination table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>person</para>
            /// </summary>
            [NameInMap("TargetTbName")]
            [Validation(Required=false)]
            public string TargetTbName { get; set; }

            /// <summary>
            /// <para>The total number of data rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The total number of tables on which data verification was performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
