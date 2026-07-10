// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class VerifyMaterialRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID that identifies a verification task. The value can be up to 64 characters in length. For a single verification task, the system supports unlimited submissions until the verification is passed and the task is completed.</para>
        /// <remarks>
        /// <para>Use a different BizId for each new verification task.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39ecf51e-2f81-4dc5-90ee-ff86125b****</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The business scenario identifier for the ID Verification service. Create one in the console first. For more information, see <a href="https://help.aliyun.com/document_detail/127885.html">Business settings</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RPMinTest</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>The HTTP or HTTPS URL of the front-facing facial photo.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://image-demo.img-cn-hangzhou.aliyuncs.com/example.jpg">http://image-demo.img-cn-hangzhou.aliyuncs.com/example.jpg</a></para>
        /// </summary>
        [NameInMap("FaceImageUrl")]
        [Validation(Required=false)]
        public string FaceImageUrl { get; set; }

        /// <summary>
        /// <para>The HTTP or HTTPS URL of the national emblem side of the ID card.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://image-demo.img-cn-hangzhou.aliyuncs.com/example3.jpg">http://image-demo.img-cn-hangzhou.aliyuncs.com/example3.jpg</a></para>
        /// </summary>
        [NameInMap("IdCardBackImageUrl")]
        [Validation(Required=false)]
        public string IdCardBackImageUrl { get; set; }

        /// <summary>
        /// <para>The HTTP or HTTPS URL of the portrait side of the ID card.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://image-demo.img-cn-hangzhou.aliyuncs.com/example2.jpg">http://image-demo.img-cn-hangzhou.aliyuncs.com/example2.jpg</a></para>
        /// </summary>
        [NameInMap("IdCardFrontImageUrl")]
        [Validation(Required=false)]
        public string IdCardFrontImageUrl { get; set; }

        /// <summary>
        /// <para>The ID card number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02343218901123****</para>
        /// </summary>
        [NameInMap("IdCardNumber")]
        [Validation(Required=false)]
        public string IdCardNumber { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the end user, such as the account ID of the end user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54sdj</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
