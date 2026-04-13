// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeBinlogFilesResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeBinlogFilesResponseBodyItems Items { get; set; }
        public class DescribeBinlogFilesResponseBodyItems : TeaModel {
            [NameInMap("LogFile")]
            [Validation(Required=false)]
            public List<DescribeBinlogFilesResponseBodyItemsLogFile> LogFile { get; set; }
            public class DescribeBinlogFilesResponseBodyItemsLogFile : TeaModel {
                [NameInMap("BinLogId")]
                [Validation(Required=false)]
                public string BinLogId { get; set; }

                [NameInMap("DownloadLink")]
                [Validation(Required=false)]
                public string DownloadLink { get; set; }

                [NameInMap("DumpBucket")]
                [Validation(Required=false)]
                public string DumpBucket { get; set; }

                [NameInMap("DumpDownloadURL")]
                [Validation(Required=false)]
                public string DumpDownloadURL { get; set; }

                [NameInMap("DumpState")]
                [Validation(Required=false)]
                public int? DumpState { get; set; }

                [NameInMap("FileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                [NameInMap("FileSize")]
                [Validation(Required=false)]
                public string FileSize { get; set; }

                [NameInMap("LinkExpiredTime")]
                [Validation(Required=false)]
                public string LinkExpiredTime { get; set; }

                [NameInMap("LogBeginTime")]
                [Validation(Required=false)]
                public string LogBeginTime { get; set; }

                [NameInMap("LogEndTime")]
                [Validation(Required=false)]
                public string LogEndTime { get; set; }

                [NameInMap("LogFileName")]
                [Validation(Required=false)]
                public string LogFileName { get; set; }

                [NameInMap("LogStatus")]
                [Validation(Required=false)]
                public string LogStatus { get; set; }

                [NameInMap("OSSEndpoint")]
                [Validation(Required=false)]
                public string OSSEndpoint { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MaxRecordsPerPage")]
        [Validation(Required=false)]
        public int? MaxRecordsPerPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F8CA8312-530A-413A-9129-F2BB32A8D404</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>240</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
