// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeLakebaseMountParameterGroupChangeLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The change logs, sorted in descending order by CreateTime. An empty array is returned if no data is found.</para>
        /// </summary>
        [NameInMap("ChangeLogs")]
        [Validation(Required=false)]
        public List<DescribeLakebaseMountParameterGroupChangeLogsResponseBodyChangeLogs> ChangeLogs { get; set; }
        public class DescribeLakebaseMountParameterGroupChangeLogsResponseBodyChangeLogs : TeaModel {
            /// <summary>
            /// <para>The change type. Valid values: create, modify, and delete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>modify</para>
            /// </summary>
            [NameInMap("ChangeType")]
            [Validation(Required=false)]
            public string ChangeType { get; set; }

            /// <summary>
            /// <para>The creation time (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-07T12:00:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the user who performed the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>Indicates whether the change is applied. Valid values: 0: No. 1: Yes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsApply")]
            [Validation(Required=false)]
            public string IsApply { get; set; }

            /// <summary>
            /// <para>The modification time (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-08T12:00:00Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The new value after the change. This value is empty if the change type is delete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NewValue")]
            [Validation(Required=false)]
            public string NewValue { get; set; }

            /// <summary>
            /// <para>The old value before the change. This value is empty if the change type is create.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OldValue")]
            [Validation(Required=false)]
            public string OldValue { get; set; }

            /// <summary>
            /// <para>The parameter name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>auto_increment_offset</para>
            /// </summary>
            [NameInMap("ParameterName")]
            [Validation(Required=false)]
            public string ParameterName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F45FFACC-xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
