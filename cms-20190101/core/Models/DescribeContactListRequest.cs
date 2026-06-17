// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeContactListRequest : TeaModel {
        /// <summary>
        /// <para>The alert notification method. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;- SMS: text message.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;- AliIM: TradeManager.</para>
        /// <list type="bullet">
        /// <item><description><para>Mail: email.</para>
        /// </description></item>
        /// <item><description><para>DingWebHook: DingTalk chatbot.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Mail</para>
        /// </summary>
        [NameInMap("ChanelType")]
        [Validation(Required=false)]
        public string ChanelType { get; set; }

        /// <summary>
        /// <para>The value of the alert notification method.</para>
        /// <remarks>
        /// <para>This parameter is required only when <c>ChanelType</c> is set to <c>Mail</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:Alice@example.com">Alice@example.com</a></para>
        /// </summary>
        [NameInMap("ChanelValue")]
        [Validation(Required=false)]
        public string ChanelValue { get; set; }

        /// <summary>
        /// <para>The name of the alert contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alice</para>
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
