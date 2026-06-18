// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeTransformStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The monitoring data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeTransformStatusResponseBodyData Data { get; set; }
        public class DescribeTransformStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the task can be canceled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanCancel")]
            [Validation(Required=false)]
            public bool? CanCancel { get; set; }

            /// <summary>
            /// <para>Indicates whether the current task is completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanFinish")]
            [Validation(Required=false)]
            public bool? CanFinish { get; set; }

            /// <summary>
            /// <para>Indicates whether the migration switchover can be performed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The migration switchover can be performed.</description></item>
            /// <item><description><b>false</b>: The migration switchover cannot be performed.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is used by the one-click upgrade feature of PolarDB.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("CanSwitch")]
            [Validation(Required=false)]
            public bool? CanSwitch { get; set; }

            /// <summary>
            /// <para>Indicates whether the switchover operation can be reverted.</para>
            /// </summary>
            [NameInMap("CanUndoSwitch")]
            [Validation(Required=false)]
            public bool? CanUndoSwitch { get; set; }

            /// <summary>
            /// <para>The Enterprise Edition instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pxc-*****</para>
            /// </summary>
            [NameInMap("EnterpriseInsName")]
            [Validation(Required=false)]
            public string EnterpriseInsName { get; set; }

            /// <summary>
            /// <para>The current migration or upgrade phase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("Phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

            /// <summary>
            /// <para>The report summary.</para>
            /// </summary>
            [NameInMap("ReportSummary")]
            [Validation(Required=false)]
            public Dictionary<string, object> ReportSummary { get; set; }

            /// <summary>
            /// <para>The date when the data report was generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-09-02 16:52:47.0</para>
            /// </summary>
            [NameInMap("ReportTime")]
            [Validation(Required=false)]
            public long? ReportTime { get; set; }

            /// <summary>
            /// <para>The standard instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pxc-*****</para>
            /// </summary>
            [NameInMap("StandardInsName")]
            [Validation(Required=false)]
            public string StandardInsName { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>173CA69A-3513-591D-8A09-C1EA37CBE2D9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
