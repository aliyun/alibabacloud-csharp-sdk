// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class MerchandiseSceneDetectionResponseBody : Darabonba.Model {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The display scene detection result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public MerchandiseSceneDetectionResponseBodyData Data { get; set; }
        public class MerchandiseSceneDetectionResponseBodyData : Darabonba.Model {
            /// <summary>
            /// <para>The details of the display scene detection result.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public MerchandiseSceneDetectionResponseBodyDataResult Result { get; set; }
            public class MerchandiseSceneDetectionResponseBodyDataResult : Darabonba.Model {
                /// <summary>
                /// <para>The positioning information.</para>
                /// </summary>
                [NameInMap("Grounding")]
                [Validation(Required=false)]
                public MerchandiseSceneDetectionResponseBodyDataResultGrounding Grounding { get; set; }
                public class MerchandiseSceneDetectionResponseBodyDataResultGrounding : Darabonba.Model {
                    /// <summary>
                    /// <para>The coverage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>complete</para>
                    /// </summary>
                    [NameInMap("Coverage")]
                    [Validation(Required=false)]
                    public string Coverage { get; set; }

                    /// <summary>
                    /// <para>The list of regions.</para>
                    /// </summary>
                    [NameInMap("Regions")]
                    [Validation(Required=false)]
                    public List<MerchandiseSceneDetectionResponseBodyDataResultGroundingRegions> Regions { get; set; }
                    public class MerchandiseSceneDetectionResponseBodyDataResultGroundingRegions : Darabonba.Model {
                        /// <summary>
                        /// <para>The 2D bounding box in the format of [top-left x, top-left y, bottom-right x, bottom-right y]. Valid values: 0 to 1000. The left coordinate must be less than the right coordinate, and the top coordinate must be less than the bottom coordinate.</para>
                        /// </summary>
                        [NameInMap("Bbox_2d")]
                        [Validation(Required=false)]
                        public List<double?> Bbox2d { get; set; }

                        /// <summary>
                        /// <para>The label.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>shelf</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The recognized text.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Multi-tier product display shelf</para>
                        /// </summary>
                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                    }

                }

                /// <summary>
                /// <para>The list of recognized scenes.</para>
                /// </summary>
                [NameInMap("Scenes")]
                [Validation(Required=false)]
                public List<MerchandiseSceneDetectionResponseBodyDataResultScenes> Scenes { get; set; }
                public class MerchandiseSceneDetectionResponseBodyDataResultScenes : Darabonba.Model {
                    /// <summary>
                    /// <para>Optional. The area proportion.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.985</para>
                    /// </summary>
                    [NameInMap("AreaRate")]
                    [Validation(Required=false)]
                    public double? AreaRate { get; set; }

                    /// <summary>
                    /// <para>Optional. The purity metric for proprietary products. The specific business criteria are subject to the recognition service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("OwnPurity")]
                    [Validation(Required=false)]
                    public double? OwnPurity { get; set; }

                    /// <summary>
                    /// <para>Optional. The display plumpness metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Plumpness")]
                    [Validation(Required=false)]
                    public double? Plumpness { get; set; }

                    /// <summary>
                    /// <para>The display name of the scene. If omitted, the value is an empty string.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Air-cooled display cabinet</para>
                    /// </summary>
                    [NameInMap("SceneActualName")]
                    [Validation(Required=false)]
                    public string SceneActualName { get; set; }

                    /// <summary>
                    /// <para>The center point of the scene, which retains the original normalized coordinates. If omitted, the value is an empty array.</para>
                    /// </summary>
                    [NameInMap("SceneCenter")]
                    [Validation(Required=false)]
                    public List<double?> SceneCenter { get; set; }

                    /// <summary>
                    /// <para>The list of region points. Each item is in the {x,y} format and retains the original normalized coordinates. If omitted, the value is an empty array.</para>
                    /// </summary>
                    [NameInMap("SceneLocation")]
                    [Validation(Required=false)]
                    public List<MerchandiseSceneDetectionResponseBodyDataResultScenesSceneLocation> SceneLocation { get; set; }
                    public class MerchandiseSceneDetectionResponseBodyDataResultScenesSceneLocation : Darabonba.Model {
                        /// <summary>
                        /// <para>The x-coordinate of the region point.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.431</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public double? X { get; set; }

                        /// <summary>
                        /// <para>The y-coordinate of the region point.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.973</para>
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public double? Y { get; set; }

                    }

                    /// <summary>
                    /// <para>The scene identifier. This parameter is required and cannot be empty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>yl_cj_lfg</para>
                    /// </summary>
                    [NameInMap("SceneName")]
                    [Validation(Required=false)]
                    public string SceneName { get; set; }

                    /// <summary>
                    /// <para>Optional. The shelf distribution proportion metric. The specific business criteria are subject to the recognition service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ShelfDistributionRate")]
                    [Validation(Required=false)]
                    public double? ShelfDistributionRate { get; set; }

                }

                /// <summary>
                /// <para>Fixed value: scene.</para>
                /// 
                /// <b>Example:</b>
                /// <para>scene</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The usage information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;ProcessingCount&quot;:1}</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public Dictionary<string, long?> UsageMap { get; set; }

        }

        /// <summary>
        /// <para>The response message or failure description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70CBEFDF-BB17-1EB3-8A21-569F3124738F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

