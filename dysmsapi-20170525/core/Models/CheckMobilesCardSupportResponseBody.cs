// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class CheckMobilesCardSupportResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description>The value OK indicates that the request was successful.</description></item>
        /// <item><description>Other values indicate that the request failed. For more information, see <a href="https://help.aliyun.com/document_detail/101346.html">Error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CheckMobilesCardSupportResponseBodyData Data { get; set; }
        public class CheckMobilesCardSupportResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of returned results.</para>
            /// </summary>
            [NameInMap("queryResult")]
            [Validation(Required=false)]
            public List<CheckMobilesCardSupportResponseBodyDataQueryResult> QueryResult { get; set; }
            public class CheckMobilesCardSupportResponseBodyDataQueryResult : TeaModel {
                /// <summary>
                /// <para>The mobile phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1390000****</para>
                /// </summary>
                [NameInMap("mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                /// <summary>
                /// <para>Indicates whether the mobile phone number supports card messages.</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("support")]
                [Validation(Required=false)]
                public bool? Support { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>819BE656-D2E0-4858-8B21-B2E477085AAF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
