// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class UpgradeColumnarVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpgradeColumnarVersionResponseBodyData Data { get; set; }
        public class UpgradeColumnarVersionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The target minor version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polardb-2.4.0_5.4.19-20250116_xcluster5.4.20-20241213</para>
            /// </summary>
            [NameInMap("MinorVersion")]
            [Validation(Required=false)]
            public string MinorVersion { get; set; }

            /// <summary>
            /// <para>The list of upgrade tasks.</para>
            /// </summary>
            [NameInMap("TaskList")]
            [Validation(Required=false)]
            public List<UpgradeColumnarVersionResponseBodyDataTaskList> TaskList { get; set; }
            public class UpgradeColumnarVersionResponseBodyDataTaskList : TeaModel {
                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-uf68f345****88zf8</para>
                /// </summary>
                [NameInMap("DbInstanceName")]
                [Validation(Required=false)]
                public string DbInstanceName { get; set; }

                /// <summary>
                /// <para>The ID of the target task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2209883</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public int? TaskId { get; set; }

            }

        }

        /// <summary>
        /// <para>The message returned for the request.</para>
        /// 
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
        /// <para>AE4F6C34-****-45AA-B5DC-4B8D816F6305</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
