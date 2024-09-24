// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateAssetSelectionConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateAssetSelectionConfigResponseBodyData Data { get; set; }
        public class CreateAssetSelectionConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The business type that is selected for the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>VIRUS_SCAN_CYCLE_CONFIG</b>: virus detection configuration</description></item>
            /// <item><description><b>VIRUS_SCAN_ONCE_TASK</b>: one-time scan for virus detection</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VIRUS_SCAN_CYCLE_CONFIG</para>
            /// </summary>
            [NameInMap("BusinessType")]
            [Validation(Required=false)]
            public string BusinessType { get; set; }

            /// <summary>
            /// <para>The ID of the current asset selection. It can be used to query and modify the asset that is selected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>53e93435-d694-4c03-9ce7-da12bee1****</para>
            /// </summary>
            [NameInMap("SelectionKey")]
            [Validation(Required=false)]
            public long? SelectionKey { get; set; }

            /// <summary>
            /// <para>The dimension based on which the asset is selected. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>group</b>: The asset is selected by server.</description></item>
            /// <item><description><b>group</b>: The asset is selected by group.</description></item>
            /// <item><description><b>vpc</b>: The asset is selected by VPC.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>group</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

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
