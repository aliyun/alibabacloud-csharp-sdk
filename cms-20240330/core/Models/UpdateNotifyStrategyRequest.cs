// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdateNotifyStrategyRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public NotifyStrategyForModify Body { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>workspace-test</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
