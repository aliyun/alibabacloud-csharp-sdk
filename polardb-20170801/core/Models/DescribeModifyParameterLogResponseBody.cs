// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeModifyParameterLogResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>polardb_mysql</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeModifyParameterLogResponseBodyItems> Items { get; set; }
        public class DescribeModifyParameterLogResponseBodyItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-10-29T09:31:37Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test01</para>
            /// </summary>
            [NameInMap("NewParameterValue")]
            [Validation(Required=false)]
            public string NewParameterValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("OldParameterValue")]
            [Validation(Required=false)]
            public string OldParameterValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hz</para>
            /// </summary>
            [NameInMap("ParameterName")]
            [Validation(Required=false)]
            public string ParameterName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD35F3-F3-44CA-AFFF-BAF869******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
