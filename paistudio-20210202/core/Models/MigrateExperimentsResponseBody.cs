// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class MigrateExperimentsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>NO_PERMISSION</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public MigrateExperimentsResponseBodyData Data { get; set; }
        public class MigrateExperimentsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AlreadyExists")]
            [Validation(Required=false)]
            public bool? AlreadyExists { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>draft-8u3ck2or5pw2i4auhf</para>
            /// </summary>
            [NameInMap("ExperimentId")]
            [Validation(Required=false)]
            public string ExperimentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Updated")]
            [Validation(Required=false)]
            public bool? Updated { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NotExistError</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E7C42CC7-2E85-508A-84F4-923B605FD10F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
