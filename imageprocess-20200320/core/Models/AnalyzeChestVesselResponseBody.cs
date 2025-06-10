// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class AnalyzeChestVesselResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AnalyzeChestVesselResponseBodyData Data { get; set; }
        public class AnalyzeChestVesselResponseBodyData : TeaModel {
            [NameInMap("AortaInfo")]
            [Validation(Required=false)]
            public AnalyzeChestVesselResponseBodyDataAortaInfo AortaInfo { get; set; }
            public class AnalyzeChestVesselResponseBodyDataAortaInfo : TeaModel {
                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Area")]
                [Validation(Required=false)]
                public List<float?> Area { get; set; }

                [NameInMap("Coordinates")]
                [Validation(Required=false)]
                public List<List<float?>> Coordinates { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("LabelValue")]
                [Validation(Required=false)]
                public long? LabelValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2722</para>
                /// </summary>
                [NameInMap("MaxArea")]
                [Validation(Required=false)]
                public float? MaxArea { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>416</para>
                /// </summary>
                [NameInMap("MaxAreaIndex")]
                [Validation(Required=false)]
                public long? MaxAreaIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>63</para>
                /// </summary>
                [NameInMap("MaxDiameter")]
                [Validation(Required=false)]
                public float? MaxDiameter { get; set; }

            }

            [NameInMap("PulmonaryInfo")]
            [Validation(Required=false)]
            public AnalyzeChestVesselResponseBodyDataPulmonaryInfo PulmonaryInfo { get; set; }
            public class AnalyzeChestVesselResponseBodyDataPulmonaryInfo : TeaModel {
                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Area")]
                [Validation(Required=false)]
                public List<float?> Area { get; set; }

                [NameInMap("Coordinates")]
                [Validation(Required=false)]
                public List<List<float?>> Coordinates { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LabelValue")]
                [Validation(Required=false)]
                public long? LabelValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>928</para>
                /// </summary>
                [NameInMap("MaxArea")]
                [Validation(Required=false)]
                public float? MaxArea { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxAreaIndex")]
                [Validation(Required=false)]
                public long? MaxAreaIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>42</para>
                /// </summary>
                [NameInMap("MaxDiameter")]
                [Validation(Required=false)]
                public float? MaxDiameter { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2439</para>
                /// </summary>
                [NameInMap("NearestAortaArea")]
                [Validation(Required=false)]
                public float? NearestAortaArea { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/ct_artery_aa_ph/local_test/2021-07-08/6C4713DF-F548-47DF-A456-5DA1C8334444_result_compressed.tgz?Expires=1625732732&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSR****&Signature=5UKVmLfM7GWllIcPr9a6dKz%2B5h">http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/ct_artery_aa_ph/local_test/2021-07-08/6C4713DF-F548-47DF-A456-5DA1C8334444_result_compressed.tgz?Expires=1625732732&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSR****&amp;Signature=5UKVmLfM7GWllIcPr9a6dKz%2B5h</a>****</para>
            /// </summary>
            [NameInMap("ResultURL")]
            [Validation(Required=false)]
            public string ResultURL { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B87D013B-F25F-47DC-ABE1-440F4837AFD2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
