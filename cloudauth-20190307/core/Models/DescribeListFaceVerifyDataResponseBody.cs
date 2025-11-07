// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeListFaceVerifyDataResponseBody : TeaModel {
        /// <summary>
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("MonitorData")]
        [Validation(Required=false)]
        public DescribeListFaceVerifyDataResponseBodyMonitorData MonitorData { get; set; }
        public class DescribeListFaceVerifyDataResponseBodyMonitorData : TeaModel {
            /// <summary>
            /// <para>Face verification data.</para>
            /// </summary>
            [NameInMap("FaceVerifyData")]
            [Validation(Required=false)]
            public List<DescribeListFaceVerifyDataResponseBodyMonitorDataFaceVerifyData> FaceVerifyData { get; set; }
            public class DescribeListFaceVerifyDataResponseBodyMonitorDataFaceVerifyData : TeaModel {
                /// <summary>
                /// <para>Verification statistics time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-10-16T00:00:00.000Z</para>
                /// </summary>
                [NameInMap("ConDate")]
                [Validation(Required=false)]
                public string ConDate { get; set; }

                /// <summary>
                /// <para>Number of failed verifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("FailCnt")]
                [Validation(Required=false)]
                public string FailCnt { get; set; }

                /// <summary>
                /// <para>Verification scheme.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Liveness</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Scene ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000011644</para>
                /// </summary>
                [NameInMap("SceneId")]
                [Validation(Required=false)]
                public string SceneId { get; set; }

                /// <summary>
                /// <para>Number of successful verifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("SuccCnt")]
                [Validation(Required=false)]
                public string SuccCnt { get; set; }

                /// <summary>
                /// <para>Total number of verifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("TotalCnt")]
                [Validation(Required=false)]
                public string TotalCnt { get; set; }

            }

        }

        /// <summary>
        /// <para>ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EBD373EA-07FC-50BC-906F-B8950B6ED462</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
