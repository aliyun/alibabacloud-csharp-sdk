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
        /// <para>The user\&quot;s account name.</para>
        /// <list type="bullet">
        /// <item><description>If the user is an Alibaba Cloud primary account <b>wangwu</b>, the format is <b>[Primary Account]</b>, for example, <b>wangwu</b>.</description></item>
        /// <item><description>If the user is a RAM account <b>zhangsan</b>@aliyun.cn, the format is <b>[Primary Account: Sub-account]</b>, for example, <b>wangwu:zhangsan</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Only one of UserId and AccountName needs to be filled in. If neither is filled in, it will default to binding the report\&quot;s Owner, and the report will be accessed with that user\&quot;s identity. If you need to configure row-level permissions, please refer to <a href="https://help.aliyun.com/document_detail/322783.html">Row-Level Permissions</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test user</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        [Obsolete]
        public string AccountName { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The type of the user\&quot;s account.</para>
        /// <list type="bullet">
        /// <item><description>1: Alibaba Cloud account</description></item>
        /// <item><description>3: Quick BI self-built account</description></item>
        /// <item><description>4: DingTalk</description></item>
        /// <item><description>5: RAM sub-account</description></item>
        /// <item><description>9: WeCom</description></item>
        /// <item><description>10: Feishu<remarks>
        /// <para>If AccountName is not empty, then AccountType must also not be empty.</para>
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
        /// <para>Component ID. This is the ID of a component within the above-mentioned dashboard; other types of works do not support this.
        /// Refer to the <a href="https://next.api.aliyun.com/api/quickbi-public/2022-01-01/QueryWorksBloodRelationship?spm=a2c4g.11186623.0.0.15615d7aWVvWAl&params=%7B%7D&lang=JAVA&tab=DOC&sdkStyle=old">QueryWorksBloodRelationship</a> API for obtaining the component ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0fc6a275c7f64f17b1****a306ce0f31</para>
        /// </summary>
        [NameInMap("CmptId")]
        [Validation(Required=false)]
        public string CmptId { get; set; }

        /// <summary>
        /// <para>Expiration time</para>
        /// <list type="bullet">
        /// <item><description>Unit: minutes</description></item>
        /// <item><description>Default: 240</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public int? ExpireTime { get; set; }

        /// <summary>
        /// <para>Global parameters for the report filter conditions.</para>
        /// <list type="bullet">
        /// <item><description>A string in JsonArray format.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you need to use global parameter capabilities, please contact the <a href="https://h5-alimebot.dingtalk.com/intl/index.htm?spm=a2c4g.11186623.0.0.3da14f6chrDv9e&sourceType=ding_talk&from=DEFFB9G5KBByQkwq23wneFIOmaJ">Quick BI Operations Manager</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;paramKey&quot;:&quot;price&quot;,&quot;joinType&quot;:&quot;and&quot;,&quot;conditionList&quot;:[{&quot;operate&quot;:&quot;&gt;&quot;,&quot;value&quot;:&quot;0&quot;}]}]</para>
        /// </summary>
        [NameInMap("GlobalParam")]
        [Validation(Required=false)]
        public string GlobalParam { get; set; }

        /// <summary>
        /// <para>The number of tickets. Each time a ticket is used, the number of tickets decreases by 1.</para>
        /// <list type="bullet">
        /// <item><description>Default value: 1</description></item>
        /// <item><description>Recommended value: 1</description></item>
        /// <item><description>Maximum value: 99999</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TicketNum")]
        [Validation(Required=false)]
        public int? TicketNum { get; set; }

        /// <summary>
        /// <para>Quick BI\&quot;s UserId, which is not your Alibaba Cloud account ID.
        /// You can call the <a href="https://next.api.aliyun.com/api/quickbi-public/2022-01-01/QueryUserInfoByAccount?spm=a2c4g.11186623.0.0.15615d7aWVvWAl&params=%7B%7D&tab=DOC&sdkStyle=old">QueryUserInfoByAccount</a> API to obtain the UserId. An example of a UserId is fe67f61a35a94b7da1a34ba174a7****.</para>
        /// <remarks>
        /// <para>Only one of UserId and AccountName needs to be filled in. If neither is filled in, it will default to binding the report\&quot;s Owner, and the report will be accessed with that user\&quot;s identity. If you need to configure row-level permissions, please refer to <a href="https://help.aliyun.com/document_detail/322783.html">Row-Level Permissions</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>46e537466****92704c8</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>Watermark parameters for the report.</para>
        /// <list type="bullet">
        /// <item><description>Must not exceed 50 characters.</description></item>
        /// <item><description>When the report type is a large screen, watermark parameter passing is not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Three-party embedding</para>
        /// </summary>
        [NameInMap("WatermarkParam")]
        [Validation(Required=false)]
        public string WatermarkParam { get; set; }

        /// <summary>
        /// <para>The ID of the report to be embedded. Currently supports dashboards, spreadsheets, data screens, self-service data retrieval, ad-hoc analysis, and data entry.</para>
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
