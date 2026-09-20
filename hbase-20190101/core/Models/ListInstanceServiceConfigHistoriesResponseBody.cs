// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class ListInstanceServiceConfigHistoriesResponseBody : TeaModel {
        [NameInMap("ConfigureHistoryList")]
        [Validation(Required=false)]
        public ListInstanceServiceConfigHistoriesResponseBodyConfigureHistoryList ConfigureHistoryList { get; set; }
        public class ListInstanceServiceConfigHistoriesResponseBodyConfigureHistoryList : TeaModel {
            [NameInMap("Config")]
            [Validation(Required=false)]
            public List<ListInstanceServiceConfigHistoriesResponseBodyConfigureHistoryListConfig> Config { get; set; }
            public class ListInstanceServiceConfigHistoriesResponseBodyConfigureHistoryListConfig : TeaModel {
                [NameInMap("ConfigureName")]
                [Validation(Required=false)]
                public string ConfigureName { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Effective")]
                [Validation(Required=false)]
                public string Effective { get; set; }

                [NameInMap("NewValue")]
                [Validation(Required=false)]
                public string NewValue { get; set; }

                [NameInMap("OldValue")]
                [Validation(Required=false)]
                public string OldValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>658C1549-2C02-4FD9-9490-EB3B285F9DCA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
