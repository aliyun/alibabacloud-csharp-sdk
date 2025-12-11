// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class UpdateSmsSignShrinkRequest : TeaModel {
        [NameInMap("AppIcpRecordId")]
        [Validation(Required=false)]
        public long? AppIcpRecordId { get; set; }

        /// <summary>
        /// <para>Application scenarios, instructions as follows:</para>
        /// <list type="bullet">
        /// <item><description>For registered websites, please enter the domain name registered with MIIT, including HTTP or HTTPS.</description></item>
        /// <item><description>For launched apps, provide the display link from the app store with HTTP or HTTPS, ensuring the app is online.</description></item>
        /// <item><description>For public accounts or mini-programs, fill in the full name, ensuring they are online.</description></item>
        /// <item><description>For e-commerce platform store names (for enterprise users only), provide the display link with HTTP or HTTPS.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com/">http://www.aliyun.com/</a></para>
        /// </summary>
        [NameInMap("ApplySceneContent")]
        [Validation(Required=false)]
        public string ApplySceneContent { get; set; }

        [NameInMap("AuthorizationLetterId")]
        [Validation(Required=false)]
        public long? AuthorizationLetterId { get; set; }

        /// <summary>
        /// <para>Additional materials, such as uploading business proof documents or screenshots of business operations, to help reviewers understand your business details.</para>
        /// </summary>
        [NameInMap("MoreData")]
        [Validation(Required=false)]
        public string MoreDataShrink { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Approved or under-review qualification ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Before applying for an SMS signature, please first <a href="https://help.aliyun.com/zh/sms/user-guide/new-qualification?spm=a2c4g.11186623.0.0.718d187bbkpMRK">apply for qualifications</a>.</description></item>
        /// <item><description>You can view the qualification ID on the <a href="https://dysms.console.aliyun.com/domestic/text/qualification">Qualification Management</a> page.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8563**</para>
        /// </summary>
        [NameInMap("QualificationId")]
        [Validation(Required=false)]
        public long? QualificationId { get; set; }

        /// <summary>
        /// <para>Explanation of the SMS signature scenario, with a maximum length of 200 characters.</para>
        /// <remarks>
        /// <para>The scenario explanation is one of the reference information for signature review. Please provide a detailed description of the usage scenarios of the launched business, along with verifiable information such as website links, registered domain addresses, app store download links, full names of public accounts or mini-programs, etc. For login scenarios, test account credentials are also required. A well-informed application explanation will enhance the efficiency of signature and template reviews. Refer to the <b>Application Scenarios</b> column in the <a href="https://help.aliyun.com/zh/sms/user-guide/signature-specifications-1?spm=a2c4g.11186623.0.i2#section-xup-k46-yi4">Signature Source</a> table for filling in SMS scenarios.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>登录场景申请验证码</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Signature not yet approved.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云验证码</para>
        /// </summary>
        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        /// <summary>
        /// <para>Source of the signature. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Full name or abbreviation of enterprises and institutions.</description></item>
        /// <item><description><b>1</b>: Full name or abbreviation of MIIT-registered websites.</description></item>
        /// <item><description><b>2</b>: Full name or abbreviation of app applications.</description></item>
        /// <item><description><b>3</b>: Full name or abbreviation of public accounts or mini-programs.</description></item>
        /// <item><description><b>4</b>: Full name or abbreviation of e-commerce platform store names.</description></item>
        /// <item><description><b>5</b>: Full name or abbreviation of trademarks.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SignSource")]
        [Validation(Required=false)]
        public int? SignSource { get; set; }

        /// <summary>
        /// <para>Signature type. It is recommended to use the default value.</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Verification code</description></item>
        /// <item><description><b>1</b>: General (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SignType")]
        [Validation(Required=false)]
        public int? SignType { get; set; }

        /// <summary>
        /// <para>Whether the signature is for self-use or others.</para>
        /// <list type="bullet">
        /// <item><description>false: Self-use</description></item>
        /// <item><description>true: Others<remarks>
        /// <para>Notice: When the signature is for self-use, select the self-use qualification ID; when it\&quot;s for others, choose the others\&quot; qualification ID.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ThirdParty")]
        [Validation(Required=false)]
        public bool? ThirdParty { get; set; }

        [NameInMap("TrademarkId")]
        [Validation(Required=false)]
        public long? TrademarkId { get; set; }

    }

}
