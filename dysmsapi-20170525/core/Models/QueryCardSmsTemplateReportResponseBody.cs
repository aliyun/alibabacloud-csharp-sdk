// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QueryCardSmsTemplateReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The request status code.</para>
        /// <list type="bullet">
        /// <item><description><para>The value OK indicates that the request was successful.</para>
        /// </description></item>
        /// <item><description><para>For information about other error codes, see <a href="https://help.aliyun.com/document_detail/101346.html">Error codes</a>.</para>
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
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCardSmsTemplateReportResponseBodyData Data { get; set; }
        public class QueryCardSmsTemplateReportResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of returned data.</para>
            /// </summary>
            [NameInMap("model")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Model { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B71F06CA-7735-183A-B52E-234EF8AFE14B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The call was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The call failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
