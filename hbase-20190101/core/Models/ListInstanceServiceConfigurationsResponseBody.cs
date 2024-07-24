// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class ListInstanceServiceConfigurationsResponseBody : TeaModel {
        [NameInMap("ConfigureList")]
        [Validation(Required=false)]
        public ListInstanceServiceConfigurationsResponseBodyConfigureList ConfigureList { get; set; }
        public class ListInstanceServiceConfigurationsResponseBodyConfigureList : TeaModel {
            [NameInMap("Config")]
            [Validation(Required=false)]
            public List<ListInstanceServiceConfigurationsResponseBodyConfigureListConfig> Config { get; set; }
            public class ListInstanceServiceConfigurationsResponseBodyConfigureListConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>hbase#hbase-site.xml#hbase.client.keyvalue.maxsize</para>
                /// </summary>
                [NameInMap("ConfigureName")]
                [Validation(Required=false)]
                public string ConfigureName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>INT</para>
                /// </summary>
                [NameInMap("ConfigureUnit")]
                [Validation(Required=false)]
                public string ConfigureUnit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10485760</para>
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>hbase client keyvalue maxsize</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("NeedRestart")]
                [Validation(Required=false)]
                public string NeedRestart { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10485760</para>
                /// </summary>
                [NameInMap("RunningValue")]
                [Validation(Required=false)]
                public string RunningValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>R[10485760,52428800]</para>
                /// </summary>
                [NameInMap("ValueRange")]
                [Validation(Required=false)]
                public string ValueRange { get; set; }

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
        /// <para>5B381E36-BCA3-4377-8638-B65C236617D5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
