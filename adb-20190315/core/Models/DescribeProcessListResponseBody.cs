// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeProcessListResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeProcessListResponseBodyItems Items { get; set; }
        public class DescribeProcessListResponseBodyItems : TeaModel {
            [NameInMap("Process")]
            [Validation(Required=false)]
            public List<DescribeProcessListResponseBodyItemsProcess> Process { get; set; }
            public class DescribeProcessListResponseBodyItemsProcess : TeaModel {
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                [NameInMap("DB")]
                [Validation(Required=false)]
                public string DB { get; set; }

                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                [NameInMap("Info")]
                [Validation(Required=false)]
                public string Info { get; set; }

                [NameInMap("ProcessId")]
                [Validation(Required=false)]
                public string ProcessId { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Time")]
                [Validation(Required=false)]
                public int? Time { get; set; }

                [NameInMap("User")]
                [Validation(Required=false)]
                public string User { get; set; }

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
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The total number of pages returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

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
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
