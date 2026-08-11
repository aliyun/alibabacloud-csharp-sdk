// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class FilesConfigVariablesValue : TeaModel {
        /// <summary>
        /// <para>变量描述</para>
        /// 
        /// <b>Example:</b>
        /// <para>自定义变量</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>是否可被用户修改</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("disableModify")]
        [Validation(Required=false)]
        public bool? DisableModify { get; set; }

        /// <summary>
        /// <para>变量是否被修改过</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isModify")]
        [Validation(Required=false)]
        public bool? IsModify { get; set; }

        /// <summary>
        /// <para>类型：普通变量-NORMAL； function变量-FUNCTION</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>变量值</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
