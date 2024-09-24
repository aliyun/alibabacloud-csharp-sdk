// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyDBClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1r053byu48p****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2035629****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0D6BF3E2-41D8-57F6-9A62-A13A70377952</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
