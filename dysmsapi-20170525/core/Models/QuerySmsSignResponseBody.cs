// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySmsSignResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description>If OK is returned, the request is successful.</description></item>
        /// <item><description>Other values indicate that the request fails. For more information, see <a href="https://help.aliyun.com/document_detail/101346.html">Error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The date and time when the signature was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-01-08 16:44:13</para>
        /// </summary>
        [NameInMap("CreateDate")]
        [Validation(Required=false)]
        public string CreateDate { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The remarks of the review. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the signature is in the <b>Approved</b> or <b>Pending Approval</b> state, No Remarks is returned.</description></item>
        /// <item><description>If the signature is in the <b>Not Approved</b> state, the reason why the signature is rejected is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>The document cannot verify the authenticity of the information. Please upload it again.</para>
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
        /// <para>The signature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun</para>
        /// </summary>
        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        /// <summary>
        /// <para>The status of the signature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The signature is pending approval.</description></item>
        /// <item><description><b>1</b>: The signature is approved.</description></item>
        /// <item><description><b>2</b>: The signature is rejected. The Reason parameter indicates the reason why the signature is rejected.</description></item>
        /// <item><description><b>10</b>: The signature is cancelled.</description></item>
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
