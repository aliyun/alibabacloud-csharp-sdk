// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListScanBaselineByTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The API call is successful.</description></item>
        /// <item><description><c>false</c>: The API call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>5259118F-79E2-57E9-9AEA-551586F4FAED</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The baseline list.</para>
        /// </summary>
        [NameInMap("ScanBaselines")]
        [Validation(Required=false)]
        public List<ListScanBaselineByTaskResponseBodyScanBaselines> ScanBaselines { get; set; }
        public class ListScanBaselineByTaskResponseBodyScanBaselines : TeaModel {
            /// <summary>
            /// <para>The baseline check category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Service Configuration</para>
            /// </summary>
            [NameInMap("BaselineClassAlias")]
            [Validation(Required=false)]
            public string BaselineClassAlias { get; set; }

            /// <summary>
            /// <para>The baseline check remediation suggestion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Obfuscate and encrypt the AccessKey to prevent exploitation</para>
            /// </summary>
            [NameInMap("BaselineDetailAdvice")]
            [Validation(Required=false)]
            public string BaselineDetailAdvice { get; set; }

            /// <summary>
            /// <para>The baseline description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Access Key stored in plaintext</para>
            /// </summary>
            [NameInMap("BaselineDetailDescription")]
            [Validation(Required=false)]
            public string BaselineDetailDescription { get; set; }

            /// <summary>
            /// <para>The baseline check path and content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>usr/local/www/project/environments/dev/common/config/paramsxxx</para>
            /// </summary>
            [NameInMap("BaselineDetailPrompt")]
            [Validation(Required=false)]
            public string BaselineDetailPrompt { get; set; }

            /// <summary>
            /// <para>The number of baseline check items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BaselineItemCount")]
            [Validation(Required=false)]
            public int? BaselineItemCount { get; set; }

            /// <summary>
            /// <para>The baseline check name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Service Configuration</para>
            /// </summary>
            [NameInMap("BaselineNameAlias")]
            [Validation(Required=false)]
            public string BaselineNameAlias { get; set; }

            /// <summary>
            /// <para>The baseline name key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ak_leak</para>
            /// </summary>
            [NameInMap("BaselineNameKey")]
            [Validation(Required=false)]
            public string BaselineNameKey { get; set; }

            /// <summary>
            /// <para>The baseline check risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("BaselineNameLevel")]
            [Validation(Required=false)]
            public string BaselineNameLevel { get; set; }

            /// <summary>
            /// <para>The creation time, in UNIX timestamp format. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1695090008000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The time of the first scan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-10 15:33:26</para>
            /// </summary>
            [NameInMap("FirstScanTime")]
            [Validation(Required=false)]
            public long? FirstScanTime { get; set; }

            /// <summary>
            /// <para>The number of high-risk items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HighRiskItemCount")]
            [Validation(Required=false)]
            public int? HighRiskItemCount { get; set; }

            /// <summary>
            /// <para>The number of low-risk items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LowRiskItemCount")]
            [Validation(Required=false)]
            public int? LowRiskItemCount { get; set; }

            /// <summary>
            /// <para>The number of medium-risk items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MiddleRiskItemCount")]
            [Validation(Required=false)]
            public int? MiddleRiskItemCount { get; set; }

            /// <summary>
            /// <para>The image scan task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2328fcaa-f28a-405d-a357-asdvfrew23</para>
            /// </summary>
            [NameInMap("ScanTaskId")]
            [Validation(Required=false)]
            public string ScanTaskId { get; set; }

            /// <summary>
            /// <para>The update time, in UNIX timestamp format. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1684220824226</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
