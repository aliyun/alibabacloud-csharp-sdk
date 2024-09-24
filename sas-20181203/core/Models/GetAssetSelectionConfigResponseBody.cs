// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAssetSelectionConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAssetSelectionConfigResponseBodyData Data { get; set; }
        public class GetAssetSelectionConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the current asset selection. It can be used to query and modify the asset that is selected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>657c8411-4e89-446c-ab66-d45d1331****</para>
            /// </summary>
            [NameInMap("SelectionKey")]
            [Validation(Required=false)]
            public string SelectionKey { get; set; }

            /// <summary>
            /// <para>The dimension based on which the asset is selected. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>instance</b>: The asset is selected by server.</description></item>
            /// <item><description><b>group</b>: The asset is selected by group.</description></item>
            /// <item><description><b>vpc</b>: The asset is selected by VPC.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>instance</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C5936B67-3EDF-53ED-A542-02543972449A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
