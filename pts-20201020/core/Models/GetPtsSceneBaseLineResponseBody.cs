// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class GetPtsSceneBaseLineResponseBody : TeaModel {
        /// <summary>
        /// <para>Baseline data</para>
        /// </summary>
        [NameInMap("Baseline")]
        [Validation(Required=false)]
        public GetPtsSceneBaseLineResponseBodyBaseline Baseline { get; set; }
        public class GetPtsSceneBaseLineResponseBodyBaseline : TeaModel {
            /// <summary>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ApiBaselines")]
            [Validation(Required=false)]
            public List<GetPtsSceneBaseLineResponseBodyBaselineApiBaselines> ApiBaselines { get; set; }
            public class GetPtsSceneBaseLineResponseBodyBaselineApiBaselines : TeaModel {
                /// <summary>
                /// <para>Average RT</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("AvgRt")]
                [Validation(Required=false)]
                public float? AvgRt { get; set; }

                /// <summary>
                /// <para>null</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("AvgTps")]
                [Validation(Required=false)]
                public float? AvgTps { get; set; }

                /// <summary>
                /// <para>null</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("FailCountBiz")]
                [Validation(Required=false)]
                public long? FailCountBiz { get; set; }

                /// <summary>
                /// <para>Failures</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("FailCountReq")]
                [Validation(Required=false)]
                public long? FailCountReq { get; set; }

                /// <summary>
                /// <para>The API ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>76543</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>null</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("MaxRt")]
                [Validation(Required=false)]
                public int? MaxRt { get; set; }

                /// <summary>
                /// <para>null</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("MinRt")]
                [Validation(Required=false)]
                public int? MinRt { get; set; }

                /// <summary>
                /// <para>The name of the API operation.</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>null</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("Seg90Rt")]
                [Validation(Required=false)]
                public float? Seg90Rt { get; set; }

                /// <summary>
                /// <para>null</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Seg99Rt")]
                [Validation(Required=false)]
                public float? Seg99Rt { get; set; }

                /// <summary>
                /// <para>null</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("SuccessRateBiz")]
                [Validation(Required=false)]
                public float? SuccessRateBiz { get; set; }

                /// <summary>
                /// <para>request success rate</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.9</para>
                /// </summary>
                [NameInMap("SuccessRateReq")]
                [Validation(Required=false)]
                public float? SuccessRateReq { get; set; }

            }

            /// <summary>
            /// <para>Scenario</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>null</para>
            /// </summary>
            [NameInMap("SceneBaseline")]
            [Validation(Required=false)]
            public GetPtsSceneBaseLineResponseBodyBaselineSceneBaseline SceneBaseline { get; set; }
            public class GetPtsSceneBaseLineResponseBodyBaselineSceneBaseline : TeaModel {
                /// <summary>
                /// <para>Average RT</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("AvgRt")]
                [Validation(Required=false)]
                public float? AvgRt { get; set; }

                /// <summary>
                /// <para>null</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("AvgTps")]
                [Validation(Required=false)]
                public float? AvgTps { get; set; }

                /// <summary>
                /// <para>null</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("FailCountBiz")]
                [Validation(Required=false)]
                public long? FailCountBiz { get; set; }

                /// <summary>
                /// <para>Failures</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("FailCountReq")]
                [Validation(Required=false)]
                public long? FailCountReq { get; set; }

                /// <summary>
                /// <para>null</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Seg90Rt")]
                [Validation(Required=false)]
                public float? Seg90Rt { get; set; }

                /// <summary>
                /// <para>null</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Seg99Rt")]
                [Validation(Required=false)]
                public float? Seg99Rt { get; set; }

                /// <summary>
                /// <para>null</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("SuccessRateBiz")]
                [Validation(Required=false)]
                public float? SuccessRateBiz { get; set; }

                /// <summary>
                /// <para>request success rate</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.9</para>
                /// </summary>
                [NameInMap("SuccessRateReq")]
                [Validation(Required=false)]
                public float? SuccessRateReq { get; set; }

            }

        }

        /// <summary>
        /// <para>The system status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4F7D2CE0-AE4C-4143-955A-8E4595AF86A6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the scene.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NHG67BF</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false:</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
