// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class QueryVerifyDownloadTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Error code.</para>
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
        /// <para>Whether the download task is completed:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Completed</description></item>
        /// <item><description><b>false</b>: Not completed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Finish")]
        [Validation(Required=false)]
        public bool? Finish { get; set; }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A6229C0-E156-48E4-B6EC-0F528BDF60D2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Task status:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: File generation in progress</description></item>
        /// <item><description><b>2</b>: File generation completed</description></item>
        /// <item><description><b>3</b>: File generation failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>Download URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://xxx/xxx.csv">http://xxx/xxx.csv</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
