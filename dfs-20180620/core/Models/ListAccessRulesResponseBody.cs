// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class ListAccessRulesResponseBody : TeaModel {
        [NameInMap("AccessRules")]
        [Validation(Required=false)]
        public List<ListAccessRulesResponseBodyAccessRules> AccessRules { get; set; }
        public class ListAccessRulesResponseBodyAccessRules : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>acg-e3755fb0-358d-4286-9942-8d461048****</para>
            /// </summary>
            [NameInMap("AccessGroupId")]
            [Validation(Required=false)]
            public string AccessGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>acr-c38028f0-f313-4385-9456-3501b1f5****</para>
            /// </summary>
            [NameInMap("AccessRuleId")]
            [Validation(Required=false)]
            public string AccessRuleId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>192.0.2.0/24</para>
            /// </summary>
            [NameInMap("NetworkSegment")]
            [Validation(Required=false)]
            public string NetworkSegment { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RDWR</para>
            /// </summary>
            [NameInMap("RWAccessType")]
            [Validation(Required=false)]
            public string RWAccessType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>55C5FFD6-BF99-41BD-9C66-FFF39189****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
