// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifyStreamingJobRequest : TeaModel {
        [NameInMap("Account")]
        [Validation(Required=false)]
        public string Account { get; set; }

        [NameInMap("Consistency")]
        [Validation(Required=false)]
        public string Consistency { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("DestColumns")]
        [Validation(Required=false)]
        public List<string> DestColumns { get; set; }

        [NameInMap("DestDatabase")]
        [Validation(Required=false)]
        public string DestDatabase { get; set; }

        [NameInMap("DestSchema")]
        [Validation(Required=false)]
        public string DestSchema { get; set; }

        [NameInMap("DestTable")]
        [Validation(Required=false)]
        public string DestTable { get; set; }

        [NameInMap("ErrorLimitCount")]
        [Validation(Required=false)]
        public long? ErrorLimitCount { get; set; }

        [NameInMap("FallbackOffset")]
        [Validation(Required=false)]
        public string FallbackOffset { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("JobConfig")]
        [Validation(Required=false)]
        public string JobConfig { get; set; }

        [NameInMap("JobDescription")]
        [Validation(Required=false)]
        public string JobDescription { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        [NameInMap("MatchColumns")]
        [Validation(Required=false)]
        public List<string> MatchColumns { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SrcColumns")]
        [Validation(Required=false)]
        public List<string> SrcColumns { get; set; }

        [NameInMap("TryRun")]
        [Validation(Required=false)]
        public bool? TryRun { get; set; }

        [NameInMap("UpdateColumns")]
        [Validation(Required=false)]
        public List<string> UpdateColumns { get; set; }

        [NameInMap("WriteMode")]
        [Validation(Required=false)]
        public string WriteMode { get; set; }

    }

}
