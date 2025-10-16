// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyThreatIntelligenceSwitchRequest : TeaModel {
        [NameInMap("CategoryList")]
        [Validation(Required=false)]
        public List<ModifyThreatIntelligenceSwitchRequestCategoryList> CategoryList { get; set; }
        public class ModifyThreatIntelligenceSwitchRequestCategoryList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>alert</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>IpOutThreatTorExit</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public string CategoryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EnableStatus")]
            [Validation(Required=false)]
            public string EnableStatus { get; set; }

        }

    }

}
