// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApiExportsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of API security export tasks.</para>
        /// </summary>
        [NameInMap("ApiExports")]
        [Validation(Required=false)]
        public List<DescribeApiExportsResponseBodyApiExports> ApiExports { get; set; }
        public class DescribeApiExportsResponseBodyApiExports : TeaModel {
            /// <summary>
            /// <para>The time when the export task was created. This is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1725604852</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The name of the exported file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>file_16109541456445334c0f01d9a7444e0e908***.csv</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The download URL of the exported file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://waf-api-sec-cn.***.aliyuncs.com/file_1610954145***.csv">https://waf-api-sec-cn.***.aliyuncs.com/file_1610954145***.csv</a></para>
            /// </summary>
            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

            /// <summary>
            /// <para>The format of the exported file, such as CSV.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CSV</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>The status of the export task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>expired</b>: The file has expired.</para>
            /// </description></item>
            /// <item><description><para><b>exporting</b>: The file is being exported.</para>
            /// </description></item>
            /// <item><description><para><b>completed</b>: The export is successful.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>completed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the export task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>apisec_api</b>: API asset task.</para>
            /// </description></item>
            /// <item><description><para><b>apisec_abnormal</b>: API threat task.</para>
            /// </description></item>
            /// <item><description><para><b>apisec_event</b>: API security event task.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>apisec_api</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9532525-E885-54E7-A178-D5554D563AFB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of export tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
