// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListImageBuildRiskItemResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListImageBuildRiskItemResponseBodyData> Data { get; set; }
        public class ListImageBuildRiskItemResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The type key of the risky build command.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key</para>
            /// </summary>
            [NameInMap("ItemKey")]
            [Validation(Required=false)]
            public string ItemKey { get; set; }

            /// <summary>
            /// <para>The type name of the risky build command.</para>
            /// 
            /// <b>Example:</b>
            /// <para>itemName.</para>
            /// </summary>
            [NameInMap("ItemName")]
            [Validation(Required=false)]
            public string ItemName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A3D7C47D-3F11-57BB-90E8-E5C20C619F37</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
