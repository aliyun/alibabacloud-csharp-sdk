// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class GetScenePreviewDataResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public GetScenePreviewDataResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class GetScenePreviewDataResponseBodyAccessDeniedDetail : TeaModel {
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0：成功，其他：失败</para>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true/false</para>
                    /// </summary>
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1****</para>
                    /// </summary>
                    [NameInMap("FloorIdx")]
                    [Validation(Required=false)]
                    public string FloorIdx { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1****</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true/false</para>
                    /// </summary>
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
                        public List<double?> Rotation { get; set; }

                        [NameInMap("Spot")]
                        [Validation(Required=false)]
                        public List<double?> Spot { get; set; }

                        [NameInMap("Viewpoint")]
                        [Validation(Required=false)]
                        public List<double?> Viewpoint { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>location_93132801658010****</para>
                    /// </summary>
                    [NameInMap("RawName")]
                    [Validation(Required=false)]
                    public string RawName { get; set; }

                    [NameInMap("Resource")]
                    [Validation(Required=false)]
                    public string Resource { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1****</para>
                    /// </summary>
                    [NameInMap("RoomIdx")]
                    [Validation(Required=false)]
                    public string RoomIdx { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>a7RqCd3kLMgglmn****</para>
                    /// </summary>
                    [NameInMap("SubSceneId")]
                    [Validation(Required=false)]
                    public string SubSceneId { get; set; }

                    /// <summary>
                    /// <para>token</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sIPGWRGLJHEIQE****</para>
                    /// </summary>
                    [NameInMap("Token")]
                    [Validation(Required=false)]
                    public string Token { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>93132801658010****</para>
                    /// </summary>
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
                [NameInMap("Config")]
                [Validation(Required=false)]
                public GetScenePreviewDataResponseBodyDataTagsConfig Config { get; set; }
                public class GetScenePreviewDataResponseBodyDataTagsConfig : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>#00000</para>
                    /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>CLICK_CHECK</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("FormImgSize")]
                    [Validation(Required=false)]
                    public List<long?> FormImgSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true/false</para>
                    /// </summary>
                    [NameInMap("FormJumpType")]
                    [Validation(Required=false)]
                    public bool? FormJumpType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("FormSelectImgType")]
                    [Validation(Required=false)]
                    public string FormSelectImgType { get; set; }

                    [NameInMap("Images")]
                    [Validation(Required=false)]
                    public List<string> Images { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true/false</para>
                    /// </summary>
                    [NameInMap("IsTagVisibleBy3d")]
                    [Validation(Required=false)]
                    public bool? IsTagVisibleBy3d { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="http://www.example.com/">http://www.example.com/</a>***</para>
                    /// </summary>
                    [NameInMap("Link")]
                    [Validation(Required=false)]
                    public string Link { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1****</para>
                    /// </summary>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>323****</para>
                    /// </summary>
                    [NameInMap("SceneId")]
                    [Validation(Required=false)]
                    public long? SceneId { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="http://www.example.com/****.mp4">http://www.example.com/****.mp4</a></para>
                    /// </summary>
                    [NameInMap("Video")]
                    [Validation(Required=false)]
                    public string Video { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Position")]
                [Validation(Required=false)]
                public List<double?> Position { get; set; }

                [NameInMap("PositionPanoCube")]
                [Validation(Required=false)]
                public List<double?> PositionPanoCube { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>IMAGE</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A8CD0AD9-8A92-455A-A984-A7E4B76FF387</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true/false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
