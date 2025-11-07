// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListGitOrganizationsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("GitOrgs")]
        [Validation(Required=false)]
        public List<ListGitOrganizationsResponseBodyGitOrgs> GitOrgs { get; set; }
        public class ListGitOrganizationsResponseBodyGitOrgs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>dfj3535</para>
            /// </summary>
            [NameInMap("OrgId")]
            [Validation(Required=false)]
            public string OrgId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aliyun-computenest</para>
            /// </summary>
            [NameInMap("OrgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9E011F98-4EE5-5E3A-8FA3-D38F2C531C1F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
