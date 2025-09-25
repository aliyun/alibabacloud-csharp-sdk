// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CreateVerifySettingRequest : TeaModel {
        /// <summary>
        /// <para>Verification scenario name, supporting Chinese, English, numbers, and hyphens (-), with a maximum of 20 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>用户注册</para>
        /// </summary>
        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        /// <summary>
        /// <para>Verification scenario identifier, supporting English letters, numbers, and hyphens (-), with a maximum of 20 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UserRegister</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>Whether to use the system\&quot;s default guide page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("GuideStep")]
        [Validation(Required=false)]
        public bool? GuideStep { get; set; }

        /// <summary>
        /// <para>Whether to use the system\&quot;s default authorization page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PrivacyStep")]
        [Validation(Required=false)]
        public bool? PrivacyStep { get; set; }

        /// <summary>
        /// <para>Whether to use the system\&quot;s default result page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ResultStep")]
        [Validation(Required=false)]
        public bool? ResultStep { get; set; }

        /// <summary>
        /// <para>The name of the authentication solution to use, such as <b>RPBasic</b>, <b>RPBioOnly</b>, etc. For all supported authentication solutions, see <a href="https://help.aliyun.com/document_detail/127521.html">Authentication Solutions</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RPBasic</para>
        /// </summary>
        [NameInMap("Solution")]
        [Validation(Required=false)]
        public string Solution { get; set; }

    }

}
