// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeDtsEtlJobVersionInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of ETL tasks.</para>
        /// </summary>
        [NameInMap("DtsEtlJobVersionInfos")]
        [Validation(Required=false)]
        public List<DescribeDtsEtlJobVersionInfoResponseBodyDtsEtlJobVersionInfos> DtsEtlJobVersionInfos { get; set; }
        public class DescribeDtsEtlJobVersionInfoResponseBodyDtsEtlJobVersionInfos : TeaModel {
            /// <summary>
            /// <para>The time when the ETL task was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1637229315000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the creator.</para>
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
            /// <para>The ID of the DTS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtsg******gd</para>
            /// </summary>
            [NameInMap("DtsInstanceId")]
            [Validation(Required=false)]
            public string DtsInstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the ETL task.</para>
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
            /// <para>The time when the ETL task was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1637230117000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The safe checkpoint of the ETL task.</para>
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
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>403</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic part in the error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>present environment is not support,so skip</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error code. This example indicates that the specified ETL task ID is invalid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidJobId</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message. This example indicates that the specified ETL task ID does not exist. In this case, the ETL task may have been deleted.</para>
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
        /// <para>The page number of the returned page. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>224DB9F7-3100-4899-AB9C-C938BCCB43E7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. If the call failed, false is returned.</para>
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
