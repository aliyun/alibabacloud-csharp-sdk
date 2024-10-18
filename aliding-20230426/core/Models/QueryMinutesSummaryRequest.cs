// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryMinutesSummaryRequest : TeaModel {
        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public QueryMinutesSummaryRequestTenantContext TenantContext { get; set; }
        public class QueryMinutesSummaryRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>607452e01401526ee39609e1</para>
        /// </summary>
        [NameInMap("conferenceId")]
        [Validation(Required=false)]
        public string ConferenceId { get; set; }

        [NameInMap("summaryTypeList")]
        [Validation(Required=false)]
        public List<string> SummaryTypeList { get; set; }

    }

}
