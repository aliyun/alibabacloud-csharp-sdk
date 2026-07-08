// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class QueryUsageStatisticsByTagIdResponseBody : TeaModel {
        /// <summary>
        /// <para>请求状态码。 <b>OK</b>为成功。</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>返回的数据内容。</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryUsageStatisticsByTagIdResponseBodyData> Data { get; set; }
        public class QueryUsageStatisticsByTagIdResponseBodyData : TeaModel {
            /// <summary>
            /// <para>授权码。</para>
            /// 
            /// <b>Example:</b>
            /// <para>g61I8UV5zd</para>
            /// </summary>
            [NameInMap("AuthorizationCode")]
            [Validation(Required=false)]
            public string AuthorizationCode { get; set; }

            /// <summary>
            /// <para>查询失败号码数。</para>
            /// 
            /// <b>Example:</b>
            /// <para>71</para>
            /// </summary>
            [NameInMap("FailTotal")]
            [Validation(Required=false)]
            public long? FailTotal { get; set; }

            /// <summary>
            /// <para>创建时间。</para>
            /// 
            /// <b>Example:</b>
            /// <para>20230312</para>
            /// </summary>
            [NameInMap("GmtDateStr")]
            [Validation(Required=false)]
            public string GmtDateStr { get; set; }

            /// <summary>
            /// <para>授权码使用记录ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>4d32c9ef-c8b0-4d69-a437-cca5****185d</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>行业名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>家政安保</para>
            /// </summary>
            [NameInMap("IndustryName")]
            [Validation(Required=false)]
            public string IndustryName { get; set; }

            /// <summary>
            /// <para>客户pid。</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000013****071</para>
            /// </summary>
            [NameInMap("PartnerId")]
            [Validation(Required=false)]
            public long? PartnerId { get; set; }

            /// <summary>
            /// <para>场景名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>电话回访1</para>
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// <para>查询成功号码数。</para>
            /// 
            /// <b>Example:</b>
            /// <para>93</para>
            /// </summary>
            [NameInMap("SuccessTotal")]
            [Validation(Required=false)]
            public long? SuccessTotal { get; set; }

            /// <summary>
            /// <para>标签名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>69</para>
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public long? TagId { get; set; }

            /// <summary>
            /// <para>标签名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>阿里云查询</para>
            /// </summary>
            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

            /// <summary>
            /// <para>查询总号码数。</para>
            /// 
            /// <b>Example:</b>
            /// <para>41</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>返回状态码描述。</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>请求ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>D45CC751-34DF-5797-81FB-9A2ED6DC024B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>表示是否调用成功。</para>
        /// <list type="bullet">
        /// <item><description>true：调用成功。             </description></item>
        /// <item><description>false：调用失败。</description></item>
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
