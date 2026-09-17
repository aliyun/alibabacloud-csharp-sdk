// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class PostInnerReaderRequest : TeaModel {
        /// <summary>
        /// <para>The fallback description used when the data source is missing. Use this parameter to pass the complete data source description information in the request parameters (Plan B).</para>
        /// </summary>
        [NameInMap("dataSourceDescriptor")]
        [Validation(Required=false)]
        public PostInnerReaderRequestDataSourceDescriptor DataSourceDescriptor { get; set; }
        public class PostInnerReaderRequestDataSourceDescriptor : TeaModel {
            /// <summary>
            /// <para>The data source name. Exact match and fuzzy match are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_ds318_hangzhou_0428</para>
            /// </summary>
            [NameInMap("dsName")]
            [Validation(Required=false)]
            public string DsName { get; set; }

        }

        /// <summary>
        /// <para>The data source name. The discovery task uses this field as the dimension identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds_dolphin_prod</para>
        /// </summary>
        [NameInMap("dataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

    }

}
