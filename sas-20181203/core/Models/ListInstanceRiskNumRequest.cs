// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListInstanceRiskNumRequest : TeaModel {
        /// <summary>
        /// <para>The instance list.</para>
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<ListInstanceRiskNumRequestInstanceList> InstanceList { get; set; }
        public class ListInstanceRiskNumRequestInstanceList : TeaModel {
            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-wz9fdluqx20mp2x7****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The UUID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/141932.html">DescribeCloudCenterInstances</a> operation to obtain the UUID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f2d6e901-1004-4ca8-9dae-53ec04a9****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
