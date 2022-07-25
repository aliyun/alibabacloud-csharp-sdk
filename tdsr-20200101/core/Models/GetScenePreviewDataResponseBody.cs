// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class GetScenePreviewDataResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetScenePreviewDataResponseBodyData Data { get; set; }
        public class GetScenePreviewDataResponseBodyData : TeaModel {
            [NameInMap("Model")]
            [Validation(Required=false)]
            public GetScenePreviewDataResponseBodyDataModel Model { get; set; }
            public class GetScenePreviewDataResponseBodyDataModel : TeaModel {
                [NameInMap("ModelPath")]
                [Validation(Required=false)]
                public string ModelPath { get; set; }

                [NameInMap("PanoList")]
                [Validation(Required=false)]
                public List<GetScenePreviewDataResponseBodyDataModelPanoList> PanoList { get; set; }
                public class GetScenePreviewDataResponseBodyDataModelPanoList : TeaModel {
                    [NameInMap("CurRoomPicList")]
                    [Validation(Required=false)]
                    public List<string> CurRoomPicList { get; set; }

                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    [NameInMap("FloorIdx")]
                    [Validation(Required=false)]
                    public string FloorIdx { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("MainImage")]
                    [Validation(Required=false)]
                    public bool? MainImage { get; set; }

                    [NameInMap("Neighbours")]
                    [Validation(Required=false)]
                    public List<string> Neighbours { get; set; }

                    [NameInMap("Position")]
                    [Validation(Required=false)]
                    public GetScenePreviewDataResponseBodyDataModelPanoListPosition Position { get; set; }
                    public class GetScenePreviewDataResponseBodyDataModelPanoListPosition : TeaModel {
                        [NameInMap("Rotation")]
                        [Validation(Required=false)]
                        public List<string> Rotation { get; set; }
                        [NameInMap("Spot")]
                        [Validation(Required=false)]
                        public List<string> Spot { get; set; }
                        [NameInMap("Viewpoint")]
                        [Validation(Required=false)]
                        public List<string> Viewpoint { get; set; }
                    };

                    [NameInMap("RawName")]
                    [Validation(Required=false)]
                    public string RawName { get; set; }

                    [NameInMap("Resource")]
                    [Validation(Required=false)]
                    public string Resource { get; set; }

                    [NameInMap("RoomIdx")]
                    [Validation(Required=false)]
                    public string RoomIdx { get; set; }

                    [NameInMap("SubSceneId")]
                    [Validation(Required=false)]
                    public string SubSceneId { get; set; }

                    [NameInMap("Token")]
                    [Validation(Required=false)]
                    public string Token { get; set; }

                    [NameInMap("VirtualId")]
                    [Validation(Required=false)]
                    public string VirtualId { get; set; }

                    [NameInMap("VirtualName")]
                    [Validation(Required=false)]
                    public string VirtualName { get; set; }

                }

                [NameInMap("TextureModelPath")]
                [Validation(Required=false)]
                public string TextureModelPath { get; set; }

                [NameInMap("TexturePanoPath")]
                [Validation(Required=false)]
                public string TexturePanoPath { get; set; }

            }
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetScenePreviewDataResponseBodyDataTags> Tags { get; set; }
            public class GetScenePreviewDataResponseBodyDataTags : TeaModel {
                public GetScenePreviewDataResponseBodyDataTagsConfig Config { get; set; }
                public class GetScenePreviewDataResponseBodyDataTagsConfig : TeaModel {
                    [NameInMap("BackgroundColor")]
                    [Validation(Required=false)]
                    public string BackgroundColor { get; set; }

                    [NameInMap("ButtonConfig")]
                    [Validation(Required=false)]
                    public GetScenePreviewDataResponseBodyDataTagsConfigButtonConfig ButtonConfig { get; set; }
                    public class GetScenePreviewDataResponseBodyDataTagsConfigButtonConfig : TeaModel {
                        [NameInMap("CustomText")]
                        [Validation(Required=false)]
                        public string CustomText { get; set; }
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }
                    };

                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("FormImgSize")]
                    [Validation(Required=false)]
                    public List<long?> FormImgSize { get; set; }

                    [NameInMap("FormJumpType")]
                    [Validation(Required=false)]
                    public bool? FormJumpType { get; set; }

                    [NameInMap("FormSelectImgType")]
                    [Validation(Required=false)]
                    public string FormSelectImgType { get; set; }

                    [NameInMap("Images")]
                    [Validation(Required=false)]
                    public List<string> Images { get; set; }

                    [NameInMap("IsTagVisibleBy3d")]
                    [Validation(Required=false)]
                    public bool? IsTagVisibleBy3d { get; set; }

                    [NameInMap("Link")]
                    [Validation(Required=false)]
                    public string Link { get; set; }

                    [NameInMap("PanoId")]
                    [Validation(Required=false)]
                    public string PanoId { get; set; }

                    [NameInMap("Position")]
                    [Validation(Required=false)]
                    public List<double?> Position { get; set; }

                    [NameInMap("PositionPanoCube")]
                    [Validation(Required=false)]
                    public List<double?> PositionPanoCube { get; set; }

                    [NameInMap("RelatedPanoIds")]
                    [Validation(Required=false)]
                    public List<string> RelatedPanoIds { get; set; }

                    [NameInMap("SceneId")]
                    [Validation(Required=false)]
                    public long? SceneId { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    [NameInMap("Video")]
                    [Validation(Required=false)]
                    public string Video { get; set; }

                }
                public string Id { get; set; }
                public List<string> Position { get; set; }
                public List<string> PositionPanoCube { get; set; }
                public string Type { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
