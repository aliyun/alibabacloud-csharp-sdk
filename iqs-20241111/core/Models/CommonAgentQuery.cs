// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class CommonAgentQuery : TeaModel {
        /// <summary>
        /// <para>The maximum number of place results to return. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The natural language question used to retrieve nearby places.</para>
        /// 
        /// <b>Example:</b>
        /// <para>High-end hotels within 5 km of Lingyin Temple in Hangzhou</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The search scenario code. Valid values: hotels (hotel), attractions (attraction), restaurants (restaurant), and entertainment (leisure and entertainment). If you do not specify this parameter, the model identifies the scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hotels</para>
        /// </summary>
        [NameInMap("querySceneEnumCode")]
        [Validation(Required=false)]
        public string QuerySceneEnumCode { get; set; }

        /// <summary>
        /// <para>The search result mode. Valid values: single (returns simplified fields) and normal (returns all fields). Default value: normal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("searchModel")]
        [Validation(Required=false)]
        public string SearchModel { get; set; }

    }

}
