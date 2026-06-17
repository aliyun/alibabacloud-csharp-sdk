// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutCustomMetricRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>状态码。</para>
        /// <remarks>
        /// <para>200表示成功。</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>返回信息。接口调用成功时，返回为空；接口调用失败时，返回失败原因。</para>
        /// 
        /// <b>Example:</b>
        /// <para>ComparisonOperator is mandatory for this action.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>请求ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>65D50468-ECEF-48F1-A6E1-D952E89D9432</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>操作是否成功。取值：</para>
        /// <list type="bullet">
        /// <item><description><para>true：成功。</para>
        /// </description></item>
        /// <item><description><para>false：失败。</para>
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
