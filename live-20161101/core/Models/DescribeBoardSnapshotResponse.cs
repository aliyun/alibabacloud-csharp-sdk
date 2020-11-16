// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeBoardSnapshotResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Snapshot")]
        [Validation(Required=true)]
        public DescribeBoardSnapshotResponseSnapshot Snapshot { get; set; }
        public class DescribeBoardSnapshotResponseSnapshot : TeaModel {
            [NameInMap("Board")]
            [Validation(Required=true)]
            public DescribeBoardSnapshotResponseSnapshotBoard Board { get; set; }
            public class DescribeBoardSnapshotResponseSnapshotBoard : TeaModel {
                [NameInMap("BoardId")]
                [Validation(Required=true)]
                public string BoardId { get; set; }

                [NameInMap("AppUid")]
                [Validation(Required=true)]
                public string AppUid { get; set; }

                [NameInMap("EventTimestamp")]
                [Validation(Required=true)]
                public long EventTimestamp { get; set; }

                [NameInMap("CreateTimestamp")]
                [Validation(Required=true)]
                public long CreateTimestamp { get; set; }

                [NameInMap("UpdateTimestamp")]
                [Validation(Required=true)]
                public long UpdateTimestamp { get; set; }

                [NameInMap("Pages")]
                [Validation(Required=true)]
                public List<DescribeBoardSnapshotResponseSnapshotBoardPages> Pages { get; set; }
                public class DescribeBoardSnapshotResponseSnapshotBoardPages : TeaModel {
                    [NameInMap("PageIndex")]
                    [Validation(Required=true)]
                    public int? PageIndex { get; set; }

                    [NameInMap("Elements")]
                    [Validation(Required=true)]
                    public List<DescribeBoardSnapshotResponseSnapshotBoardPagesElements> Elements { get; set; }
                    public class DescribeBoardSnapshotResponseSnapshotBoardPagesElements : TeaModel {
                        [NameInMap("ElementIndex")]
                        [Validation(Required=true)]
                        public string ElementIndex { get; set; }

                        [NameInMap("OwnerId")]
                        [Validation(Required=true)]
                        public string OwnerId { get; set; }

                        [NameInMap("ElementType")]
                        [Validation(Required=true)]
                        public int? ElementType { get; set; }

                        [NameInMap("UpdateTimestamp")]
                        [Validation(Required=true)]
                        public long UpdateTimestamp { get; set; }

                        [NameInMap("Data")]
                        [Validation(Required=true)]
                        public string Data { get; set; }

                    }

                }

                [NameInMap("Configs")]
                [Validation(Required=true)]
                public List<DescribeBoardSnapshotResponseSnapshotBoardConfigs> Configs { get; set; }
                public class DescribeBoardSnapshotResponseSnapshotBoardConfigs : TeaModel {
                    [NameInMap("AppUid")]
                    [Validation(Required=true)]
                    public string AppUid { get; set; }

                    [NameInMap("Data")]
                    [Validation(Required=true)]
                    public string Data { get; set; }

                }

            }
        };

    }

}
