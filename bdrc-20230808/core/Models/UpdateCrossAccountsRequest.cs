// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class UpdateCrossAccountsRequest : TeaModel {
        [NameInMap("CreateTargets")]
        [Validation(Required=false)]
        public List<UpdateCrossAccountsRequestCreateTargets> CreateTargets { get; set; }
        public class UpdateCrossAccountsRequestCreateTargets : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123***7890</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACCOUNT</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

        [NameInMap("DeleteTargets")]
        [Validation(Required=false)]
        public List<UpdateCrossAccountsRequestDeleteTargets> DeleteTargets { get; set; }
        public class UpdateCrossAccountsRequestDeleteTargets : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123***7890</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACCOUNT</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

    }

}
