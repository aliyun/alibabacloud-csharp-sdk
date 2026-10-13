// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListAgentRequest : TeaModel {
        /// <summary>
        /// <para>The business space name. You can use this parameter to search by name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BusinessSpace_001</para>
        /// </summary>
        [NameInMap("AgentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// <para>The commodity code. You can use this parameter to filter by commodity code and query instance information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>G_cloudBeeBot_public</para>
        /// </summary>
        [NameInMap("GoodsCodes")]
        [Validation(Required=false)]
        public string GoodsCodes { get; set; }

        /// <summary>
        /// <para>The current page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page in the response. Maximum value: 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
