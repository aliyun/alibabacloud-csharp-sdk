// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class GetInnerReadAsyncResultRequest : TeaModel {
        /// <summary>
        /// <para>The data source name. The probe task uses this field as its dimension identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds_dolphin_prod</para>
        /// </summary>
        [NameInMap("dataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

    }

}
