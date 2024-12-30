// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ScheduleData : TeaModel {
        [NameInMap("AdBreaks")]
        [Validation(Required=false)]
        public List<ScheduleDataAdBreaks> AdBreaks { get; set; }
        public class ScheduleDataAdBreaks : TeaModel {
            [NameInMap("MessageType")]
            [Validation(Required=false)]
            public string MessageType { get; set; }

            [NameInMap("OffsetMillis")]
            [Validation(Required=false)]
            public string OffsetMillis { get; set; }

            [NameInMap("SourceLocationName")]
            [Validation(Required=false)]
            public string SourceLocationName { get; set; }

            [NameInMap("SourceName")]
            [Validation(Required=false)]
            public string SourceName { get; set; }

            [NameInMap("SpliceInsertSettings")]
            [Validation(Required=false)]
            public string SpliceInsertSettings { get; set; }

            [NameInMap("TimeSignalSettings")]
            [Validation(Required=false)]
            public string TimeSignalSettings { get; set; }

        }

        [NameInMap("ApproximateDurationSeconds")]
        [Validation(Required=false)]
        public long? ApproximateDurationSeconds { get; set; }

        [NameInMap("ApproximateStartTime")]
        [Validation(Required=false)]
        public string ApproximateStartTime { get; set; }

        [NameInMap("EntryType")]
        [Validation(Required=false)]
        public string EntryType { get; set; }

        [NameInMap("ProgramName")]
        [Validation(Required=false)]
        public string ProgramName { get; set; }

        [NameInMap("SourceLocationName")]
        [Validation(Required=false)]
        public string SourceLocationName { get; set; }

        [NameInMap("SourceName")]
        [Validation(Required=false)]
        public string SourceName { get; set; }

        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
