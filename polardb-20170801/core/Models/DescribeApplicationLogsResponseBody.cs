// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeApplicationLogsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeApplicationLogsResponseBodyItems Items { get; set; }
        public class DescribeApplicationLogsResponseBodyItems : TeaModel {
            [NameInMap("LogRecords")]
            [Validation(Required=false)]
            public List<DescribeApplicationLogsResponseBodyItemsLogRecords> LogRecords { get; set; }
            public class DescribeApplicationLogsResponseBodyItemsLogRecords : TeaModel {
                [NameInMap("ComponentName")]
                [Validation(Required=false)]
                public string ComponentName { get; set; }

                [NameInMap("ContainerName")]
                [Validation(Required=false)]
                public string ContainerName { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                [NameInMap("FileLine")]
                [Validation(Required=false)]
                public string FileLine { get; set; }

                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("FullFilePath")]
                [Validation(Required=false)]
                public string FullFilePath { get; set; }

                [NameInMap("Hostname")]
                [Validation(Required=false)]
                public string Hostname { get; set; }

                [NameInMap("LogLevelId")]
                [Validation(Required=false)]
                public long? LogLevelId { get; set; }

                [NameInMap("LogLevelName")]
                [Validation(Required=false)]
                public string LogLevelName { get; set; }

                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Runtime")]
                [Validation(Required=false)]
                public string Runtime { get; set; }

                [NameInMap("RuntimeVersion")]
                [Validation(Required=false)]
                public string RuntimeVersion { get; set; }

                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CED079B7-A408-41A1-BFF1-EC608E******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
