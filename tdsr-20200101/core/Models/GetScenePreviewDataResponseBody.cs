// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class GetScenePreviewDataResponseBody : TeaModel {
        /// <summary>
        /// 返回码
        /// </summary>
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
                /// <summary>
                /// 模型地址
                /// </summary>
                [NameInMap("ModelPath")]
                [Validation(Required=false)]
                public string ModelPath { get; set; }

                /// <summary>
                /// 点位数据
                /// </summary>
                [NameInMap("PanoList")]
                [Validation(Required=false)]
                public List<GetScenePreviewDataResponseBodyDataModelPanoList> PanoList { get; set; }
                public class GetScenePreviewDataResponseBodyDataModelPanoList : TeaModel {
                    /// <summary>
                    /// 当前房间的所有点位
                    /// </summary>
                    [NameInMap("CurRoomPicList")]
                    [Validation(Required=false)]
                    public List<string> CurRoomPicList { get; set; }

                    /// <summary>
                    /// 当前点位是否渲染，false不渲染，场景无法跳转
                    /// </summary>
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// 楼层号
                    /// </summary>
                    [NameInMap("FloorIdx")]
                    [Validation(Required=false)]
                    public string FloorIdx { get; set; }

                    /// <summary>
                    /// 点位ID
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// 单房间多图情况下，是否为主图，默认true
                    /// </summary>
                    [NameInMap("MainImage")]
                    [Validation(Required=false)]
                    public bool? MainImage { get; set; }

                    /// <summary>
                    /// 当前房间邻近可视的点位id
                    /// </summary>
                    [NameInMap("Neighbours")]
                    [Validation(Required=false)]
                    public List<string> Neighbours { get; set; }

                    /// <summary>
                    /// 位置数据
                    /// </summary>
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

                    /// <summary>
                    /// 一个名称，无实际意义
                    /// </summary>
                    [NameInMap("RawName")]
                    [Validation(Required=false)]
                    public string RawName { get; set; }

                    /// <summary>
                    /// 全景贴图路径
                    /// </summary>
                    [NameInMap("Resource")]
                    [Validation(Required=false)]
                    public string Resource { get; set; }

                    /// <summary>
                    /// 房间号
                    /// </summary>
                    [NameInMap("RoomIdx")]
                    [Validation(Required=false)]
                    public string RoomIdx { get; set; }

                    /// <summary>
                    /// 子场景ID
                    /// </summary>
                    [NameInMap("SubSceneId")]
                    [Validation(Required=false)]
                    public string SubSceneId { get; set; }

                    /// <summary>
                    /// token
                    /// </summary>
                    [NameInMap("Token")]
                    [Validation(Required=false)]
                    public string Token { get; set; }

                    /// <summary>
                    /// 图片虚拟ID
                    /// </summary>
                    [NameInMap("VirtualId")]
                    [Validation(Required=false)]
                    public string VirtualId { get; set; }

                    /// <summary>
                    /// 图片名称
                    /// </summary>
                    [NameInMap("VirtualName")]
                    [Validation(Required=false)]
                    public string VirtualName { get; set; }

                }

                /// <summary>
                /// 模型的贴图路径
                /// </summary>
                [NameInMap("TextureModelPath")]
                [Validation(Required=false)]
                public string TextureModelPath { get; set; }

                /// <summary>
                /// 漫游后预览图片路径
                /// </summary>
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
                    /// <summary>
                    /// 背景色
                    /// </summary>
                    [NameInMap("BackgroundColor")]
                    [Validation(Required=false)]
                    public string BackgroundColor { get; set; }

                    /// <summary>
                    /// 按钮配置
                    /// </summary>
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

                    /// <summary>
                    /// 内容
                    /// </summary>
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

                    /// <summary>
                    /// 图片链接
                    /// </summary>
                    [NameInMap("Images")]
                    [Validation(Required=false)]
                    public List<string> Images { get; set; }

                    /// <summary>
                    /// 是否在鸟瞰模式下显示
                    /// </summary>
                    [NameInMap("IsTagVisibleBy3d")]
                    [Validation(Required=false)]
                    public bool? IsTagVisibleBy3d { get; set; }

                    /// <summary>
                    /// 超链接
                    /// </summary>
                    [NameInMap("Link")]
                    [Validation(Required=false)]
                    public string Link { get; set; }

                    /// <summary>
                    /// 点位ID
                    /// </summary>
                    [NameInMap("PanoId")]
                    [Validation(Required=false)]
                    public string PanoId { get; set; }

                    /// <summary>
                    /// 坐标
                    /// </summary>
                    [NameInMap("Position")]
                    [Validation(Required=false)]
                    public List<double?> Position { get; set; }

                    [NameInMap("PositionPanoCube")]
                    [Validation(Required=false)]
                    public List<double?> PositionPanoCube { get; set; }

                    [NameInMap("RelatedPanoIds")]
                    [Validation(Required=false)]
                    public List<string> RelatedPanoIds { get; set; }

                    /// <summary>
                    /// 场景ID
                    /// </summary>
                    [NameInMap("SceneId")]
                    [Validation(Required=false)]
                    public long? SceneId { get; set; }

                    /// <summary>
                    /// 标题
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    /// <summary>
                    /// 视频链接
                    /// </summary>
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

        /// <summary>
        /// 错误消息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 是否请求成功
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
