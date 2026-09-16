// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeInfoCheckExportRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 200 indicates success. Other values indicate failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The result list.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeInfoCheckExportRecordResponseBodyItems> Items { get; set; }
        public class DescribeInfoCheckExportRecordResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The download time. The value is a UNIX timestamp in milliseconds (ms), for example, 1758250979000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1758250979000</para>
            /// </summary>
            [NameInMap("DownloadDate")]
            [Validation(Required=false)]
            public string DownloadDate { get; set; }

            /// <summary>
            /// <para>The ID of the download task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>202510189017278</para>
            /// </summary>
            [NameInMap("DownloadTaskId")]
            [Validation(Required=false)]
            public string DownloadTaskId { get; set; }

            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>手机号二要素统计202509013975081.csv</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The file type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CSV</para>
            /// </summary>
            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// <para>The product type name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ID_CARD_2_META</b>: ID card two-element verification.</description></item>
            /// <item><description><b>ID_PERIOD</b>: ID card validity period verification.</description></item>
            /// <item><description><b>MOBILE_ONLINE_LENGTH</b>: Mobile number online duration.</description></item>
            /// <item><description><b>MOBILE_ONLINE_STATUS</b>: Mobile number online status.</description></item>
            /// <item><description><b>MOBILE_3_META_SIMPLE</b>: Mobile number three-element verification (simple edition).</description></item>
            /// <item><description><b>MOBILE_3_META</b>: Mobile number three-element verification (detailed edition).</description></item>
            /// <item><description><b>MOBILE_2_META</b>: Mobile number two-element verification.</description></item>
            /// <item><description><b>BANK_CARD_N_META</b>: Bank card verification (detailed edition).</description></item>
            /// <item><description><b>MOBILE_DETECT</b>: Number detection.</description></item>
            /// <item><description><b>VEHICLE_N_META</b>: Vehicle element verification (enhanced edition).</description></item>
            /// <item><description><b>VEHICLE_PENTA_INFO</b>: Vehicle five-element information recognition.</description></item>
            /// <item><description><b>VEHICLE_LICENSE_INFO</b>: Vehicle information recognition.</description></item>
            /// <item><description><b>VEHICLE_INSURE_DATE</b>: Vehicle insurance date query.</description></item>
            /// <item><description><b>VEHICLE_CHECK</b>: Vehicle element verification.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ID_CARD_2_META</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: File is being generated.</description></item>
            /// <item><description><b>2</b>: File generation is complete.</description></item>
            /// <item><description><b>3</b>: File generation failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The task URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://cn-shanghai-aliyun-cloudauth.oss-cn-shanghai.aliyuncs.com/console/xxxxxxxx.xlsx">https://cn-shanghai-aliyun-cloudauth.oss-cn-shanghai.aliyuncs.com/console/xxxxxxxx.xlsx</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the response is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
