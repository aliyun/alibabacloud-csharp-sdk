// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class UpdateRCSSignatureRequest : TeaModel {
        /// <summary>
        /// <para>背景图片ossKey</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("BackgroundImage")]
        [Validation(Required=false)]
        public string BackgroundImage { get; set; }

        /// <summary>
        /// <para>气泡颜色</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("BubbleColor")]
        [Validation(Required=false)]
        public string BubbleColor { get; set; }

        /// <summary>
        /// <para>行业类型</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public long? Category { get; set; }

        /// <summary>
        /// <para>描述信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>纬度</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("Latitude")]
        [Validation(Required=false)]
        public string Latitude { get; set; }

        /// <summary>
        /// <para>logo图片ossKey</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("Logo")]
        [Validation(Required=false)]
        public string Logo { get; set; }

        /// <summary>
        /// <para>经度</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("Longitude")]
        [Validation(Required=false)]
        public string Longitude { get; set; }

        /// <summary>
        /// <para>办公地址</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("OfficeAddress")]
        [Validation(Required=false)]
        public string OfficeAddress { get; set; }

        /// <summary>
        /// <para>服务邮箱</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("ServiceEmail")]
        [Validation(Required=false)]
        public string ServiceEmail { get; set; }

        /// <summary>
        /// <para>服务电话</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("ServicePhone")]
        [Validation(Required=false)]
        public string ServicePhone { get; set; }

        /// <summary>
        /// <para>服务条款URL</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("ServiceTerms")]
        [Validation(Required=false)]
        public string ServiceTerms { get; set; }

        /// <summary>
        /// <para>服务官网URL</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("ServiceWebsite")]
        [Validation(Required=false)]
        public string ServiceWebsite { get; set; }

        /// <summary>
        /// <para>签名名称（用于定位5G签名）</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

    }

}
