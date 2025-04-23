// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeOrgByLayerResponseBody : TeaModel {
        [NameInMap("Orgs")]
        [Validation(Required=false)]
        public List<DescribeOrgByLayerResponseBodyOrgs> Orgs { get; set; }
        public class DescribeOrgByLayerResponseBodyOrgs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>org-1mox****</para>
            /// </summary>
            [NameInMap("OrgId")]
            [Validation(Required=false)]
            public string OrgId { get; set; }

            [NameInMap("OrgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>org-ezqr****</para>
            /// </summary>
            [NameInMap("ParentOrgId")]
            [Validation(Required=false)]
            public string ParentOrgId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
