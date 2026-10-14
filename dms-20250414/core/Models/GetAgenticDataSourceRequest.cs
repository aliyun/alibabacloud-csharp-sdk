// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class GetAgenticDataSourceRequest : TeaModel {
        /// <summary>
        /// <para>The UUID of the data source to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou_a1b2c3d4e5f6</para>
        /// </summary>
        [NameInMap("DataSourceUuid")]
        [Validation(Required=false)]
        public string DataSourceUuid { get; set; }

    }

}
