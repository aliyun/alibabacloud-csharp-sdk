// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeTransformStatusResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeTransformStatusResponseBodyData Data { get; set; }
        public class DescribeTransformStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanCancel")]
            [Validation(Required=false)]
            public bool? CanCancel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanFinish")]
            [Validation(Required=false)]
            public bool? CanFinish { get; set; }

            [NameInMap("CanSwitch")]
            [Validation(Required=false)]
            public bool? CanSwitch { get; set; }

            [NameInMap("CanUndoSwitch")]
            [Validation(Required=false)]
            public bool? CanUndoSwitch { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pxc-*****</para>
            /// </summary>
            [NameInMap("EnterpriseInsName")]
            [Validation(Required=false)]
            public string EnterpriseInsName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("Phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

            [NameInMap("ReportSummary")]
            [Validation(Required=false)]
            public Dictionary<string, object> ReportSummary { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-09-02 16:52:47.0</para>
            /// </summary>
            [NameInMap("ReportTime")]
            [Validation(Required=false)]
            public long? ReportTime { get; set; }

            /// <summary>
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
