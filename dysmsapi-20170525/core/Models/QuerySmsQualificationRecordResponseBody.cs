// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySmsQualificationRecordResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySmsQualificationRecordResponseBodyData Data { get; set; }
        public class QuerySmsQualificationRecordResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QuerySmsQualificationRecordResponseBodyDataList> List { get; set; }
            public class QuerySmsQualificationRecordResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>审核备注</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("AuditRemark")]
                [Validation(Required=false)]
                public string AuditRemark { get; set; }

                /// <summary>
                /// <para>审核时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-12-26 17:29:04</para>
                /// </summary>
                [NameInMap("AuditTime")]
                [Validation(Required=false)]
                public string AuditTime { get; set; }

                /// <summary>
                /// <para>公司名称或实人认证姓名</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("CompanyName")]
                [Validation(Required=false)]
                public string CompanyName { get; set; }

                /// <summary>
                /// <para>创建时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-02-20 11:59:30</para>
                /// </summary>
                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                /// <summary>
                /// <para>资质组ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000****</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                /// <summary>
                /// <para>法人名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("LegalPersonName")]
                [Validation(Required=false)]
                public string LegalPersonName { get; set; }

                /// <summary>
                /// <para>资质组名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("QualificationGroupName")]
                [Validation(Required=false)]
                public string QualificationGroupName { get; set; }

                /// <summary>
                /// <para>审核状态名</para>
                /// 
                /// <b>Example:</b>
                /// <para>INT</para>
                /// </summary>
                [NameInMap("StateName")]
                [Validation(Required=false)]
                public string StateName { get; set; }

                /// <summary>
                /// <para>是否自用</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("UseBySelf")]
                [Validation(Required=false)]
                public string UseBySelf { get; set; }

                /// <summary>
                /// <para>工单ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>2001****</para>
                /// </summary>
                [NameInMap("WorkOrderId")]
                [Validation(Required=false)]
                public long? WorkOrderId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>25D5AFDE-8EBC-132E-8909-1FDC071DA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
