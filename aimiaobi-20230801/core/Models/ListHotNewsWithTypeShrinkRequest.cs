// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListHotNewsWithTypeShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the business space: <a href="https://help.aliyun.com/document_detail/3027170.html">AgentKey</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c160c841c8e54295bf2f441432785944_p_efm</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        /// <summary>
        /// <para>The news category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>society: social current affairs.</description></item>
        /// <item><description>person: people news.</description></item>
        /// <item><description>government: government affairs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>society</para>
        /// </summary>
        [NameInMap("NewsType")]
        [Validation(Required=false)]
        public string NewsType { get; set; }

        /// <summary>
        /// <para>The list of news categories for multi-selection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>society: social current affairs.</description></item>
        /// <item><description>person: people news.</description></item>
        /// <item><description>government: government affairs.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("NewsTypes")]
        [Validation(Required=false)]
        public string NewsTypesShrink { get; set; }

        /// <summary>
        /// <para>The number of records per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
