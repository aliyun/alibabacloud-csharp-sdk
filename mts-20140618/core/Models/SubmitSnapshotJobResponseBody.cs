// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitSnapshotJobResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SnapshotJob")]
        [Validation(Required=false)]
        public SubmitSnapshotJobResponseBodySnapshotJob SnapshotJob { get; set; }
        public class SubmitSnapshotJobResponseBodySnapshotJob : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }
            [NameInMap("SnapshotConfig")]
            [Validation(Required=false)]
            public SubmitSnapshotJobResponseBodySnapshotJobSnapshotConfig SnapshotConfig { get; set; }
            public class SubmitSnapshotJobResponseBodySnapshotJobSnapshotConfig : TeaModel {
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                [NameInMap("TileOut")]
                [Validation(Required=false)]
                public SubmitSnapshotJobResponseBodySnapshotJobSnapshotConfigTileOut TileOut { get; set; }
                public class SubmitSnapshotJobResponseBodySnapshotJobSnapshotConfigTileOut : TeaModel {
                    [NameInMap("Padding")]
                    [Validation(Required=false)]
                    public string Padding { get; set; }
                    [NameInMap("Color")]
                    [Validation(Required=false)]
                    public string Color { get; set; }
                    [NameInMap("CellSelStep")]
                    [Validation(Required=false)]
                    public string CellSelStep { get; set; }
                    [NameInMap("CellHeight")]
                    [Validation(Required=false)]
                    public string CellHeight { get; set; }
                    [NameInMap("CellWidth")]
                    [Validation(Required=false)]
                    public string CellWidth { get; set; }
                    [NameInMap("Margin")]
                    [Validation(Required=false)]
                    public string Margin { get; set; }
                    [NameInMap("Columns")]
                    [Validation(Required=false)]
                    public string Columns { get; set; }
                    [NameInMap("IsKeepCellPic")]
                    [Validation(Required=false)]
                    public string IsKeepCellPic { get; set; }
                    [NameInMap("Lines")]
                    [Validation(Required=false)]
                    public string Lines { get; set; }
                };

                [NameInMap("Interval")]
                [Validation(Required=false)]
                public string Interval { get; set; }

                [NameInMap("FrameType")]
                [Validation(Required=false)]
                public string FrameType { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                [NameInMap("OutputFile")]
                [Validation(Required=false)]
                public SubmitSnapshotJobResponseBodySnapshotJobSnapshotConfigOutputFile OutputFile { get; set; }
                public class SubmitSnapshotJobResponseBodySnapshotJobSnapshotConfigOutputFile : TeaModel {
                    [NameInMap("RoleArn")]
                    [Validation(Required=false)]
                    public string RoleArn { get; set; }
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }
                };

                [NameInMap("Num")]
                [Validation(Required=false)]
                public string Num { get; set; }

                [NameInMap("TileOutputFile")]
                [Validation(Required=false)]
                public SubmitSnapshotJobResponseBodySnapshotJobSnapshotConfigTileOutputFile TileOutputFile { get; set; }
                public class SubmitSnapshotJobResponseBodySnapshotJobSnapshotConfigTileOutputFile : TeaModel {
                    [NameInMap("RoleArn")]
                    [Validation(Required=false)]
                    public string RoleArn { get; set; }
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }
                };

            }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("MNSMessageResult")]
            [Validation(Required=false)]
            public SubmitSnapshotJobResponseBodySnapshotJobMNSMessageResult MNSMessageResult { get; set; }
            public class SubmitSnapshotJobResponseBodySnapshotJobMNSMessageResult : TeaModel {
                [NameInMap("MessageId")]
                [Validation(Required=false)]
                public string MessageId { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

            }
            [NameInMap("Input")]
            [Validation(Required=false)]
            public SubmitSnapshotJobResponseBodySnapshotJobInput Input { get; set; }
            public class SubmitSnapshotJobResponseBodySnapshotJobInput : TeaModel {
                [NameInMap("RoleArn")]
                [Validation(Required=false)]
                public string RoleArn { get; set; }

                [NameInMap("Object")]
                [Validation(Required=false)]
                public string Object { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

            }
            [NameInMap("Count")]
            [Validation(Required=false)]
            public string Count { get; set; }
            [NameInMap("TileCount")]
            [Validation(Required=false)]
            public string TileCount { get; set; }
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
        };

    }

}
