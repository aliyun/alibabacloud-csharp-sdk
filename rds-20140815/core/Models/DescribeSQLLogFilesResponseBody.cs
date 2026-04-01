// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeSQLLogFilesResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSQLLogFilesResponseBodyItems Items { get; set; }
        public class DescribeSQLLogFilesResponseBodyItems : TeaModel {
            [NameInMap("LogFile")]
            [Validation(Required=false)]
            public List<DescribeSQLLogFilesResponseBodyItemsLogFile> LogFile { get; set; }
            public class DescribeSQLLogFilesResponseBodyItemsLogFile : TeaModel {
                [NameInMap("FileID")]
                [Validation(Required=false)]
                public string FileID { get; set; }

                [NameInMap("LogDownloadURL")]
                [Validation(Required=false)]
                public string LogDownloadURL { get; set; }

                [NameInMap("LogEndTime")]
                [Validation(Required=false)]
                public string LogEndTime { get; set; }

                [NameInMap("LogSize")]
                [Validation(Required=false)]
                public string LogSize { get; set; }

                [NameInMap("LogStartTime")]
                [Validation(Required=false)]
                public string LogStartTime { get; set; }

                [NameInMap("LogStatus")]
                [Validation(Required=false)]
                public string LogStatus { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
