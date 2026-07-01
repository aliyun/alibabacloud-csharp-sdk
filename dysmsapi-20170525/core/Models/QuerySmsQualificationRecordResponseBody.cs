// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySmsQualificationRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>访问被拒绝详细信息。</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>请求状态码。</para>
        /// <list type="bullet">
        /// <item><description>返回OK代表请求成功。</description></item>
        /// <item><description>其他错误码，请参见本章节的错误码列表或产品<a href="https://help.aliyun.com/document_detail/101346.html">API错误码</a>。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>资质审核列表</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySmsQualificationRecordResponseBodyData Data { get; set; }
        public class QuerySmsQualificationRecordResponseBodyData : TeaModel {
            /// <summary>
            /// <para>满足过滤条件的数据列表。</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QuerySmsQualificationRecordResponseBodyDataList> List { get; set; }
            public class QuerySmsQualificationRecordResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>审核备注。</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("AuditRemark")]
                [Validation(Required=false)]
                public string AuditRemark { get; set; }

                /// <summary>
                /// <para>审核时间。</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-12-26 17:29:04</para>
                /// </summary>
                [NameInMap("AuditTime")]
                [Validation(Required=false)]
                public string AuditTime { get; set; }

                /// <summary>
                /// <para>企业名称。</para>
                /// 
                /// <b>Example:</b>
                /// <para>阿里云云通信有限公司</para>
                /// </summary>
                [NameInMap("CompanyName")]
                [Validation(Required=false)]
                public string CompanyName { get; set; }

                /// <summary>
                /// <para>资质创建时间。</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-02-20 11:59:30</para>
                /// </summary>
                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                /// <summary>
                /// <para>资质ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000****</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                /// <summary>
                /// <para>法人姓名。</para>
                /// 
                /// <b>Example:</b>
                /// <para>李华</para>
                /// </summary>
                [NameInMap("LegalPersonName")]
                [Validation(Required=false)]
                public string LegalPersonName { get; set; }

                /// <summary>
                /// <para>资质名称。</para>
                /// 
                /// <b>Example:</b>
                /// <para>阿里云云通信有限公司李华</para>
                /// </summary>
                [NameInMap("QualificationGroupName")]
                [Validation(Required=false)]
                public string QualificationGroupName { get; set; }

                /// <summary>
                /// <para>审核状态。取值：</para>
                /// <list type="bullet">
                /// <item><description>INIT：审核中。</description></item>
                /// <item><description>NOT_PASS：审核不通过。 </description></item>
                /// <item><description>PASS：审核通过。</description></item>
                /// <item><description>NOT_FINISH：资料待补充。</description></item>
                /// <item><description>CANCEL：已撤回。</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>INIT</para>
                /// </summary>
                [NameInMap("StateName")]
                [Validation(Required=false)]
                public string StateName { get; set; }

                /// <summary>
                /// <para>资质申请用途，取值：</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>：自用。</description></item>
                /// <item><description><b>false</b>：他用。</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("UseBySelf")]
                [Validation(Required=false)]
                public string UseBySelf { get; set; }

                /// <summary>
                /// <para>审核工单ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>2001****</para>
                /// </summary>
                [NameInMap("WorkOrderId")]
                [Validation(Required=false)]
                public long? WorkOrderId { get; set; }

            }

            /// <summary>
            /// <para>当前页码。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <para>每页数据条数。</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>总条数。</para>
            /// 
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>状态码的描述。</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>请求ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>25D5AFDE-8EBC-132E-8909-1FDC071DA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>调用接口是否成功。取值：</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>：调用成功。</description></item>
        /// <item><description><b>false</b>：调用失败。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
