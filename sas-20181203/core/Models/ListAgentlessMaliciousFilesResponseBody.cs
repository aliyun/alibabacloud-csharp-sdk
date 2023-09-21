// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAgentlessMaliciousFilesResponseBody : TeaModel {
        /// <summary>
        /// The malicious files.
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListAgentlessMaliciousFilesResponseBodyList> List { get; set; }
        public class ListAgentlessMaliciousFilesResponseBodyList : TeaModel {
            /// <summary>
            /// The details of the exception.
            /// </summary>
            [NameInMap("Details")]
            [Validation(Required=false)]
            public List<ListAgentlessMaliciousFilesResponseBodyListDetails> Details { get; set; }
            public class ListAgentlessMaliciousFilesResponseBodyListDetails : TeaModel {
                /// <summary>
                /// The name of the exception.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The name key of the exception.
                /// </summary>
                [NameInMap("NameKey")]
                [Validation(Required=false)]
                public string NameKey { get; set; }

                /// <summary>
                /// The type of the exception.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The value of the exception.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The URL to download the malicious image sample.
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// The file path.
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public long? FilePath { get; set; }

            /// <summary>
            /// The timestamp generated when the first scan was performed. Unit: milliseconds.
            /// </summary>
            [NameInMap("FirstScanTimestamp")]
            [Validation(Required=false)]
            public long? FirstScanTimestamp { get; set; }

            /// <summary>
            /// The highlighted JSON string.
            /// </summary>
            [NameInMap("HighLight")]
            [Validation(Required=false)]
            public string HighLight { get; set; }

            /// <summary>
            /// The event ID.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The name of the asset.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The public IP address of the server.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The private IP address of the server.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// The timestamp generated when the last scan was performed. Unit: milliseconds.
            /// </summary>
            [NameInMap("LatestScanTimestamp")]
            [Validation(Required=false)]
            public long? LatestScanTimestamp { get; set; }

            /// <summary>
            /// The severity of the malicious file. Valid values:
            /// 
            /// *   serious
            /// *   suspicious
            /// *   remind
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// The MD5 hash value of the malicious file.
            /// </summary>
            [NameInMap("MaliciousMd5")]
            [Validation(Required=false)]
            public string MaliciousMd5 { get; set; }

            /// <summary>
            /// The name of the malicious file.
            /// </summary>
            [NameInMap("MaliciousName")]
            [Validation(Required=false)]
            public string MaliciousName { get; set; }

            [NameInMap("MaliciousType")]
            [Validation(Required=false)]
            public string MaliciousType { get; set; }

            /// <summary>
            /// The remarks.
            /// </summary>
            [NameInMap("Notes")]
            [Validation(Required=false)]
            public List<ListAgentlessMaliciousFilesResponseBodyListNotes> Notes { get; set; }
            public class ListAgentlessMaliciousFilesResponseBodyListNotes : TeaModel {
                /// <summary>
                /// The remark.
                /// </summary>
                [NameInMap("Note")]
                [Validation(Required=false)]
                public string Note { get; set; }

                /// <summary>
                /// The ID of the remark.
                /// </summary>
                [NameInMap("NoteId")]
                [Validation(Required=false)]
                public string NoteId { get; set; }

                /// <summary>
                /// The time when the remark was created.
                /// </summary>
                [NameInMap("NoteTime")]
                [Validation(Required=false)]
                public string NoteTime { get; set; }

            }

            /// <summary>
            /// The handling result of the exception.
            /// </summary>
            [NameInMap("OperateResult")]
            [Validation(Required=false)]
            public string OperateResult { get; set; }

            /// <summary>
            /// The timestamp generated when the exception is handled. Unit: milliseconds.
            /// </summary>
            [NameInMap("OperateTimestamp")]
            [Validation(Required=false)]
            public string OperateTimestamp { get; set; }

            /// <summary>
            /// The partition of the disk.
            /// </summary>
            [NameInMap("Partition")]
            [Validation(Required=false)]
            public string Partition { get; set; }

            /// <summary>
            /// The ID of the asset that is scanned.
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// The name of the asset that is scanned.
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// The type of the asset that is scanned. Valid values:
            /// 
            /// *   2: The scanned asset is an image.
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// The UUID of the asset.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListAgentlessMaliciousFilesResponseBodyPageInfo PageInfo { get; set; }
        public class ListAgentlessMaliciousFilesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
