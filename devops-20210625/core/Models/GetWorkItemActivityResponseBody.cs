// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetWorkItemActivityResponseBody : TeaModel {
        [NameInMap("activities")]
        [Validation(Required=false)]
        public List<GetWorkItemActivityResponseBodyActivities> Activities { get; set; }
        public class GetWorkItemActivityResponseBodyActivities : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>update</para>
            /// </summary>
            [NameInMap("actionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3201131</para>
            /// </summary>
            [NameInMap("eventId")]
            [Validation(Required=false)]
            public long? EventId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1640867079624</para>
            /// </summary>
            [NameInMap("eventTime")]
            [Validation(Required=false)]
            public long? EventTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>workitem.updated</para>
            /// </summary>
            [NameInMap("eventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            [NameInMap("newValue")]
            [Validation(Required=false)]
            public List<GetWorkItemActivityResponseBodyActivitiesNewValue> NewValue { get; set; }
            public class GetWorkItemActivityResponseBodyActivitiesNewValue : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Sprint-221124</para>
                /// </summary>
                [NameInMap("displayValue")]
                [Validation(Required=false)]
                public string DisplayValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>bed1cca179badeb501a72d1194</para>
                /// </summary>
                [NameInMap("plainValue")]
                [Validation(Required=false)]
                public string PlainValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Sprint</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            [NameInMap("oldValue")]
            [Validation(Required=false)]
            public List<GetWorkItemActivityResponseBodyActivitiesOldValue> OldValue { get; set; }
            public class GetWorkItemActivityResponseBodyActivitiesOldValue : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Sprint-221124</para>
                /// </summary>
                [NameInMap("displayValue")]
                [Validation(Required=false)]
                public string DisplayValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>bed1cca179badeb501a72d1194</para>
                /// </summary>
                [NameInMap("plainValue")]
                [Validation(Required=false)]
                public string PlainValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Sprint</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>19xx7043xxxxxxx914</para>
            /// </summary>
            [NameInMap("operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3201132</para>
            /// </summary>
            [NameInMap("parentEventId")]
            [Validation(Required=false)]
            public long? ParentEventId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>public</para>
            /// </summary>
            [NameInMap("property")]
            [Validation(Required=false)]
            public GetWorkItemActivityResponseBodyActivitiesProperty Property { get; set; }
            public class GetWorkItemActivityResponseBodyActivitiesProperty : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>标题</para>
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>subject</para>
                /// </summary>
                [NameInMap("propertyIdentifier")]
                [Validation(Required=false)]
                public string PropertyIdentifier { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>subject</para>
                /// </summary>
                [NameInMap("propertyName")]
                [Validation(Required=false)]
                public string PropertyName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("propertyType")]
                [Validation(Required=false)]
                public string PropertyType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>e8bxxxxxxxxxxxxxxxx23</para>
            /// </summary>
            [NameInMap("resourceIdentifier")]
            [Validation(Required=false)]
            public string ResourceIdentifier { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Openapi.RequestError</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>error</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ASSDS-ASSASX-XSAXSA-XSAXSAXS</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
