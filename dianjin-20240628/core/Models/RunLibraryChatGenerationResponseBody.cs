// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class RunLibraryChatGenerationResponseBody : TeaModel {
        /// <summary>
        /// <para>The time consumed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        /// <summary>
        /// <para>The response data (non-streaming).</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;finish&quot;:true,
        ///     &quot;text&quot;:&quot;是的，记名预付卡的有效期不得低于3年。&quot;,
        ///     &quot;message&quot;: &quot;是的，记名预付卡的有效期不得低于3年。&quot;,
        ///     &quot;queryResult&quot;:{
        ///       &quot;errCode&quot;: &quot;0&quot;,	//接口协议层面的错误码，正常为0，未授权，参数错误，服务器异常时会发生变化，可以忽略不处理
        ///       &quot;message&quot;: &quot;ok&quot;,	//接口协议层面的消息
        ///       &quot;data&quot;:{
        ///         &quot;success&quot;: true,	//有回答true 无回答false
        ///         &quot;answer&quot;: null,	//大模型生成的回答结果
        ///         &quot;embeddingElapsedMs&quot;: 127,
        ///         &quot;vectorSearchElapsedMs&quot;: 2745,
        ///         &quot;llmElapsedMs&quot;: 7911,
        ///         &quot;totalElapsedMs&quot;: 10820,
        ///         &quot;chunks&quot;: [	//召回的分块信息，一般为top5或top10，可联系我们调整效果
        ///           {
        ///             &quot;chunkId&quot;: &quot;470182177892469799&quot;,	//分块信息的编号
        ///             &quot;docId&quot;: &quot;22666332&quot;,	//分块关联的文档编号
        ///             &quot;chunkText&quot;: &quot;Profits plummeted in the first quarter, can\&quot;t you bear it? In fact, previous rounds of price cuts have indeed had a certain impact on Tesla\&quot;s financial data. Tesla has just released its financial report for the first quarter of this year. The data shows that in Q1 2023, Tesla achieved revenue of 23.33 billion US dollars, an increase of 24% over the previous year; Tesla delivered more than 422,000 electric vehicles worldwide in the first quarter, an increase of 36% over the previous year&quot;,	//新闻原始内容
        ///             &quot;chunkMeta&quot;: {	// demo数据中的其他metadata
        ///               &quot;language&quot;: &quot;en&quot;,
        ///               &quot;unique_id&quot;: &quot;news_22666332_13&quot;,
        ///               &quot;content_type&quot;: &quot;news&quot;,
        ///               &quot;stock_id_list&quot;: []
        ///             }
        ///           }],
        ///         &quot;documents&quot;: [{
        ///           &quot;docId&quot;: &quot;1686637056086872065&quot;,	//文档编号
        ///           &quot;gmtCreate&quot;: &quot;2023-08-02 15:16:25&quot;,	//文档的创建时间
        ///           &quot;libraryId&quot;: &quot;a1b2c3&quot;,	//文档关联的知识库编号
        ///           &quot;title&quot;: &quot;2023年工银信用卡微信、京东绑卡消费累计积分活动&quot;,	//文档标题
        ///           &quot;url&quot;: null	//文档连接，如有
        ///         }]	//块文本关联的文档
        ///       },
        ///       &quot;success&quot;: true	//接口协议层面的成功/失败状态 true就是errCode为0
        ///     }
        ///   }</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// <para>The data type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5E3FBAF1-17AF-53B7-AF0A-CDCEEB6DE658</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-04-24 11:54:34</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
