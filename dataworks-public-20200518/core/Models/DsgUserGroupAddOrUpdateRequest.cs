// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgUserGroupAddOrUpdateRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("UserGroups")]
        [Validation(Required=false)]
        public List<DsgUserGroupAddOrUpdateRequestUserGroups> UserGroups { get; set; }
        public class DsgUserGroupAddOrUpdateRequestUserGroups : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Accounts")]
            [Validation(Required=false)]
            public List<string> Accounts { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("UserGroupType")]
            [Validation(Required=false)]
            public int? UserGroupType { get; set; }

        }

    }

}
