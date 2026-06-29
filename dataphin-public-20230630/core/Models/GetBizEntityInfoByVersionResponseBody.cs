// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetBizEntityInfoByVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The creation result.</para>
        /// </summary>
        [NameInMap("BizEntityInfo")]
        [Validation(Required=false)]
        public GetBizEntityInfoByVersionResponseBodyBizEntityInfo BizEntityInfo { get; set; }
        public class GetBizEntityInfoByVersionResponseBodyBizEntityInfo : TeaModel {
            /// <summary>
            /// <para>The business object.</para>
            /// </summary>
            [NameInMap("BizObject")]
            [Validation(Required=false)]
            public GetBizEntityInfoByVersionResponseBodyBizEntityInfoBizObject BizObject { get; set; }
            public class GetBizEntityInfoByVersionResponseBodyBizEntityInfoBizObject : TeaModel {
                /// <summary>
                /// <para>The approval flow ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>221323121212</para>
                /// </summary>
                [NameInMap("ApprovalId")]
                [Validation(Required=false)]
                public string ApprovalId { get; set; }

                /// <summary>
                /// <para>The approval status. For more information, refer to the query business entity details operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>APPROVING</para>
                /// </summary>
                [NameInMap("ApprovalStatus")]
                [Validation(Required=false)]
                public string ApprovalStatus { get; set; }

                /// <summary>
                /// <para>The list of child business objects of the business object.</para>
                /// </summary>
                [NameInMap("ChildBizEntityIdList")]
                [Validation(Required=false)]
                public List<long?> ChildBizEntityIdList { get; set; }

                /// <summary>
                /// <para>The description of the business object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display name of the business object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>create_object_name</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-10 10:00:00</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-10 10:00:00</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The business object ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1011</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The ID of the user who last modified the business object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30010010</para>
                /// </summary>
                [NameInMap("LastModifier")]
                [Validation(Required=false)]
                public string LastModifier { get; set; }

                /// <summary>
                /// <para>The name of the user who last modified the business object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("LastModifierName")]
                [Validation(Required=false)]
                public string LastModifierName { get; set; }

                /// <summary>
                /// <para>The code name of the business object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>create_object_code_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The online status. For more information, refer to the query business entity details operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("OnlineStatus")]
                [Validation(Required=false)]
                public string OnlineStatus { get; set; }

                /// <summary>
                /// <para>The owner of the business object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("OwnerName")]
                [Validation(Required=false)]
                public string OwnerName { get; set; }

                /// <summary>
                /// <para>The owner of the business object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30010010</para>
                /// </summary>
                [NameInMap("OwnerUserId")]
                [Validation(Required=false)]
                public string OwnerUserId { get; set; }

                /// <summary>
                /// <para>The parent entity that the business object inherits from. Only common business objects support inheritance, and the parent entity must be online.</para>
                /// 
                /// <b>Example:</b>
                /// <para>116306</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

                /// <summary>
                /// <para>The list of associated online business entity IDs.</para>
                /// </summary>
                [NameInMap("RefBizEntityIdList")]
                [Validation(Required=false)]
                public List<long?> RefBizEntityIdList { get; set; }

                /// <summary>
                /// <para>The number of associated logical dimension tables.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RefDimTableCount")]
                [Validation(Required=false)]
                public int? RefDimTableCount { get; set; }

                /// <summary>
                /// <para>The number of associated aggregate tables.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RefSummaryTableCount")]
                [Validation(Required=false)]
                public int? RefSummaryTableCount { get; set; }

                /// <summary>
                /// <para>The status. For more information, refer to the query business entity details operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The object type of the business object. For more information, refer to the query business entity details operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The business process.</para>
            /// </summary>
            [NameInMap("BizProcess")]
            [Validation(Required=false)]
            public GetBizEntityInfoByVersionResponseBodyBizEntityInfoBizProcess BizProcess { get; set; }
            public class GetBizEntityInfoByVersionResponseBodyBizEntityInfoBizProcess : TeaModel {
                /// <summary>
                /// <para>The approval flow ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>221323121212</para>
                /// </summary>
                [NameInMap("ApprovalId")]
                [Validation(Required=false)]
                public string ApprovalId { get; set; }

                /// <summary>
                /// <para>The approval status. For more information, refer to the query business entity details operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>APPROVING</para>
                /// </summary>
                [NameInMap("ApprovalStatus")]
                [Validation(Required=false)]
                public string ApprovalStatus { get; set; }

                /// <summary>
                /// <para>The list of business event activity IDs contained in the business flow activity. This parameter is valid only when the type is a business flow activity.</para>
                /// </summary>
                [NameInMap("BizEventEntityIdList")]
                [Validation(Required=false)]
                public List<long?> BizEventEntityIdList { get; set; }

                /// <summary>
                /// <para>The description of the business process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display name of the business process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>业务活动测试</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-10 10:00:00</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-10 10:00:00</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>Indicates whether the business process is depended on by other entities.</para>
                /// </summary>
                [NameInMap("HasDependent")]
                [Validation(Required=false)]
                public bool? HasDependent { get; set; }

                /// <summary>
                /// <para>The business process ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1011</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The ID of the user who last modified the business object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30010010</para>
                /// </summary>
                [NameInMap("LastModifier")]
                [Validation(Required=false)]
                public string LastModifier { get; set; }

                /// <summary>
                /// <para>The name of the user who last modified the business object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("LastModifierName")]
                [Validation(Required=false)]
                public string LastModifierName { get; set; }

                /// <summary>
                /// <para>The name of the business process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>create_process_code_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The online status. For more information, refer to the query business entity details operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("OnlineStatus")]
                [Validation(Required=false)]
                public string OnlineStatus { get; set; }

                /// <summary>
                /// <para>The owner of the business object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("OwnerName")]
                [Validation(Required=false)]
                public string OwnerName { get; set; }

                /// <summary>
                /// <para>The owner of the business object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30010010</para>
                /// </summary>
                [NameInMap("OwnerUserId")]
                [Validation(Required=false)]
                public string OwnerUserId { get; set; }

                /// <summary>
                /// <para>The preceding business flow activities of the business flow activity.</para>
                /// </summary>
                [NameInMap("PreBizProcessIdList")]
                [Validation(Required=false)]
                public List<long?> PreBizProcessIdList { get; set; }

                /// <summary>
                /// <para>The list of associated online business entity IDs.</para>
                /// </summary>
                [NameInMap("RefBizEntityIdList")]
                [Validation(Required=false)]
                public List<long?> RefBizEntityIdList { get; set; }

                /// <summary>
                /// <para>The number of associated fact tables.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RefFactTableCount")]
                [Validation(Required=false)]
                public int? RefFactTableCount { get; set; }

                /// <summary>
                /// <para>The status. For more information, refer to the query business entity details operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The type of the business process. For more information, refer to the query business entity details operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BIZ_EVENT</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The business unit ID of the business object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6798087749072704</para>
            /// </summary>
            [NameInMap("BizUnitId")]
            [Validation(Required=false)]
            public long? BizUnitId { get; set; }

            /// <summary>
            /// <para>The ID of the subject domain to which the entity belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20101011</para>
            /// </summary>
            [NameInMap("DataDomainId")]
            [Validation(Required=false)]
            public long? DataDomainId { get; set; }

            /// <summary>
            /// <para>The type of the business entity. For more information, refer to the query business entity details operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BIZ_OBJECT</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The error code. A value of OK indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
