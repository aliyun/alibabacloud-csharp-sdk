// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ImportRoomGenieScenesRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a7a3***013</para>
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1211</para>
        /// </summary>
        [NameInMap("RoomNo")]
        [Validation(Required=false)]
        public string RoomNo { get; set; }

        [NameInMap("SceneList")]
        [Validation(Required=false)]
        public List<ImportRoomGenieScenesRequestSceneList> SceneList { get; set; }
        public class ImportRoomGenieScenesRequestSceneList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Actions")]
            [Validation(Required=false)]
            public List<ImportRoomGenieScenesRequestSceneListActions> Actions { get; set; }
            public class ImportRoomGenieScenesRequestSceneListActions : TeaModel {
                [NameInMap("AttributeValues")]
                [Validation(Required=false)]
                public List<ImportRoomGenieScenesRequestSceneListActionsAttributeValues> AttributeValues { get; set; }
                public class ImportRoomGenieScenesRequestSceneListActionsAttributeValues : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>powerstate</para>
                    /// </summary>
                    [NameInMap("AttributeName")]
                    [Validation(Required=false)]
                    public string AttributeName { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("AttributeValue")]
                    [Validation(Required=false)]
                    public string AttributeValue { get; set; }

                }

                [NameInMap("Device")]
                [Validation(Required=false)]
                public ImportRoomGenieScenesRequestSceneListActionsDevice Device { get; set; }
                public class ImportRoomGenieScenesRequestSceneListActionsDevice : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>light</para>
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("DeviceIndex")]
                    [Validation(Required=false)]
                    public int? DeviceIndex { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3c5d2ab8f9ec</para>
                    /// </summary>
                    [NameInMap("DeviceNumber")]
                    [Validation(Required=false)]
                    public string DeviceNumber { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                }

                [NameInMap("Reply")]
                [Validation(Required=false)]
                public string Reply { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Display")]
            [Validation(Required=false)]
            public bool? Display { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://xxx.com/yyy.png">http://xxx.com/yyy.png</a></para>
            /// </summary>
            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TriggerLogical")]
            [Validation(Required=false)]
            public int? TriggerLogical { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Triggers")]
            [Validation(Required=false)]
            public List<ImportRoomGenieScenesRequestSceneListTriggers> Triggers { get; set; }
            public class ImportRoomGenieScenesRequestSceneListTriggers : TeaModel {
                [NameInMap("AttributeValues")]
                [Validation(Required=false)]
                public List<ImportRoomGenieScenesRequestSceneListTriggersAttributeValues> AttributeValues { get; set; }
                public class ImportRoomGenieScenesRequestSceneListTriggersAttributeValues : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("AttributeName")]
                    [Validation(Required=false)]
                    public string AttributeName { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("AttributeValue")]
                    [Validation(Required=false)]
                    public string AttributeValue { get; set; }

                }

                [NameInMap("CorpusList")]
                [Validation(Required=false)]
                public List<string> CorpusList { get; set; }

                [NameInMap("Device")]
                [Validation(Required=false)]
                public ImportRoomGenieScenesRequestSceneListTriggersDevice Device { get; set; }
                public class ImportRoomGenieScenesRequestSceneListTriggersDevice : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    [NameInMap("DeviceIndex")]
                    [Validation(Required=false)]
                    public string DeviceIndex { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("DeviceNumber")]
                    [Validation(Required=false)]
                    public string DeviceNumber { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

        }

    }

}
