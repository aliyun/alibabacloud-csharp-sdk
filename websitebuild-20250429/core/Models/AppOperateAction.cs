// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class AppOperateAction : TeaModel {
        /// <summary>
        /// <para>用于唯一标识一个操作行为</para>
        /// </summary>
        [NameInMap("ActionKey")]
        [Validation(Required=false)]
        public string ActionKey { get; set; }

        /// <summary>
        /// <para>用于在界面中展示操作名称</para>
        /// </summary>
        [NameInMap("ActionText")]
        [Validation(Required=false)]
        public string ActionText { get; set; }

        /// <summary>
        /// <para>标识该操作是否可用</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>点击操作时跳转的URL地址</para>
        /// </summary>
        [NameInMap("Href")]
        [Validation(Required=false)]
        public string Href { get; set; }

    }

}
