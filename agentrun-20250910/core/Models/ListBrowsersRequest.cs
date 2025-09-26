// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ListBrowsersRequest : TeaModel {
        /// <summary>
        /// <para>根据浏览器实例名称进行模糊匹配过滤</para>
        /// 
        /// <b>Example:</b>
        /// <para>browser</para>
        /// </summary>
        [NameInMap("browserName")]
        [Validation(Required=false)]
        public string BrowserName { get; set; }

        /// <summary>
        /// <para>当前页码，从1开始计数</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>每页返回的记录数量</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>根据浏览器实例的运行状态进行过滤，可选值：CREATING、READY、DELETING等</para>
        /// 
        /// <b>Example:</b>
        /// <para>CREATING</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
