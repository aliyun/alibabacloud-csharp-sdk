// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetBizMetricByNameRequest : TeaModel {
        /// <summary>
        /// <para>Query request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BizMetricByNameQuery")]
        [Validation(Required=false)]
        public GetBizMetricByNameRequestBizMetricByNameQuery BizMetricByNameQuery { get; set; }
        public class GetBizMetricByNameRequestBizMetricByNameQuery : TeaModel {
            /// <summary>
            /// <para>Specifies whether to query draft or published asset details. Set this parameter to True to query draft details, or False to query published details.</para>
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
        /// <para>Tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

    }

}
