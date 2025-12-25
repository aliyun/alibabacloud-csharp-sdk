// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateThreadRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("variables")]
        [Validation(Required=false)]
        public CreateThreadRequestVariables Variables { get; set; }
        public class CreateThreadRequestVariables : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>az_alipay</para>
            /// </summary>
            [NameInMap("project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rum-monitor-test-aysls-pub-cn-heyuan-monitor</para>
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

    }

}
