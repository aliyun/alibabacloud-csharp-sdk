// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CheckInstanceResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The data source ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>reso-*********</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Hologres</description></item>
        /// <item><description>EAS</description></item>
        /// <item><description>BE</description></item>
        /// <item><description>Rec</description></item>
        /// <item><description>Platform</description></item>
        /// <item><description>SLS</description></item>
        /// <item><description>DataHub</description></item>
        /// <item><description>Kafka</description></item>
        /// <item><description>Flinkvvp</description></item>
        /// <item><description>ACR</description></item>
        /// <item><description>OSS</description></item>
        /// <item><description>DataWorks</description></item>
        /// <item><description>PAI</description></item>
        /// <item><description>MaxCompute</description></item>
        /// <item><description>GraphCompute</description></item>
        /// <item><description>Redis</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The resource URI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bucket-test-123</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

    }

}
