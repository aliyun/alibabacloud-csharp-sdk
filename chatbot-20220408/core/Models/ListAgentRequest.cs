// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListAgentRequest : TeaModel {
        /// <summary>
        /// <para>The name of the business space. Use this parameter to filter the results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>业务空间_001</para>
        /// </summary>
        [NameInMap("AgentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// <para>The commodity code. Filters the results to return only business spaces associated with a specific commodity code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>G_cloudBeeBot_public</para>
        /// </summary>
        [NameInMap("GoodsCodes")]
        [Validation(Required=false)]
        public string GoodsCodes { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
