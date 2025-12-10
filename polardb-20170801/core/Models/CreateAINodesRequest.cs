// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateAINodesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>pm-xxxxxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("DBNodes")]
        [Validation(Required=false)]
        public List<CreateAINodesRequestDBNodes> DBNodes { get; set; }
        public class CreateAINodesRequestDBNodes : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>polar.mysql.g4.xlarge.gu10</para>
            /// </summary>
            [NameInMap("DBNodeClass")]
            [Validation(Required=false)]
            public string DBNodeClass { get; set; }

        }

    }

}
