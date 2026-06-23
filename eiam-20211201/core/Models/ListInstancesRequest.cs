// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListInstancesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>disabled</para>
        /// </summary>
        [NameInMap("CrossRegionReplication")]
        [Validation(Required=false)]
        public string CrossRegionReplication { get; set; }

        /// <summary>
        /// <para>The license edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>free: Free Edition.</description></item>
        /// <item><description>trial: Trial Edition.</description></item>
        /// <item><description>scalability: Capability Expansion Edition.</description></item>
        /// <item><description>standard: Standard Edition.</description></item>
        /// <item><description>enterprise: Enterprise Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>free</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>The list of instance IDs.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>creating: Being created.</description></item>
        /// <item><description>running: Running.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
