// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20180528.Models
{
    public class QuerySnapshotJobListResponseBody : TeaModel {
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("NonExistSnapshotJobIds")]
        [Validation(Required=false)]
        public QuerySnapshotJobListResponseBodyNonExistSnapshotJobIds NonExistSnapshotJobIds { get; set; }
        public class QuerySnapshotJobListResponseBodyNonExistSnapshotJobIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SnapshotJobList")]
        [Validation(Required=false)]
        public QuerySnapshotJobListResponseBodySnapshotJobList SnapshotJobList { get; set; }
        public class QuerySnapshotJobListResponseBodySnapshotJobList : TeaModel {
            [NameInMap("SnapshotJob")]
            [Validation(Required=false)]
            public List<QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJob> SnapshotJob { get; set; }
            public class QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJob : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Count")]
                [Validation(Required=false)]
                public string Count { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Input")]
                [Validation(Required=false)]
                public QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobInput Input { get; set; }
                public class QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobInput : TeaModel {
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                    [NameInMap("RoleArn")]
                    [Validation(Required=false)]
                    public string RoleArn { get; set; }

                }

                [NameInMap("MNSMessageResult")]
                [Validation(Required=false)]
                public QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobMNSMessageResult MNSMessageResult { get; set; }
                public class QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobMNSMessageResult : TeaModel {
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    [NameInMap("MessageId")]
                    [Validation(Required=false)]
                    public string MessageId { get; set; }

                }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }

                [NameInMap("SnapshotConfig")]
                [Validation(Required=false)]
                public QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobSnapshotConfig SnapshotConfig { get; set; }
                public class QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobSnapshotConfig : TeaModel {
                    [NameInMap("FrameType")]
                    [Validation(Required=false)]
                    public string FrameType { get; set; }

                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public string Interval { get; set; }

                    [NameInMap("Num")]
                    [Validation(Required=false)]
                    public string Num { get; set; }

                    [NameInMap("OutputFile")]
                    [Validation(Required=false)]
                    public QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobSnapshotConfigOutputFile OutputFile { get; set; }
                    public class QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobSnapshotConfigOutputFile : TeaModel {
                        [NameInMap("Bucket")]
                        [Validation(Required=false)]
                        public string Bucket { get; set; }

                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }

                        [NameInMap("Object")]
                        [Validation(Required=false)]
                        public string Object { get; set; }

                        [NameInMap("RoleArn")]
                        [Validation(Required=false)]
                        public string RoleArn { get; set; }

                    }

                    [NameInMap("TileOut")]
                    [Validation(Required=false)]
                    public QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobSnapshotConfigTileOut TileOut { get; set; }
                    public class QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobSnapshotConfigTileOut : TeaModel {
                        [NameInMap("CellHeight")]
                        [Validation(Required=false)]
                        public string CellHeight { get; set; }

                        [NameInMap("CellSelStep")]
                        [Validation(Required=false)]
                        public string CellSelStep { get; set; }

                        [NameInMap("CellWidth")]
                        [Validation(Required=false)]
                        public string CellWidth { get; set; }

                        [NameInMap("Color")]
                        [Validation(Required=false)]
                        public string Color { get; set; }

                        [NameInMap("Columns")]
                        [Validation(Required=false)]
                        public string Columns { get; set; }

                        [NameInMap("IsKeepCellPic")]
                        [Validation(Required=false)]
                        public string IsKeepCellPic { get; set; }

                        [NameInMap("Lines")]
                        [Validation(Required=false)]
                        public string Lines { get; set; }

                        [NameInMap("Margin")]
                        [Validation(Required=false)]
                        public string Margin { get; set; }

                        [NameInMap("Padding")]
                        [Validation(Required=false)]
                        public string Padding { get; set; }

                    }

                    [NameInMap("TileOutputFile")]
                    [Validation(Required=false)]
                    public QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobSnapshotConfigTileOutputFile TileOutputFile { get; set; }
                    public class QuerySnapshotJobListResponseBodySnapshotJobListSnapshotJobSnapshotConfigTileOutputFile : TeaModel {
                        [NameInMap("Bucket")]
                        [Validation(Required=false)]
                        public string Bucket { get; set; }

                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }

                        [NameInMap("Object")]
                        [Validation(Required=false)]
                        public string Object { get; set; }

                        [NameInMap("RoleArn")]
                        [Validation(Required=false)]
                        public string RoleArn { get; set; }

                    }

                    [NameInMap("Time")]
                    [Validation(Required=false)]
                    public string Time { get; set; }

                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("TileCount")]
                [Validation(Required=false)]
                public string TileCount { get; set; }

                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }

        }

    }

}
