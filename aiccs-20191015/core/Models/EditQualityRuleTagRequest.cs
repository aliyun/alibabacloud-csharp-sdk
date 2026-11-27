// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class EditQualityRuleTagRequest : TeaModel {
        /// <summary>
        /// <para>The parsing types.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AnalysisTypes")]
        [Validation(Required=false)]
        public List<EditQualityRuleTagRequestAnalysisTypes> AnalysisTypes { get; set; }
        public class EditQualityRuleTagRequestAnalysisTypes : TeaModel {
            /// <summary>
            /// <para>The ID of the rule tag. Default value: null.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the rule tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>639</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>Instance ID of the AICCS instance. You can obtain instance ID from the Artificial Intelligence Cloud Call Service console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
