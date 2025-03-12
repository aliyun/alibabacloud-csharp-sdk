// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class UpdateProjectConfigRequest : TeaModel {
        [NameInMap("CommonTransferConfig")]
        [Validation(Required=false)]
        public UpdateProjectConfigRequestCommonTransferConfig CommonTransferConfig { get; set; }
        public class UpdateProjectConfigRequestCommonTransferConfig : TeaModel {
            [NameInMap("SinkStoreFormat")]
            [Validation(Required=false)]
            public string SinkStoreFormat { get; set; }

            [NameInMap("SourceStoreFormat")]
            [Validation(Required=false)]
            public string SourceStoreFormat { get; set; }

        }

        [NameInMap("FullTransferConfig")]
        [Validation(Required=false)]
        public UpdateProjectConfigRequestFullTransferConfig FullTransferConfig { get; set; }
        public class UpdateProjectConfigRequestFullTransferConfig : TeaModel {
            [NameInMap("IndexDDLConcurrencyLimit")]
            [Validation(Required=false)]
            public int? IndexDDLConcurrencyLimit { get; set; }

            [NameInMap("MaxConcurrentIndexDDLs")]
            [Validation(Required=false)]
            public int? MaxConcurrentIndexDDLs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("ReadWorkerNum")]
            [Validation(Required=false)]
            public int? ReadWorkerNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ThrottleIOPS")]
            [Validation(Required=false)]
            public int? ThrottleIOPS { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ThrottleRps")]
            [Validation(Required=false)]
            public int? ThrottleRps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("WriteWorkerNum")]
            [Validation(Required=false)]
            public int? WriteWorkerNum { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>np_fe****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("IncrTransferConfig")]
        [Validation(Required=false)]
        public UpdateProjectConfigRequestIncrTransferConfig IncrTransferConfig { get; set; }
        public class UpdateProjectConfigRequestIncrTransferConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("IncrSyncThreadCount")]
            [Validation(Required=false)]
            public int? IncrSyncThreadCount { get; set; }

            [NameInMap("RecordTypeWhiteList")]
            [Validation(Required=false)]
            public List<string> RecordTypeWhiteList { get; set; }

            [NameInMap("SupportDDLTypes")]
            [Validation(Required=false)]
            public List<string> SupportDDLTypes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ThrottleIOPS")]
            [Validation(Required=false)]
            public int? ThrottleIOPS { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ThrottleRps")]
            [Validation(Required=false)]
            public int? ThrottleRps { get; set; }

        }

        [NameInMap("ReverseIncrTransferConfig")]
        [Validation(Required=false)]
        public UpdateProjectConfigRequestReverseIncrTransferConfig ReverseIncrTransferConfig { get; set; }
        public class UpdateProjectConfigRequestReverseIncrTransferConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("IncrSyncThreadCount")]
            [Validation(Required=false)]
            public int? IncrSyncThreadCount { get; set; }

            [NameInMap("RecordTypeWhiteList")]
            [Validation(Required=false)]
            public List<string> RecordTypeWhiteList { get; set; }

            [NameInMap("SupportDDLTypes")]
            [Validation(Required=false)]
            public List<string> SupportDDLTypes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ThrottleIOPS")]
            [Validation(Required=false)]
            public int? ThrottleIOPS { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ThrottleRps")]
            [Validation(Required=false)]
            public int? ThrottleRps { get; set; }

        }

    }

}
