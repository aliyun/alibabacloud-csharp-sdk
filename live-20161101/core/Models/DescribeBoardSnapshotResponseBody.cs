// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeBoardSnapshotResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Snapshot")]
        [Validation(Required=false)]
        public DescribeBoardSnapshotResponseBodySnapshot Snapshot { get; set; }
        public class DescribeBoardSnapshotResponseBodySnapshot : TeaModel {
            [NameInMap("Board")]
            [Validation(Required=false)]
            public DescribeBoardSnapshotResponseBodySnapshotBoard Board { get; set; }
            public class DescribeBoardSnapshotResponseBodySnapshotBoard : TeaModel {
                [NameInMap("BoardId")]
                [Validation(Required=false)]
                public string BoardId { get; set; }

                [NameInMap("AppUid")]
                [Validation(Required=false)]
                public string AppUid { get; set; }

                [NameInMap("EventTimestamp")]
                [Validation(Required=false)]
                public long? EventTimestamp { get; set; }

                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

                [NameInMap("Pages")]
                [Validation(Required=false)]
                public List<DescribeBoardSnapshotResponseBodySnapshotBoardPages> Pages { get; set; }
                public class DescribeBoardSnapshotResponseBodySnapshotBoardPages : TeaModel {
                    [NameInMap("PageIndex")]
                    [Validation(Required=false)]
                    public int? PageIndex { get; set; }

                    [NameInMap("Elements")]
                    [Validation(Required=false)]
                    public List<DescribeBoardSnapshotResponseBodySnapshotBoardPagesElements> Elements { get; set; }
                    public class DescribeBoardSnapshotResponseBodySnapshotBoardPagesElements : TeaModel {
                        [NameInMap("ElementIndex")]
                        [Validation(Required=false)]
                        public string ElementIndex { get; set; }

                        [NameInMap("OwnerId")]
                        [Validation(Required=false)]
                        public string OwnerId { get; set; }

                        [NameInMap("ElementType")]
                        [Validation(Required=false)]
                        public int? ElementType { get; set; }

                        [NameInMap("UpdateTimestamp")]
                        [Validation(Required=false)]
                        public long? UpdateTimestamp { get; set; }

                        [NameInMap("Data")]
                        [Validation(Required=false)]
                        public string Data { get; set; }

                    }

                }

                [NameInMap("Configs")]
                [Validation(Required=false)]
                public List<DescribeBoardSnapshotResponseBodySnapshotBoardConfigs> Configs { get; set; }
                public class DescribeBoardSnapshotResponseBodySnapshotBoardConfigs : TeaModel {
                    [NameInMap("AppUid")]
                    [Validation(Required=false)]
                    public string AppUid { get; set; }

                    [NameInMap("Data")]
                    [Validation(Required=false)]
                    public string Data { get; set; }

                }

            }
        };

    }

}
