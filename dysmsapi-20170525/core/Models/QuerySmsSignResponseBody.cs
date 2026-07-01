// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySmsSignResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the request.</para>
        /// <list type="bullet">
        /// <item><description><para><c>OK</c> indicates that the request was successful.</para>
        /// </description></item>
        /// <item><description><para>For other error codes, see <a href="https://help.aliyun.com/document_detail/101346.html">Error codes</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The date and time when the SMS signature was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-01-08 16:44:13</para>
        /// </summary>
        [NameInMap("CreateDate")]
        [Validation(Required=false)]
        public string CreateDate { get; set; }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The review reason.</para>
        /// <list type="bullet">
        /// <item><description><para>If the review status is <b>Approved</b> or <b>Pending Review</b>, this parameter is empty.</para>
        /// </description></item>
        /// <item><description><para>If the review status is <b>Rejected</b>, this parameter provides the reason for the rejection.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>文件不能证明信息真实性，请重新上传</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CC89A90C-978F-46AC-B80D-54738371E7CA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The SMS signature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云</para>
        /// </summary>
        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        /// <summary>
        /// <para>The review status of the SMS signature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Pending Review.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Approved.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Rejected. For details, see the <c>Reason</c> parameter.</para>
        /// </description></item>
        /// <item><description><para><b>10</b>: Canceled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SignStatus")]
        [Validation(Required=false)]
        public int? SignStatus { get; set; }

    }

}
