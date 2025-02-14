// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateEnvironmentRequest : TeaModel {
        /// <summary>
        /// <para>Environment alias.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试环境</para>
        /// </summary>
        [NameInMap("alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        /// <summary>
        /// <para>Description of the environment, which can include information such as the purpose of the environment and its owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>这是xxx的xx项目测试环境</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Gateway ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cq7l5s5lhtgi6qasrdc0</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>Environment name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmycs5expl7oq</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
