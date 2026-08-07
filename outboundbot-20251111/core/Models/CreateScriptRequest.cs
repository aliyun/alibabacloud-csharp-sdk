// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class CreateScriptRequest : TeaModel {
        /// <summary>
        /// <para>描述</para>
        /// 
        /// <b>Example:</b>
        /// <para>用于测试</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>实例ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试场景</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>NLU引擎类型</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEEBOT</para>
        /// </summary>
        [NameInMap("NluEngine")]
        [Validation(Required=false)]
        public string NluEngine { get; set; }

    }

}
