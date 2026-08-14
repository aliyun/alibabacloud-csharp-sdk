// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeDtsEtlJobVersionInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The array of ETL task information objects.</para>
        /// </summary>
        [NameInMap("DtsEtlJobVersionInfos")]
        [Validation(Required=false)]
        public List<DescribeDtsEtlJobVersionInfoResponseBodyDtsEtlJobVersionInfos> DtsEtlJobVersionInfos { get; set; }
        public class DescribeDtsEtlJobVersionInfoResponseBodyDtsEtlJobVersionInfos : TeaModel {
            /// <summary>
            /// <para>The timestamp when the ETL task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1637229315000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The creator ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000000</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The username of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para><em><b>@</b></em>*.com</para>
            /// </summary>
            [NameInMap("CreatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// <para>The DTS instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtsg******gd</para>
            /// </summary>
            [NameInMap("DtsInstanceId")]
            [Validation(Required=false)]
            public string DtsInstanceId { get; set; }

            /// <summary>
            /// <para>The ETL task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>l5512es7w15****</para>
            /// </summary>
            [NameInMap("DtsJobId")]
            [Validation(Required=false)]
            public string DtsJobId { get; set; }

            /// <summary>
            /// <para>The name of the ETL task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_sql</para>
            /// </summary>
            [NameInMap("DtsJobName")]
            [Validation(Required=false)]
            public string DtsJobName { get; set; }

            /// <summary>
            /// <para>The modification timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1637230117000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The safe checkpoint, which indicates the current position of the ETL task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1637230117000</para>
            /// </summary>
            [NameInMap("SafeCheckpoint")]
            [Validation(Required=false)]
            public string SafeCheckpoint { get; set; }

            /// <summary>
            /// <para>The log level. Valid values: ERROR, WARN, INFO, and DEBUG.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INFO</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The version number of the ETL task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

        /// <summary>
        /// <para>The dynamic error code associated with this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>403</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message associated with this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>present environment is not support,so skip</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error code returned when the specified ETL task ID is invalid and the corresponding task cannot be found.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidJobId</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the specified ETL task ID is invalid and the corresponding task cannot be found. The task may have been deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified dts job id %s is not exists.</para>
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
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The page number of the instance status list. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>224DB9F7-3100-4899-AB9C-C938BCCB43E7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. A value of false indicates a failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
