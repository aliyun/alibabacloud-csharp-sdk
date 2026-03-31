// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the marker after which the returned list begins.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cHlvZHBzX3VkZl8xMDExNV8xNDU3NDI4NDkzKg==</para>
        /// </summary>
        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxItem")]
        [Validation(Required=false)]
        public int? MaxItem { get; set; }

        /// <summary>
        /// <para>The name of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>res</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The name of the schema.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("schemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

    }

}
