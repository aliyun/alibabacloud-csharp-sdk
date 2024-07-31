// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgDesensPlanAddOrUpdateRequest : TeaModel {
        /// <summary>
        /// A collection of data masking rules that you want to add or modify.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DesensRules")]
        [Validation(Required=false)]
        public List<DsgDesensPlanAddOrUpdateRequestDesensRules> DesensRules { get; set; }
        public class DsgDesensPlanAddOrUpdateRequestDesensRules : TeaModel {
            /// <summary>
            /// Specifies whether to add a watermark. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("CheckWatermark")]
            [Validation(Required=false)]
            public bool? CheckWatermark { get; set; }

            /// <summary>
            /// The sensitive field type.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// The data masking rule.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("DesensPlan")]
            [Validation(Required=false)]
            public DsgDesensPlanAddOrUpdateRequestDesensRulesDesensPlan DesensPlan { get; set; }
            public class DsgDesensPlanAddOrUpdateRequestDesensRulesDesensPlan : TeaModel {
                /// <summary>
                /// The masking method configured in the data masking rule. Valid values:
                /// 
                /// *   hash
                /// *   mapping
                /// *   mask
                /// *   charreplacement
                /// *   intervalselect
                /// *   decimalpoint
                /// *   emptydesens
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("DesensPlanType")]
                [Validation(Required=false)]
                public string DesensPlanType { get; set; }

                /// <summary>
                /// The parameters for the data masking rule.
                /// </summary>
                [NameInMap("ExtParam")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtParam { get; set; }

            }

            /// <summary>
            /// The ID of the data masking rule. You can call the [DsgDesensPlanQueryList](https://help.aliyun.com/document_detail/2786578.html) operation to query the ID of the data masking rule.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// The owner of the data masking rule.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// The name of the data masking rule.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The level-2 data masking scenario.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("SceneIds")]
            [Validation(Required=false)]
            public List<int?> SceneIds { get; set; }

            /// <summary>
            /// The status of the data masking rule. Valid values:
            /// 
            /// *   0: expired
            /// *   1: effective
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

    }

}
