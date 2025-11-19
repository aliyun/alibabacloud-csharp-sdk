// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class BrowserConfiguration : TeaModel {
        [NameInMap("browserType")]
        [Validation(Required=false)]
        public string BrowserType { get; set; }

        /// <summary>
        /// <para>要启用的浏览器扩展列表</para>
        /// </summary>
        [NameInMap("enableExtension")]
        [Validation(Required=false)]
        public List<string> EnableExtension { get; set; }

        /// <summary>
        /// <para>是否以无头模式运行浏览器</para>
        /// </summary>
        [NameInMap("headless")]
        [Validation(Required=false)]
        public bool? Headless { get; set; }

        /// <summary>
        /// <para>浏览器用户代理字符串</para>
        /// </summary>
        [NameInMap("userAgent")]
        [Validation(Required=false)]
        public string UserAgent { get; set; }

        [NameInMap("viewPort")]
        [Validation(Required=false)]
        public ViewPortConfiguration ViewPort { get; set; }

    }

}
