// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetBizMetricByNameRequest : TeaModel {
        /// <summary>
        /// <para>The query request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BizMetricByNameQuery")]
        [Validation(Required=false)]
        public GetBizMetricByNameRequestBizMetricByNameQuery BizMetricByNameQuery { get; set; }
        public class GetBizMetricByNameRequestBizMetricByNameQuery : TeaModel {
            /// <summary>
            /// <para>Specifies whether to query the details of a draft or published asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>True: Draft.</description></item>
            /// <item><description>False: Published.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Draft")]
            [Validation(Required=false)]
            public bool? Draft { get; set; }

            /// <summary>
            /// <para>The name of the business metric.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Metric1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
