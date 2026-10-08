// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryOperationAuditInfoListResponseBody : TeaModel {
        /// <summary>
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        /// <summary>
        /// <para>Review data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryOperationAuditInfoListResponseBodyData> Data { get; set; }
        public class QueryOperationAuditInfoListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Information pending review.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;regType&quot;:1,&quot;registrantName&quot;:&quot;张三&quot;,&quot;telephone&quot;:&quot;1390123****&quot;,&quot;account&quot;:&quot;<a href="mailto:username@example.com">username@example.com</a>&quot;,&quot;reason&quot;:1,&quot;remark&quot;:&quot;账号丢失&quot;}</para>
            /// </summary>
            [NameInMap("AuditInfo")]
            [Validation(Required=false)]
            public string AuditInfo { get; set; }

            /// <summary>
            /// <para>Review status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Information to be completed.</description></item>
            /// <item><description><b>1</b>, <b>2</b>, <b>3</b>, <b>4</b>: Under review.</description></item>
            /// <item><description><b>5</b>: Review failed.</description></item>
            /// <item><description><b>6</b>: Review succeeded.</description></item>
            /// <item><description><b>7</b>: Review canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public int? AuditStatus { get; set; }

            /// <summary>
            /// <para>Review type. Valid value:</para>
            /// <para><b>1</b>: Offline domain name transfer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AuditType")]
            [Validation(Required=false)]
            public int? AuditType { get; set; }

            /// <summary>
            /// <para>Name of the reviewed business.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com等域名线下转移</para>
            /// </summary>
            [NameInMap("BusinessName")]
            [Validation(Required=false)]
            public string BusinessName { get; set; }

            /// <summary>
            /// <para>Record creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1581919010101</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com,aliyundoc.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>Review record ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Review remark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>审核中</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>Record update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1581919010101</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether there is a next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

        /// <summary>
        /// <para>Number of records per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Indicates whether a previous page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PrePage")]
        [Validation(Required=false)]
        public bool? PrePage { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9DFCF6F8-243C-40EC-8035-4B12FEFD7D48</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>199</para>
        /// </summary>
        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        /// <summary>
        /// <para>Total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
