// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class AppOperateAction : TeaModel {
        /// <summary>
        /// <para>The key used to uniquely identify an action.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BeginDialogue</para>
        /// </summary>
        [NameInMap("ActionKey")]
        [Validation(Required=false)]
        public string ActionKey { get; set; }

        /// <summary>
        /// <para>The text used to display the action name in the user interface.</para>
        /// </summary>
        [NameInMap("ActionText")]
        [Validation(Required=false)]
        public string ActionText { get; set; }

        /// <summary>
        /// <para>Indicates whether the action is available.</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The URL to navigate to when the action is clicked.</para>
        /// </summary>
        [NameInMap("Href")]
        [Validation(Required=false)]
        public string Href { get; set; }

    }

}
