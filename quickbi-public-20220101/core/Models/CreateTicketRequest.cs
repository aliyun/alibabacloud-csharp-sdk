// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class CreateTicketRequest : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The account name of the user.</para>
        /// <list type="bullet">
        /// <item><description>If the user is an Alibaba Cloud account <b>wangwu</b>, the format is <b>[primary account]</b>, for example, <b>wangwu</b>.</description></item>
        /// <item><description>If the user is a Resource Access Management (RAM) users account <b>zhangsan</b>@aliyun.cn**, the format is <b>[primary account:RAM user]</b>, for example, <b>wangwu:zhangsan</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Specify either UserId or AccountName. If neither is specified, the report owner is attached by default, and the report is accessed under that user\&quot;s identity. To configure row-level permissions for data, see <a href="https://help.aliyun.com/document_detail/322783.html">Row-level permissions</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        [Obsolete]
        public string AccountName { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The account type of the user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Alibaba Cloud account</description></item>
        /// <item><description>3: Quick BI custom account</description></item>
        /// <item><description>4: DingTalk</description></item>
        /// <item><description>5: RAM user</description></item>
        /// <item><description>9: WeCom</description></item>
        /// <item><description>10: Lark<remarks>
        /// <para>If AccountName is specified, AccountType must also be specified.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        [Obsolete]
        public int? AccountType { get; set; }

        /// <summary>
        /// <para>The component ID. This is the ID of a specific component in the dashboard. Other report types are not supported.
        /// To obtain the component ID, see <a href="https://next.api.aliyun.com/api/quickbi-public/2022-01-01/QueryWorksBloodRelationship?spm=a2c4g.11186623.0.0.15615d7aWVvWAl&params=%7B%7D&lang=JAVA&tab=DOC&sdkStyle=old">QueryWorksBloodRelationship</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0fc6a275c7f64f17b1****a306ce0f31</para>
        /// </summary>
        [NameInMap("CmptId")]
        [Validation(Required=false)]
        public string CmptId { get; set; }

        /// <summary>
        /// <para>The expiration time.</para>
        /// <list type="bullet">
        /// <item><description>Unit: minutes.</description></item>
        /// <item><description>Default value: 240.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public int? ExpireTime { get; set; }

        /// <summary>
        /// <para>The global parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;paramKey&quot;:&quot;price&quot;,&quot;joinType&quot;:&quot;and&quot;,&quot;conditionList&quot;:[{&quot;operate&quot;:&quot;&gt;&quot;,&quot;value&quot;:&quot;0&quot;}]}]</para>
        /// </summary>
        [NameInMap("GlobalParam")]
        [Validation(Required=false)]
        public string GlobalParam { get; set; }

        /// <summary>
        /// <para>The number of times the ticket can be used. Each time the ticket is used for access, the count decreases by 1.</para>
        /// <list type="bullet">
        /// <item><description>Default value: 1.</description></item>
        /// <item><description>Recommended value: 1.</description></item>
        /// <item><description>Maximum value: 99999.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TicketNum")]
        [Validation(Required=false)]
        public int? TicketNum { get; set; }

        /// <summary>
        /// <para>The Quick BI user ID, not your Alibaba Cloud account ID.
        /// You can call the <a href="https://next.api.aliyun.com/api/quickbi-public/2022-01-01/QueryUserInfoByAccount?spm=a2c4g.11186623.0.0.15615d7aWVvWAl&params=%7B%7D&tab=DOC&sdkStyle=old">QueryUserInfoByAccount</a> operation to obtain the user ID. Example: fe67f61a35a94b7da1a34ba174a7****.</para>
        /// <remarks>
        /// <para>Specify either UserId or AccountName. If neither is specified, the report owner is used by default, and the report is accessed under that user\&quot;s identity. To configure row-level permissions for data, see <a href="https://help.aliyun.com/document_detail/322783.html">Row-level permissions</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>46e537466****92704c8</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The watermark parameter for the report.</para>
        /// <list type="bullet">
        /// <item><description>The value cannot exceed 50 characters.</description></item>
        /// <item><description>Watermark parameters are not supported when the report type is data screen.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ticket embed</para>
        /// </summary>
        [NameInMap("WatermarkParam")]
        [Validation(Required=false)]
        public string WatermarkParam { get; set; }

        /// <summary>
        /// <para>The ID of the report for which embedding is enabled. Dashboards, workbooks, data screens, ad hoc queries, ad hoc analyses, and data entry forms are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a206f5f3-****-e9b17c835b03</para>
        /// </summary>
        [NameInMap("WorksId")]
        [Validation(Required=false)]
        public string WorksId { get; set; }

    }

}
