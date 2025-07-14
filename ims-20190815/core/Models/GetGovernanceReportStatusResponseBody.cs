// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetGovernanceReportStatusResponseBody : TeaModel {
        [NameInMap("GovernanceItemsStatus")]
        [Validation(Required=false)]
        public GetGovernanceReportStatusResponseBodyGovernanceItemsStatus GovernanceItemsStatus { get; set; }
        public class GetGovernanceReportStatusResponseBodyGovernanceItemsStatus : TeaModel {
            [NameInMap("GovernanceItemStatus")]
            [Validation(Required=false)]
            public List<GetGovernanceReportStatusResponseBodyGovernanceItemsStatusGovernanceItemStatus> GovernanceItemStatus { get; set; }
            public class GetGovernanceReportStatusResponseBodyGovernanceItemsStatusGovernanceItemStatus : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>AccountRecentUsingAccessKey</para>
                /// </summary>
                [NameInMap("GovernanceItem")]
                [Validation(Required=false)]
                public string GovernanceItem { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Progressing</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F2CE9688-AA85-5F23-8C22-0EC23473405A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Progressing</para>
        /// </summary>
        [NameInMap("WholeReportStatus")]
        [Validation(Required=false)]
        public string WholeReportStatus { get; set; }

    }

}
