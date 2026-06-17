// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeCrossCloudRegionRequest : TeaModel {
        /// <summary>
        /// <para>The cloud service provider. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>HuaweiCloud</para>
        /// </description></item>
        /// <item><description><para>Azure</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HuaweiCloud</para>
        /// </summary>
        [NameInMap("CloudProvider")]
        [Validation(Required=false)]
        public string CloudProvider { get; set; }

        /// <summary>
        /// <para>The ID of the third-party cloud region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-east-3</para>
        /// </summary>
        [NameInMap("CrossCloudRegionId")]
        [Validation(Required=false)]
        public string CrossCloudRegionId { get; set; }

        /// <summary>
        /// <para>The database engine type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>MySQL</para>
        /// </description></item>
        /// <item><description><para>PostgreSQL</para>
        /// </description></item>
        /// <item><description><para>Oracle</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

    }

}
