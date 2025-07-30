// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeGroupsResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Groups")]
        [Validation(Required=false)]
        public List<DescribeGroupsResponseBodyGroups> Groups { get; set; }
        public class DescribeGroupsResponseBodyGroups : TeaModel {
            [NameInMap("AuthedResources")]
            [Validation(Required=false)]
            public Dictionary<string, string> AuthedResources { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ug-2412ojkwtybd****</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("TransferFileNeedApproval")]
            [Validation(Required=false)]
            public bool? TransferFileNeedApproval { get; set; }

            [NameInMap("UserCount")]
            [Validation(Required=false)]
            public int? UserCount { get; set; }

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
