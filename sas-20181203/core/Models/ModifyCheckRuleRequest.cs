// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyCheckRuleRequest : TeaModel {
        [NameInMap("AddInstanceList")]
        [Validation(Required=false)]
        public List<ModifyCheckRuleRequestAddInstanceList> AddInstanceList { get; set; }
        public class ModifyCheckRuleRequestAddInstanceList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>i-wz9g8ljygfqs1ez3****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("DeleteInstanceList")]
        [Validation(Required=false)]
        public List<ModifyCheckRuleRequestDeleteInstanceList> DeleteInstanceList { get; set; }
        public class ModifyCheckRuleRequestDeleteInstanceList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>i-8vb0e8qdaj0yyxjo****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testRemark</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9000**</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>WHITE</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>INSTANCE</para>
        /// </summary>
        [NameInMap("ScopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

    }

}
