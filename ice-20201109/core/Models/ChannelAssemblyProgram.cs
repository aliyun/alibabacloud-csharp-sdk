// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ChannelAssemblyProgram : TeaModel {
        [NameInMap("AdBreaks")]
        [Validation(Required=false)]
        public List<ChannelAssemblyProgramAdBreaks> AdBreaks { get; set; }
        public class ChannelAssemblyProgramAdBreaks : TeaModel {
            [NameInMap("ChannelName")]
            [Validation(Required=false)]
            public string ChannelName { get; set; }

            [NameInMap("MessageType")]
            [Validation(Required=false)]
            public string MessageType { get; set; }

            [NameInMap("OffsetMillis")]
            [Validation(Required=false)]
            public long? OffsetMillis { get; set; }

            [NameInMap("ProgramName")]
            [Validation(Required=false)]
            public string ProgramName { get; set; }

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

        [NameInMap("Arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        [NameInMap("ChannelName")]
        [Validation(Required=false)]
        public string ChannelName { get; set; }

        [NameInMap("ClipRange")]
        [Validation(Required=false)]
        public string ClipRange { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

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

        [NameInMap("Transition")]
        [Validation(Required=false)]
        public string Transition { get; set; }

    }

}
