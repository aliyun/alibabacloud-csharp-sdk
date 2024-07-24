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
                /// <summary>
                /// <b>Example:</b>
                /// <para>hbase#hbase-site.xml#hbase.client.keyvalue.maxsize</para>
                /// </summary>
                [NameInMap("ConfigureName")]
                [Validation(Required=false)]
                public string ConfigureName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1608708923000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Effective")]
                [Validation(Required=false)]
                public string Effective { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10485770</para>
                /// </summary>
                [NameInMap("NewValue")]
                [Validation(Required=false)]
                public string NewValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10485760</para>
                /// </summary>
                [NameInMap("OldValue")]
                [Validation(Required=false)]
                public string OldValue { get; set; }

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
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>658C1549-2C02-4FD9-9490-EB3B285F9DCA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
