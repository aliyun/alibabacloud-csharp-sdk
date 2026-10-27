// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetAddonSchemaRequest : TeaModel {
        /// <summary>
        /// <para>The language environment. Default value: zh. Valid values: zh, en.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("aliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// <para>The add-on catalog version. Valid values: v1, v2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2</para>
        /// </summary>
        [NameInMap("apiVersion")]
        [Validation(Required=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// <para>The environment type. Valid values: CS (container), ECS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CS</para>
        /// </summary>
        [NameInMap("environmentType")]
        [Validation(Required=false)]
        public string EnvironmentType { get; set; }

        /// <summary>
        /// <para>The component version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.1.1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
