// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetImageDistributeInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code of the API. A value of 200 indicates success. If the call fails, the corresponding error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The image information returned by the query.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetImageDistributeInfoResponseBodyData Data { get; set; }
        public class GetImageDistributeInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of region distribution information for the image version.</para>
            /// </summary>
            [NameInMap("ImageRegionDistributeList")]
            [Validation(Required=false)]
            public List<GetImageDistributeInfoResponseBodyDataImageRegionDistributeList> ImageRegionDistributeList { get; set; }
            public class GetImageDistributeInfoResponseBodyDataImageRegionDistributeList : TeaModel {
                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the image belongs. The account ID for a system image is 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456789</para>
                /// </summary>
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public long? AliUid { get; set; }

                /// <summary>
                /// <para>The ID of the ECS image corresponding to the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m-bp1example****</para>
                /// </summary>
                [NameInMap("EcsImageId")]
                [Validation(Required=false)]
                public string EcsImageId { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-04-25 15:13:57</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The last update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-04-25 15:13:57</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The image ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>imgc-xxxx</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The processing information reported by the region distribution task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The distribution progress of the image in the region, expressed as a percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// <para>The ID of the region to which the image is distributed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The region distribution status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AVAILABLE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The logical ID of the image on the unit side, which can be different from the central image ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m-1bdedef****</para>
                /// </summary>
                [NameInMap("UnitImageId")]
                [Validation(Required=false)]
                public string UnitImageId { get; set; }

                /// <summary>
                /// <para>The image version ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>iv-xxx</para>
                /// </summary>
                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

            }

            /// <summary>
            /// <para>The list of region IDs supported by the image.</para>
            /// </summary>
            [NameInMap("ImageRegionList")]
            [Validation(Required=false)]
            public List<string> ImageRegionList { get; set; }

            /// <summary>
            /// <para>The source of the image. For example, center indicates the central image service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>center</para>
            /// </summary>
            [NameInMap("ImageSource")]
            [Validation(Required=false)]
            public string ImageSource { get; set; }

        }

        /// <summary>
        /// <para>The processing information returned by the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8737D130-BFD0-5D51-96F6-C08EB1139A25</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful. Valid values: true: Successful. false: Failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
