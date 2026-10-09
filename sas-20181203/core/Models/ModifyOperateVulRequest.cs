// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyOperateVulRequest : TeaModel {
        /// <summary>
        /// <para>The client token used to ensure request idempotence. Use a different token for each request. Only ASCII characters are supported. The value can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-0016e04115b</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run for this request. Valid values: true: performs only a dry run without executing the actual operation. false: sends the request normally. Default value: false.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The source identifier of the request. Set this parameter to <b>sas</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The information about the vulnerability to handle. This parameter is in JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>name</b>: The name of the vulnerability.</description></item>
        /// <item><description><b>uuid</b>: The UUID of the server that has the vulnerability.</description></item>
        /// <item><description><b>tag</b>: The label of the vulnerability. Valid values:<list type="bullet">
        /// <item><description><b>oval</b>: Linux software vulnerability</description></item>
        /// <item><description><b>system</b>: Windows system vulnerability</description></item>
        /// <item><description><b>cms</b>: Web-CMS vulnerability</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For other vulnerability types, call the <a href="~~DescribeVulList~~">DescribeVulList</a> operation to obtain vulnerability information.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>isFront</b>: Specifies whether the Windows patch is a prerequisite patch. Set this parameter only when handling Windows system vulnerabilities. You can ignore this parameter for other vulnerability types. Valid values:<list type="bullet">
        /// <item><description><b>0</b>: No.</description></item>
        /// <item><description><b>1</b>: Yes.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Batch processing is supported. Separate multiple vulnerability entries with commas (,). Call the <a href="~~DescribeVulList~~">DescribeVulList</a> operation to obtain vulnerability information.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;alilinux2:2.1903:ALINUX2-SA-2022:0007&quot;,&quot;uuid&quot;:&quot;a3bb82a8-a3bd-4546-acce-45ac34af****&quot;,&quot;tag&quot;:&quot;oval&quot;,&quot;isFront&quot;:0},{&quot;name&quot;:&quot;alilinux2:2.1903:ALINUX2-SA-2022:0007&quot;,&quot;uuid&quot;:&quot;98a6fecc-88cd-46f2-8e35-f808a388****&quot;,&quot;tag&quot;:&quot;oval&quot;,&quot;isFront&quot;:0}]</para>
        /// </summary>
        [NameInMap("Info")]
        [Validation(Required=false)]
        public string Info { get; set; }

        /// <summary>
        /// <para>The operation to perform on the vulnerability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>vul_fix</b>: Fix the vulnerability.</description></item>
        /// <item><description><b>vul_verify</b>: Verify the vulnerability.</description></item>
        /// <item><description><b>vul_ignore</b>: Ignore the vulnerability.</description></item>
        /// <item><description><b>vul_undo_ignore</b>: Cancel ignoring the vulnerability.</description></item>
        /// <item><description><b>vul_delete</b>: Delete the vulnerability.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vul_fix</para>
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// <para>The reason for ignoring the vulnerability. This parameter is required only when the operation is set to <b>ignore</b> (that is, <b>OperateType</b> is set to <b>vul_ignore</b>).</para>
        /// 
        /// <b>Example:</b>
        /// <para>not operate</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account associated with a member account in the resource directory.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The type of vulnerability to handle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cve</b>: Linux software vulnerability</description></item>
        /// <item><description><b>sys</b>: Windows system vulnerability</description></item>
        /// <item><description><b>cms</b>: Web-CMS vulnerability</description></item>
        /// <item><description><b>emg</b>: Emergency vulnerability</description></item>
        /// <item><description><b>app</b>: Application vulnerability</description></item>
        /// <item><description><b>sca</b>: Software constituency parsing vulnerability</description></item>
        /// </list>
        /// <remarks>
        /// <para>Fix operations are not supported for emergency vulnerabilities (emg), application vulnerabilities (app), or software constituency parsing vulnerabilities (sca). These vulnerability types do not support the execute vulnerability fix operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cve</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
