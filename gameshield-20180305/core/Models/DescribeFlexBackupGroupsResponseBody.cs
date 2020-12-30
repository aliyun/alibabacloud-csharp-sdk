// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeFlexBackupGroupsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

        [NameInMap("AllBackupGroups")]
        [Validation(Required=false)]
        public DescribeFlexBackupGroupsResponseBodyAllBackupGroups AllBackupGroups { get; set; }
        public class DescribeFlexBackupGroupsResponseBodyAllBackupGroups : TeaModel {
            [NameInMap("SharedGroups")]
            [Validation(Required=false)]
            public List<DescribeFlexBackupGroupsResponseBodyAllBackupGroupsSharedGroups> SharedGroups { get; set; }
            public class DescribeFlexBackupGroupsResponseBodyAllBackupGroupsSharedGroups : TeaModel {
                public int? Status { get; set; }
                public string GroupId { get; set; }
                public string SpecDesc { get; set; }
            }
            [NameInMap("BackupGroups")]
            [Validation(Required=false)]
            public List<DescribeFlexBackupGroupsResponseBodyAllBackupGroupsBackupGroups> BackupGroups { get; set; }
            public class DescribeFlexBackupGroupsResponseBodyAllBackupGroupsBackupGroups : TeaModel {
                public int? Status { get; set; }
                public string GroupId { get; set; }
            }
        };

    }

}
