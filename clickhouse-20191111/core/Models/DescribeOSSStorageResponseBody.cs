// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeOSSStorageResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether tiered storage for hot and cold data can be enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Tiered storage can be enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Tiered storage cannot be enabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ColdStorage")]
        [Validation(Required=false)]
        public bool? ColdStorage { get; set; }

        /// <summary>
        /// <para>The parameters of the tiered storage policy for hot and cold data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{ &quot;currentValue&quot;:&quot;0.1&quot;, &quot;defaultValue&quot;:&quot;0.1&quot;, &quot;desc&quot;:&quot;Ratio of free disk space. When the ratio exceeds the value of configuration parameter, ClickHouse start to move data to the cold storage&quot;, &quot;name&quot;:&quot;move_factor&quot;, &quot;restart&quot;:true, &quot;valueRange&quot;:&quot;(0, 1]&quot; },{ &quot;currentValue&quot;:&quot;true&quot;, &quot;defaultValue&quot;:&quot;true&quot;, &quot;desc&quot;:&quot;Disables merging of data parts on cold storage&quot;, &quot;name&quot;:&quot;prefer_not_to_merge&quot;, &quot;restart&quot;:true, &quot;valueRange&quot;:&quot;true|false&quot; }]</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aadbb456-ebf7-4ed8-9671-fad9f3846ca4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of tiered storage for hot and cold data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>CREATING</b>: Tiered storage is being enabled.</para>
        /// </description></item>
        /// <item><description><para><b>DISABLE</b>: Tiered storage is disabled.</para>
        /// </description></item>
        /// <item><description><para><b>ENABLE</b>: Tiered storage is enabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ENABLE</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The cold storage space used. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.00</para>
        /// </summary>
        [NameInMap("StorageUsage")]
        [Validation(Required=false)]
        public string StorageUsage { get; set; }

    }

}
