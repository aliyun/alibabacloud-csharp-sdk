// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListQueryViewsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of results to return per request when using the NextToken-based pagination. Valid values: 1 to 100. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next query. You do not need to specify this parameter for the first query or if no more results exist. If more results exist, set this parameter to the NextToken value returned by the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAASLVeIxed4466E0LVmGkzwS6hJKd9DGVGMDRM6Lu****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of query views.</para>
        /// </summary>
        [NameInMap("QueryViews")]
        [Validation(Required=false)]
        public List<ListQueryViewsResponseBodyQueryViews> QueryViews { get; set; }
        public class ListQueryViewsResponseBodyQueryViews : TeaModel {
            /// <summary>
            /// <para>The custom query condition of the view.</para>
            /// 
            /// <b>Example:</b>
            /// <para>preset</para>
            /// </summary>
            [NameInMap("QueryViewCondition")]
            [Validation(Required=false)]
            public string QueryViewCondition { get; set; }

            /// <summary>
            /// <para>The alert filter statement of the view.</para>
            /// 
            /// <b>Example:</b>
            /// <para>module_code: alibaba_cloud_sas_custom_rule</para>
            /// </summary>
            [NameInMap("QueryViewCriteria")]
            [Validation(Required=false)]
            public string QueryViewCriteria { get; set; }

            /// <summary>
            /// <para>The list of displayed fields.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;alert_name_cn&quot;,&quot;alert_type_cn&quot;,&quot;entity_list&quot;,&quot;alert_level&quot;,&quot;alert_status&quot;,&quot;start_time&quot;,&quot;end_time&quot;]</para>
            /// </summary>
            [NameInMap("QueryViewFields")]
            [Validation(Required=false)]
            public string QueryViewFields { get; set; }

            /// <summary>
            /// <para>The unique identifier of the query view.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qv-a1b2c3d4e5f6g7h8****</para>
            /// </summary>
            [NameInMap("QueryViewId")]
            [Validation(Required=false)]
            public string QueryViewId { get; set; }

            /// <summary>
            /// <para>The view name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alert</para>
            /// </summary>
            [NameInMap("QueryViewName")]
            [Validation(Required=false)]
            public string QueryViewName { get; set; }

            /// <summary>
            /// <para>The display order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("QueryViewOrder")]
            [Validation(Required=false)]
            public string QueryViewOrder { get; set; }

            /// <summary>
            /// <para>The scene to which the view belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alert</para>
            /// </summary>
            [NameInMap("QueryViewScene")]
            [Validation(Required=false)]
            public string QueryViewScene { get; set; }

            /// <summary>
            /// <para>The view status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("QueryViewStatus")]
            [Validation(Required=false)]
            public string QueryViewStatus { get; set; }

            /// <summary>
            /// <para>The view type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>preset</para>
            /// </summary>
            [NameInMap("QueryViewType")]
            [Validation(Required=false)]
            public string QueryViewType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
