// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Support_plan20210706.Models
{
    public class ListProductByGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>data</para>
        /// 
        /// <b>Example:</b>
        /// <para>[     {       &quot;wfNodeId&quot;: &quot;dealingNode&quot;,//任务单状态       &quot;createEmpId&quot;: null,//创建人工号，可以忽略       &quot;createTime&quot;: 1637571435000,//任务单创建时间       &quot;orderId&quot;: &quot;E2111221H1UKCZ&quot;,//任务单号       &quot;isImportant&quot;: &quot;normal&quot;,//是否紧急       &quot;closeTime&quot;: null,//任务单关单时间       &quot;taskTitle&quot;: &quot;测试单16点44&quot;,//标题       &quot;productType&quot;: &quot;3270&quot;//问题分类     },     {       &quot;wfNodeId&quot;: &quot;dealingNode&quot;,       &quot;createEmpId&quot;: null,       &quot;createTime&quot;: 1637820497000,       &quot;orderId&quot;: &quot;E211125CG111EM&quot;,       &quot;isImportant&quot;: &quot;normal&quot;,       &quot;closeTime&quot;: null,       &quot;taskTitle&quot;: &quot;测试单14&quot;,       &quot;class&quot;: &quot;com.aliyun.dingtalklanding.dto.OpenTaskOrderDTO&quot;,       &quot;productType&quot;: &quot;3270&quot;     }   ]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>msg</para>
        /// 
        /// <b>Example:</b>
        /// <para>请求成功</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>success</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
