// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAssetSelectionSelectedTargetResponseBody : TeaModel {
        /// <summary>
        /// <para>The data details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAssetSelectionSelectedTargetResponseBodyData> Data { get; set; }
        public class ListAssetSelectionSelectedTargetResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The asset ID. When selecting by machine, the value is the UUID of the machine. When selecting by group, the value is the group ID. When selecting by VPC, the value is the VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30****</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <para>The asset name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jen****</para>
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each API request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1EB12F73-6828-59D2-9FBF-F3713FD55128</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
