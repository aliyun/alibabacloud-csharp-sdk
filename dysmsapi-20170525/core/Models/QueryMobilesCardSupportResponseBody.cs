// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QueryMobilesCardSupportResponseBody : TeaModel {
        /// <summary>
        /// <para>请求状态码。</para>
        /// <list type="bullet">
        /// <item><description>返回OK代表请求成功。</description></item>
        /// <item><description>其他错误码，请参见<a href="https://help.aliyun.com/document_detail/101346.html">错误码列表</a>。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>返回数据。</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryMobilesCardSupportResponseBodyData Data { get; set; }
        public class QueryMobilesCardSupportResponseBodyData : TeaModel {
            /// <summary>
            /// <para>查询值。</para>
            /// </summary>
            [NameInMap("QueryResult")]
            [Validation(Required=false)]
            public List<QueryMobilesCardSupportResponseBodyDataQueryResult> QueryResult { get; set; }
            public class QueryMobilesCardSupportResponseBodyDataQueryResult : TeaModel {
                /// <summary>
                /// <para>查询的手机号码。</para>
                /// 
                /// <b>Example:</b>
                /// <para>1380000****</para>
                /// </summary>
                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                /// <summary>
                /// <para>是否支持卡片短信。取值：</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>：支持。</description></item>
                /// <item><description><b>false</b>：不支持。</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Support")]
                [Validation(Required=false)]
                public bool? Support { get; set; }

            }

        }

        /// <summary>
        /// <para>阿里云为该请求生成的唯一标识符。</para>
        /// 
        /// <b>Example:</b>
        /// <para>08C17DFE-2E10-54F4-BAFB-7180039CC217</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>调用接口是否成功。取值：</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>：调用成功。</para>
        /// </description></item>
        /// <item><description><para><b>false</b>：调用失败。</para>
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
