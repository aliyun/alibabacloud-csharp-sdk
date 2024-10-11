// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class CheckClickhouseToRDSResponseBody : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description>When the value <b>true</b> is returned for the <b>Status</b> parameter, the system does not return the ErrorCode parameter.</description></item>
        /// <item><description>When the value <b>false</b> is returned for the <b>Status</b> parameter, the system returns for the ErrorCode parameter the reason why the ApsaraDB for ClickHouse cluster cannot be connected to the ApsaraDB RDS for MySQL instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NotSameVpc</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A82758F8-E793-5610-BE11-0E46664305C2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the ApsaraDB for ClickHouse cluster can be connected to the ApsaraDB RDS for MySQL instance.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The ApsaraDB for ClickHouse cluster can be connected to the ApsaraDB RDS for MySQL instance.</description></item>
        /// <item><description><b>false</b>: The ApsaraDB for ClickHouse cluster cannot be connected to the ApsaraDB RDS for MySQL instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public bool? Status { get; set; }

    }

}
