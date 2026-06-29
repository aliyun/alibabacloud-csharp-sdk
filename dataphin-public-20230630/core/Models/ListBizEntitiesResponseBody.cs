// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListBizEntitiesResponseBody : TeaModel {
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
        /// <para>The paginated result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListBizEntitiesResponseBodyPageResult PageResult { get; set; }
        public class ListBizEntitiesResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The list of business entities.</para>
            /// </summary>
            [NameInMap("BizEntityList")]
            [Validation(Required=false)]
            public List<ListBizEntitiesResponseBodyPageResultBizEntityList> BizEntityList { get; set; }
            public class ListBizEntitiesResponseBodyPageResultBizEntityList : TeaModel {
                /// <summary>
                /// <para>The list of parent business process IDs. This parameter is valid only when the entity type is business process.</para>
                /// </summary>
                [NameInMap("BelongToBizEntityIdList")]
                [Validation(Required=false)]
                public List<long?> BelongToBizEntityIdList { get; set; }

                /// <summary>
                /// <para>The ID of the business unit to which the business process belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6798087749072704</para>
                /// </summary>
                [NameInMap("BizUnitId")]
                [Validation(Required=false)]
                public long? BizUnitId { get; set; }

                /// <summary>
                /// <para>The list of child business object IDs. This parameter is valid only when the entity type is business object.</para>
                /// </summary>
                [NameInMap("ChildBizEntityIdList")]
                [Validation(Required=false)]
                public List<long?> ChildBizEntityIdList { get; set; }

                /// <summary>
                /// <para>The ID of the data domain to which the business process belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20101011</para>
                /// </summary>
                [NameInMap("DataDomainId")]
                [Validation(Required=false)]
                public long? DataDomainId { get; set; }

                /// <summary>
                /// <para>The description of the business entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display name of the business entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>业务活动测试</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The time when the business entity was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-10 10:00:00</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the business entity was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-10 10:00:00</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>Indicates whether the entity is a child business object.</para>
                /// </summary>
                [NameInMap("HasChildBizEntity")]
                [Validation(Required=false)]
                public bool? HasChildBizEntity { get; set; }

                /// <summary>
                /// <para>The ID of the business entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12121111</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The ID of the user who last modified the business entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30010010</para>
                /// </summary>
                [NameInMap("LastModifier")]
                [Validation(Required=false)]
                public string LastModifier { get; set; }

                /// <summary>
                /// <para>The name of the user who last modified the business entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("LastModifierName")]
                [Validation(Required=false)]
                public string LastModifierName { get; set; }

                /// <summary>
                /// <para>Indicates whether the entity is a sublevel of a hierarchy dimension.</para>
                /// </summary>
                [NameInMap("LevelSubBizObject")]
                [Validation(Required=false)]
                public bool? LevelSubBizObject { get; set; }

                /// <summary>
                /// <para>The name of the business entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>create_process_code_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The online status of the business entity. Valid values: </para>
                /// <list type="bullet">
                /// <item><description>SUBMITTED: not online.</description></item>
                /// <item><description>APPROVING: pending approval.</description></item>
                /// <item><description>PUBLISHED: online.</description></item>
                /// <item><description>REJECT: failed to go online.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SUBMITTED</para>
                /// </summary>
                [NameInMap("OnlineStatus")]
                [Validation(Required=false)]
                public string OnlineStatus { get; set; }

                /// <summary>
                /// <para>The ID of the business entity owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("OwnerName")]
                [Validation(Required=false)]
                public string OwnerName { get; set; }

                /// <summary>
                /// <para>The ID of the business entity owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30010010</para>
                /// </summary>
                [NameInMap("OwnerUserId")]
                [Validation(Required=false)]
                public string OwnerUserId { get; set; }

                /// <summary>
                /// <para>The list of associated central business entity IDs.</para>
                /// </summary>
                [NameInMap("RefBizEntityIdList")]
                [Validation(Required=false)]
                public List<long?> RefBizEntityIdList { get; set; }

                /// <summary>
                /// <para>The number of associated logical tables.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RefTableCount")]
                [Validation(Required=false)]
                public int? RefTableCount { get; set; }

                /// <summary>
                /// <para>The status of the business entity. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DRAFT: draft or not online.</description></item>
                /// <item><description>SUBMITTING: being submitted.</description></item>
                /// <item><description>SUBMITTED: submitted.</description></item>
                /// <item><description>DEVELOPING: under development.</description></item>
                /// <item><description>PUBLISHING: being published.</description></item>
                /// <item><description>PUBLISHED: published.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SUBMITTED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The subtype of the business entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("SubType")]
                [Validation(Required=false)]
                public string SubType { get; set; }

                /// <summary>
                /// <para>The list of subsequent business process IDs. This parameter is valid only when the entity type is business process.</para>
                /// </summary>
                [NameInMap("SuffixBizEntityIdList")]
                [Validation(Required=false)]
                public List<long?> SuffixBizEntityIdList { get; set; }

                /// <summary>
                /// <para>The type of the business entity. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>BIZ_OBJECT: business object.</description></item>
                /// <item><description>BIZ_PROCESS: business process.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BIZ_OBJECT</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

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
