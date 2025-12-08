// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DetectLivingFaceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectLivingFaceResponseBodyData Data { get; set; }
        public class DetectLivingFaceResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<DetectLivingFaceResponseBodyDataElements> Elements { get; set; }
            public class DetectLivingFaceResponseBodyDataElements : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FaceNumber")]
                [Validation(Required=false)]
                public long? FaceNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/facebody/DetectLivingFace/DetectLivingFace4.jpg">http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/facebody/DetectLivingFace/DetectLivingFace4.jpg</a></para>
                /// </summary>
                [NameInMap("ImageURL")]
                [Validation(Required=false)]
                public string ImageURL { get; set; }

                [NameInMap("Results")]
                [Validation(Required=false)]
                public List<DetectLivingFaceResponseBodyDataElementsResults> Results { get; set; }
                public class DetectLivingFaceResponseBodyDataElementsResults : TeaModel {
                    [NameInMap("Frames")]
                    [Validation(Required=false)]
                    public List<DetectLivingFaceResponseBodyDataElementsResultsFrames> Frames { get; set; }
                    public class DetectLivingFaceResponseBodyDataElementsResultsFrames : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>84.83</para>
                        /// </summary>
                        [NameInMap("Rate")]
                        [Validation(Required=false)]
                        public float? Rate { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="http://aligreen-shanghai.oss-cn-shanghai.aliyuncs.com/prod/hammal/26210da42/28118541_TB1urBOQFXXXXbMXFXXXXXXXXXX-1442-257.png?Expires=1582703593&OSSAccessKeyId=H4sp5QfNbuDg****&Signature=%2B8iUkb5YjomYR8ujV2c8wMAavs****&x-oss-process=image%2Fcrop%2Cx_0%2Cw_288%2Fauto-orient%2C0">http://aligreen-shanghai.oss-cn-shanghai.aliyuncs.com/prod/hammal/26210da42/28118541_TB1urBOQFXXXXbMXFXXXXXXXXXX-1442-257.png?Expires=1582703593&amp;OSSAccessKeyId=H4sp5QfNbuDg****&amp;Signature=%2B8iUkb5YjomYR8ujV2c8wMAavs****&amp;x-oss-process=image%2Fcrop%2Cx_0%2Cw_288%2Fauto-orient%2C0</a></para>
                        /// </summary>
                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>liveness</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>blurred, occluded or large angle face, please check.</para>
                    /// </summary>
                    [NameInMap("MessageTips")]
                    [Validation(Required=false)]
                    public string MessageTips { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>76.22</para>
                    /// </summary>
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public float? Rate { get; set; }

                    [NameInMap("Rect")]
                    [Validation(Required=false)]
                    public DetectLivingFaceResponseBodyDataElementsResultsRect Rect { get; set; }
                    public class DetectLivingFaceResponseBodyDataElementsResultsRect : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>60</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public long? Height { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>20</para>
                        /// </summary>
                        [NameInMap("Left")]
                        [Validation(Required=false)]
                        public long? Left { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("Top")]
                        [Validation(Required=false)]
                        public long? Top { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>50</para>
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public long? Width { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>review</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>img1owc8WGskNm78OEAPJTZal-1****</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2EEA0396-BD84-5729-B8BD-D60776FCEF2B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
