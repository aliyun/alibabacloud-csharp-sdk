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
                [NameInMap("ConfigureName")]
                [Validation(Required=false)]
                public string ConfigureName { get; set; }

                [NameInMap("ConfigureUnit")]
                [Validation(Required=false)]
                public string ConfigureUnit { get; set; }

                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("NeedRestart")]
                [Validation(Required=false)]
                public string NeedRestart { get; set; }

                [NameInMap("RunningValue")]
                [Validation(Required=false)]
                public string RunningValue { get; set; }

                [NameInMap("ValueRange")]
                [Validation(Required=false)]
                public string ValueRange { get; set; }

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
        /// <para>5B381E36-BCA3-4377-8638-B65C236617D5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
