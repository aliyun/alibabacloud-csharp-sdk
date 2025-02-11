// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkWarehouseBatchSQLRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DMS</para>
        /// </summary>
        [NameInMap("Agency")]
        [Validation(Required=false)]
        public string Agency { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>amv-uf6485635f***</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sq2024123*****</para>
        /// </summary>
        [NameInMap("QueryId")]
        [Validation(Required=false)]
        public string QueryId { get; set; }

    }

}
