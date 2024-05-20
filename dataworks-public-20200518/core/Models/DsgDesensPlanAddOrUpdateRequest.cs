// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgDesensPlanAddOrUpdateRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DesensRules")]
        [Validation(Required=false)]
        public List<DsgDesensPlanAddOrUpdateRequestDesensRules> DesensRules { get; set; }
        public class DsgDesensPlanAddOrUpdateRequestDesensRules : TeaModel {
            [NameInMap("CheckWatermark")]
            [Validation(Required=false)]
            public bool? CheckWatermark { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("DesensPlan")]
            [Validation(Required=false)]
            public DsgDesensPlanAddOrUpdateRequestDesensRulesDesensPlan DesensPlan { get; set; }
            public class DsgDesensPlanAddOrUpdateRequestDesensRulesDesensPlan : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("DesensPlanType")]
                [Validation(Required=false)]
                public string DesensPlanType { get; set; }

                [NameInMap("ExtParam")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtParam { get; set; }

            }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("SceneIds")]
            [Validation(Required=false)]
            public List<int?> SceneIds { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

    }

}
