// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetCredentialReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The content of the user credential report.</para>
        /// <para>The report is Base64-encoded. After you decode the report, the credential report is in the CSV format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OVZWK4RMOVZW****</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The time when the user credential report was generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-19T15:06:52Z</para>
        /// </summary>
        [NameInMap("GeneratedTime")]
        [Validation(Required=false)]
        public string GeneratedTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the response is truncated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public string IsTruncated { get; set; }

        /// <summary>
        /// <para>The parameter that is used to obtain the truncated part. This parameter takes effect only when <c>IsTruncated</c> is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXAMPLE</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7A01826E-7601-44B0-B4DF-2B0C509836DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
