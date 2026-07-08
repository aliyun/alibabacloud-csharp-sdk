// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeRenderingInstanceConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The configuration to query. By default, the configurations of all modules are returned.</para>
        /// </summary>
        [NameInMap("Configuration")]
        [Validation(Required=false)]
        public List<DescribeRenderingInstanceConfigurationRequestConfiguration> Configuration { get; set; }
        public class DescribeRenderingInstanceConfigurationRequestConfiguration : TeaModel {
            /// <summary>
            /// <para>The list of attribute names to query. By default, all attributes are returned.</para>
            /// </summary>
            [NameInMap("AttributeNames")]
            [Validation(Required=false)]
            public List<string> AttributeNames { get; set; }

            /// <summary>
            /// <para>The name of the module.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>location</para>
            /// </summary>
            [NameInMap("ModuleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the cloud application service instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
        /// </summary>
        [NameInMap("RenderingInstanceId")]
        [Validation(Required=false)]
        public string RenderingInstanceId { get; set; }

    }

}
