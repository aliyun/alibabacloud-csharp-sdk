// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyOperateVulRequest : TeaModel {
        /// <summary>
        /// <para>The request ID. Set the value to <b>sas</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The details of the vulnerability. The value of this parameter is in the JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>name</b>: the name of the vulnerability.</para>
        /// </description></item>
        /// <item><description><para><b>uuid</b>: the UUID of the server on which the vulnerability is detected.</para>
        /// </description></item>
        /// <item><description><para><b>tag</b>: the tag that is added to the vulnerability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>oval</b>: Linux software vulnerability</description></item>
        /// <item><description><b>system</b>: Windows system vulnerability</description></item>
        /// <item><description><b>cms</b>: Web-CMS vulnerability</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeVulList~~">DescribeVulList</a> operation to query the tags that are added to vulnerabilities of other types.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para><b>isFront</b>: specifies whether a pre-patch is required to fix the Windows system vulnerability. This field is required only for Windows system vulnerabilities. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: no</description></item>
        /// <item><description><b>1</b>: yes</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> You can fix multiple vulnerabilities at a time. Separate the details of multiple vulnerabilities with commas (,). You can call the <a href="~~DescribeVulList~~">DescribeVulLIst</a> operation to query the details of vulnerabilities.</para>
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
        /// <para>The operation that you want to perform on the vulnerability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>vul_fix</b>: fixes the vulnerability.</description></item>
        /// <item><description><b>vul_verify</b>: verifies the vulnerability fix.</description></item>
        /// <item><description><b>vul_ignore</b>: ignores the vulnerability.</description></item>
        /// <item><description><b>vul_undo_ignore</b>: cancels ignoring the vulnerability.</description></item>
        /// <item><description><b>vul_delete</b>: deletes the vulnerability.</description></item>
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
        /// <para>The reason why the vulnerability is <b>ignored</b>.</para>
        /// <remarks>
        /// <para> This parameter is required only when you set <b>OperateType</b> to <b>vul_ignore</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>not operate</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The type of the vulnerability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cve</b>: Linux software vulnerability</description></item>
        /// <item><description><b>sys</b>: Windows system vulnerability</description></item>
        /// <item><description><b>cms</b>: Web-CMS vulnerability</description></item>
        /// <item><description><b>emg</b>: urgent vulnerability</description></item>
        /// <item><description><b>app</b>: application vulnerability</description></item>
        /// <item><description><b>sca</b>: vulnerability that is detected based on software component analysis</description></item>
        /// </list>
        /// <remarks>
        /// <para> You cannot fix the urgent vulnerabilities, application vulnerabilities, or vulnerabilities that are detected based on software component analysis.</para>
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
