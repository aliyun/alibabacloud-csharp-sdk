// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class DeleteQualityRulesRequest : TeaModel {
        /// <summary>
        /// <para>The delete instruction.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeleteCommand")]
        [Validation(Required=false)]
        public DeleteQualityRulesRequestDeleteCommand DeleteCommand { get; set; }
        public class DeleteQualityRulesRequestDeleteCommand : TeaModel {
            /// <summary>
            /// <para>The rule IDs.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RuleIdList")]
            [Validation(Required=false)]
            public List<long?> RuleIdList { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

    }

}
