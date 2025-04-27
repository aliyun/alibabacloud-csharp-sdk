// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListCollectorsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource with which the shipper is associated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>es-cn-nif1q8auz0003****</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the shipper.</para>
        /// 
        /// <b>Example:</b>
        /// <para>collectorName1</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Valid values: 1 to 200. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The ID of the shipper.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ct-cn-77uqof2s7rg5c****</para>
        /// </summary>
        [NameInMap("resId")]
        [Validation(Required=false)]
        public string ResId { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 1 to 500. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>The type of the machine on which the shipper is deployed. If you leave this parameter empty, shippers deployed on all types of machines are returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ECS</description></item>
        /// <item><description>ACK</description></item>
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
