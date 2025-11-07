// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribePageSettingResponseBody : TeaModel {
        /// <summary>
        /// <para>Failure reasons.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///             &quot;11&quot;: &quot;认证不通过，可能原因：1、公安网照片缺失；2、公安网照片格式错误；3、公安网照片找不到人脸等可能&quot;,
        ///             &quot;1&quot;: &quot;认证通过&quot;,
        ///             &quot;12&quot;: &quot;认证不通过，可能原因：公安网系统异常，无法比对等可能&quot;,
        ///             &quot;2&quot;: &quot;认证不通过，原因：实名校验不通过&quot;,
        ///             &quot;3&quot;: &quot;认证不通过，可能原因：1、身份证照片模糊、光线问题造成字体无法识别；2、身份证照片信息与需认证的身份证姓名不一致；3、提交的照片为非身份证照片等可能&quot;,
        ///             &quot;4&quot;: &quot;认证不通过，可能原因：1、身份证照片模糊、光线问题造成字体无法识别；2、身份证照片信息与需认证的身份证号码不一致；3、提交的照片为非身份证照片等可能&quot;,
        ///             &quot;5&quot;: &quot;认证不通过，可能原因：身份证照片有效期已过期（或即将过期）等可能&quot;,
        ///             &quot;6&quot;: &quot;认证不通过，可能原因：人脸与身份证头像不一致等可能&quot;,
        ///             &quot;7&quot;: &quot;认证不通过，可能原因：人脸与公安网照片不一致等可能&quot;,
        ///             &quot;8&quot;: &quot;认证不通过，可能原因：1、提交的身份证照片非身份证原照片；2、未提交有效身份证照片等可能&quot;,
        ///             &quot;9&quot;: &quot;认证不通过，可能原因：非账号本人操作等可能&quot;,
        ///             &quot;10&quot;: &quot;认证不通过，可能原因：非同人操作等可能&quot;
        ///         }</para>
        /// </summary>
        [NameInMap("FailReasons")]
        [Validation(Required=false)]
        public Dictionary<string, object> FailReasons { get; set; }

        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C58A8581-6A5B-55F1-B2EF-1CEAC97DA181</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
