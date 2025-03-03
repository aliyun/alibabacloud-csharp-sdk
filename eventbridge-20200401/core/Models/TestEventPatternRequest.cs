// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class TestEventPatternRequest : TeaModel {
        /// <summary>
        /// <para>The event.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;datacontenttype&quot;: &quot;application/json;charset=utf-8&quot;,
        ///     &quot;aliyunaccountid&quot;: &quot;<em><b><b>&quot;,
        ///     &quot;aliyunpublishtime&quot;: &quot;2023-04-</b></b>:54:57.939Z&quot;,
        ///     &quot;data&quot;: {
        ///         &quot;resourceEventType&quot;: &quot;<b><b>&quot;,
        ///         &quot;resourceCreateTime&quot;: &quot;</b></b>&quot;,
        ///         &quot;resourceId&quot;: &quot;sls-code-***-debug&quot;,
        ///         &quot;captureTime&quot;: &quot;**</em>&quot;
        ///     },
        ///     &quot;aliyunoriginalaccountid&quot;: &quot;<b><b>&quot;,
        ///     &quot;specversion&quot;: &quot;1.0&quot;,
        ///     &quot;aliyuneventbusname&quot;: &quot;</b></b>&quot;,
        ///     &quot;id&quot;: &quot;295e6bd2-bb72-4f70-<em><em><b>-204a0680ee41&quot;,
        ///     &quot;source&quot;: &quot;acs.sls&quot;,
        ///     &quot;time&quot;: &quot;2023-04-</b></em>:37:56Z&quot;,
        ///     &quot;aliyunregionid&quot;: &quot;cn-</em>**&quot;,
        ///     &quot;type&quot;: &quot;sls:Config:****&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Event")]
        [Validation(Required=false)]
        public string Event { get; set; }

        /// <summary>
        /// <para>The event pattern.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key1&quot;: &quot;value1&quot;}</para>
        /// </summary>
        [NameInMap("EventPattern")]
        [Validation(Required=false)]
        public string EventPattern { get; set; }

    }

}
