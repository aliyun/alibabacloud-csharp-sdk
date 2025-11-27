// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeOrgByLayerResponseBody : TeaModel {
        /// <summary>
        /// <para>The organizations.</para>
        /// </summary>
        [NameInMap("Orgs")]
        [Validation(Required=false)]
        public List<DescribeOrgByLayerResponseBodyOrgs> Orgs { get; set; }
        public class DescribeOrgByLayerResponseBodyOrgs : TeaModel {
            /// <summary>
            /// <para>The ID of the organization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>org-1mox****</para>
            /// </summary>
            [NameInMap("OrgId")]
            [Validation(Required=false)]
            public string OrgId { get; set; }

            /// <summary>
            /// <para>The name of the organization.</para>
            /// </summary>
            [NameInMap("OrgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            /// <summary>
            /// <para>The ID of the parent organization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>org-ezqr****</para>
            /// </summary>
            [NameInMap("ParentOrgId")]
            [Validation(Required=false)]
            public string ParentOrgId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
