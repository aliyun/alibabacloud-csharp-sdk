// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateGatewayRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable Internet access. Default value: false.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>false</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableInternet")]
        [Validation(Required=false)]
        public bool? EnableInternet { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable internal network access. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableIntranet")]
        [Validation(Required=false)]
        public bool? EnableIntranet { get; set; }

        /// <summary>
        /// <para>The instance type used for the private gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c6.4xlarge</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>Indicates whether it is the default private gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsDefault")]
        [Validation(Required=false)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// <para>The private gateway alias.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mygateway1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of nodes in the private gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

    }

}
