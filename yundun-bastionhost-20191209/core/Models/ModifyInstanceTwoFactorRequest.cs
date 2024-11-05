// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ModifyInstanceTwoFactorRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable two-factor authentication. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableTwoFactor")]
        [Validation(Required=false)]
        public string EnableTwoFactor { get; set; }

        /// <summary>
        /// <para>The ID of the bastion host.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the ID of the bastion host.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-st220aw****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host.</para>
        /// <remarks>
        /// <para>For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The duration within which two-factor authentication is not required after a user passes two-factor authentication. Valid values: 0 to 168. Unit: hours. If you set this parameter to 0, the user must pass two-factor authentication every time the user logs on to the bastion host.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SkipTwoFactorTime")]
        [Validation(Required=false)]
        public string SkipTwoFactorTime { get; set; }

        /// <summary>
        /// <para>The method used to send a verification code for two-factor authentication. If EnableTwoFactor is set to true, you must specify at least one method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sms:</b> text message.</description></item>
        /// <item><description><b>email</b>: email.</description></item>
        /// <item><description><b>dingtalk</b>: notice in DingTalk.</description></item>
        /// <item><description><b>totp</b>: one-time password (OTP) token.</description></item>
        /// <item><description><b>gmusbkey</b>: SM-based USB key.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;sms&quot;]</para>
        /// </summary>
        [NameInMap("TwoFactorMethods")]
        [Validation(Required=false)]
        public string TwoFactorMethods { get; set; }

    }

}
