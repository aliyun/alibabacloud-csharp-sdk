// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDefaultCollectorConfigurationsRequest : TeaModel {
        /// <summary>
        /// <para>The type of the collector. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>fileBeat</description></item>
        /// <item><description>metricBeat</description></item>
        /// <item><description>heartBeat</description></item>
        /// <item><description>auditBeat.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fileBeat</para>
        /// </summary>
        [NameInMap("resType")]
        [Validation(Required=false)]
        public string ResType { get; set; }

        /// <summary>
        /// <para>The version of the collector. The available versions vary based on the type of machine on which the collector is deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ECS: 6.8.5_with_community</description></item>
        /// <item><description>ACK: 6.8.13_with_community.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6.8.5_with_community</para>
        /// </summary>
        [NameInMap("resVersion")]
        [Validation(Required=false)]
        public string ResVersion { get; set; }

        /// <summary>
        /// <para>The type of machine on which the collector is deployed. If you do not specify this parameter, all types are returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ECS: Elastic Compute Service (ECS) instance</description></item>
        /// <item><description>ACK: Container Service for Kubernetes (ACK) cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
