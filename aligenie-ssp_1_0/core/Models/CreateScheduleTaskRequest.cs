// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class CreateScheduleTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public CreateScheduleTaskRequestDeviceInfo DeviceInfo { get; set; }
        public class CreateScheduleTaskRequestDeviceInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>12**45</para>
            /// </summary>
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PROJECT_ID</para>
            /// </summary>
            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DAFE****ce3ej=</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OPEN_ID</para>
            /// </summary>
            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1**2</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public CreateScheduleTaskRequestPayload Payload { get; set; }
        public class CreateScheduleTaskRequestPayload : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ActionDTOs")]
            [Validation(Required=false)]
            public List<CreateScheduleTaskRequestPayloadActionDTOs> ActionDTOs { get; set; }
            public class CreateScheduleTaskRequestPayloadActionDTOs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;k1&quot;:&quot;v1&quot;,&quot;k2&quot;:{&quot;key&quot;:1}}</para>
                /// </summary>
                [NameInMap("customAction")]
                [Validation(Required=false)]
                public Dictionary<string, object> CustomAction { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IdempotentId")]
            [Validation(Required=false)]
            public string IdempotentId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ScheduleDTO")]
            [Validation(Required=false)]
            public CreateScheduleTaskRequestPayloadScheduleDTO ScheduleDTO { get; set; }
            public class CreateScheduleTaskRequestPayloadScheduleDTO : TeaModel {
                [NameInMap("Once")]
                [Validation(Required=false)]
                public CreateScheduleTaskRequestPayloadScheduleDTOOnce Once { get; set; }
                public class CreateScheduleTaskRequestPayloadScheduleDTOOnce : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>26</para>
                    /// </summary>
                    [NameInMap("Day")]
                    [Validation(Required=false)]
                    public int? Day { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("Hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("Minute")]
                    [Validation(Required=false)]
                    public int? Minute { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>7</para>
                    /// </summary>
                    [NameInMap("Month")]
                    [Validation(Required=false)]
                    public int? Month { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2022</para>
                    /// </summary>
                    [NameInMap("Year")]
                    [Validation(Required=false)]
                    public int? Year { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1661589255000</para>
                /// </summary>
                [NameInMap("ScheduleEndTime")]
                [Validation(Required=false)]
                public long? ScheduleEndTime { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1656318855000</para>
                /// </summary>
                [NameInMap("ScheduleStartTime")]
                [Validation(Required=false)]
                public long? ScheduleStartTime { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ONCE</para>
                /// </summary>
                [NameInMap("ScheduleType")]
                [Validation(Required=false)]
                public string ScheduleType { get; set; }

                [NameInMap("StatutoryWorkingDay")]
                [Validation(Required=false)]
                public CreateScheduleTaskRequestPayloadScheduleDTOStatutoryWorkingDay StatutoryWorkingDay { get; set; }
                public class CreateScheduleTaskRequestPayloadScheduleDTOStatutoryWorkingDay : TeaModel {
                    [NameInMap("Hours")]
                    [Validation(Required=false)]
                    public List<int?> Hours { get; set; }

                    [NameInMap("Minutes")]
                    [Validation(Required=false)]
                    public List<int?> Minutes { get; set; }

                }

                [NameInMap("Weekly")]
                [Validation(Required=false)]
                public CreateScheduleTaskRequestPayloadScheduleDTOWeekly Weekly { get; set; }
                public class CreateScheduleTaskRequestPayloadScheduleDTOWeekly : TeaModel {
                    [NameInMap("DaysOfWeek")]
                    [Validation(Required=false)]
                    public List<int?> DaysOfWeek { get; set; }

                    [NameInMap("Hours")]
                    [Validation(Required=false)]
                    public List<int?> Hours { get; set; }

                    [NameInMap("Minutes")]
                    [Validation(Required=false)]
                    public List<int?> Minutes { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public CreateScheduleTaskRequestUserInfo UserInfo { get; set; }
        public class CreateScheduleTaskRequestUserInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>12**45</para>
            /// </summary>
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PROJECT_ID</para>
            /// </summary>
            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>HOFF****my7Iw=</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OPEN_ID</para>
            /// </summary>
            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1**2</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

    }

}
