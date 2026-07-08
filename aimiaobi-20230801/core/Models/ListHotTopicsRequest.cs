// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListHotTopicsRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the business space.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx_p_efm</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The end of the creation time filter range (inclusive). The value must be in the <c>yyyy-MM-dd HH:mm:ss</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-06-04 23:59:59</para>
        /// </summary>
        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public string CreateTimeEnd { get; set; }

        /// <summary>
        /// <para>The start of the creation time filter range (inclusive). The value must be in the <c>yyyy-MM-dd HH:mm:ss</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-06-01 00:00:00</para>
        /// </summary>
        [NameInMap("CreateTimeStart")]
        [Validation(Required=false)]
        public string CreateTimeStart { get; set; }

        /// <summary>
        /// <para>Filters the results by a custom business field. The service performs an exact keyword match on this field. The value can be up to 255 characters long.</para>
        /// 
        /// <b>Example:</b>
        /// <para>biz-tag-001</para>
        /// </summary>
        [NameInMap("CustomField")]
        [Validation(Required=false)]
        public string CustomField { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return for a single request. If this parameter is not specified, the service uses a default value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to retrieve the next page of results. If you do not specify this parameter, the service returns the first page of results. You can get this token from the <c>NextToken</c> response parameter of the previous request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>下一页的token</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>A list of topic IDs.</para>
        /// </summary>
        [NameInMap("TopicIds")]
        [Validation(Required=false)]
        public List<string> TopicIds { get; set; }

        /// <summary>
        /// <para>The keywords for a full-text search on hot topics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>根据热榜主题全文检索</para>
        /// </summary>
        [NameInMap("TopicQuery")]
        [Validation(Required=false)]
        public string TopicQuery { get; set; }

        /// <summary>
        /// <para>Filters the results by hot topic source. For a list of supported hot topic sources, call the <c>ListHotSources</c> operation.</para>
        /// <para><c>Aggregation</c>: represents the aggregated list of national hot topics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Quark</para>
        /// </summary>
        [NameInMap("TopicSource")]
        [Validation(Required=false)]
        public string TopicSource { get; set; }

        /// <summary>
        /// <para>Filters the results by data version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>数据版本筛选</para>
        /// </summary>
        [NameInMap("TopicVersion")]
        [Validation(Required=false)]
        public string TopicVersion { get; set; }

        /// <summary>
        /// <para>Filters the results by hot topic.</para>
        /// </summary>
        [NameInMap("Topics")]
        [Validation(Required=false)]
        public List<string> Topics { get; set; }

        /// <summary>
        /// <para>Specifies whether to include news in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("WithNews")]
        [Validation(Required=false)]
        public bool? WithNews { get; set; }

    }

}
