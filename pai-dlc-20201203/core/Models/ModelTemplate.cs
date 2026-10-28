// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ModelTemplate : TeaModel {
        /// <summary>
        /// <para>The collection where the model template resides. Default value: QuickStartTemplate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>QuickStartTemplate</para>
        /// </summary>
        [NameInMap("Collections")]
        [Validation(Required=false)]
        public string Collections { get; set; }

        /// <summary>
        /// <para>The name of the model template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qwen3-VL-32B-Instruct-PAI_template</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The provider of the model template. Default value: pai, which indicates that the model template is officially provided by PAI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pai</para>
        /// </summary>
        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

    }

}
