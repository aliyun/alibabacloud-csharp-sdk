// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class AllocateClusterPublicConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The prefix of the public connection address.</para>
        /// <list type="bullet">
        /// <item><description><para>It must begin with a lowercase letter and can contain only lowercase letters, digits, and hyphens (-).</para>
        /// </description></item>
        /// <item><description><para>It must be no more than 30 characters long.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test12</para>
        /// </summary>
        [NameInMap("ConnectionStringPrefix")]
        [Validation(Required=false)]
        public string ConnectionStringPrefix { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The cluster ID of an Enterprise Edition, Basic Edition, or Data Lakehouse Edition cluster.
        /// &lt;props=&quot;intl&quot;&gt;The cluster ID of a Data Lakehouse Edition cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1z5d2q71is2****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>AnalyticDB</b> (default): the AnalyticDB for MySQL engine.</para>
        /// </description></item>
        /// <item><description><para><b>Clickhouse</b>: the wide table engine.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Clickhouse</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

    }

}
