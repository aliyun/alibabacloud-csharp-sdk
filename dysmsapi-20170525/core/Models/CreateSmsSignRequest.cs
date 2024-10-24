// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class CreateSmsSignRequest : TeaModel {
        /// <summary>
        /// <para>Application scenarios, instructions as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>For registered websites, enter the domain name with HTTP or HTTPS that has been registered with the MIIT.</para>
        /// </description></item>
        /// <item><description><para>For launched apps, provide a display link from the app store with HTTP or HTTPS, ensuring the app is online.</para>
        /// </description></item>
        /// <item><description><para>For public accounts or mini-programs, input the full name, ensuring they are online.</para>
        /// </description></item>
        /// <item><description><para>For e-commerce platform store names, applicable only to enterprise users, provide a display link with HTTP or HTTPS for the store.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com/">http://www.aliyun.com/</a></para>
        /// </summary>
        [NameInMap("ApplySceneContent")]
        [Validation(Required=false)]
        public string ApplySceneContent { get; set; }

        /// <summary>
        /// <para>Additional information to supplement uploaded business proof documents or screenshots, which helps reviewers understand your business details.</para>
        /// <para>This parameter is optional; please fill it out based on your actual needs.</para>
        /// </summary>
        [NameInMap("MoreData")]
        [Validation(Required=false)]
        public List<string> MoreData { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Approved or under-review qualification ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Before applying for an SMS signature, please first <a href="https://help.aliyun.com/zh/sms/user-guide/new-qualification?spm=a2c4g.11186623.0.0.718d187bbkpMRK">Apply for Qualification</a>.</description></item>
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
        /// <para>The scenario explanation is one of the reference materials for signature review. Please provide a detailed description of the usage scenarios for your live services, along with links to verify these services such as website URLs with MIIT备案, app store display links, full names of public accounts or mini-programs, etc. For login scenarios, test account credentials are also required. A comprehensive application explanation enhances the efficiency of signature and template reviews. Refer to the <b>Application Scenario</b> column in the <a href="https://help.aliyun.com/zh/sms/user-guide/signature-specifications-1?spm=a2c4g.11186623.0.i2#section-xup-k46-yi4">Signature Source</a> table for filling in SMS scenarios.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SMS signature for the login scenario using verification code.</para>
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
        /// <para>Signature name. Please adhere to the <a href="https://help.aliyun.com/zh/sms/user-guide/signature-specifications-1?spm=a2c4g.11186623.0.0.4f9710fder2gR7#section-0p8-qn8-mmy">Signature Specifications</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Signature names are case-insensitive; e.g., 【Aliyun Communication】 and 【aliyun communication】 are considered identical.</description></item>
        /// <item><description>If your verification code signature and general signature names are the same, the system defaults to using the general signature for sending SMS messages.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun</para>
        /// </summary>
        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        /// <summary>
        /// <para>Signature source. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Full name or abbreviation of an enterprise or institution.</description></item>
        /// <item><description><b>1</b>: Full name or abbreviation of a MIIT-registered website.</description></item>
        /// <item><description><b>2</b>: Full name or abbreviation of an App.</description></item>
        /// <item><description><b>3</b>: Full name or abbreviation of an official account or mini-program.</description></item>
        /// <item><description><b>4</b>: Full name or abbreviation of an e-commerce platform store.</description></item>
        /// <item><description><b>5</b>: Full name or abbreviation of a trademark.</description></item>
        /// </list>
        /// <para>For detailed information on signature sources, refer to <a href="https://help.aliyun.com/zh/sms/user-guide/signature-specifications-1?spm=a2c4g.11186623.0.0.4f9710fder2gR7#section-xup-k46-yi4">Signature Source</a>.</para>
        /// <remarks>
        /// <para>This interface does not support applying for signatures with sources as <b>Test or Learning</b> and <b>Trial Use</b>. If you need to apply for signatures with these sources, please go to the <a href="https://dysms.console.aliyun.com/domestic/text/sign/add/qualification">SMS Service Console</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SignSource")]
        [Validation(Required=false)]
        public int? SignSource { get; set; }

        /// <summary>
        /// <para>Signature type. Values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Verification Code</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: General (Default)</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>It is recommended to use the default value: <b>General</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SignType")]
        [Validation(Required=false)]
        public int? SignType { get; set; }

        /// <summary>
        /// <para>Choose whether the applied signature is for self-use or third-party use.</para>
        /// <list type="bullet">
        /// <item><description><para>false: Self-use (default)</para>
        /// </description></item>
        /// <item><description><para>true: Third-party use</para>
        /// <remarks>
        /// <para>Notice: Please select self-use qualification ID when the signature is for self-use; choose third-party use qualification ID when it\&quot;s for third-party use.</para>
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

    }

}
