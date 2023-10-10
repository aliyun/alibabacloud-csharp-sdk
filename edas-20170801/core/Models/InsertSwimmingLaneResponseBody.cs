// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertSwimmingLaneResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data that is returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public InsertSwimmingLaneResponseBodyData Data { get; set; }
        public class InsertSwimmingLaneResponseBodyData : TeaModel {
            /// <summary>
            /// The applications that are associated with lanes.
            /// </summary>
            [NameInMap("AppInfos")]
            [Validation(Required=false)]
            public string AppInfos { get; set; }

            /// <summary>
            /// The throttling rule for the lane.
            /// 
            /// priority: the priority of the throttling rule for the lane. Valid values: 1 to 100.
            /// 
            /// path: the path that is matched by the throttling rule for the lane.
            /// 
            /// restItems: conditions to be met.
            /// 
            /// condition: the relationship among the conditions to be met.
            /// 
            /// *   AND: all conditions
            /// *   OR: one of the conditions
            /// 
            /// restItems.type: the type of the rule. Valid values:
            /// 
            /// *   header: matches by request header.
            /// *   cookie: matches by request cookie.
            /// *   param: matches by request parameters.
            /// 
            /// restItems.name: the key that matches the rule.
            /// 
            /// restItems.value: the value that matches the rule.
            /// 
            /// restItems.cond: the condition that matches the rule. Valid values:
            /// 
            /// *   "==": The parameter value is equal to the value that you enter in the Value field.
            /// *   "!=": The parameter value is not equal to the value that you enter in the Value field.
            /// *   ">": The parameter value is greater than the value that you enter in the Value field.
            /// *   "<": The parameter value is less than the value that you enter in the Value field.
            /// *   ">=": The parameter value is greater than or equal to the value that you enter in the Value field.
            /// *   "<=": The parameter value is less than or equal to the value that you enter in the Value field.
            /// *   "in": The parameter value is within the values that you enter in the Value field.
            /// 
            /// restItems.operator: the type of the value. Valid values:
            /// 
            /// *   rawvalue: the initial value
            /// *   mod: the reminder obtained by performing modulo operation
            /// *   list: the value from the list
            /// </summary>
            [NameInMap("EntryRule")]
            [Validation(Required=false)]
            public string EntryRule { get; set; }

            /// <summary>
            /// The ID of the lane group.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// The ID of the lane.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The name of the lane.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the namespace.
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// The association relationships between lanes and applications.
            /// </summary>
            [NameInMap("SwimmingLaneAppRelationShipList")]
            [Validation(Required=false)]
            public List<InsertSwimmingLaneResponseBodyDataSwimmingLaneAppRelationShipList> SwimmingLaneAppRelationShipList { get; set; }
            public class InsertSwimmingLaneResponseBodyDataSwimmingLaneAppRelationShipList : TeaModel {
                /// <summary>
                /// The ID of the application.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// The name of the application.
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// The ID of the lane.
                /// </summary>
                [NameInMap("LaneId")]
                [Validation(Required=false)]
                public long? LaneId { get; set; }

                /// <summary>
                /// The association rule.
                /// </summary>
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public string Rules { get; set; }

            }

            /// <summary>
            /// The tag of the lane.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// The additional information that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
