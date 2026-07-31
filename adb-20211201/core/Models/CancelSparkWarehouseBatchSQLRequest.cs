// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CancelSparkWarehouseBatchSQLRequest : TeaModel {
        /// <summary>
        /// <para>The client name for auxiliary recording. The value is a meaningful string of up to 16 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DMS</para>
        /// </summary>
        [NameInMap("Agency")]
        [Validation(Required=false)]
        public string Agency { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-uf6485635f***</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The execution ID of the Spark SQL.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sq202501011001s****</para>
        /// </summary>
        [NameInMap("QueryId")]
        [Validation(Required=false)]
        public string QueryId { get; set; }

    }

}
