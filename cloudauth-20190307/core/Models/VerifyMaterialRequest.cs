// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class VerifyMaterialRequest : TeaModel {
        /// <summary>
        /// <para>A unique ID that identifies a single authentication task, not exceeding 64 characters. For a single authentication task, the system supports unlimited submissions until the final authentication is passed and the task is completed.</para>
        /// <remarks>
        /// <para>Different BizIds are required for different authentication tasks.</para>
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
        /// <para>Identifier for the business scenario using the real-person authentication service. Please refer to <a href="https://help.aliyun.com/document_detail/127885.html">Business Setup</a> and complete the creation in the console first.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RPMinTest</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>HTTP or HTTPS link to the frontal face image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://image-demo.img-cn-hangzhou.aliyuncs.com/example.jpg">http://image-demo.img-cn-hangzhou.aliyuncs.com/example.jpg</a></para>
        /// </summary>
        [NameInMap("FaceImageUrl")]
        [Validation(Required=false)]
        public string FaceImageUrl { get; set; }

        /// <summary>
        /// <para>HTTP or HTTPS link to the national emblem side of the ID card.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://image-demo.img-cn-hangzhou.aliyuncs.com/example3.jpg">http://image-demo.img-cn-hangzhou.aliyuncs.com/example3.jpg</a></para>
        /// </summary>
        [NameInMap("IdCardBackImageUrl")]
        [Validation(Required=false)]
        public string IdCardBackImageUrl { get; set; }

        /// <summary>
        /// <para>HTTP or HTTPS link to the portrait side of the ID card image.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://image-demo.img-cn-hangzhou.aliyuncs.com/example2.jpg">http://image-demo.img-cn-hangzhou.aliyuncs.com/example2.jpg</a></para>
        /// </summary>
        [NameInMap("IdCardFrontImageUrl")]
        [Validation(Required=false)]
        public string IdCardFrontImageUrl { get; set; }

        /// <summary>
        /// <para>ID number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02343218901123****</para>
        /// </summary>
        [NameInMap("IdCardNumber")]
        [Validation(Required=false)]
        public string IdCardNumber { get; set; }

        /// <summary>
        /// <para>Name.</para>
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
