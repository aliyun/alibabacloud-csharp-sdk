// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class ExecWorkflowConnectivityRequest : TeaModel {
        /// <summary>
        /// <para>The datasource config. The value is a JSON character string whose structure is defined by each dsType. Parse the JSON string before use. Sensitive fields such as tokens are masked in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;endpoint&quot;:&quot;...&quot;,&quot;token&quot;:&quot;******&quot;}</para>
        /// </summary>
        [NameInMap("dsConfig")]
        [Validation(Required=false)]
        public string DsConfig { get; set; }

        /// <summary>
        /// <para>The data source name. Exact match and fuzzy match are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_ds318_hangzhou_0428</para>
        /// </summary>
        [NameInMap("dsName")]
        [Validation(Required=false)]
        public string DsName { get; set; }

        /// <summary>
        /// <para>The data source type, such as Hive or MaxCompute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hive</para>
        /// </summary>
        [NameInMap("dsType")]
        [Validation(Required=false)]
        public string DsType { get; set; }

        /// <summary>
        /// <para>The data source version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.2.0</para>
        /// </summary>
        [NameInMap("dsVersion")]
        [Validation(Required=false)]
        public string DsVersion { get; set; }

        /// <summary>
        /// <para>The primary key ID that uniquely identifies a record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Specifies whether the configuration has been modified.</para>
        /// </summary>
        [NameInMap("isModified")]
        [Validation(Required=false)]
        public bool? IsModified { get; set; }

    }

}
