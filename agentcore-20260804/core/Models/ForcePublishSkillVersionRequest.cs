// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ForcePublishSkillVersionRequest : TeaModel {
        /// <summary>
        /// <para>The request body.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public ForcePublishSkillVersionRequestBody Body { get; set; }
        public class ForcePublishSkillVersionRequestBody : TeaModel {
            /// <summary>
            /// <para>The commit message recorded on the release version produced by this publish operation. Takes effect in HEAD draft mode. If left empty, the draft message is used. Ignored in version Draft mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>First release version</para>
            /// </summary>
            [NameInMap("commitMsg")]
            [Validation(Required=false)]
            public string CommitMsg { get; set; }

            /// <summary>
            /// <para>Specifies whether to update the latest label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("updateLatestLabel")]
            [Validation(Required=false)]
            public bool? UpdateLatestLabel { get; set; }

        }

    }

}
