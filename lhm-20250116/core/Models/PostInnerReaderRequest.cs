// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class PostInnerReaderRequest : TeaModel {
        [NameInMap("dataSourceDescriptor")]
        [Validation(Required=false)]
        public PostInnerReaderRequestDataSourceDescriptor DataSourceDescriptor { get; set; }
        public class PostInnerReaderRequestDataSourceDescriptor : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test_ds318_hangzhou_0428</para>
            /// </summary>
            [NameInMap("dsName")]
            [Validation(Required=false)]
            public string DsName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ds_dolphin_prod</para>
        /// </summary>
        [NameInMap("dataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

    }

}
