// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListCollectorsRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID associated with the collector.</para>
        /// 
        /// <b>Example:</b>
        /// <para>es-cn-nif1q8auz0003****</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The collector name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>collectorName1</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number of the returned results. Default value: 1. Minimum value: 1. Maximum value: 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The collector ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ct-cn-77uqof2s7rg5c****</para>
        /// </summary>
        [NameInMap("resId")]
        [Validation(Required=false)]
        public string ResId { get; set; }

        /// <summary>
        /// <para>The number of results per page. Default value: 20. Minimum value: 1. Maximum value: 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>The type of machine on which the collector is deployed. If this parameter is not specified, all types are returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ECS: ECS instance</para>
        /// </description></item>
        /// <item><description><para>ACK: Container Kubernetes cluster.</para>
        /// </description></item>
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
