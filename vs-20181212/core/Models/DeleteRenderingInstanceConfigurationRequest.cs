// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DeleteRenderingInstanceConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The configuration content. By default, all configured modules are cleared.</para>
        /// </summary>
        [NameInMap("Configuration")]
        [Validation(Required=false)]
        public List<DeleteRenderingInstanceConfigurationRequestConfiguration> Configuration { get; set; }
        public class DeleteRenderingInstanceConfigurationRequestConfiguration : TeaModel {
            /// <summary>
            /// <para>The list of attribute names whose configurations are to be cleared. By default, all configured attributes of the module are cleared.</para>
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
        /// <para>The cloud application service instance ID.</para>
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
