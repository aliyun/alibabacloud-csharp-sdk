// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ExecuteAutoDisposeRecordsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("SelectedEntityList")]
        [Validation(Required=false)]
        public List<ExecuteAutoDisposeRecordsRequestSelectedEntityList> SelectedEntityList { get; set; }
        public class ExecuteAutoDisposeRecordsRequestSelectedEntityList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0000089b040b8935fed2e24ca2ec8335</para>
            /// </summary>
            [NameInMap("AutoDisposeRecordId")]
            [Validation(Required=false)]
            public string AutoDisposeRecordId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9938fc2708ddc7b7651f3a19e4f09962</para>
            /// </summary>
            [NameInMap("EntityUuid")]
            [Validation(Required=false)]
            public string EntityUuid { get; set; }

        }

        [NameInMap("UnSelectedEntityList")]
        [Validation(Required=false)]
        public List<ExecuteAutoDisposeRecordsRequestUnSelectedEntityList> UnSelectedEntityList { get; set; }
        public class ExecuteAutoDisposeRecordsRequestUnSelectedEntityList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0000089b040b8935fed2e24ca2ec8335</para>
            /// </summary>
            [NameInMap("AutoDisposeRecordId")]
            [Validation(Required=false)]
            public string AutoDisposeRecordId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ae6ac3e1c9ada174eb8dadd029a2e9d1</para>
            /// </summary>
            [NameInMap("EntityUuid")]
            [Validation(Required=false)]
            public string EntityUuid { get; set; }

        }

    }

}
