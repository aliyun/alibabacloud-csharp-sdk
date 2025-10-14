// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class UpgradeCDCVersionResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpgradeCDCVersionResponseBodyData Data { get; set; }
        public class UpgradeCDCVersionResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>polardb-2.4.0_5.4.19-20250116_xcluster5.4.20-20241213</para>
            /// </summary>
            [NameInMap("MinorVersion")]
            [Validation(Required=false)]
            public string MinorVersion { get; set; }

            [NameInMap("TaskList")]
            [Validation(Required=false)]
            public List<UpgradeCDCVersionResponseBodyDataTaskList> TaskList { get; set; }
            public class UpgradeCDCVersionResponseBodyDataTaskList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>rm-uf68f345****88zf8</para>
                /// </summary>
                [NameInMap("DbInstanceName")]
                [Validation(Required=false)]
                public string DbInstanceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1861190497624654848</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public int? TaskId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB4307F5-3D04-51E8-ABAD-49E0B3F962FC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
