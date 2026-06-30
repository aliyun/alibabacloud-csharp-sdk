// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class NextNodeSituations : TeaModel {
        /// <summary>
        /// <para>Judgment Conditions</para>
        /// </summary>
        [NameInMap("ConditionGroup")]
        [Validation(Required=false)]
        public List<NextNodeSituationsConditionGroup> ConditionGroup { get; set; }
        public class NextNodeSituationsConditionGroup : TeaModel {
            /// <summary>
            /// <para>Collection of matching conditions</para>
            /// </summary>
            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public List<JudgeNodeMetaDesc> Conditions { get; set; }

            /// <summary>
            /// <para>The matching relationship between conditions</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The matching relationship between conditions: currently all are OR relationships.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
